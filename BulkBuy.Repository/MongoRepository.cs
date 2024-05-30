using BulkBuy.Core.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Repository;

public class MongoRepository<T> : IRepository
{
    private readonly IMongoDatabase _database;
    private readonly string _collectionName;
    private readonly IMongoCollection<T> _dbCollection;
    private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

    public MongoRepository(IMongoDatabase database, string collectionName)
    {
        _database = database;
        _collectionName = collectionName;
        _dbCollection = database.GetCollection<T>(collectionName);
    }

    public Task DeleteAsync<T1>(Expression<Func<T1, bool>> dataFilters, string collectionName) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task<T1> GetItemAsync<T1>(Expression<Func<T1, bool>> dataFilters) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<T1>> GetItemsAsync<T1>(Expression<Func<T1, bool>> dataFilters) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<T1>> GetItemsAsync<T1>() where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync<T1>(T1 data, string collectionName = "") where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync<T1>(List<T1> datas, string collectionName = "") where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync<T1>(Expression<Func<T1, bool>> dataFilters, T1 data) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync<T1>(Expression<Func<T1, bool>> dataFilters, IDictionary<string, object> updates) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }

    public Task UpdateManyAsync<T1>(Expression<Func<T1, bool>> dataFilters, IDictionary<string, object> updates) where T1 : IBaseEntity
    {
        throw new NotImplementedException();
    }



    //public Task DeleteAsync<T1>(Expression<Func<T1, bool>> dataFilters, string collectionName) where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}


    //public Task<T1> GetItemAsync<T1>(Expression<Func<T1, bool>> dataFilters) where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}


    ////public async Task<IReadOnlyCollection<T>> GetItemsAsync()
    ////{
    ////    return await _dbCollection.Find(filterBuilder.Empty).ToListAsync();
    ////}

    //public async Task<IReadOnlyCollection<T1>> GetItemsAsync<T1>(Expression<Func<T1, bool>> dataFilters) where T1 : IBaseEntity
    //{
    //    return await _dbCollection.Find(filterBuilder.Empty).ToListAsync();

    //}

    //public Task<IReadOnlyCollection<T1>> GetItemsAsync<T1>() where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}

    ////public async Task SaveAsync(T data, string collectionName = "")
    ////{
    ////    await _dbCollection.InsertOneAsync(data);
    ////}

    ////public async Task SaveAsync(List<T> datas, string collectionName = "")
    ////{
    ////    throw new NotImplementedException();
    ////}

    //public Task SaveAsync<T1>(T1 data, string collectionName = "") where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}

    //public Task SaveAsync<T1>(List<T1> datas, string collectionName = "") where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}

    ////public async Task UpdateAsync(Expression<Func<T, bool>> dataFilters, T data)
    ////{
    ////    throw new NotImplementedException();
    ////}

    ////public async Task UpdateAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates)
    ////{
    ////    throw new NotImplementedException();
    ////}

    //public Task UpdateAsync<T1>(Expression<Func<T1, bool>> dataFilters, T1 data) where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}

    //public Task UpdateAsync<T1>(Expression<Func<T1, bool>> dataFilters, IDictionary<string, object> updates) where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}

    //public async Task UpdateManyAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task UpdateManyAsync<T1>(Expression<Func<T1, bool>> dataFilters, IDictionary<string, object> updates) where T1 : IBaseEntity
    //{
    //    throw new NotImplementedException();
    //}
}
