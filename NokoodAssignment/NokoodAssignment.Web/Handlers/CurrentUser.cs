using Microsoft.AspNetCore.Identity;
using NokoodAssignment.Application.Base;

namespace NokoodAssignment.Web.Handlers
{
    public class CurrentUser : ICurrentUser
    {
        public CurrentUser()
        {
            
        }
        private IdentityUser _identityUser;
        public string Id { get; private set; }

        public string Username { get; private set; }

        public string Email { get; private set; }

        public bool IsAuthenticated { get; private set; }

        public void InitalizeUser(IdentityUser user)
        {
            if (user is not null)
            {
                _identityUser = user;
                Id = user.Id;
                Username = user.UserName;
                Email = user.Email;
                IsAuthenticated = true;
            }
            else
            {
                _identityUser = null;
                Id = string.Empty;
                Username = string.Empty;
                Email = string.Empty;
                IsAuthenticated = false;
            }
        }
    }
}
