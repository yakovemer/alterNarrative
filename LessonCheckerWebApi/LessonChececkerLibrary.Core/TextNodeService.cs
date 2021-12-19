using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace AltNarrativeLibrary.Core
{
    public class TextNodeService : ITextNodeService
    {
        private readonly IMongoCollection<TextNodeDb> _textNodes;

        public TextNodeService(IDbClient dbClient)
        {
            _textNodes = dbClient.GetTextNodeCollection();
        }


        public List<TextNodeDb> GetTextNodes()
        {
            return _textNodes.Find(t => true).ToList();
        }
    }
}
