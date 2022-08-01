using System;
using System.ComponentModel;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.Core
{
    public interface IClientService
    {
        public bool ClientInformationValidation(UserInformation userInformation);

        event PropertyChangedEventHandler PropertyChanged;

        public Country Country { get; set; }
    }
}
