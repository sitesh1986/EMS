﻿using EMS.DbModelRepository.Models;
using EMS.DbModelRepository.Models.GraphModel;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class CustomerManager
    {
        private IEmsRepository<Customer> _emsRepository { get; set; }
        private PrivilegeManager _privilegeManager { get; set; }
        private EmailManager _emailManager { get; set; }
        private IEmsRepository<CustomerMeter> _meterRepository { get; set; }
        public CustomerManager(IEmsRepository<Customer> emsRepository, PrivilegeManager privilegeManager,
            EmailManager emailManager, IEmsRepository<CustomerMeter> meterRepository)
        {
            _emsRepository = emsRepository;
            _privilegeManager = privilegeManager;
            _emailManager = emailManager;
            _meterRepository = meterRepository;
        }
        public async Task<Customer> CreateCustomer(Customer customer, List<int> privileges,List<int> meters)
        {
            customer.UserPassword = encryptpass(customer.UserPassword);
            var existCustomer = await _emsRepository.GetWhere(x => x.Email.Equals(customer.Email));
            if (existCustomer.ToList().Count > 0)
                throw new Exception("Customer already exists");
            var createdCustomer = await _emsRepository.Add(customer);
            if (privileges != null)
                await _privilegeManager.CreateCustomerPrivilege(privileges, createdCustomer.Id);
            if (meters != null)
                await CreateCustomerMeter(meters,createdCustomer.Id);
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
        public async Task CreateCustomerMeter(List<int> meters,int customerId)
        {
            List<CustomerMeter> custMeter= new List<CustomerMeter>();
            foreach (var meter in meters)
            {
                CustomerMeter customerPrivilege = new CustomerMeter
                {
                    CustomerId = customerId,
                    MeterId = meter
                };
                custMeter.Add(customerPrivilege);
            }
            await _meterRepository.InsertBulk(custMeter);
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
