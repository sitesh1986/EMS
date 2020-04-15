using EMS.Common.DataCalculation;
using EMS.ManagerRepository.FactoryRepository;
using EMS.ModelBuilderRepository.Models;
using EMS.SqlRepository.DbRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class EmsDataCalculateManager
    {
       private Factory _factory { get; set; }
        private EmsBlockManager _emsBlockManager { get; set; }

        public EmsDataCalculateManager(EmsBlockManager emsBlockManager,Factory factory)
        {
            _emsBlockManager = emsBlockManager;
            _factory = factory;
        }
        public async Task Calculation(string data)
        {
            Block block = new Block();
            List<string> emsData = new List<string>();
            var rlData = JsonConvert.DeserializeObject<EmsDataReplication>(data);
            if (rlData.G != string.Empty)
            {
                var keyValuePairs = EmsCalculation.Calcuclate(rlData.G);
                block = await _emsBlockManager.GetBlocksByFields(keyValuePairs.header["startAddress"], keyValuePairs.header["modeBusFc"], keyValuePairs.header["totalReg"]);
                emsData.AddRange(keyValuePairs.values);
            }

            else
            {
                var keyValuePairs = EmsCalculation.Calcuclate(rlData.Data);
                block = await _emsBlockManager.GetBlocksByFields(keyValuePairs.header["startAddress"], keyValuePairs.header["modeBusFc"], keyValuePairs.header["totalReg"]);
                emsData.AddRange(keyValuePairs.values);
            }

            var IpmManager= _factory.GetIPMManager(block.BlockName);
            await IpmManager.CreateData(block,emsData,rlData);
        }

    }
}
