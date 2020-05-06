﻿using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class LoginManager
    {
        private IEmsRepository<Customer> _emsRepository { get; set; }
        public LoginManager(IEmsRepository<Customer> emsRepository)
        {
            _emsRepository = emsRepository;
        }
        public async Task<Customer> CheckUserCredential(Customer customer)
        {
            var existCustomer = await _emsRepository.GetByCondition(x => (x.UserName.Equals(customer.UserName) || x.Email.Equals(customer.UserName)) && x.UserPassword.Equals(customer.UserPassword));
            if (existCustomer.ToList().Count == 0)
                throw new InvalidOperationException("User Does not Exist");
            return existCustomer.FirstOrDefault();
        }
    }
}
