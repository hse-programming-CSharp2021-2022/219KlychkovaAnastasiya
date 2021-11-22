using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace TaskSet
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString)
        {
            redis = ConnectionMultiplexer.Connect($"{connectionString}:19876,password=cg7bY38Ry4NjsESqKVeVXKSgD1CPc1lj,ConnectTimeout=10000,allowAdmin=true");
            database = redis.GetDatabase();
        }

        public static void Add(string key, string value)
        {
            database.SetAdd(key, value);
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static bool ExistProduct(string key, string productName)
        {
            return database.SetContains(key, productName);
        }

        public static List<string> GetProducts(string key)
        {
            return new List<string>(Array.ConvertAll(database.SetMembers(key),t=>t.ToString()));
        }
    }
}