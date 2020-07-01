using EMS.Common;
using EMS.Common.Constants;
using EMS.Common.ModelMappingClass;
using EMS.DbModelRepository.Models;
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
        Dictionary<string, float> pm250LData = new Dictionary<string, float>();
        public EmsPM520LManager(IEmsRepository<PM520L> emsRepository,IEmsRepository<EmsMaster> emsMasterRepository)
        {
            _emsRepository = emsRepository;
            _emsMasterRepository = emsMasterRepository;
        }

        public async Task CreateData(Block block, List<string> values, EmsDataReplication emsData, int slaveId)
        {
            try
            {
                
                var pm520L = await _emsRepository.GetWhere(x=>x.ModelName.Contains(block.BlockName));
                for (int i = 0; i < values.Count; i++)
                {
                    Int32 IntRep = Int32.Parse(values[i], NumberStyles.AllowHexSpecifier);
                    // Integer to Byte[] and presenting it for float conversion
                    float f = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
                    var cal = block.StartAddress + 1 + (i * block.TotalReg / block.TotalParams);
                    var key = pm520L.Where(x => x.ModBusAddress.Equals(cal)).Select(p => p.Parameter).FirstOrDefault();
                    pm250LData.Add(key, f);
                }
                var deviceDetails = DeviceCalculation.CalculateDevice(emsData);
                EmsMaster emsMaster = new EmsMaster
                {
                    DeviceId = deviceDetails.deviceId,
                    DateEms = deviceDetails.emsDate,
                    StartingAddress = block.StartAddress,
                    FunctionCode = block.ModBusFC,
                    SlaveId = slaveId,
                  
                };
                MapRecordField(emsMaster, block.BlockName);
                emsMaster.VLNAVG = (emsMaster.VRY + emsMaster.VYB + emsMaster.VBR) / 3;
                emsMaster.VLNAVG = (emsMaster.VR + emsMaster.VY + emsMaster.VB) / 3;
                emsMaster.IAVG = (emsMaster.IR + emsMaster.IY + emsMaster.IB) / 3;
                await _emsMasterRepository.Add(emsMaster);
            }
            catch(Exception ex)
            {

            }
           
            }
        public void MapRecordField(EmsMaster emsMaster, string meterName)
        {
            switch(meterName)
            {
                case MeterConstant._Venlite1:
                    emsMaster.WHCONTOT = pm250LData[pm520LMapping._WHCON];
                    emsMaster.WHGENTOT = pm250LData[pm520LMapping._WHGENTOT];
                    emsMaster.IY = pm250LData[pm520LMapping._IY];
                    emsMaster.IB = pm250LData[pm520LMapping._IB];
                    emsMaster.IR = pm250LData[pm520LMapping._IR];
                    emsMaster.VR = pm250LData[pm520LMapping._VR];
                    emsMaster.VY = pm250LData[pm520LMapping._VY];
                    emsMaster.VB = pm250LData[pm520LMapping._VB];
                    emsMaster.WR = pm250LData[pm520LMapping._WR];
                    emsMaster.WY = pm250LData[pm520LMapping._WY];
                    emsMaster.WB = pm250LData[pm520LMapping._WB];
                    emsMaster.WattsTot = pm250LData[pm520LMapping._WATTSTOT];
                    emsMaster.PFAVG = pm250LData[pm520LMapping._PFAVG];
                    break;
                case MeterConstant._Venlite2:
                    emsMaster.WHGENTOT = pm250LData[Vanlite2Mapping._WHGENTOT];
                    emsMaster.IY = pm250LData[Vanlite2Mapping._IY];
                    emsMaster.IB = pm250LData[Vanlite2Mapping._IB];
                    emsMaster.IR = pm250LData[Vanlite2Mapping._IR];
                    emsMaster.VR = pm250LData[Vanlite2Mapping._VR];
                    emsMaster.VY = pm250LData[Vanlite2Mapping._VY];
                    emsMaster.VB = pm250LData[Vanlite2Mapping._VB];
                    emsMaster.WR = pm250LData[Vanlite2Mapping._WR];
                    emsMaster.WY = pm250LData[Vanlite2Mapping._WY];
                    emsMaster.WB = pm250LData[Vanlite2Mapping._WB];
                    break;
            }
        }
    }

}
