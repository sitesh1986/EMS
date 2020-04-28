using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class PrivilegeManager
    {
        private IEmsRepository<CustomerPrivilege> _emsRepository { get; set; }
        private IEmsRepository<Privilige> _privilegeRepository { get; set; }
        public PrivilegeManager(IEmsRepository<CustomerPrivilege> emsRepository, IEmsRepository<Privilige> privilegeRepository)
        {
            _emsRepository = emsRepository;
            _privilegeRepository = privilegeRepository;
        }
        public async Task CreateCustomerPrivilege(List<int> privileges, int customerId)
        {
            List<CustomerPrivilege> custPrivilege = new List<CustomerPrivilege>();
            foreach (var privilege in privileges)
            {
                CustomerPrivilege customerPrivilege = new CustomerPrivilege
                {
                 CustomerId=customerId,
                  PrivilegeId=privilege
                };
                custPrivilege.Add(customerPrivilege);
            }
            await _emsRepository.InsertBulk(custPrivilege);
        }
        public async Task<List<Privilige>> GetAllPrivileges()
        {
           var privileges= await _privilegeRepository.GetAll();
            return privileges.ToList();
        }
        public async Task<List<CustomerPrivilege>> GetCustomerPrivileges(int customerId)
        {
            var customerPrivileges = await _emsRepository.GetByCondition(x => x.CustomerId.Equals(customerId));
            return customerPrivileges.ToList();
        }

        public async Task<List<string>> GetCustomerPrivilegesNamesById(int customerId)
        {
            var customerPrivileges = await _emsRepository.GetByCondition(x => x.CustomerId.Equals(customerId));
            var privilegesIds = customerPrivileges.Select(x => x.PrivilegeId).ToList();
            var privelegesName = await _privilegeRepository.GetByCondition(x => privilegesIds.Contains(x.Id));
            return privelegesName.Select(x=>x.PrivilegeName).ToList();
        }
    }
}
