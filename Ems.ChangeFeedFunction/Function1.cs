using System;
using System.Threading.Tasks;

using Ems.ChangeFeedFunction.EmsDependencyInjection;
using EMS.ManagerRepository.Manager;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Ems.ChangeFeedFunction
{

    public class Function1
    {
        private EmsDataCalculateManager _emsDataCalculateManager;
        public Function1(EmsDataCalculateManager emsDataCalculateManager)
        {
            _emsDataCalculateManager = emsDataCalculateManager;
        }
        [FunctionName("Function1")]
        public async Task Run([ServiceBusTrigger("emsq", Connection = "ServiceBusconnectionString")]string myQueueItem,
            ILogger log)
        {
            await _emsDataCalculateManager.Calculation(myQueueItem);
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
