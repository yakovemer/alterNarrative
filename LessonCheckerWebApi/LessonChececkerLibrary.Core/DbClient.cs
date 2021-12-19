using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace AltNarrativeLibrary.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<TextNodeDb> _textNodes;

        public DbClient(IOptions<TextNodeDbConfig> textNodeDbConfig)
        {
            var client = new MongoClient(textNodeDbConfig.Value.Connection_String);
            var database = client.GetDatabase(textNodeDbConfig.Value.Database_Name);
            _textNodes = database.GetCollection<TextNodeDb>(textNodeDbConfig.Value.TextNodes_Collection_Name);
        }

        public IMongoCollection<TextNodeDb> GetTextNodeCollection() => _textNodes;


    }
}
