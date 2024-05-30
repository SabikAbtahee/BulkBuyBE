﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Database
{
    public class MongoDbSettings
    {
        public string Host {  get; init; }

        public string Port { get; init; }

        public string DatabaseName { get; init; }

        public string ConnectionString => $"mongodb://{Host}:{Port}";
    }
}