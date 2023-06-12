using NokoodAssignment.Application.Dots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
