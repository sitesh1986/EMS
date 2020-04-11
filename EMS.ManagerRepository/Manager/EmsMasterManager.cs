using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
namespace EMS.ManagerRepository.Manager
{
    public class EmsMasterManager
    {
        private ServiceBusManager _serviceBusManager { get; set; }
        public EmsMasterManager(ServiceBusManager serviceBusManager)
        {
            _serviceBusManager = serviceBusManager;
        }
        public async Task<string> Create(string Body)
        {
            return await _serviceBusManager.CreateMessageInServiceBus(Body);
        }

      

    }
}
