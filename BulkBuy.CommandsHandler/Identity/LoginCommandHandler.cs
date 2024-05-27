using BulkBuy.Commands.Common;
using BulkBuy.Commands.Identity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.CommandsHandler.Identity
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, BaseCommandResponse>
    {
        public Task<BaseCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BaseCommandResponse()
            {

            });
        }
    }
}
