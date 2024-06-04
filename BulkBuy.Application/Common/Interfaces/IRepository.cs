using BulkBuy.Domain.Interfaces;
using System.Linq.Expressions;

namespace BulkBuy.Application.Common.Interfaces;

public interface IRepository
{
    Task<IReadOnlyCollection<TEntity>> GetItemsAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters) where TEntity : IBaseEntity;

    Task<IReadOnlyCollection<TEntity>> GetItemsAsync<TEntity>() where TEntity : IBaseEntity;

    Task<TEntity> GetItemAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters) where TEntity : IBaseEntity;

    Task SaveAsync<TEntity>(TEntity data, string collectionName = "") where TEntity : IBaseEntity;

    Task SaveAsync<TEntity>(List<TEntity> datas, string collectionName = "") where TEntity : IBaseEntity;

    Task UpdateAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters, TEntity data) where TEntity : IBaseEntity;

    Task UpdateAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters, IDictionary<string, object> updates) where TEntity : IBaseEntity;

    Task UpdateManyAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters, IDictionary<string, object> updates) where TEntity : IBaseEntity;

    Task DeleteAsync<TEntity>(Expression<Func<TEntity, bool>> dataFilters, string collectionName) where TEntity : IBaseEntity;

    Task DeleteManyAsync<T1>(Expression<Func<T1, bool>> dataFilters, string collectionName) where T1 : IBaseEntity;


}
