using System;
using System.Net.Http;

namespace Maersk.DataAggregator.Core
{
    public abstract class LoggingService
    {
        private readonly HttpClient httpClient;

        public LoggingService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public void SendLogsToNotificationUpstreamService(int clientId)
        {
            //call API maersk.DataAggregator.NotificationService with ClientUserInformation to be logged and shown to Upstream
        }


    }
}
