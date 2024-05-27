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
    public class RegistrationCommandHandler : IRequestHandler<RegistrationCommand, BaseCommandResponse>
    {
        public Task<BaseCommandResponse> Handle(RegistrationCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BaseCommandResponse());
        }
    }
}
