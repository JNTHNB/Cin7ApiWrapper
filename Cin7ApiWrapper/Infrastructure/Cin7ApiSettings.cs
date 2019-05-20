using System;
using System.Configuration;

namespace Cin7ApiWrapper.Infrastructure
{

    internal interface ICin7ApiSettings
    {
        string BaseUrl { get; }
    }

    internal class Cin7ApiSettings : ICin7ApiSettings
    {
        const string Cin7ApiBaseUrlElementName = "Cin7ApiBaseUrl";

        public Cin7ApiSettings()
        {
            var settings = ConfigurationManager.AppSettings;

            BaseUrl = settings.Get(Cin7ApiBaseUrlElementName);

            if (string.IsNullOrWhiteSpace(BaseUrl))
            {
                throw new Exception($"{Cin7ApiBaseUrlElementName} in appSettings is undefined.");
            }
        }

        public string BaseUrl { get; }
    }
}
