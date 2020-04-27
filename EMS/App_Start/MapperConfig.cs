using AutoMapper;
using EMS.Common.ViewModels;
using EMS.DbModelRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EMS.App_Start
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<EMSCustomerViewModel, Customer>().ReverseMap();
            CreateMap<DeviceViewModel, DeviceModel>().ReverseMap();
        }
    }
}
