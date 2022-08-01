using System;
using Maersk.DataAggregator.Models;

namespace Maersk.DataAggregator.Core
{
    public interface IExtractorParser
    {
        public void SaveUserInformation(UserInformation userInformation);
    }
}
