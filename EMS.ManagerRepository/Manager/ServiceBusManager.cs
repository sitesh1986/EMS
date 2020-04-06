using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
   
    public class ServiceBusManager
    {
        private IConfiguration _configuration;
        static QueueClient queueClient;
        string messageBody = string.Empty;
        public ServiceBusManager(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> CreateMessageInServiceBus(string msgBody)
        {
            var sbConnection= _configuration.GetSection("ServiceBusConnection").GetSection("SbConnectionString");
            var queueName= _configuration.GetSection("ServiceBusConnection").GetSection("QueueName");
            try
            {
                var result = msgBody.Split('&').Select(x => x.Split('=')).ToDictionary(x => x[0], x => x[1]);
                messageBody = JsonConvert.SerializeObject(result);
                queueClient = new QueueClient(sbConnection.Value, queueName.Value);

                var message = new Message(Encoding.UTF8.GetBytes(messageBody));
               
                await queueClient.SendAsync(message);
                return "\"" + "ACK" + "\"";
            }
            catch(Exception ex)
            {
                return "Bad Request";
            }
        
        }
    }
}
