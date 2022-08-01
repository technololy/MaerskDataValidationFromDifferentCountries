using System;
using System.ComponentModel;
using System.Net.Http;
using Maersk.DataAggregator.Core;
using Maersk.DataAggregator.Core.Services;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.FlatFileCore
{
    public class ProcessFiles: Core.LoggingService, Core.IExtractorParser
    {
        private readonly IRepositoryService repositoryService;
        private readonly IClientService clientService;

        public ProcessFiles(UserInformation userInformation,HttpClient httpClient, IRepositoryService repositoryService,Core.IClientService clientService) :base(httpClient)
        {
            this.repositoryService = repositoryService;
            this.clientService = clientService;

            bool result = ClientInformationValidation(userInformation);
            if(result) SaveUserInformation(userInformation);
            SendLogsToNotificationUpstreamService(userInformation.UpstreamExtractorApplicationId);
        }

        public Country Country { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool ClientInformationValidation(UserInformation userInformation)
        {
           return clientService.ClientInformationValidation(userInformation);
        }

        public void SaveUserInformation(UserInformation userInformation)
        {
            repositoryService.InsertIntoTable(userInformation);
        }
    }
}
