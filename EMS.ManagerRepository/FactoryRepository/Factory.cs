using EMS.Common;
using EMS.ManagerRepository.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.ManagerRepository.FactoryRepository
{
   
    public class Factory
    {
        private EmsPM520LManager _emsPM520LManager { get; set; }
        public Factory(EmsPM520LManager emsPM520LManager)
        {
            _emsPM520LManager = emsPM520LManager;
        }
        public IpmFieldManager returnvalues = null;
        public IpmFieldManager GetIPMManager(string type)
        {
            returnvalues = _emsPM520LManager;
            return returnvalues;
        }
    }
}
