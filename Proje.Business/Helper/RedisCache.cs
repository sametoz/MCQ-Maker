using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;

namespace Proje.Business.Helper
{
    public class RedisCache : ICache
    {
        public static RedisCache Instance { get; set; } = new RedisCache();
        private readonly ConnectionMultiplexer _connection = ConnectionMultiplexer.Connect("localhost:6379");
        private readonly IDatabase _database;
        private RedisCache()
        {
            _database = _connection.GetDatabase();
        }
        public void Add(byte[] key, byte[] value)
        {
            _database.StringSet(key, value);
        }
        public void Add(string key, string value)
        {
            _database.StringSet(key, value);
        }

        public string Retrieve(string key)
        {
            return _database.StringGet(key);
        }
    }
}
