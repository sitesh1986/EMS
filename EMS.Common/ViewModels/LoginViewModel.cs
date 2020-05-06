using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class LoginViewModel
    {
        [JsonProperty("user_name")]
        public string UserName { get; set; }
        [JsonProperty("password")]
        public string UserPassword { get; set; }
    }
}
