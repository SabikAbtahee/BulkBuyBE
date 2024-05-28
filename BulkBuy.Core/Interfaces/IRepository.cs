using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Interfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        Task<IReadOnlyCollection<T>> GetItemsAsync(Expression<Func<T, bool>> dataFilters);

        Task<IReadOnlyCollection<T>> GetItemsAsync();

        Task<T> GetItemAsync(Expression<Func<T, bool>> dataFilters);

        Task SaveAsync(T data, string collectionName = "");

        Task SaveAsync(List<T> datas, string collectionName = "");

        Task UpdateAsync(Expression<Func<T, bool>> dataFilters, T data);

        Task UpdateAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates);

        Task UpdateManyAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates);

        Task DeleteAsync(Expression<Func<T, bool>> dataFilters, string collectionName);


    }
}
