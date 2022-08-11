using MongoDB.Driver;

namespace DatabaseConnection
{
    public class ConnectionMongo
    {
        private readonly IMongoDatabase _mongoDatabase;
        private readonly MongoClientSettings _mongoClientSettings;

        public ConnectionMongo()
        {
            _mongoClientSettings = MongoClientSettings.FromConnectionString("mongodb+srv://camis:camis@cluster0.pllljc1.mongodb.net/?retryWrites=true&w=majority");
            _mongoDatabase = new MongoClient(_mongoClientSettings).GetDatabase(MongoUrl
                .Create("mongodb+srv://camis:camis@cluster0.pllljc1.mongodb.net/?retryWrites=true&w=majority")
                .DatabaseName);
        }
    }
}