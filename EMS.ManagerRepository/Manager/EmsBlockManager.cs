using EMS.ModelsRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{

    public class EmsBlockManager
    {
        private IEmsRepository<Block> _emsRepository { get; set; }
        public EmsBlockManager(IEmsRepository<Block> emsRepository)
        {
            _emsRepository = emsRepository;
        }
        public async Task<bool> CreateBlock(Block block)
        {
           var result= await _emsRepository.Add(block);
            return result;
        }
        public async Task<Block> GetBlocksByFields(int startAddress,int modBusFC,int totalReg)
        {
            var blockdata=await _emsRepository.GetByCondition(x=>x.ModBusFC.Equals(modBusFC) && x.StartAddress.Equals(startAddress) && x.TotalReg.Equals(totalReg));
            return blockdata.FirstOrDefault();
        }
    }
}
