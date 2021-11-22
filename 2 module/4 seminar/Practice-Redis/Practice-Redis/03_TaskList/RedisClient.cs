using System;
using StackExchange.Redis;

namespace TaskList
{
    public static class RedisClient
    {
        /// <summary>
        /// Maximum number of versions to store
        /// </summary>
        public const uint MaxCount = 5;

        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString)
        {
            redis = ConnectionMultiplexer.Connect($"{connectionString}:19876,password=cg7bY38Ry4NjsESqKVeVXKSgD1CPc1lj,ConnectTimeout=10000,allowAdmin=true");
            database = redis.GetDatabase();
        }

        public static string Get(string key)
        {
            return database.ListGetByIndex(key,-1);
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static void Add(string key, string value)
        {
            database.ListRightPush(key, value);
            if(database.ListLength(key) > MaxCount)
            {
                database.ListLeftPop(key);
            }
        }
        public static string Back(string key)
        {
            if (database.ListLength(key) > 1)
            {
                return $"Version {database.ListRightPop(key)} has been removed";
            }
            else
            {
                database.KeyDelete(key);
                return "Application was deleted";
            }
        }
    }
}