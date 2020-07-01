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
            CreateMap<Customer, EMSCustomerViewModel>().ReverseMap();
            CreateMap<DeviceViewModel, DeviceModel>().ReverseMap();
            CreateMap<LoginViewModel, Customer>().ReverseMap();
            CreateMap<EmsMaster, EMSMasterViewModel>();
            //CreateMap<EmsMaster,EMSMasterViewModel>().ReverseMap();
        }
    }
}
