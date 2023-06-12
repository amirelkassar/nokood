using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NokoodAssignment.Application.Dots
{
    public class UserTokenDto
    {
        public string Token { get; set; }
        public DateTime ExpiresAt { get; set; }
        public bool Success { get; set; } = false;
    }
}
