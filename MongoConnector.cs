// MongoConnector.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace NodeApi.MongoDB {

    [Imported]
    [ScriptName("Db")]
    public sealed class MongoConnector {

        public MongoConnector(string name, MongoServer server) {
        }

        public MongoConnector(string name, MongoServer server, object options) {
        }

        public void Open(Action<MongoDatabase> callback)
        {
        }
    }
}
