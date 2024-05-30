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

    public static IServiceCollection ConfigureMongoRepository<T>(this IServiceCollection services, string collectionName) where T : IBaseEntity
    {
        services.AddSingleton<IRepository>(serviceProvider =>
        {
            var database = serviceProvider.GetService<IMongoDatabase>();
            return new MongoRepository<T>(database, collectionName);
        });
        return services;
    }

    public static IServiceCollection ConfigureMongoRepositories(this IServiceCollection services, string @namespace)
    {
        var types = AppDomain.CurrentDomain.GetAssemblies()
        .SelectMany(assembly => GetLoadableTypes(assembly))
        .Where(type => type.IsClass && type.Namespace == @namespace);

        foreach (var type in types)
        {
            var method = typeof(MongoDbExtensions).GetMethod(nameof(ConfigureMongoRepository))
                .MakeGenericMethod(type);
            method.Invoke(null, new object[] { services, $"{type.Name}s" });
        }

        return services;
    }

    private static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
    {
        try
        {
            return assembly.GetTypes();
        }
        catch (ReflectionTypeLoadException e)
        {
            return e.Types.Where(t => t != null);
        }
    }
}

