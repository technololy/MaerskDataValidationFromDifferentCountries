using System;
namespace Maersk.DataAggregator.Models
{
    public class DatabaseConnectionInfo
    {
        public DatabaseConnectionInfo()
        {
        }

        public string ConnectionString { get; set; }
        public string DbName { get; set; }
        public int TimeOut { get; set; }
    }
}
