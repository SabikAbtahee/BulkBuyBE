using BulkBuy.Application.Common.Interfaces;

namespace BulkBuy.Infrastructure.Services;
internal class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
