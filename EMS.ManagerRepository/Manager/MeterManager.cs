using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class MeterManager
    {
        private IEmsRepository<MetersModel> _emsRepository { get; set; }
        private IEmsRepository<CustomerMeter> _meterRepository { get; set; }
        public MeterManager(IEmsRepository<MetersModel> emsRepository, IEmsRepository<CustomerMeter> meterRepository)
        {
            _emsRepository = emsRepository;
            _meterRepository = meterRepository;
        }
        public async Task<List<MetersModel>> GetAll()
        {
            var meters= await _emsRepository.GetAll();
            return meters.ToList();
        }
        public async Task<List<MetersModel>> GetCustomerMetereByCustomerId(int customerId)
        {
            var customerPrivileges = await _meterRepository.GetByCondition(x => x.CustomerId.Equals(customerId));
            var meterIds = customerPrivileges.Select(x => x.MeterId).ToList();
            var meters = await _emsRepository.GetByCondition(x => meterIds.Contains(x.Id));
            return meters.ToList();
        }
    }
}
