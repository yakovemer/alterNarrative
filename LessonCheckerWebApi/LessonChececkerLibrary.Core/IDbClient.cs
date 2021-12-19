﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltNarrativeLibrary.Core
{
    public interface IDbClient
    {
        public IMongoCollection<TextNodeDb> GetTextNodeCollection();
    }
}
