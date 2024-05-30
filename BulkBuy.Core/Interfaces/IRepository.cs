using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Core.Interfaces
{
    public interface IRepository
    {
        Task<IReadOnlyCollection<T>> GetItemsAsync<T>(Expression<Func<T, bool>> dataFilters) where T : IBaseEntity;

        Task<IReadOnlyCollection<T>> GetItemsAsync<T>() where T : IBaseEntity;

        Task<T> GetItemAsync<T>(Expression<Func<T, bool>> dataFilters) where T : IBaseEntity;

        Task SaveAsync<T>(T data, string collectionName = "") where T : IBaseEntity;

        Task SaveAsync<T>(List<T> datas, string collectionName = "") where T : IBaseEntity;

        Task UpdateAsync<T>(Expression<Func<T, bool>> dataFilters, T data) where T : IBaseEntity;

        Task UpdateAsync<T>(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates) where T : IBaseEntity;

        Task UpdateManyAsync<T>(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates) where T : IBaseEntity;

        Task DeleteAsync<T>(Expression<Func<T, bool>> dataFilters, string collectionName) where T : IBaseEntity;


    }
}
