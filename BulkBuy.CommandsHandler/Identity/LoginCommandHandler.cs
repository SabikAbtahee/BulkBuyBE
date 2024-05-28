using BulkBuy.Commands.Common;
using BulkBuy.Commands.Identity;
using BulkBuy.Core.Interfaces;
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
        private readonly ILoggerManager _logger;

        public LoginCommandHandler(ILoggerManager logger)
        {
            _logger = logger;
        }
        public Task<BaseCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BaseCommandResponse()
            {

            });
        }
    }
}
