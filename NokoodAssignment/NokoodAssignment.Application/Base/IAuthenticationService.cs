using NokoodAssignment.Application.Dots;

namespace NokoodAssignment.Application.Base
{
    public interface IAuthenticationService
    {
        Task<UserTokenDto> LoginAsync(LoginDto input);
        Task<bool> ValidateUserAsync(LoginDto input);
        string Key { get; }
        byte[] KeyBytes { get; }
        bool RefreshTokenEnabled { get; }
        int TokenExpiryDays { get; }
    }
}
