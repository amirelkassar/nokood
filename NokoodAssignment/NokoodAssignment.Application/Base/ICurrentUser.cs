using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
