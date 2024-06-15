using BulkBuy.Application.Common.Interfaces;
using BulkBuy.Domain.Interfaces;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace BulkBuy.Infrastructure.Database;


public class MongoRepository : IRepository
{
    private readonly IMongoDatabase _database;
    private readonly IDateTimeProvider _dateTimeProvider;

    public MongoRepository(IMongoDatabase database, IDateTimeProvider dateTimeProvider)
    {
        _database = database;
        _dateTimeProvider = dateTimeProvider;
    }

    public async Task DeleteAsync<T>(Expression<Func<T, bool>> dataFilters, string collectionName) where T : IBaseEntity
    {
        if (string.IsNullOrEmpty(collectionName))
        {
            collectionName = $"{typeof(T).Name}s";
        }
        var collection = _database.GetCollection<T>(collectionName);
        await collection.DeleteOneAsync(dataFilters);
    }

    public async Task DeleteManyAsync<T>(Expression<Func<T, bool>> dataFilters, string collectionName) where T : IBaseEntity
    {
        if (string.IsNullOrEmpty(collectionName))
        {
            collectionName = $"{typeof(T).Name}s";
        }
        var collection = _database.GetCollection<T>(collectionName);
        await collection.DeleteManyAsync(dataFilters);
    }

    public async Task<T> GetItemAsync<T>(Expression<Func<T, bool>> dataFilters) where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);
        return await collection.Find(dataFilters).FirstOrDefaultAsync();
    }

    public async Task<IReadOnlyCollection<T>> GetItemsAsync<T>(Expression<Func<T, bool>> dataFilters) where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);
        var items = await collection.Find(dataFilters).ToListAsync();
        return items.AsReadOnly();
    }

    public async Task<IReadOnlyCollection<T>> GetItemsAsync<T>() where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);
        var items = await collection.Find(_ => true).ToListAsync();
        return items.AsReadOnly();
    }

    public async Task SaveAsync<T>(T data, string collectionName = "") where T : IBaseEntity
    {
        if (collectionName == "")
        {
            collectionName = $"{typeof(T).Name}s";
        }
        await _database.GetCollection<T>(collectionName).InsertOneAsync(data);

    }

    public async Task SaveAsync<T>(List<T> datas, string collectionName = "") where T : IBaseEntity
    {
        if (string.IsNullOrEmpty(collectionName))
        {
            collectionName = $"{typeof(T).Name}s";
        }
        var collection = _database.GetCollection<T>(collectionName);
        await collection.InsertManyAsync(datas);
    }

    public async Task UpdateAsync<T>(Expression<Func<T, bool>> dataFilters, T data) where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);
        data.LastUpdateDate = _dateTimeProvider.UtcNow;
        await collection.ReplaceOneAsync(dataFilters, data);
    }

    public async Task UpdateAsync<T>(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates) where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);

        var updateDefinition = new UpdateDefinitionBuilder<T>();
        var updateDefinitions = new List<UpdateDefinition<T>>();

        foreach (var update in updates)
        {
            updateDefinitions.Add(updateDefinition.Set(update.Key, update.Value));
        }
        //updateDefinitions.Add(updateDefinition.Set("LastUpdateDate", _dateTimeProvider.UtcNow));
        var combinedUpdate = updateDefinition.Combine(updateDefinitions);

        await collection.UpdateOneAsync(dataFilters, combinedUpdate);
    }

    public async Task UpdateManyAsync<T>(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates) where T : IBaseEntity
    {
        var collectionName = $"{typeof(T).Name}s";
        var collection = _database.GetCollection<T>(collectionName);

        var updateDefinition = new UpdateDefinitionBuilder<T>();
        var updateDefinitions = new List<UpdateDefinition<T>>();

        foreach (var update in updates)
        {
            updateDefinitions.Add(updateDefinition.Set(update.Key, update.Value));
        }

        var combinedUpdate = updateDefinition.Combine(updateDefinitions);

        await collection.UpdateManyAsync(dataFilters, combinedUpdate);
    }

}
