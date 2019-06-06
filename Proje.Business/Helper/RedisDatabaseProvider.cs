using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Helper
{
    public class RedisDatabaseProvider: IRedisDatabaseProvider
    {
        private ConnectionMultiplexer _redisMultiplexer;

        public IDatabase GetDatabase()
        {
            if (_redisMultiplexer == null)
            {
                _redisMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
            }

            return _redisMultiplexer.GetDatabase();

        }
    }
}
