using System;
using System.Collections.Generic;
using DOTNET_API.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DOTNET_API.Repositories
{
    public class MongoDbItemsRepository : IItemsRepository
    {
        private const string databaseName = "mongoDotnet";
        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection;
        private readonly FilterDefinitionBuilder<Item> _filterDefinitionBuilder = Builders<Item>.Filter;

        public MongoDbItemsRepository(IMongoClient mongoClient)
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName);
            itemsCollection = database.GetCollection<Item>(collectionName);
        }
        public Item GetItem(Guid id)
        {
            var filter = _filterDefinitionBuilder.Eq(item => item.Id, id);
            return itemsCollection.Find(filter).SingleOrDefault();
        }

        public IEnumerable<Item> GetItems()
        {
            return itemsCollection.Find(new BsonDocument()).ToList();
        }

        public void CreateItem(Item item)
        {
            itemsCollection.InsertOne(item);
        }

        public void UpdateItem(Item item)
        {
            var filter = _filterDefinitionBuilder.Eq(existingItem => existingItem.Id, item.Id);
            itemsCollection.ReplaceOne(filter, item);
        }

        public void DeleteItem(Guid id)
        {
            var filter = _filterDefinitionBuilder.Eq(existingItem => existingItem.Id, id);
            itemsCollection.DeleteOne(filter);
        }
    }
}