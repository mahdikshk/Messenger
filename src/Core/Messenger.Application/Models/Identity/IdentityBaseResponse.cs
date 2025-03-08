using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Application.Models.Identity
{
    public abstract class IdentityBaseResponse
    {
        public List<string> Errors { get; set; } = [];
    }
}
