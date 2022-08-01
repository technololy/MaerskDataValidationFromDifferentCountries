using System;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.Core.Services
{
    public interface IRepositoryService
    {
        public DatabaseConnectionInfo DatabaseConnectionInfo { get; set; }
        public void InsertIntoTable(UserInformation userInformation);
        public void UpdateTable(UserInformation userInformation);
        public void DeleteFromTable(UserInformation userInformation);
        public void GetFromTable(UserInformation userInformation);
    }
}
