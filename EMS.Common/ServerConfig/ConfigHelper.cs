using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace EMS.Common.ServerConfig
{
    public static class ConfigHelper
    {
        public static string GetConnectionnString
        {
            get
            {
                var appsettingValue = Environment.GetEnvironmentVariable("connectionStrings");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : ConfigurationManager.AppSettings.Get("connectionStrings");
            }
        }
    }
}
