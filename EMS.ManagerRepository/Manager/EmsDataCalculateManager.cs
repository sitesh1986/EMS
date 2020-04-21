using EMS.Common.DataCalculation;
using EMS.ManagerRepository.FactoryRepository;
using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace EMS.ManagerRepository.Manager
{
    public class EmsDataCalculateManager
    {
        private Factory _factory { get; set; }
        private EmsBlockManager _emsBlockManager { get; set; }

        public EmsDataCalculateManager(EmsBlockManager emsBlockManager, Factory factory)
        {
            _emsBlockManager = emsBlockManager;
            _factory = factory;
        }
        public async Task Calculation(string data)
        {
            string streamData = string.Empty;
            Block block = new Block();
           
            var rlData = JsonConvert.DeserializeObject<EmsDataReplication>(data);
            if (!string.IsNullOrEmpty(rlData.G))
                streamData = rlData.G;
            else
                streamData = rlData.Data;

            var streamDataList = streamData.Split('/').ToList();
            streamDataList.RemoveAll(item => string.IsNullOrEmpty(item));
            foreach (var convertedData in streamDataList)
            {
                List<string> emsData = new List<string>();
                var keyValuePairs = EmsCalculation.Calcuclate(convertedData);
                block = await _emsBlockManager.GetBlocksByFields(keyValuePairs.header["startAddress"], keyValuePairs.header["modeBusFc"], keyValuePairs.header["totalReg"]);
                emsData.AddRange(keyValuePairs.values);
                var IpmManager = _factory.GetIPMManager(block.BlockName);
                await IpmManager.CreateData(block, emsData, rlData, keyValuePairs.header["slaveId"]);
            }
          
        }

    }
}
