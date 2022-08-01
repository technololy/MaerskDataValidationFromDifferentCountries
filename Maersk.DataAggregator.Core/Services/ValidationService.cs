using System;
using System.ComponentModel;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.Core.Services
{
    public class ValidationService: IClientService
    {
        private readonly IClientService clientService;

        public ValidationService(IClientService clientService)
        {
            this.clientService = clientService;
        }

        public Country Country
        {
            get => throw new NotImplementedException();
            set
            {
                //get the country name/code from upstream file and set up the other country properties here
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool ClientInformationValidation(UserInformation userInformation)
        {
            //checks the userinformation against the rules set in ClientSpecifics.json
            if (true)
            {

            }
            else
            {

            }

            throw new NotImplementedException();
        }
    }
}
