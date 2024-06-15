using BulkBuy.Application.Common.Interfaces;
using BulkBuy.Application.Identity.Commands.Register;
using BulkBuy.Domain.Common.Constants;
using BulkBuy.Domain.Entities;
using BulkBuy.Domain.Interfaces;

namespace BulkBuy.Application.Identity.Services;

public class AuthenticationService
{
    private readonly IRepository _repository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IDateTimeProvider _dateTimeProvider;

    public AuthenticationService(IRepository repository, IPasswordHasher passwordHasher, IDateTimeProvider dateTimeProvider)
    {
        _repository = repository;
        _passwordHasher = passwordHasher;
        _dateTimeProvider = dateTimeProvider;
    }
    public Person PrepareCustomerPerson(RegisterCommand request, Guid userId)
    {
        var person = new Person
        {
            DisplayName = request.Name,
            FirstName = request.Name,
            LastName = request.Name,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Address = request.Address,
            UserId = userId
        };
        person.SetIdsForCreation(userId);
        return person;
    }

    public User PrepareCustomerUser(RegisterCommand request)
    {
        var user = new User
        {
            UserName = request.Name,
            Email = request.Email,
            Password = _passwordHasher.EncryptPassword(request.Password),
            Roles = new List<string> { RoleTypes.Customer }
        };
        user.SetIdsForCreation(user.Id);
        return user;
    }

    public async Task SavePerson(Person person)
    {
        await _repository.SaveAsync<Person>(person);
    }

    public async Task SaveUser(User user)
    {
        await _repository.SaveAsync<User>(user);
    }

    public async Task UpdateLoginInfoAfterLogin(Guid userId)
    {
        var user = await _repository.GetItemAsync<User>(p => p.Id == userId);

        IDictionary<string, object> updates = new Dictionary<string, object>
        {
            {nameof(User.LastLoginTime), _dateTimeProvider.UtcNow},
            {nameof(User.LoginCount), user.LoginCount == null ? 1 : user.LoginCount + 1}
        };
        await _repository.UpdateAsync<User>(p => p.Id == userId, updates);
    }
}