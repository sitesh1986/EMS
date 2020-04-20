using EMS.DbModelRepository.Models;
using EMS.DbModelRepository.Models.GraphModel;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class CustomerManager
    {
        private IEmsRepository<Customer> _emsRepository { get; set; }
        private PrivilegeManager _privilegeManager { get; set; }
        private EmailManager _emailManager { get; set; }
        public CustomerManager(IEmsRepository<Customer> emsRepository, PrivilegeManager privilegeManager,
            EmailManager emailManager)
        {
            _emsRepository = emsRepository;
            _privilegeManager = privilegeManager;
            _emailManager = emailManager;
        }
        public async Task<Customer> CreateCustomer(Customer customer, List<int> privileges)
        {
            customer.UserPassword = encryptpass(customer.UserPassword);
            var createdCustomer = await _emsRepository.Add(customer);
            if (privileges != null)
                await _privilegeManager.CreateCustomerPrivilege(privileges, createdCustomer.Id);
            _emailManager.SendEmailViaWebApi(customer);
            return createdCustomer;
        }
        public string encryptpass(string password)
        {
            string msg = "";
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            msg = Convert.ToBase64String(encode);
            return msg;
        }
        //private async Task<bool> CreateB2CUser(Customer userModel)
        //{
        //    try
        //    {
        //        var uc = new GraphUserModel
        //        {
        //            accountEnabled = true
        //        };
        //        List<SignInNames> names = new List<SignInNames>();
        //        SignInNames name = new SignInNames
        //        {
        //            type = "emailAddress",
        //            value = userModel.Email
        //        };
        //        names.Add(name);
        //        uc.signInNames = names;
        //        uc.creationType = "LocalAccount";
        //        uc.displayName = userModel.CustomerName;
        //        uc.passwordProfile = new PasswordProfile
        //        {
        //            password = userModel.UserPassword,
        //            forceChangePasswordNextLogin = false
        //        };
        //        uc.passwordPolicies = "DisablePasswordExpiration";

        //        var userString = Newtonsoft.Json.JsonConvert.SerializeObject(uc);
        //        await this._b2CGraphClient.CreateUser(userString);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //}
    }
}
