using EMS.ModelBuilderRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EMS.Common.DataCalculation
{
    public static class EmsCalculation
    {
        public static (IDictionary<string,int> header,List<string> values) Calcuclate(string emsData)
        {

            Dictionary<string,int> data = new Dictionary<string, int>();
            var startAddress = Convert.ToInt32(emsData.Substring(0, 4), 16);
            var slaveIdHexa = Convert.ToInt32(emsData.Substring(4, 2), 16);
            var modeBusFc = Convert.ToInt32(emsData.Substring(6, 2), 16);
            var totalReg = Convert.ToInt32(emsData.Substring(8, 2), 16) / 2;
            data.Add("startAddress", startAddress);
            data.Add("slaveId", slaveIdHexa);
            data.Add("modeBusFc", modeBusFc);
            data.Add("totalReg", totalReg);
            var headerData = emsData.Substring(0, 10);
            var dataString = emsData.Replace(headerData, "");
            var valuesData=Split(dataString, 8).ToList();

            return (data,valuesData);
           
        }
        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
