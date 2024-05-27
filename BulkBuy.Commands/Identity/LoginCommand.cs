using BulkBuy.Commands.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Commands.Identity
{
    public class LoginCommand : IRequest<BaseCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
