using EMS.ModelBuilderRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public interface IpmFieldManager
    {
        Task CreateData(Block keyValuePairs,List<string> values, EmsDataReplication emsData);
    }
}
