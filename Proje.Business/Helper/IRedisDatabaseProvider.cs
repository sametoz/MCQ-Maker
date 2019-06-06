using StackExchange.Redis;
namespace Proje.Business.Helper
{
    public interface IRedisDatabaseProvider
    {
        IDatabase GetDatabase();

    }
}