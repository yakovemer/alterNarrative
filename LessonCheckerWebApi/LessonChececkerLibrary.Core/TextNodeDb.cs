using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltNarrativeLibrary.Core
{
    public class Info
    {
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string externalId { get; set; }
        public string description { get; set; }

        public string type { get; set; }
        public DateTime created { get; set; }
    }
    public class TextNodeDb
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public DateTime createdAt { get; set; }

        //[BsonRepresentation(MongoDB.Bson.BsonType.Timestamp)]
        public BsonTimestamp updatedAt { get; set;}

        public ObjectId[] childNodeIds { get; set; }
        public ObjectId? parentNodeId { get; set; }

    }
}
