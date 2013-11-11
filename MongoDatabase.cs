// MongoDatabase.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace NodeApi.MongoDB {

    [Imported]
    [ScriptName("Db")]
    public sealed class MongoDatabase {

        public MongoDatabase(string name, MongoServer server) {
        }

        public MongoDatabase(string name, MongoServer server, object options) {
        }

        public void Authenticate(string userName, string password, Action<bool> successCallback)
        {
        }

        public void Close() {
        }

        public void Close(Action callback)
        {
        }

        public void Close(bool forceClose, Action callback)
        {
        }

        public static void Connection(string url, Action<MongoDatabase> callback)
        {
        }

        public void CreateCollection(string name, Action<MongoCollection> callback)
        {
        }

        public void CreateCollection(string name, object options, Action<MongoCollection> callback)
        {
        }

        public void DropCollection(string name, Action callback)
        {
        }

        [ScriptName("admin")]
        public void GetAdminDatabase(Action<MongoDatabase> callback)
        {
        }

        [ScriptName("collection")]
        public void GetCollection(string name, Action<MongoCollection> callback)
        {
        }

        [ScriptName("collection")]
        public void GetCollection(string name, object options, Action<MongoCollection> callback)
        {
        }

        [ScriptName("collectionsInfo")]
        public void GetCollectionInfo(string name, Action<object> callback)
        {
        }

        [ScriptName("collectionNames")]
        public void GetCollectionNames(Action<object> callback)
        {
        }

        [ScriptName("collectionNames")]
        public void GetCollectionNames(string name, Action<object> callback)
        {
        }

        [ScriptName("collectionNames")]
        public void GetCollectionNames(string name, object options, Action<object> callback)
        {
        }

        [ScriptName("db")]
        public MongoDatabase GetDatabase(string name) {
            return null;
        }

        public void Open(Action<MongoDatabase> callback)
        {
        }

        public void RemoveCollection(string fromName, string toName, Action callback)
        {
        }

        public MongoCollection collection(string CollectionName)
        {
            return null;
        }
    }
}
