using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Application.Dots;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Persistence.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> userManager;
        private IdentityUser user;
        public AuthenticationService(
            IConfiguration configuration,
            UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
            var authSection = configuration.GetSection("AuthHandler");
            Key = authSection["Key"];
            KeyBytes = Encoding.ASCII.GetBytes(Key);
            RefreshTokenEnabled = authSection.GetValue<bool>("EnableRefreshToken");
            TokenExpiryDays = authSection.GetValue<int>("ExpiryDays");
        }
        public string Key { get; }

        public byte[] KeyBytes { get; }

        public bool RefreshTokenEnabled { get; }

        public int TokenExpiryDays { get; }

        public async Task<UserTokenDto> LoginAsync(LoginDto input)
        {
            var model = new UserTokenDto();
            if (await ValidateUserAsync(input))
            {

                //preparing the singing credentials
                var signingcredentials = GenerateSigningCredentials();
                //preparing the overload
                var claims = await LoadClaims();
                //preparing the token
                DateTime lifetime;
                var token = GenerateTokenAsync(signingcredentials, claims, out lifetime);
                //preparing the model
                model.Token = new JwtSecurityTokenHandler().WriteToken(token);
                model.ExpiresAt = lifetime;
                model.Success = true;
            }
            return model;
        }

        public async Task<bool> ValidateUserAsync(LoginDto input)
        {
            if (input.UserNameOrEmailAddress.Contains('@'))
                user = await userManager.FindByEmailAsync(input.UserNameOrEmailAddress);
            else
                user = await userManager.FindByNameAsync(input.UserNameOrEmailAddress);
            return (user != null && await userManager.CheckPasswordAsync(user, input.Password));
        }

        private SigningCredentials GenerateSigningCredentials()
        {
            return new SigningCredentials(key: new SymmetricSecurityKey(KeyBytes),
            algorithm: SecurityAlgorithms.HmacSha256);
        }
        private async Task<ICollection<Claim>> LoadClaims()
        {
            //user data
            var userclaims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.Email),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Sid,user.Id.ToString()),
                new Claim(ClaimTypes.SerialNumber,user.Id.ToString())
            };
            //user roles
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                userclaims.Add(new Claim(ClaimTypes.Role, role));
            }
            return userclaims;
        }
        private JwtSecurityToken GenerateTokenAsync(SigningCredentials credentials, ICollection<Claim> claims, out DateTime lifetime)
        {
            lifetime = DateTime.UtcNow.AddDays(TokenExpiryDays);
            //preparing the token
            var token = new JwtSecurityToken(
                notBefore: DateTime.UtcNow,
                claims: claims,
                signingCredentials: credentials,
                expires: lifetime);
            return token;
        }


    }
}
