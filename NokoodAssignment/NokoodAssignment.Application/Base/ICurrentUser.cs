using Microsoft.AspNetCore.Identity;

namespace NokoodAssignment.Application.Base
{
    public interface ICurrentUser
    {
        string Id { get; }
        string Username { get; }
        string Email { get; }
        bool IsAuthenticated { get; }
        void InitalizeUser(IdentityUser user);
    }
}
