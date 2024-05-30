using BulkBuy.Commands.Identity;
using BulkBuy.Identity.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Identity.CommandsHandlers
{
    public class RegistrationCommandHandler : IRequestHandler<RegistrationCommand, RegistrationDto>
    {
        public Task<RegistrationDto> Handle(RegistrationCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new RegistrationDto());
        }
    }
}
