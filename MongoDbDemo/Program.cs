using MongoDB.Bson;
using MongoDB.Driver;
using System;
namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var client = new MongoDB.Driver.MongoClient("mongodb://192.168.1.117:27017");

            var database = client.GetDatabase("test");

            var document = new BsonDocument
{
    { "yuxianye", "MongoDB" },
    { "name", "MongoDB" },
    { "type", "Database" },
    { "count", 1 },
    { "info", new BsonDocument
        {
            { "x", 203 },
            { "y", 102 }
        }}
};


            var collection = database.GetCollection<MongoDB.Bson.BsonDocument>("test");
            collection.InsertOne(document);
            var count = collection.CountDocuments(new BsonDocument());

            //Console.WriteLine(collection.ToJson<BsonDocument>());

            var vv = collection.Find(new BsonDocument()).ToList();

            foreach (var v in vv)
            {
                Console.WriteLine($"{v.ToString()}");
            }

            Console.WriteLine($"数量{count}");

            var document2 = collection.FindSync(new BsonDocument());
            Console.WriteLine(document2.ToString());

            Console.ReadLine();

        }
    }
}
