using StackExchange.Redis;

namespace TakeAwayNight.Basket.Settings
{
    public class RedisService
    {
        public string _Host { get; set; }
        public int _Port { get; set; }
        public RedisService(string host, int port)
        {
            _Host = host;
            _Port = port;
        }

       

        public ConnectionMultiplexer _connectionMultiplexer;

        public void Connect() => _connectionMultiplexer = ConnectionMultiplexer.Connect($"{_Host}:{_Port}");

        public IDatabase GetDb(int db = 1) => _connectionMultiplexer.GetDatabase(0);
    }
}
