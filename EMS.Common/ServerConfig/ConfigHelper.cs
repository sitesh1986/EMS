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

        public static string GetClientId
        {
            get
            {
                var appsettingValue = Environment.GetEnvironmentVariable("B2C:ClientId");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : ConfigurationManager.AppSettings.Get("B2C:ClientId");
            }
        }

        public static string GetClientSecret
        {
            get
            {
                var appsettingValue = Environment.GetEnvironmentVariable("B2C:ClientSecret");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : ConfigurationManager.AppSettings.Get("B2C:ClientSecret");
            }
        }

        public static string GetTenant
        {
            get
            {
                var appsettingValue = Environment.GetEnvironmentVariable("B2C:Tenant");
                return !string.IsNullOrEmpty(appsettingValue) ? appsettingValue : ConfigurationManager.AppSettings.Get("B2C:Tenant");
            }
        }
    }
}
