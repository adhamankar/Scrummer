﻿using MongoDB.Driver;
using Scrummer.Infrastructure.Mongo.Seedwork;
using System.Configuration;

namespace Scrummer.Infrastructure.Mongo
{
    public class ScrummerUnitOfWork : IMongoUnitOfWork
    {
        MongoDatabase database;

        public ScrummerUnitOfWork()
        {
            //read connectionstring from webapplication
            var connectionString = ConfigurationManager.AppSettings["MongoConnectionString"];
            database = MongoDatabase.Create(connectionString);
        }

        public MongoCollection<TEntity> CreateSet<TEntity>() where TEntity : class
        {
            string collectionName = typeof(TEntity).Name;
            return database.GetCollection<TEntity>(collectionName);
        }

        public void Commit()
        {
            //do nothing
        }

        public void Dispose()
        {
            //do nothing
        }
    }
}
