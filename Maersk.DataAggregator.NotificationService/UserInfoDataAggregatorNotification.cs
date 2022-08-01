using System;
namespace Maersk.DataAggregator.NotificationService
{
    public class UserInfoDataAggregatorNotification
    {
        public UserInfoDataAggregatorNotification()
        {
        }

        public void SaveUserInfoValidationResult()
        {
            //Save the result of successful or failed validation
        }


        public void NotifyClientsOfValidationResults(int clientId)
        {
            //notify clients of the results of the Clients Information that was processed
            //notification can be via email, API, etc.
        }
    }
}
