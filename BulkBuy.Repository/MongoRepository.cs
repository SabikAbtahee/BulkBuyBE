﻿using BulkBuy.Core.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Repository
{
    public class MongoRepository<T> : IRepository<T> where T : IBaseEntity
    {
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;
        private readonly IMongoCollection<T> _dbCollection;
        private readonly FilterDefinitionBuilder<T> filterBuilder = Builders<T>.Filter;

        public MongoRepository(IMongoDatabase database,string collectionName)
        {
            _database = database;
            _collectionName = collectionName;
            _dbCollection = database.GetCollection<T>(collectionName);
        }

        public async Task DeleteAsync(Expression<Func<T, bool>> dataFilters, string collectionName)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetItemAsync(Expression<Func<T, bool>> dataFilters)
        {
            throw new NotImplementedException();
        }

        public async Task<IReadOnlyCollection<T>> GetItemsAsync(Expression<Func<T, bool>> dataFilters)
        {
            //return await _dbCollection.Find(filterBuilder.Empty).ToListAsync();
            throw new NotImplementedException();

        }

        public async Task<IReadOnlyCollection<T>> GetItemsAsync()
        {
            return await _dbCollection.Find(filterBuilder.Empty).ToListAsync();
        }

        public async Task SaveAsync(T data, string collectionName = "")
        {
            await _dbCollection.InsertOneAsync(data);
        }

        public async Task SaveAsync(List<T> datas, string collectionName = "")
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Expression<Func<T, bool>> dataFilters, T data)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateManyAsync(Expression<Func<T, bool>> dataFilters, IDictionary<string, object> updates)
        {
            throw new NotImplementedException();
        }
    }
}