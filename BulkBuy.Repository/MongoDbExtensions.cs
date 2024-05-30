    using System;
    using BulkBuy.Core.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization;
    using MongoDB.Bson.Serialization.Serializers;
    using System.Reflection;
    using MongoDB.Driver;
    using Microsoft.Extensions.Configuration;

    namespace BulkBuy.Repository;


    public static class MongoDbExtensions
    {
        public static IServiceCollection ConfigureMongoDatabase(this IServiceCollection services)
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));

            services.AddSingleton(serviceProvider =>
            {
                var configuration = serviceProvider.GetService<IConfiguration>();
                var mongoDbSettings = configuration.GetSection(nameof(MongoDbSettings)).Get<MongoDbSettings>();
                var mongoClient = new MongoClient(mongoDbSettings.ConnectionString);
                return mongoClient.GetDatabase(mongoDbSettings.DatabaseName);
            });
            return services;
        }

        public static IServiceCollection ConfigureMongoRepository(this IServiceCollection services)
        {
            services.AddSingleton<IRepository>(serviceProvider => new MongoRepository(serviceProvider.GetService<IMongoDatabase>())
            );
            return services;
        }
        
    }

