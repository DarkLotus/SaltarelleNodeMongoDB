// MongoCursor.cs
// Script#/Libraries/Node/Mongo
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace NodeApi.MongoDB {

    [Imported]
    [ScriptName("Cursor")]
    public sealed class MongoCursor {

        public MongoCursor(MongoDatabase database, MongoCollection collection, object query, object fields) {
        }

        public MongoCursor(MongoDatabase database, MongoCollection collection, object query, object fields, object options) {
        }

        public MongoCursor BatchSize(int size) {
            return null;
        }

        public void Close(Action callback)
        {
        }

        public void Count(Action<int> callback)
        {
        }

        public void Each(Action<object> callback)
        {
        }

        public bool IsClosed() {
            return false;
        }

        public MongoCursor Limit(int limit) {
            return null;
        }

        public void NextObject(Action<object> callback)
        {
        }

        public MongoCursor Rewind() {
            return null;
        }

        public MongoCursor Skip(int skip) {
            return null;
        }

        public MongoCursor Sort(string field, string direction) {
            return null;
        }

        public MongoCursor Sort(object[] fields) {
            return null;
        }

        public void ToArray(Action<object[]> callback)
        {
        }
    }
}
