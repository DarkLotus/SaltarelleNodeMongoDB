// MongoClient.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace NodeApi.MongoDB {

    [Imported]
    [IgnoreNamespace]
    public class MongoClient {

        public MongoClient(MongoServer server) {
        }

        public void Close() {
        }

        public void Close(Action callback)
        {
        }

        public static void Connect(string url, Action<Exception,MongoClient> callback)
        {
        }

        public static void Connect(string url, object options, Action<MongoDatabase> callback)
        {
        }

        [ScriptName("db")]
        public MongoDatabase GetDatabase(string name) {
            return null;
        }

        public void Open(Action<Exception,MongoClient> callback)
        {
        }
    }
}
