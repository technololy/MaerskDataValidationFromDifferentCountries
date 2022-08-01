using System;
using Maersk.DataAggregator.Core.Services;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.Core
{
    public class RepositoryService: IRepositoryService
    {
        public RepositoryService()
        {
        }

        public DatabaseConnectionInfo DatabaseConnectionInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DeleteFromTable(UserInformation userInformation)
        {
            throw new NotImplementedException();
        }

        public void GetFromTable(UserInformation userInformation)
        {
            throw new NotImplementedException();
        }

        public void InsertIntoTable(UserInformation userInformation)
        {
            throw new NotImplementedException();
        }

        public void UpdateTable(UserInformation userInformation)
        {
            throw new NotImplementedException();
        }
    }
}
