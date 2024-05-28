using BulkBuy.Identity.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Commands.Identity
{
    public class LoginCommand : IRequest<LoginDto>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
