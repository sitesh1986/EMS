using EMS.Common;
using EMS.Common.ModelMappingClass;
using EMS.ModelBuilderRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class EmsPM520LManager:IpmFieldManager
    {
        private IEmsRepository<EmsMaster> _emsMasterRepository { get; set; }
        private IEmsRepository<PM520L> _emsRepository { get; set; }
        public EmsPM520LManager(IEmsRepository<PM520L> emsRepository,IEmsRepository<EmsMaster> emsMasterRepository)
        {
            _emsRepository = emsRepository;
            _emsMasterRepository = emsMasterRepository;
        }

        public async Task CreateData(Block block, List<string> values, EmsDataReplication emsData)
        {
           
            Dictionary<string, float> pm250LData = new Dictionary<string, float>();
            var pm520L = await _emsRepository.GetAll();
            for(int i=0;i< values.Count;i++)
            {
                Int32 IntRep = Int32.Parse(values[i], NumberStyles.AllowHexSpecifier);
                // Integer to Byte[] and presenting it for float conversion
                float f = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
                var cal = block.StartAddress + 1 + (i * block.TotalReg / block.TotalParams);
                var key = pm520L.Where(x => x.ModBusAddress.Equals(cal)).Select(p => p.Parameter).FirstOrDefault();
                pm250LData.Add(key,f);
            }
            var deviceDetails = DeviceCalculation.CalculateDevice(emsData);
            EmsMaster emsMaster = new EmsMaster
            {
                DeviceId=deviceDetails.deviceId,
                DateEms=deviceDetails.emsDate,

                WHCONTOT =pm250LData[pm520LMapping._WHCON],
                WHGENTOT= pm250LData[pm520LMapping._WHGENTOT],
                IY= pm250LData[pm520LMapping._IY],
                IB= pm250LData[pm520LMapping._IB],
                IR= pm250LData[pm520LMapping._IR],
                VR = pm250LData[pm520LMapping._VR],
                VY= pm250LData[pm520LMapping._VY],
                VB= pm250LData[pm520LMapping._VB],
                WR= pm250LData[pm520LMapping._WR],
                WY= pm250LData[pm520LMapping._WY],
                WB= pm250LData[pm520LMapping._WB],
                WattsTot= pm250LData[pm520LMapping._WATTSTOT],
                PFAVG= pm250LData[pm520LMapping._PFAVG]
            };
            emsMaster.VLNAVG = (emsMaster.VRY + emsMaster.VYB + emsMaster.VBR) / 3;
            emsMaster.VLNAVG = (emsMaster.VR + emsMaster.VY + emsMaster.VB) / 3;
            emsMaster.IAVG = (emsMaster.IR + emsMaster.IY + emsMaster.IB) / 3;
            await _emsMasterRepository.Add(emsMaster);
        }
    }
}
