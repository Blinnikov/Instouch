using System;
using Microsoft.Extensions.Configuration;

namespace Blinnikov.Instouch.Services.Common
{
    public class AppSettings : IAppSettings
    {
        private readonly IConfigurationRoot _config;

        public AppSettings(IConfigurationRoot config)
        {
            this._config = config;
        }
        public string Username => this._config["username"];

        public string Password => this._config["password"];
    }
}
