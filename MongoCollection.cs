// MongoCollection.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace NodeApi.MongoDB {

    [Imported]
    [ScriptName("collection")]
    [IgnoreNamespace]
    public sealed class MongoCollection {

        public MongoCollection(MongoDatabase database, string name) {
        }

        public MongoCollection(MongoDatabase database, string name, object options) {
        }

        public void Count(Action<int> callback)
        {
        }

        public void Count(object query, Action<int> callback)
        {
        }

        public void Count(object query, object options, Action<int> callback)
        {
        }

        public void Distinct(string key, Action<object[]> callback)
        {
        }

        public void Distinct(string key, object query, Action<object[]> callback)
        {
        }

        public void Distinct(string key, object query, object options, Action<object[]> callback)
        {
        }

        public void Drop(Action callback)
        {
        }

        public MongoCursor Find(object query) {
            return null;
        }

        public MongoCursor Find(object query, object options) {
            return null;
        }

        public void FindAndModify(object query, object[] sort, object document, Action<object> callback)
        {
        }

        public void FindAndModify(object query, object[] sort, object document, object options, Action<object> callback)
        {
        }

        public void FindAndRemove(object query, object[] sort, Action<object> callback)
        {
        }

        public void FindAndRemove(object query, object[] sort, object options, Action<object> callback)
        {
        }

        public MongoCursor FindOne(object query, Action<object> callback)
        {
            return null;
        }

        public MongoCursor FindOne(object query, object options, Action<object> callback)
        {
            return null;
        }

        public void Insert(object[] documents) {
        }
        public void Insert(object document, Action<Exception> callback)
        {
        }
        public void Insert(object[] documents, object options) {
        }

        public void Insert(object[] documents, object options, Action callback)
        {
        }

        public void Remove() {
        }

        public void Remove(Action callback)
        {
        }

        public void Remove(object selector) {
        }

        public void Remove(object selector, Action callback)
        {
        }

        public void Remove(object selector, object options, Action callback)
        {
        }

        public void Rename(string newName, Action callback)
        {
        }

        public void Update(object selector, object document) {
        }

        public void Update(object selector, object document, Action callback)
        {
        }

        public void Update(object selector, object document, object options, Action callback)
        {
        }
    }
}
