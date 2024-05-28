using BulkBuy.Identity.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Commands.Identity
{
    public class RegistrationCommand : IRequest<RegistrationDto>
    {
    }
}
