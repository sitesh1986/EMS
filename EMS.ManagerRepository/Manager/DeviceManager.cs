using EMS.Common;
using EMS.Common.Constants;
using EMS.DbModelRepository.Models;
using EMS.SqlRepository.DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.ManagerRepository.Manager
{
    public class DeviceManager
    {
        private IEmsRepository<DeviceModel> _emsRepository { get; set; }
        public DeviceManager(IEmsRepository<DeviceModel> emsRepository)
        {
            _emsRepository = emsRepository;
        }
        public async Task<DeviceModel> CreateDevice(DeviceModel deviceModel)
        {
            deviceModel.DeviceSerialNumber = DeviceHelper.GetDeviceSerialNo(deviceModel.DeviceSerialNumber);
            var existdevice =await GetDeviceBySerialNo(deviceModel.DeviceSerialNumber);
            if (existdevice != null)
                throw new ArgumentException("Serial No already exists");
            var device = await _emsRepository.Add(deviceModel);
            return device;
        }

        public async Task<DeviceModel> UpdateDevice(DeviceModel deviceModel)
        {
            var device = await _emsRepository.Update(deviceModel);
            return device;
        }
        public async Task<List<DeviceModel>> GetDevices()
        {
            var devices = await _emsRepository.GetAll();
            return devices.ToList();
        }
        public async Task<DeviceModel> GetDeviceBySerialNo(string serialNo)
        {
            var device = await _emsRepository.GetByCondition(x=>x.DeviceSerialNumber.Equals(serialNo));
            return device.FirstOrDefault();
        }

        public async Task<bool> DeleteDevice(string serialNo)
        {
            var device = await GetDeviceBySerialNo(serialNo);
             await _emsRepository.Remove(device);
            return true;
        }
    }
}
