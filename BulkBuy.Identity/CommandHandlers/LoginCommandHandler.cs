using BulkBuy.Commands.Identity;
using BulkBuy.Core.Entities;
using BulkBuy.Core.Interfaces;
using BulkBuy.Identity.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.CommandsHandler.Identity
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginDto>
    {
        private readonly ILoggerManager _logger;
        private readonly IRepository<Person> _repository;

        public LoginCommandHandler(ILoggerManager logger, IRepository<Person> repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task<LoginDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            await _repository.SaveAsync(new Person());
            var a = await _repository.GetItemsAsync();

            return new LoginDto();
        }
    }
}
