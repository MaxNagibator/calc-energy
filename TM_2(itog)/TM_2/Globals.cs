using SqlProviderNameSpace;

namespace TM_2
{
    public static class Globals
    {
        public static string ConnectionString { get; set; }
        public static SqlProvider GetSqlProvider()
        {
            return new SqlProvider(ConnectionString);
        }
    }
}
