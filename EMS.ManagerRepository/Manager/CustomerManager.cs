using EMS.AzureGraphRepository;
using EMS.ModelBuilderRepository.Models;
using EMS.ModelBuilderRepository.Models.GraphModel;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class CustomerManager
    {
        private B2CGraphClient _b2CGraphClient { get; set; }
        private IEmsRepository<Customer> _emsRepository { get; set; }
        public CustomerManager(B2CGraphClient b2CGraphClient, IEmsRepository<Customer> emsRepository)
        {
            _b2CGraphClient = b2CGraphClient;
            _emsRepository = emsRepository;
        }
        public async Task<bool> CreateCustomer(Customer customer)
        {
            //bool b2cUser = await CreateB2CUser(customer);
            //if (b2cUser)
               bool user= await _emsRepository.Add(customer);
            return user;
        }
        private async Task<bool> CreateB2CUser(Customer userModel)
        {
            try
            {
                var uc = new GraphUserModel
                {
                    accountEnabled = true
                };
                List<SignInNames> names = new List<SignInNames>();
                SignInNames name = new SignInNames
                {
                    type = "emailAddress",
                    value = userModel.Email
                };
                names.Add(name);
                uc.signInNames = names;
                uc.creationType = "LocalAccount";
                uc.displayName = userModel.CustomerName;
                uc.passwordProfile = new PasswordProfile
                {
                    password = userModel.UserPassword,
                    forceChangePasswordNextLogin = false
                };
                uc.passwordPolicies = "DisablePasswordExpiration";

                var userString = Newtonsoft.Json.JsonConvert.SerializeObject(uc);
                await this._b2CGraphClient.CreateUser(userString);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
