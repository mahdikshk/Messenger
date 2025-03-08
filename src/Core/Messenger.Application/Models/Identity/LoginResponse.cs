using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Application.Models.Identity
{
    public class LoginResponse : IdentityBaseResponse
    {
        public string Token { get; set; } = null!;
    }
}
