using EMS.Common.Constants;

using EMS.DbModelRepository.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EMS.Common.DataCalculation
{
    public static class ReportCalculation
    {
        public static EmsMaster GetHistoricalDataCalculation(List<EmsMaster> emsMasters)
        {
            EmsMaster emsMaster = new EmsMaster();
            int i = 0;
            Dictionary<string, EnergyStartEndRecord> keyValuePairs = new Dictionary<string, EnergyStartEndRecord>();
            foreach (var data in emsMasters)
            {
                emsMaster.DeviceId = data.DeviceId;
                emsMaster.DateEms = data.DateEms;
                emsMaster.SlaveId = emsMaster.SlaveId;
                if (data.VLLAVG != 0)
                    ReportConstants._VLLAVG = ReportConstants._VLLAVG + 1;
                emsMaster.VLLAVG += data.VLLAVG;
                if (data.VRY != 0)
                    ReportConstants._VRY = ReportConstants._VRY + 1;
                emsMaster.VRY += data.VRY;
                if (data.VYB != 0)
                    ReportConstants._VYB = ReportConstants._VYB + 1;
                emsMaster.VYB += data.VYB;
                if (data.VBR != 0)
                    ReportConstants._VBR = ReportConstants._VBR + 1;
                emsMaster.VBR += data.VBR;
                if (data.VLNAVG != 0)
                    ReportConstants._VLNAVG = ReportConstants._VLNAVG + 1;
                emsMaster.VLNAVG += data.VLNAVG;
                if (data.VR != 0)
                    ReportConstants._VR = ReportConstants._VR + 1;
                emsMaster.VR += data.VR;
                if (data.VY != 0)
                    ReportConstants._VY = ReportConstants._VY + 1;
                emsMaster.VY += data.VY;
                if (data.VB != 0)
                    ReportConstants._VB = ReportConstants._VB + 1;
                emsMaster.VB += data.VB;
                if (data.IAVG != 0)
                    ReportConstants._IAVG = ReportConstants._IAVG + 1;
                emsMaster.IAVG += data.IAVG;
                if (data.IR != 0)
                    ReportConstants._IR = ReportConstants._IR + 1;
                emsMaster.IR += data.IR;
                if (data.IY != 0)
                    ReportConstants._IY = ReportConstants._IY + 1;
                emsMaster.IY += data.IY;
                if (data.VLLAVG != 0)
                    ReportConstants._VLLAVG = ReportConstants._VLLAVG + 1;
                emsMaster.IB += data.IB;
                if (data.HZ != 0)
                    ReportConstants._HZ = ReportConstants._HZ + 1;
                emsMaster.HZ += data.HZ;
                if (data.PFAVG != 0)
                    ReportConstants._PFAVG = ReportConstants._PFAVG + 1;
                emsMaster.PFAVG += data.PFAVG;
                if (data.PFR != 0)
                    ReportConstants._PFR = ReportConstants._PFR + 1;
                emsMaster.PFR += data.PFR;
                if (data.PFY != 0)
                    ReportConstants._PFY = ReportConstants._PFY + 1;
                emsMaster.PFY += data.PFY;
                if (data.PFB != 0)
                    ReportConstants._PFB = ReportConstants._PFB + 1;
                emsMaster.PFB += data.PFB;
                if (data.WattsTot != 0)
                    ReportConstants._WattsTot = ReportConstants._WattsTot + 1;
                emsMaster.WattsTot += data.WattsTot;
                if (data.WR != 0)
                    ReportConstants._WR = ReportConstants._WR + 1;
                emsMaster.WR += data.WR;
                if (data.WY != 0)
                    ReportConstants._WY = ReportConstants._WY + 1;
                emsMaster.WY += data.WY;
                if (data.WB != 0)
                    ReportConstants._WB = ReportConstants._WB + 1;
                emsMaster.WB += data.WB;
                if (data.VATOT != 0)
                    ReportConstants._VATOT = ReportConstants._VATOT + 1;
                emsMaster.VATOT += data.VATOT;
                if (data.VAR != 0)
                    ReportConstants._VAR = ReportConstants._VAR + 1;
                emsMaster.VAR += data.VAR;
                if (data.VAY != 0)
                    ReportConstants._VAY = ReportConstants._VAY + 1;
                emsMaster.VAY += data.VAY;
                if (data.VAB != 0)
                    ReportConstants._VAB = ReportConstants._VAB + 1;
                emsMaster.VAB += data.VAB;
                if (data.VARTOT != 0)
                    ReportConstants._VARTOT = ReportConstants._VARTOT + 1;
                emsMaster.VARTOT += data.VARTOT;
                if (data.VARR != 0)
                    ReportConstants._VARR = ReportConstants._VARR + 1;
                emsMaster.VARR += data.VARR;
                if (data.VARY != 0)
                    ReportConstants._VARY = ReportConstants._VARY + 1;
                emsMaster.VARY += data.VARY;
                if (data.VARB != 0)
                    ReportConstants._VARB = ReportConstants._VARB + 1;
                emsMaster.VARB += data.VARB;
                if (data.RPM != 0)
                    ReportConstants._RPM = ReportConstants._RPM + 1;
                emsMaster.RPM += data.RPM;
                if (data.UNBALANCEVOLTAGEVLL != 0)
                    ReportConstants._UNBALANCEVOLTAGEVLL = ReportConstants._UNBALANCEVOLTAGEVLL + 1;
                emsMaster.UNBALANCEVOLTAGEVLL += data.UNBALANCEVOLTAGEVLL;
                if (data.UNBALANCEVOLTAGEVLN != 0)
                    ReportConstants._UNBALANCEVOLTAGEVLN = ReportConstants._UNBALANCEVOLTAGEVLN + 1;
                emsMaster.UNBALANCEVOLTAGEVLN += data.UNBALANCEVOLTAGEVLN;
                if (data.UNBALANCECURRENTAMPS != 0)
                    ReportConstants._UNBALANCECURRENTAMPS = ReportConstants._UNBALANCECURRENTAMPS + 1;
                emsMaster.UNBALANCECURRENTAMPS += data.UNBALANCECURRENTAMPS;
                if (data.NEUTRALCURRENTLN != 0)
                    ReportConstants._NEUTRALCURRENTLN = ReportConstants._NEUTRALCURRENTLN + 1;
                emsMaster.NEUTRALCURRENTLN += data.NEUTRALCURRENTLN;
                if (data.MAXIMAMDEMAND != 0)
                    ReportConstants._MAXIMAMDEMAND = ReportConstants._MAXIMAMDEMAND + 1;
                emsMaster.MAXIMAMDEMAND += data.MAXIMAMDEMAND;
                if (data.RISINGDEMAND != 0)
                    ReportConstants._RISINGDEMAND = ReportConstants._RISINGDEMAND + 1;
                emsMaster.RISINGDEMAND += data.RISINGDEMAND;
                if (data.DEMAND1 != 0)
                    ReportConstants._DEMAND1 = ReportConstants._DEMAND1 + 1;
                emsMaster.DEMAND1 += data.DEMAND1;
                if (data.DEMAND2 != 0)
                    ReportConstants._DEMAND2 = ReportConstants._DEMAND2 + 1;
                emsMaster.DEMAND2 += data.DEMAND2;
                if (data.DEMAND3 != 0)
                    ReportConstants._DEMAND3 = ReportConstants._DEMAND3 + 1;
                emsMaster.DEMAND3 += data.DEMAND3;
                if (data.THDVOLTAGEVLL != 0)
                    ReportConstants._THDVOLTAGEVLL = ReportConstants._THDVOLTAGEVLL + 1;
                emsMaster.THDVOLTAGEVLL += data.THDVOLTAGEVLL;
                if (data.THDVOLTAGEVLN != 0)
                    ReportConstants._THDVOLTAGEVLN = ReportConstants._THDVOLTAGEVLN + 1;
                emsMaster.THDVOLTAGEVLN += data.THDVOLTAGEVLN;
                if (data.THDCURRENTA != 0)
                    ReportConstants._THDCURRENTA = ReportConstants._THDCURRENTA + 1;
                emsMaster.THDCURRENTA += data.THDCURRENTA;
                if (data.FIRSTSTHRVRY != 0)
                    ReportConstants._FIRSTSTHRVRY = ReportConstants._FIRSTSTHRVRY + 1;
                emsMaster.FIRSTSTHRVRY += data.FIRSTSTHRVRY;
                if (data.FIRSTSTHRVYB != 0)
                    ReportConstants._FIRSTSTHRVYB = ReportConstants._FIRSTSTHRVYB + 1;
                emsMaster.FIRSTSTHRVYB += data.FIRSTSTHRVYB;
                if (data.FIRSTSTHRVBR != 0)
                    ReportConstants._FIRSTSTHRVBR = ReportConstants._FIRSTSTHRVBR + 1;
                emsMaster.FIRSTSTHRVBR += data.FIRSTSTHRVBR;
                if (data.FIRSTSTHRIR != 0)
                    ReportConstants._FIRSTSTHRIR = ReportConstants._FIRSTSTHRIR + 1;
                emsMaster.FIRSTSTHRIR += data.FIRSTSTHRIR;
                if (data.FIRSTSTHRIY != 0)
                    ReportConstants._FIRSTSTHRIY = ReportConstants._FIRSTSTHRIY + 1;
                emsMaster.FIRSTSTHRIY += data.FIRSTSTHRIY;
                if (data.FIRSTSTHRIB != 0)
                    ReportConstants._FIRSTSTHRIB = ReportConstants._FIRSTSTHRIB + 1;
                emsMaster.FIRSTSTHRIB += data.FIRSTSTHRIB;
                if (data.SECONDHARVRY != 0)
                    ReportConstants._SECONDHARVRY = ReportConstants._SECONDHARVRY + 1;
                emsMaster.SECONDHARVRY += data.SECONDHARVRY;
                if (data.SECONDHARVYB != 0)
                    ReportConstants._SECONDHARVYB = ReportConstants._SECONDHARVYB + 1;
                emsMaster.SECONDHARVYB += data.SECONDHARVYB;
                if (data.SECONDHARVBR != 0)
                    ReportConstants._SECONDHARVBR = ReportConstants._SECONDHARVBR + 1;
                emsMaster.SECONDHARVBR += data.SECONDHARVBR;
                if (data.SECONDHARIR != 0)
                    ReportConstants._SECONDHARIR = ReportConstants._SECONDHARIR + 1;
                emsMaster.SECONDHARIR += data.SECONDHARIR;
                if (data.SECONDHARIY != 0)
                    ReportConstants._SECONDHARIY = ReportConstants._SECONDHARIY + 1;
                emsMaster.SECONDHARIY += data.SECONDHARIY;
                if (data.SECONDHARIB != 0)
                    ReportConstants._SECONDHARIB = ReportConstants._SECONDHARIB + 1;
                emsMaster.SECONDHARIB += data.SECONDHARIB;
                if (data.THIRDHARVRY != 0)
                    ReportConstants._THIRDHARVRY = ReportConstants._THIRDHARVRY + 1;
                emsMaster.THIRDHARVRY += data.THIRDHARVRY;
                if (data.THIRDHARVYB != 0)
                    ReportConstants._THIRDHARVYB = ReportConstants._THIRDHARVYB + 1;
                emsMaster.THIRDHARVYB += data.THIRDHARVYB;
                if (data.THIRDHARVBR != 0)
                    ReportConstants._THIRDHARVBR = ReportConstants._THIRDHARVBR + 1;
                emsMaster.THIRDHARVBR += data.THIRDHARVBR;
                if (data.THIRDHARIR != 0)
                    ReportConstants._THIRDHARIR = ReportConstants._THIRDHARIR + 1;
                emsMaster.THIRDHARIR += data.THIRDHARIR;
                if (data.THIRDHARIY != 0)
                    ReportConstants._THIRDHARIY = ReportConstants._THIRDHARIY + 1;
                emsMaster.THIRDHARIY += data.THIRDHARIY;
                if (data.THIRDHARIB != 0)
                    ReportConstants._THIRDHARIB = ReportConstants._THIRDHARIB + 1;
                emsMaster.THIRDHARIB += data.THIRDHARIB;
                if (data.FOURTHHARVRY != 0)
                    ReportConstants._FOURTHHARVRY = ReportConstants._FOURTHHARVRY + 1;
                emsMaster.FOURTHHARVRY += data.FOURTHHARVRY;
                if (data.FOURTHARVYB != 0)
                    ReportConstants._FOURTHARVYB = ReportConstants._FOURTHARVYB + 1;
                emsMaster.FOURTHARVYB += data.FOURTHARVYB;
                if (data.THIRDDHARVBR != 0)
                    ReportConstants._THIRDDHARVBR = ReportConstants._THIRDDHARVBR + 1;
                emsMaster.THIRDDHARVBR += data.THIRDDHARVBR;
                if (data.FOURTHHARIR != 0)
                    ReportConstants._FOURTHHARIR = ReportConstants._FOURTHHARIR + 1;
                emsMaster.FOURTHHARIR += data.FOURTHHARIR;
                if (data.FOURTHHARIY != 0)
                    ReportConstants._FOURTHHARIY = ReportConstants._FOURTHHARIY + 1;
                emsMaster.FOURTHHARIY += data.FOURTHHARIY;
                if (data.FOURTHHARIB != 0)
                    ReportConstants._FOURTHHARIB = ReportConstants._FOURTHHARIB + 1;
                emsMaster.FOURTHHARIB += data.FOURTHHARIB;
                if (data.FIFTHHARVRY != 0)
                    ReportConstants._FIFTHHARVRY = ReportConstants._FIFTHHARVRY + 1;
                emsMaster.FIFTHHARVRY += data.FIFTHHARVRY;
                if (data.FIFTHHARVYB != 0)
                    ReportConstants._FIFTHHARVYB = ReportConstants._FIFTHHARVYB + 1;
                emsMaster.FIFTHHARVYB += data.FIFTHHARVYB;
                if (data.FIFTHHARVBR != 0)
                    ReportConstants._FIFTHHARVBR = ReportConstants._FIFTHHARVBR + 1;
                emsMaster.FIFTHHARVBR += data.FIFTHHARVBR;
                if (data.FIFTHHARIR != 0)
                    ReportConstants._FIFTHHARIR = ReportConstants._FIFTHHARIR + 1;
                emsMaster.FIFTHHARIR += data.FIFTHHARIR;
                if (data.FIFTHHARIY != 0)
                    ReportConstants._FIFTHHARIY = ReportConstants._FIFTHHARIY + 1;
                emsMaster.FIFTHHARIY += data.FIFTHHARIY;
                if (data.FIFTHHARIB != 0)
                    ReportConstants._FIFTHHARIB = ReportConstants._FIFTHHARIB + 1;
                emsMaster.FIFTHHARIB += data.FIFTHHARIB;
                if (data.SIXTHHARVRY != 0)
                    ReportConstants._SIXTHHARVRY = ReportConstants._SIXTHHARVRY + 1;
                emsMaster.SIXTHHARVRY += data.SIXTHHARVRY;
                if (data.SIXTHHARVYB != 0)
                    ReportConstants._SIXTHHARVYB = ReportConstants._SIXTHHARVYB + 1;
                emsMaster.SIXTHHARVYB += data.SIXTHHARVYB;
                if (data.SIXTHHARVBR != 0)
                    ReportConstants._SIXTHHARVBR = ReportConstants._SIXTHHARVBR + 1;
                emsMaster.SIXTHHARVBR += data.SIXTHHARVBR;
                if (data.SIXTHHARIR != 0)
                    ReportConstants._SIXTHHARIR = ReportConstants._SIXTHHARIR + 1;
                emsMaster.SIXTHHARIR += data.SIXTHHARIR;
                if (data.SIXTHHARIY != 0)
                    ReportConstants._SIXTHHARIY = ReportConstants._SIXTHHARIY + 1;
                emsMaster.SIXTHHARIY += data.SIXTHHARIY;
                if (data.SIXTHHARIB != 0)
                    ReportConstants._SIXTHHARIB = ReportConstants._SIXTHHARIB + 1;
                emsMaster.SIXTHHARIB += data.SIXTHHARIB;
                if (data.SEVENTHHARVRY != 0)
                    ReportConstants._SEVENTHHARVRY = ReportConstants._SEVENTHHARVRY + 1;
                emsMaster.SEVENTHHARVRY += data.SEVENTHHARVRY;
                if (data.SEVENTHHARVYB != 0)
                    ReportConstants._SEVENTHHARVYB = ReportConstants._SEVENTHHARVYB + 1;
                emsMaster.SEVENTHHARVYB += data.SEVENTHHARVYB;
                if (data.SEVENTHHARVBR != 0)
                    ReportConstants._SEVENTHHARVBR = ReportConstants._SEVENTHHARVBR + 1;
                emsMaster.SEVENTHHARVBR += data.SEVENTHHARVBR;
                if (data.SEVENTHHARIR != 0)
                    ReportConstants._SEVENTHHARIR = ReportConstants._SEVENTHHARIR + 1;
                emsMaster.SEVENTHHARIR += data.SEVENTHHARIR;
                if (data.SEVENTHHARIY != 0)
                    ReportConstants._SEVENTHHARIY = ReportConstants._SEVENTHHARIY + 1;
                emsMaster.SEVENTHHARIY += data.SEVENTHHARIY;
                if (data.SEVENTHHARIB != 0)
                    ReportConstants._SEVENTHHARIB = ReportConstants._SEVENTHHARIB + 1;
                emsMaster.SEVENTHHARIB += data.SEVENTHHARIB;
                if (data.EIGHTHARVRY != 0)
                    ReportConstants._EIGHTHARVRY = ReportConstants._EIGHTHARVRY + 1;
                emsMaster.EIGHTHARVRY += data.EIGHTHARVRY;
                if (data.EIGHTHARVYB != 0)
                    ReportConstants._EIGHTHARVYB = ReportConstants._EIGHTHARVYB + 1;
                emsMaster.EIGHTHARVYB += data.EIGHTHARVYB;
                if (data.EIGHTHARVBR != 0)
                    ReportConstants._EIGHTHARVBR = ReportConstants._EIGHTHARVBR + 1;
                emsMaster.EIGHTHARVBR += data.EIGHTHARVBR;
                if (data.EIGHTHARIR != 0)
                    ReportConstants._EIGHTHARIR = ReportConstants._EIGHTHARIR + 1;
                emsMaster.EIGHTHARIR += data.EIGHTHARIR;
                if (data.EIGHTHARIY != 0)
                    ReportConstants._EIGHTHARIY = ReportConstants._EIGHTHARIY + 1;
                emsMaster.EIGHTHARIY += data.EIGHTHARIY;
                if (data.EIGHTHARIB != 0)
                    ReportConstants._EIGHTHARIB = ReportConstants._EIGHTHARIB + 1;
                emsMaster.EIGHTHARIB += data.EIGHTHARIB;
                if (data.NINTHHARVRY != 0)
                    ReportConstants._NINTHHARVRY = ReportConstants._NINTHHARVRY + 1;
                emsMaster.NINTHHARVRY += data.NINTHHARVRY;
                if (data.NINTHHARVYB != 0)
                    ReportConstants._NINTHHARVYB = ReportConstants._NINTHHARVYB + 1;
                emsMaster.NINTHHARVYB += data.NINTHHARVYB;
                if (data.NINTHHARVBR != 0)
                    ReportConstants._NINTHHARVBR = ReportConstants._NINTHHARVBR + 1;
                emsMaster.NINTHHARVBR += data.NINTHHARVBR;
                if (data.NINTHHARIR != 0)
                    ReportConstants._NINTHHARIR = ReportConstants._NINTHHARIR + 1;
                emsMaster.NINTHHARIR += data.NINTHHARIR;
                if (data.NINTHHARIY != 0)
                    ReportConstants._NINTHHARIY = ReportConstants._NINTHHARIY + 1;
                emsMaster.NINTHHARIY += data.NINTHHARIY;
                if (data.NINTHHARIB != 0)
                    ReportConstants._NINTHHARIB = ReportConstants._NINTHHARIB + 1;
                emsMaster.NINTHHARIB += data.NINTHHARIB;
                if (data.TENTHHARVRY != 0)
                    ReportConstants._TENTHHARVRY = ReportConstants._TENTHHARVRY + 1;
                emsMaster.TENTHHARVRY += data.TENTHHARVRY;
                if (data.TENTHHARVYB != 0)
                    ReportConstants._TENTHHARVYB = ReportConstants._TENTHHARVYB + 1;
                emsMaster.TENTHHARVYB += data.TENTHHARVYB;
                if (data.TENTHHARVBR != 0)
                    ReportConstants._TENTHHARVBR = ReportConstants._TENTHHARVBR + 1;
                emsMaster.TENTHHARVBR += data.TENTHHARVBR;
                if (data.TENTHHARIR != 0)
                    ReportConstants._TENTHHARIR = ReportConstants._TENTHHARIR + 1;
                emsMaster.TENTHHARIR += data.TENTHHARIR;
                if (data.TENTHHARIY != 0)
                    ReportConstants._TENTHHARIY = ReportConstants._TENTHHARIY + 1;
                emsMaster.TENTHHARIY += data.TENTHHARIY;
                if (data.TENTHHARIB != 0)
                    ReportConstants._TENTHHARIB = ReportConstants._TENTHHARIB + 1;
                emsMaster.TENTHHARIB += data.TENTHHARIB;
                if (data.ELEVENTHHARVRY != 0)
                    ReportConstants._ELEVENTHHARVRY = ReportConstants._ELEVENTHHARVRY + 1;
                emsMaster.ELEVENTHHARVRY += data.ELEVENTHHARVRY;
                if (data.ELEVENTHHARVYB != 0)
                    ReportConstants._ELEVENTHHARVYB = ReportConstants._ELEVENTHHARVYB + 1;
                emsMaster.ELEVENTHHARVYB += data.ELEVENTHHARVYB;
                if (data.ELEVENTHHARVBR != 0)
                    ReportConstants._ELEVENTHHARVBR = ReportConstants._ELEVENTHHARVBR + 1;
                emsMaster.ELEVENTHHARVBR += data.ELEVENTHHARVBR;
                if (data.ELEVENTHHARIR != 0)
                    ReportConstants._ELEVENTHHARIR = ReportConstants._ELEVENTHHARIR + 1;
                emsMaster.ELEVENTHHARIR += data.ELEVENTHHARIR;
                if (data.ELEVENTHHARIY != 0)
                    ReportConstants._ELEVENTHHARIY = ReportConstants._ELEVENTHHARIY + 1;
                emsMaster.ELEVENTHHARIY += data.ELEVENTHHARIY;
                if (data.ELEVENTHHARIB != 0)
                    ReportConstants._ELEVENTHHARIB = ReportConstants._ELEVENTHHARIB + 1;
                emsMaster.ELEVENTHHARIB += data.ELEVENTHHARIB;
                if (data.TWELVEHARVRY != 0)
                    ReportConstants._TWELVEHARVRY = ReportConstants._TWELVEHARVRY + 1;
                emsMaster.TWELVEHARVRY += data.TWELVEHARVRY;
                if (data.TWELVEHARVYB != 0)
                    ReportConstants._TWELVEHARVYB = ReportConstants._TWELVEHARVYB + 1;
                emsMaster.TWELVEHARVYB += data.TWELVEHARVYB;
                if (data.TWELVEHARVBR != 0)
                    ReportConstants._TWELVEHARVBR = ReportConstants._TWELVEHARVBR + 1;
                emsMaster.TWELVEHARVBR += data.TWELVEHARVBR;
                if (data.TWELVEHARIR != 0)
                    ReportConstants._TWELVEHARIR = ReportConstants._TWELVEHARIR + 1;
                emsMaster.TWELVEHARIR += data.TWELVEHARIR;
                if (data.TWELVEHARIY != 0)
                    ReportConstants._TWELVEHARIY = ReportConstants._TWELVEHARIY + 1;
                emsMaster.TWELVEHARIY += data.TWELVEHARIY;
                if (data.TWELVEHARIB != 0)
                    ReportConstants._TWELVEHARIB = ReportConstants._TWELVEHARIB + 1;
                emsMaster.TWELVEHARIB += data.TWELVEHARIB;
                if (data.THIRTEENHARVRY != 0)
                    ReportConstants._THIRTEENHARVRY = ReportConstants._THIRTEENHARVRY + 1;
                emsMaster.THIRTEENHARVRY += data.THIRTEENHARVRY;
                if (data.THIRTEENHARVYB != 0)
                    ReportConstants._THIRTEENHARVYB = ReportConstants._THIRTEENHARVYB + 1;
                emsMaster.THIRTEENHARVYB += data.THIRTEENHARVYB;
                if (data.THIRTEENHARVBR != 0)
                    ReportConstants._THIRTEENHARVBR = ReportConstants._THIRTEENHARVBR + 1;
                emsMaster.THIRTEENHARVBR += data.THIRTEENHARVBR;
                if (data.THIRTEENHARIR != 0)
                    ReportConstants._THIRTEENHARIR = ReportConstants._THIRTEENHARIR + 1;
                emsMaster.THIRTEENHARIR += data.THIRTEENHARIR;
                if (data.THIRTEENHARIY != 0)
                    ReportConstants._THIRTEENHARIY = ReportConstants._THIRTEENHARIY + 1;
                emsMaster.THIRTEENHARIY += data.THIRTEENHARIY;
                if (data.THIRTEENHARIB != 0)
                    ReportConstants._THIRTEENHARIB = ReportConstants._THIRTEENHARIB + 1;
                emsMaster.THIRTEENHARIB += data.THIRTEENHARIB;
                if (data.FOURTEENHARVRY != 0)
                    ReportConstants._FOURTEENHARVRY = ReportConstants._FOURTEENHARVRY + 1;
                emsMaster.FOURTEENHARVRY += data.FOURTEENHARVRY;
                if (data.FOURTEENHARVYB != 0)
                    ReportConstants._FOURTEENHARVYB = ReportConstants._FOURTEENHARVYB + 1;
                emsMaster.FOURTEENHARVYB += data.FOURTEENHARVYB;
                if (data.FOURTEENHARVBR != 0)
                    ReportConstants._FOURTEENHARVBR = ReportConstants._FOURTEENHARVBR + 1;
                emsMaster.FOURTEENHARVBR += data.FOURTEENHARVBR;
                if (data.FOURTEENHARIR != 0)
                    ReportConstants._FOURTEENHARIR = ReportConstants._FOURTEENHARIR + 1;
                emsMaster.FOURTEENHARIR += data.FOURTEENHARIR;
                if (data.FOURTEENHARIY != 0)
                    ReportConstants._FOURTEENHARIY = ReportConstants._FOURTEENHARIY + 1;
                emsMaster.FOURTEENHARIY += data.FOURTEENHARIY;
                if (data.FOURTEENHARIB != 0)
                    ReportConstants._FOURTEENHARIB = ReportConstants._FOURTEENHARIB + 1;
                emsMaster.FOURTEENHARIB += data.FOURTEENHARIB;
                if (data.FIFTHEENHARVRY != 0)
                    ReportConstants._FIFTHEENHARVRY = ReportConstants._FIFTHEENHARVRY + 1;
                emsMaster.FIFTHEENHARVRY += data.FIFTHEENHARVRY;
                if (data.FIFTHEENHARVYB != 0)
                    ReportConstants._FIFTHEENHARVYB = ReportConstants._FIFTHEENHARVYB + 1;
                emsMaster.FIFTHEENHARVYB += data.FIFTHEENHARVYB;
                if (data.FIFTHEENHARVBR != 0)
                    ReportConstants._FIFTHEENHARVBR = ReportConstants._FIFTHEENHARVBR + 1;
                emsMaster.FIFTHEENHARVBR += data.FIFTHEENHARVBR;
                if (data.FIFTHEENHARIR != 0)
                    ReportConstants._FIFTHEENHARIR = ReportConstants._FIFTHEENHARIR + 1;
                emsMaster.FIFTHEENHARIR += data.FIFTHEENHARIR;
                if (data.FIFTHEENHARIY != 0)
                    ReportConstants._FIFTHEENHARIY = ReportConstants._FIFTHEENHARIY + 1;
                emsMaster.FIFTHEENHARIY += data.FIFTHEENHARIY;
                if (data.FIFTHEENHARIB != 0)
                    ReportConstants._FIFTHEENHARIB = ReportConstants._FIFTHEENHARIB + 1;
                emsMaster.FIFTHEENHARIB += data.FIFTHEENHARIB;
                if (data.SIXTHEENHARVRY != 0)
                    ReportConstants._SIXTHEENHARVRY = ReportConstants._SIXTHEENHARVRY + 1;
                emsMaster.SIXTHEENHARVRY += data.SIXTHEENHARVRY;
                if (data.SIXTHEENHARVYB != 0)
                    ReportConstants._SIXTHEENHARVYB = ReportConstants._SIXTHEENHARVYB + 1;
                emsMaster.SIXTHEENHARVYB += data.SIXTHEENHARVYB;
                if (data.SIXTHEENHARVBR != 0)
                    ReportConstants._SIXTHEENHARVBR = ReportConstants._SIXTHEENHARVBR + 1;
                emsMaster.SIXTHEENHARVBR += data.SIXTHEENHARVBR;
                if (data.SIXTHEENHARIR != 0)
                    ReportConstants._SIXTHEENHARIR = ReportConstants._SIXTHEENHARIR + 1;
                emsMaster.SIXTHEENHARIR += data.SIXTHEENHARIR;
                if (data.SIXTHEENHARIY != 0)
                    ReportConstants._SIXTHEENHARIY = ReportConstants._SIXTHEENHARIY + 1;
                emsMaster.SIXTHEENHARIY += data.SIXTHEENHARIY;
                if (data.SIXTHEENHARIB != 0)
                    ReportConstants._SIXTHEENHARIB = ReportConstants._SIXTHEENHARIB + 1;
                emsMaster.SIXTHEENHARIB += data.SIXTHEENHARIB;
                if (data.SEVENTHEENHARVRY != 0)
                    ReportConstants._SEVENTHEENHARVRY = ReportConstants._SEVENTHEENHARVRY + 1;
                emsMaster.SEVENTHEENHARVRY += data.SEVENTHEENHARVRY;
                if (data.SEVENTHEENHARVYB != 0)
                    ReportConstants._SEVENTHEENHARVYB = ReportConstants._SEVENTHEENHARVYB + 1;
                emsMaster.SEVENTHEENHARVYB += data.SEVENTHEENHARVYB;
                if (data.SEVENTHEENHARVBR != 0)
                    ReportConstants._SEVENTHEENHARVBR = ReportConstants._SEVENTHEENHARVBR + 1;
                emsMaster.SEVENTHEENHARVBR += data.SEVENTHEENHARVBR;
                if (data.SEVENTHEENHARIR != 0)
                    ReportConstants._SEVENTHEENHARIR = ReportConstants._SEVENTHEENHARIR + 1;
                emsMaster.SEVENTHEENHARIR += data.SEVENTHEENHARIR;
                if (data.SEVENTHEENHARIY != 0)
                    ReportConstants._SEVENTHEENHARIY = ReportConstants._SEVENTHEENHARIY + 1;
                emsMaster.SEVENTHEENHARIY += data.SEVENTHEENHARIY;
                if (data.SEVENTHEENHARIB != 0)
                    ReportConstants._SEVENTHEENHARIB = ReportConstants._SEVENTHEENHARIB + 1;
                emsMaster.SEVENTHEENHARIB += data.SEVENTHEENHARIB;
                if (data.EIGHTHEENHARVRY != 0)
                    ReportConstants._EIGHTHEENHARVRY = ReportConstants._EIGHTHEENHARVRY + 1;
                emsMaster.EIGHTHEENHARVRY += data.EIGHTHEENHARVRY;
                if (data.EIGHTHEENHARVYB != 0)
                    ReportConstants._EIGHTHEENHARVYB = ReportConstants._EIGHTHEENHARVYB + 1;
                emsMaster.EIGHTHEENHARVYB += data.EIGHTHEENHARVYB;
                if (data.EIGHTHEENHARVBR != 0)
                    ReportConstants._EIGHTHEENHARVBR = ReportConstants._EIGHTHEENHARVBR + 1;
                emsMaster.EIGHTHEENHARVBR += data.EIGHTHEENHARVBR;
                if (data.EIGHTHEENHARIR != 0)
                    ReportConstants._EIGHTHEENHARIR = ReportConstants._EIGHTHEENHARIR + 1;
                emsMaster.EIGHTHEENHARIR += data.EIGHTHEENHARIR;
                if (data.EIGHTHEENHARIY != 0)
                    ReportConstants._EIGHTHEENHARIY = ReportConstants._EIGHTHEENHARIY + 1;
                emsMaster.EIGHTHEENHARIY += data.EIGHTHEENHARIY;
                if (data.EIGHTEENHARIB != 0)
                    ReportConstants._EIGHTEENHARIB = ReportConstants._EIGHTEENHARIB + 1;
                emsMaster.EIGHTEENHARIB += data.EIGHTEENHARIB;
                if (data.NINTHEENHARVRY != 0)
                    ReportConstants._NINTHEENHARVRY = ReportConstants._NINTHEENHARVRY + 1;
                emsMaster.NINTHEENHARVRY += data.NINTHEENHARVRY;
                if (data.NINTHEENHARVYB != 0)
                    ReportConstants._NINTHEENHARVYB = ReportConstants._NINTHEENHARVYB + 1;
                emsMaster.NINTHEENHARVYB += data.NINTHEENHARVYB;
                if (data.NINTHEENHARVBR != 0)
                    ReportConstants._NINTHEENHARVBR = ReportConstants._NINTHEENHARVBR + 1;
                emsMaster.NINTHEENHARVBR += data.NINTHEENHARVBR;
                if (data.NINTHEENHARIR != 0)
                    ReportConstants._NINTHEENHARIR = ReportConstants._NINTHEENHARIR + 1;
                emsMaster.NINTHEENHARIR += data.NINTHEENHARIR;
                if (data.NINTHEENHARIY != 0)
                    ReportConstants._NINTHEENHARIY = ReportConstants._NINTHEENHARIY + 1;
                emsMaster.NINTHEENHARIY += data.NINTHEENHARIY;
                if (data.NINTHEENHARIB != 0)
                    ReportConstants._NINTHEENHARIB = ReportConstants._NINTHEENHARIB + 1;
                emsMaster.NINTHEENHARIB += data.NINTHEENHARIB;
                if (data.TWENTYHARVRY != 0)
                    ReportConstants._TWENTYHARVRY = ReportConstants._TWENTYHARVRY + 1;
                emsMaster.TWENTYHARVRY += data.TWENTYHARVRY;
                if (data.TWENTYHARVYB != 0)
                    ReportConstants._TWENTYHARVYB = ReportConstants._TWENTYHARVYB + 1;
                emsMaster.TWENTYHARVYB += data.TWENTYHARVYB;
                if (data.TWENTYHARVBR != 0)
                    ReportConstants._TWENTYHARVBR = ReportConstants._TWENTYHARVBR + 1;
                emsMaster.TWENTYHARVBR += data.TWENTYHARVBR;
                if (data.TWENTYHARIR != 0)
                    ReportConstants._TWENTYHARIR = ReportConstants._TWENTYHARIR + 1;
                emsMaster.TWENTYHARIR += data.TWENTYHARIR;
                if (data.TWENTYHARIY != 0)
                    ReportConstants._TWENTYHARIY = ReportConstants._TWENTYHARIY + 1;
                emsMaster.TWENTYHARIY += data.TWENTYHARIY;
                if (data.TWENTYHARIB != 0)
                    ReportConstants._TWENTYHARIB = ReportConstants._TWENTYHARIB + 1;
                emsMaster.TWENTYHARIB += data.TWENTYHARIB;
                if (data.TWENTY1HARVRY != 0)
                    ReportConstants._TWENTY1HARVRY = ReportConstants._TWENTY1HARVRY + 1;
                emsMaster.TWENTY1HARVRY += data.TWENTY1HARVRY;
                if (data.TWENTY1HARVYB != 0)
                    ReportConstants._TWENTY1HARVYB = ReportConstants._TWENTY1HARVYB + 1;
                emsMaster.TWENTY1HARVYB += data.TWENTY1HARVYB;
                if (data.TWENTY1HARVBR != 0)
                    ReportConstants._TWENTY1HARVBR = ReportConstants._TWENTY1HARVBR + 1;
                emsMaster.TWENTY1HARVBR += data.TWENTY1HARVBR;
                if (data.TWENTY1HARIR != 0)
                    ReportConstants._TWENTY1HARIR = ReportConstants._TWENTY1HARIR + 1;
                emsMaster.TWENTY1HARIR += data.TWENTY1HARIR;
                if (data.TWENTY1HARIY != 0)
                    ReportConstants._TWENTY1HARIY = ReportConstants._TWENTY1HARIY + 1;
                emsMaster.TWENTY1HARIY += data.TWENTY1HARIY;
                if (data.TWENTY1HARIB != 0)
                    ReportConstants._TWENTY1HARIB = ReportConstants._TWENTY1HARIB + 1;
                emsMaster.TWENTY1HARIB += data.TWENTY1HARIB;
                if (data.TWENTY2HARVRY != 0)
                    ReportConstants._TWENTY2HARVRY = ReportConstants._TWENTY2HARVRY + 1;
                emsMaster.TWENTY2HARVRY += data.TWENTY2HARVRY;
                if (data.TWENTY2HARVYB != 0)
                    ReportConstants._TWENTY2HARVYB = ReportConstants._TWENTY2HARVYB + 1;
                emsMaster.TWENTY2HARVYB += data.TWENTY2HARVYB;
                if (data.TWENTY2HARVBR != 0)
                    ReportConstants._TWENTY2HARVBR = ReportConstants._TWENTY2HARVBR + 1;
                emsMaster.TWENTY2HARVBR += data.TWENTY2HARVBR;
                if (data.TWENTY2HARIR != 0)
                    ReportConstants._TWENTY2HARIR = ReportConstants._TWENTY2HARIR + 1;
                emsMaster.TWENTY2HARIR += data.TWENTY2HARIR;
                if (data.TWENTY2HARIY != 0)
                    ReportConstants._TWENTY2HARIY = ReportConstants._TWENTY2HARIY + 1;
                emsMaster.TWENTY2HARIY += data.TWENTY2HARIY;
                if (data.TWENTY2HARIB != 0)
                    ReportConstants._TWENTY2HARIB = ReportConstants._TWENTY2HARIB + 1;
                emsMaster.TWENTY2HARIB += data.TWENTY2HARIB;
                if (data.TWENTY3HARVRY != 0)
                    ReportConstants._TWENTY3HARVRY = ReportConstants._TWENTY3HARVRY + 1;
                emsMaster.TWENTY3HARVRY += data.TWENTY3HARVRY;
                if (data.TWENTY3HARVYB != 0)
                    ReportConstants._TWENTY3HARVYB = ReportConstants._TWENTY3HARVYB + 1;
                emsMaster.TWENTY3HARVYB += data.TWENTY3HARVYB;
                if (data.TWENTY3HARVBR != 0)
                    ReportConstants._TWENTY3HARVBR = ReportConstants._TWENTY3HARVBR + 1;
                emsMaster.TWENTY3HARVBR += data.TWENTY3HARVBR;
                if (data.TWENTY3HARIR != 0)
                    ReportConstants._TWENTY3HARIR = ReportConstants._TWENTY3HARIR + 1;
                emsMaster.TWENTY3HARIR += data.TWENTY3HARIR;
                if (data.TWENTY3HARIY != 0)
                    ReportConstants._TWENTY3HARIY = ReportConstants._TWENTY3HARIY + 1;
                emsMaster.TWENTY3HARIY += data.TWENTY3HARIY;
                if (data.TWENTY3HARIB != 0)
                    ReportConstants._TWENTY3HARIB = ReportConstants._TWENTY3HARIB + 1;
                emsMaster.TWENTY3HARIB += data.TWENTY3HARIB;
                if (data.TWENTY4HARVRY != 0)
                    ReportConstants._TWENTY4HARVRY = ReportConstants._TWENTY4HARVRY + 1;
                emsMaster.TWENTY4HARVRY += data.TWENTY4HARVRY;
                if (data.TWENTY4HARVYB != 0)
                    ReportConstants._TWENTY4HARVYB = ReportConstants._TWENTY4HARVYB + 1;
                emsMaster.TWENTY4HARVYB += data.TWENTY4HARVYB;
                if (data.TWENTY4HARVBR != 0)
                    ReportConstants._TWENTY4HARVBR = ReportConstants._TWENTY4HARVBR + 1;
                emsMaster.TWENTY4HARVBR += data.TWENTY4HARVBR;
                if (data.TWENTY4HARIR != 0)
                    ReportConstants._TWENTY4HARIR = ReportConstants._TWENTY4HARIR + 1;
                emsMaster.TWENTY4HARIR += data.TWENTY4HARIR;
                if (data.TWENTY4HARIY != 0)
                    ReportConstants._TWENTY4HARIY = ReportConstants._TWENTY4HARIY + 1;
                emsMaster.TWENTY4HARIY += data.TWENTY4HARIY;
                if (data.TWENTY4HARIB != 0)
                    ReportConstants._TWENTY4HARIB = ReportConstants._TWENTY4HARIB + 1;
                emsMaster.TWENTY4HARIB += data.TWENTY4HARIB;
                if (data.TWENTY5HARVRY != 0)
                    ReportConstants._TWENTY5HARVRY = ReportConstants._TWENTY5HARVRY + 1;
                emsMaster.TWENTY5HARVRY += data.TWENTY5HARVRY;
                if (data.TWENTY5HARVYB != 0)
                    ReportConstants._TWENTY5HARVYB = ReportConstants._TWENTY5HARVYB + 1;
                emsMaster.TWENTY5HARVYB += data.TWENTY5HARVYB;
                if (data.TWENTY5HARVBR != 0)
                    ReportConstants._TWENTY5HARVBR = ReportConstants._TWENTY5HARVBR + 1;
                emsMaster.TWENTY5HARVBR += data.TWENTY5HARVBR;
                if (data.TWENTY5HARIR != 0)
                    ReportConstants._TWENTY5HARIR = ReportConstants._TWENTY5HARIR + 1;
                emsMaster.TWENTY5HARIR += data.TWENTY5HARIR;
                if (data.TWENTY5HARIY != 0)
                    ReportConstants._TWENTY5HARIY = ReportConstants._TWENTY5HARIY + 1;
                emsMaster.TWENTY5HARIY += data.TWENTY5HARIY;
                if (data.TWENTY5HARIB != 0)
                    ReportConstants._TWENTY5HARIB = ReportConstants._TWENTY5HARIB + 1;
                emsMaster.TWENTY5HARIB += data.TWENTY5HARIB;
                if (data.TWENTY6HARVRY != 0)
                    ReportConstants._TWENTY6HARVRY = ReportConstants._TWENTY6HARVRY + 1;
                emsMaster.TWENTY6HARVRY += data.TWENTY6HARVRY;
                if (data.TWENTY6HARVYB != 0)
                    ReportConstants._TWENTY6HARVYB = ReportConstants._TWENTY6HARVYB + 1;
                emsMaster.TWENTY6HARVYB += data.TWENTY6HARVYB;
                if (data.TWENTY6HARVBR != 0)
                    ReportConstants._TWENTY6HARVBR = ReportConstants._TWENTY6HARVBR + 1;
                emsMaster.TWENTY6HARVBR += data.TWENTY6HARVBR;
                if (data.TWENTY6HARIR != 0)
                    ReportConstants._TWENTY6HARIR = ReportConstants._TWENTY6HARIR + 1;
                emsMaster.TWENTY6HARIR += data.TWENTY6HARIR;
                if (data.TWENTY6HARIY != 0)
                    ReportConstants._TWENTY6HARIY = ReportConstants._TWENTY6HARIY + 1;
                emsMaster.TWENTY6HARIY += data.TWENTY6HARIY;
                if (data.TWENTY6HARIB != 0)
                    ReportConstants._TWENTY6HARIB = ReportConstants._TWENTY6HARIB + 1;
                emsMaster.TWENTY6HARIB += data.TWENTY6HARIB;
                if (data.TWENTY7HARVRY != 0)
                    ReportConstants._TWENTY7HARVRY = ReportConstants._TWENTY7HARVRY + 1;
                emsMaster.TWENTY7HARVRY += data.TWENTY7HARVRY;
                if (data.TWENTY7HARVYB != 0)
                    ReportConstants._TWENTY7HARVYB = ReportConstants._TWENTY7HARVYB + 1;
                emsMaster.TWENTY7HARVYB += data.TWENTY7HARVYB;
                if (data.TWENTY7HARVBR != 0)
                    ReportConstants._TWENTY7HARVBR = ReportConstants._TWENTY7HARVBR + 1;
                emsMaster.TWENTY7HARVBR += data.TWENTY7HARVBR;
                if (data.TWENTY7HARIR != 0)
                    ReportConstants._TWENTY7HARIR = ReportConstants._TWENTY7HARIR + 1;
                emsMaster.TWENTY7HARIR += data.TWENTY7HARIR;
                if (data.TWENTY7HARIY != 0)
                    ReportConstants._TWENTY7HARIY = ReportConstants._TWENTY7HARIY + 1;
                emsMaster.TWENTY7HARIY += data.TWENTY7HARIY;
                if (data.TWENTY7HARIB != 0)
                    ReportConstants._TWENTY7HARIB = ReportConstants._TWENTY7HARIB + 1;
                emsMaster.TWENTY7HARIB += data.TWENTY7HARIB;
                if (data.TWENTY8HARVRY != 0)
                    ReportConstants._TWENTY8HARVRY = ReportConstants._TWENTY8HARVRY + 1;
                emsMaster.TWENTY8HARVRY += data.TWENTY8HARVRY;
                if (data.TWENTY8HARVYB != 0)
                    ReportConstants._TWENTY8HARVYB = ReportConstants._TWENTY8HARVYB + 1;
                emsMaster.TWENTY8HARVYB += data.TWENTY8HARVYB;
                if (data.TWENTY8HARVBR != 0)
                    ReportConstants._TWENTY8HARVBR = ReportConstants._TWENTY8HARVBR + 1;
                emsMaster.TWENTY8HARVBR += data.TWENTY8HARVBR;
                if (data.TWENTY8HARIR != 0)
                    ReportConstants._TWENTY8HARIR = ReportConstants._TWENTY8HARIR + 1;
                emsMaster.TWENTY8HARIR += data.TWENTY8HARIR;
                if (data.TWENTY8HARIY != 0)
                    ReportConstants._TWENTY8HARIY = ReportConstants._TWENTY8HARIY + 1;
                emsMaster.TWENTY8HARIY += data.TWENTY8HARIY;
                if (data.TWENTY8HARIB != 0)
                    ReportConstants._TWENTY8HARIB = ReportConstants._TWENTY8HARIB + 1;
                emsMaster.TWENTY8HARIB += data.TWENTY8HARIB;
                if (data.TWENTY9HARVRY != 0)
                    ReportConstants._TWENTY9HARVRY = ReportConstants._TWENTY9HARVRY + 1;
                emsMaster.TWENTY9HARVRY += data.TWENTY9HARVRY;
                if (data.TWENTY9HARVYB != 0)
                    ReportConstants._TWENTY9HARVYB = ReportConstants._TWENTY9HARVYB + 1;
                emsMaster.TWENTY9HARVYB += data.TWENTY9HARVYB;
                if (data.TWENTY9HARVBR != 0)
                    ReportConstants._TWENTY9HARVBR = ReportConstants._TWENTY9HARVBR + 1;
                emsMaster.TWENTY9HARVBR += data.TWENTY9HARVBR;
                if (data.TWENTY9HARIR != 0)
                    ReportConstants._TWENTY9HARIR = ReportConstants._TWENTY9HARIR + 1;
                emsMaster.TWENTY9HARIR += data.TWENTY9HARIR;
                if (data.TWENTY9HARIY != 0)
                    ReportConstants._TWENTY9HARIY = ReportConstants._TWENTY9HARIY + 1;
                emsMaster.TWENTY9HARIY += data.TWENTY9HARIY;
                if (data.TWENTY9HARIB != 0)
                    ReportConstants._TWENTY9HARIB = ReportConstants._TWENTY9HARIB + 1;
                emsMaster.TWENTY9HARIB += data.TWENTY9HARIB;
                if (data.THIRTYHARVRY != 0)
                    ReportConstants._THIRTYHARVRY = ReportConstants._THIRTYHARVRY + 1;
                emsMaster.THIRTYHARVRY += data.THIRTYHARVRY;
                if (data.THIRTYHARVYB != 0)
                    ReportConstants._THIRTYHARVYB = ReportConstants._THIRTYHARVYB + 1;
                emsMaster.THIRTYHARVYB += data.THIRTYHARVYB;
                if (data.THIRTYHARVBR != 0)
                    ReportConstants._THIRTYHARVBR = ReportConstants._THIRTYHARVBR + 1;
                emsMaster.THIRTYHARVBR += data.THIRTYHARVBR;
                if (data.THIRTYHARIR != 0)
                    ReportConstants._THIRTYHARIR = ReportConstants._THIRTYHARIR + 1;
                emsMaster.THIRTYHARIR += data.THIRTYHARIR;
                if (data.THIRTYHARIY != 0)
                    ReportConstants._THIRTYHARIY = ReportConstants._THIRTYHARIY + 1;
                emsMaster.THIRTYHARIY += data.THIRTYHARIY;
                if (data.THIRTYHARIB != 0)
                    ReportConstants._THIRTYHARIB = ReportConstants._THIRTYHARIB + 1;
                emsMaster.THIRTYHARIB += data.THIRTYHARIB;
                if (data.THIRTY1HARVRY != 0)
                    ReportConstants._THIRTY1HARVRY = ReportConstants._THIRTY1HARVRY + 1;
                emsMaster.THIRTY1HARVRY += data.THIRTY1HARVRY;
                if (data.THIRTY1HARVYB != 0)
                    ReportConstants._THIRTY1HARVYB = ReportConstants._THIRTY1HARVYB + 1;
                emsMaster.THIRTY1HARVYB += data.THIRTY1HARVYB;
                if (data.THIRTY1HARVBR != 0)
                    ReportConstants._THIRTY1HARVBR = ReportConstants._THIRTY1HARVBR + 1;
                emsMaster.THIRTY1HARVBR += data.THIRTY1HARVBR;
                if (data.THIRTY1HARIR != 0)
                    ReportConstants._THIRTY1HARIR = ReportConstants._THIRTY1HARIR + 1;
                emsMaster.THIRTY1HARIR += data.THIRTY1HARIR;
                if (data.THIRTY1HARIY != 0)
                    ReportConstants._THIRTY1HARIY = ReportConstants._THIRTY1HARIY + 1;
                emsMaster.THIRTY1HARIY += data.THIRTY1HARIY;
                if (data.THIRTY1HARIB != 0)
                    ReportConstants._THIRTY1HARIB = ReportConstants._THIRTY1HARIB + 1;
                emsMaster.THIRTY1HARIB += data.THIRTY1HARIB;
                if (data.THIRTY2HARVRY != 0)
                    ReportConstants._THIRTY2HARVRY = ReportConstants._THIRTY2HARVRY + 1;
                emsMaster.THIRTY2HARVRY += data.THIRTY2HARVRY;
                if (data.THIRTY2HARVYB != 0)
                    ReportConstants._THIRTY2HARVYB = ReportConstants._THIRTY2HARVYB + 1;
                emsMaster.THIRTY2HARVYB += data.THIRTY2HARVYB;
                if (data.THIRTY2HARVBR != 0)
                    ReportConstants._THIRTY2HARVBR = ReportConstants._THIRTY2HARVBR + 1;
                emsMaster.THIRTY2HARVBR += data.THIRTY2HARVBR;
                if (data.THIRTY2HARIR != 0)
                    ReportConstants._THIRTY2HARIR = ReportConstants._THIRTY2HARIR + 1;
                emsMaster.THIRTY2HARIR += data.THIRTY2HARIR;
                if (data.THIRTY2HARIY != 0)
                    ReportConstants._THIRTY2HARIY = ReportConstants._THIRTY2HARIY + 1;
                emsMaster.THIRTY2HARIY += data.THIRTY2HARIY;
                if (data.THIRTY2HARIB != 0)
                    ReportConstants._THIRTY2HARIB = ReportConstants._THIRTY2HARIB + 1;
                emsMaster.THIRTY2HARIB += data.THIRTY2HARIB;
                if (data.THIRTY3HARVRY != 0)
                    ReportConstants._THIRTY3HARVRY = ReportConstants._THIRTY3HARVRY + 1;
                emsMaster.THIRTY3HARVRY += data.THIRTY3HARVRY;
                if (data.THIRTY3HARVYB != 0)
                    ReportConstants._THIRTY3HARVYB = ReportConstants._THIRTY3HARVYB + 1;
                emsMaster.THIRTY3HARVYB += data.THIRTY3HARVYB;
                if (data.THIRTY3HARVBR != 0)
                    ReportConstants._THIRTY3HARVBR = ReportConstants._THIRTY3HARVBR + 1;
                emsMaster.THIRTY3HARVBR += data.THIRTY3HARVBR;
                if (data.THIRTY3HARIR != 0)
                    ReportConstants._THIRTY3HARIR = ReportConstants._THIRTY3HARIR + 1;
                emsMaster.THIRTY3HARIR += data.THIRTY3HARIR;
                if (data.THIRTY3HARIY != 0)
                    ReportConstants._THIRTY3HARIY = ReportConstants._THIRTY3HARIY + 1;
                emsMaster.THIRTY3HARIY += data.THIRTY3HARIY;
                if (data.THIRTY3HARIB != 0)
                    ReportConstants._THIRTY3HARIB = ReportConstants._THIRTY3HARIB + 1;
                emsMaster.THIRTY3HARIB += data.THIRTY3HARIB;
                if (data.ANALOGINPUT1 != 0)
                    ReportConstants._ANALOGINPUT1 = ReportConstants._ANALOGINPUT1 + 1;
                emsMaster.ANALOGINPUT1 += data.ANALOGINPUT1;
                if (data.ANALOGINPUT2 != 0)
                    ReportConstants._ANALOGINPUT2 = ReportConstants._ANALOGINPUT2 + 1;
                emsMaster.ANALOGINPUT2 += data.ANALOGINPUT2;
                if (data.ANALOGINPUT21 != 0)
                    ReportConstants._ANALOGINPUT21 = ReportConstants._ANALOGINPUT21 + 1;
                emsMaster.ANALOGINPUT21 += data.ANALOGINPUT21;
                if (data.ANALOGINPUT3 != 0)
                    ReportConstants._ANALOGINPUT3 = ReportConstants._ANALOGINPUT3 + 1;
                emsMaster.ANALOGINPUT3 += data.ANALOGINPUT3;
                if (data.ANALOGINPUT31 != 0)
                    ReportConstants._ANALOGINPUT31 = ReportConstants._ANALOGINPUT31 + 1;
                emsMaster.ANALOGINPUT31 += data.ANALOGINPUT31;
                if (data.ANALOGINPUT4 != 0)
                    ReportConstants._ANALOGINPUT4 = ReportConstants._ANALOGINPUT4 + 1;
                emsMaster.ANALOGINPUT4 += data.ANALOGINPUT4;
                if (data.ANALOGINPUT41 != 0)
                    ReportConstants._ANALOGINPUT41 = ReportConstants._ANALOGINPUT41 + 1;
                emsMaster.ANALOGINPUT41 += data.ANALOGINPUT41;
                if (data.ANALOGINPUT5 != 0)
                    ReportConstants._ANALOGINPUT5 = ReportConstants._ANALOGINPUT5 + 1;
                emsMaster.ANALOGINPUT5 += data.ANALOGINPUT5;
                if (data.ANALOGINPUT51 != 0)
                    ReportConstants._ANALOGINPUT51 = ReportConstants._ANALOGINPUT51 + 1;
                emsMaster.ANALOGINPUT51 += data.ANALOGINPUT51;
                if (data.ANALOGINPUT6 != 0)
                    ReportConstants._ANALOGINPUT6 = ReportConstants._ANALOGINPUT6 + 1;
                emsMaster.ANALOGINPUT6 += data.ANALOGINPUT6;
                if (data.ANALOGINPUT61 != 0)
                    ReportConstants._ANALOGINPUT61 = ReportConstants._ANALOGINPUT61 + 1;
                emsMaster.ANALOGINPUT61 += data.ANALOGINPUT61;
                if (data.ANALOGINPUT7 != 0)
                    ReportConstants._ANALOGINPUT7 = ReportConstants._ANALOGINPUT7 + 1;
                emsMaster.ANALOGINPUT7 += data.ANALOGINPUT7;
                if (data.ANALOGINPUT71 != 0)
                    ReportConstants._ANALOGINPUT71 = ReportConstants._ANALOGINPUT71 + 1;
                emsMaster.ANALOGINPUT71 += data.ANALOGINPUT71;
                if (data.ANALOGINPUT8 != 0)
                    ReportConstants._ANALOGINPUT8 = ReportConstants._ANALOGINPUT8 + 1;
                emsMaster.ANALOGINPUT8 += data.ANALOGINPUT8;
                if (data.ANALOGINPUT81 != 0)
                    ReportConstants._ANALOGINPUT81 = ReportConstants._ANALOGINPUT81 + 1;
                emsMaster.ANALOGINPUT81 += data.ANALOGINPUT81;
                if (data.ANALOGINPUT9 != 0)
                    ReportConstants._ANALOGINPUT9 = ReportConstants._ANALOGINPUT9 + 1;
                emsMaster.ANALOGINPUT9 += data.ANALOGINPUT9;
                if (data.ANALOGINPUT91 != 0)
                    ReportConstants._ANALOGINPUT91 = ReportConstants._ANALOGINPUT91 + 1;
                emsMaster.ANALOGINPUT91 += data.ANALOGINPUT91;
                if (data.ANALOGINPUT10 != 0)
                    ReportConstants._ANALOGINPUT10 = ReportConstants._ANALOGINPUT10 + 1;
                emsMaster.ANALOGINPUT10 += data.ANALOGINPUT10;
                if (data.ANALOGINPUT101 != 0)
                    ReportConstants._ANALOGINPUT101 = ReportConstants._ANALOGINPUT101 + 1;
                emsMaster.ANALOGINPUT101 += data.ANALOGINPUT101;
                if (data.ANALOGINPUT11 != 0)
                    ReportConstants._ANALOGINPUT11 = ReportConstants._ANALOGINPUT11 + 1;
                emsMaster.ANALOGINPUT11 += data.ANALOGINPUT11;
                if (data.ANALOGINPUT111 != 0)
                    ReportConstants._ANALOGINPUT111 = ReportConstants._ANALOGINPUT111 + 1;
                emsMaster.ANALOGINPUT111 += data.ANALOGINPUT111;
                if (data.ANALOGINPUT12 != 0)
                    ReportConstants._ANALOGINPUT12 = ReportConstants._ANALOGINPUT12 + 1;
                emsMaster.ANALOGINPUT12 += data.ANALOGINPUT12;
                if (data.DIGITALINPUT1 != 0)
                    ReportConstants._DIGITALINPUT1 = ReportConstants._DIGITALINPUT1 + 1;
                emsMaster.DIGITALINPUT1 += data.DIGITALINPUT1;
                if (data.DIGITALINPUT2 != 0)
                    ReportConstants._DIGITALINPUT2 = ReportConstants._DIGITALINPUT2 + 1;
                emsMaster.DIGITALINPUT2 += data.DIGITALINPUT2;
                if (data.DIGITALINPUT21 != 0)
                    ReportConstants._DIGITALINPUT21 = ReportConstants._DIGITALINPUT21 + 1;
                emsMaster.DIGITALINPUT21 += data.DIGITALINPUT21;
                if (data.DIGITALINPUT3 != 0)
                    ReportConstants._DIGITALINPUT3 = ReportConstants._DIGITALINPUT3 + 1;
                emsMaster.DIGITALINPUT3 += data.DIGITALINPUT3;
                if (data.DIGITALINPUT31 != 0)
                    ReportConstants._DIGITALINPUT31 = ReportConstants._DIGITALINPUT31 + 1;
                emsMaster.DIGITALINPUT31 += data.DIGITALINPUT31;
                if (data.DIGITALINPUT4 != 0)
                    ReportConstants._DIGITALINPUT4 = ReportConstants._DIGITALINPUT4 + 1;
                emsMaster.DIGITALINPUT4 += data.DIGITALINPUT4;
                if (data.DIGITALINPUT41 != 0)
                    ReportConstants._DIGITALINPUT41 = ReportConstants._DIGITALINPUT41 + 1;
                emsMaster.DIGITALINPUT41 += data.DIGITALINPUT41;
                if (data.DIGITALINPUT5 != 0)
                    ReportConstants._DIGITALINPUT5 = ReportConstants._DIGITALINPUT5 + 1;
                emsMaster.DIGITALINPUT5 += data.DIGITALINPUT5;
                if (data.DIGITALINPUT51 != 0)
                    ReportConstants._DIGITALINPUT51 = ReportConstants._DIGITALINPUT51 + 1;
                emsMaster.DIGITALINPUT51 += data.DIGITALINPUT51;
                if (data.DIGITALINPUT6 != 0)
                    ReportConstants._DIGITALINPUT6 = ReportConstants._DIGITALINPUT6 + 1;
                emsMaster.DIGITALINPUT6 += data.DIGITALINPUT6;
                if (data.DIGITALINPUT61 != 0)
                    ReportConstants._DIGITALINPUT61 = ReportConstants._DIGITALINPUT61 + 1;
                emsMaster.DIGITALINPUT61 += data.DIGITALINPUT61;
                if (data.DIGITALINPUT7 != 0)
                    ReportConstants._DIGITALINPUT7 = ReportConstants._DIGITALINPUT7 + 1;
                emsMaster.DIGITALINPUT7 += data.DIGITALINPUT7;
                if (data.DIGITALINPUT71 != 0)
                    ReportConstants._DIGITALINPUT71 = ReportConstants._DIGITALINPUT71 + 1;
                emsMaster.DIGITALINPUT71 += data.DIGITALINPUT71;
                if (data.DIGITALINPUT8 != 0)
                    ReportConstants._DIGITALINPUT8 = ReportConstants._DIGITALINPUT8 + 1;
                emsMaster.DIGITALINPUT8 += data.DIGITALINPUT8;
                if (data.DIGITALINPUT81 != 0)
                    ReportConstants._DIGITALINPUT81 = ReportConstants._DIGITALINPUT81 + 1;
                emsMaster.DIGITALINPUT81 += data.DIGITALINPUT81;
                if (data.DIGITALINPUT9 != 0)
                    ReportConstants._DIGITALINPUT9 = ReportConstants._DIGITALINPUT9 + 1;
                emsMaster.DIGITALINPUT9 += data.DIGITALINPUT9;
                if (data.DIGITALINPUT91 != 0)
                    ReportConstants._DIGITALINPUT91 = ReportConstants._DIGITALINPUT91 + 1;
                emsMaster.DIGITALINPUT91 += data.DIGITALINPUT91;
                if (data.DIGITALINPUT10 != 0)
                    ReportConstants._DIGITALINPUT10 = ReportConstants._DIGITALINPUT10 + 1;
                emsMaster.DIGITALINPUT10 += data.DIGITALINPUT10;
                if (data.DIGITALINPUT101 != 0)
                    ReportConstants._DIGITALINPUT101 = ReportConstants._DIGITALINPUT101 + 1;
                emsMaster.DIGITALINPUT101 += data.DIGITALINPUT101;
                if (data.DIGITALINPUT11 != 0)
                    ReportConstants._DIGITALINPUT11 = ReportConstants._DIGITALINPUT11 + 1;
                emsMaster.DIGITALINPUT11 += data.DIGITALINPUT11;
                if (data.DIGITALINPUT111 != 0)
                    ReportConstants._DIGITALINPUT111 = ReportConstants._DIGITALINPUT111 + 1;
                emsMaster.DIGITALINPUT111 += data.DIGITALINPUT111;
                if (data.DIGITALINPUT12 != 0)
                    ReportConstants._DIGITALINPUT12 = ReportConstants._DIGITALINPUT12 + 1;
                emsMaster.DIGITALINPUT12 += data.DIGITALINPUT12;
                if (data.DIGITALOUTPUT1 != 0)
                    ReportConstants._DIGITALOUTPUT1 = ReportConstants._DIGITALOUTPUT1 + 1;
                emsMaster.DIGITALOUTPUT1 += data.DIGITALOUTPUT1;
                if (data.DIGITALOUTPUT2 != 0)
                    ReportConstants._DIGITALOUTPUT2 = ReportConstants._DIGITALOUTPUT2 + 1;
                emsMaster.DIGITALOUTPUT2 += data.DIGITALOUTPUT2;
                if (data.DIGITALOUTPUT21 != 0)
                    ReportConstants._DIGITALOUTPUT21 = ReportConstants._DIGITALOUTPUT21 + 1;
                emsMaster.DIGITALOUTPUT21 += data.DIGITALOUTPUT21;
                if (data.DIGITALOUTPUT3 != 0)
                    ReportConstants._DIGITALOUTPUT3 = ReportConstants._DIGITALOUTPUT3 + 1;
                emsMaster.DIGITALOUTPUT3 += data.DIGITALOUTPUT3;
                if (data.DIGITALOUTPUT31 != 0)
                    ReportConstants._DIGITALOUTPUT31 = ReportConstants._DIGITALOUTPUT31 + 1;
                emsMaster.DIGITALOUTPUT31 += data.DIGITALOUTPUT31;
                if (data.DIGITALOUTPUT4 != 0)
                    ReportConstants._DIGITALOUTPUT4 = ReportConstants._DIGITALOUTPUT4 + 1;
                emsMaster.DIGITALOUTPUT4 += data.DIGITALOUTPUT4;
                if (data.DIGITALOUTPUT41 != 0)
                    ReportConstants._DIGITALOUTPUT41 = ReportConstants._DIGITALOUTPUT41 + 1;
                emsMaster.DIGITALOUTPUT41 += data.DIGITALOUTPUT41;
                if (data.DIGITALOUTPUT5 != 0)
                    ReportConstants._DIGITALOUTPUT5 = ReportConstants._DIGITALOUTPUT5 + 1;
                emsMaster.DIGITALOUTPUT5 += data.DIGITALOUTPUT5;
                if (data.DIGITALOUTPUT51 != 0)
                    ReportConstants._DIGITALOUTPUT51 = ReportConstants._DIGITALOUTPUT51 + 1;
                emsMaster.DIGITALOUTPUT51 += data.DIGITALOUTPUT51;
                if (data.DIGITALOUTPUT6 != 0)
                    ReportConstants._DIGITALOUTPUT6 = ReportConstants._DIGITALOUTPUT6 + 1;
                emsMaster.DIGITALOUTPUT6 += data.DIGITALOUTPUT6;
                if (data.DIGITALOUTPUT61 != 0)
                    ReportConstants._DIGITALOUTPUT61 = ReportConstants._DIGITALOUTPUT61 + 1;
                emsMaster.DIGITALOUTPUT61 += data.DIGITALOUTPUT61;
                if (data.DIGITALOUTPUT7 != 0)
                    ReportConstants._DIGITALOUTPUT7 = ReportConstants._DIGITALOUTPUT7 + 1;
                emsMaster.DIGITALOUTPUT7 += data.DIGITALOUTPUT7;
                if (data.DIGITALOUTPUT71 != 0)
                    ReportConstants._DIGITALOUTPUT71 = ReportConstants._DIGITALOUTPUT71 + 1;
                emsMaster.DIGITALOUTPUT71 += data.DIGITALOUTPUT71;
                if (data.DIGITALOUTPUT8 != 0)
                    ReportConstants._DIGITALOUTPUT8 = ReportConstants._DIGITALOUTPUT8 + 1;
                emsMaster.DIGITALOUTPUT8 += data.DIGITALOUTPUT8;
                if (data.DIGITALOUTPUT81 != 0)
                    ReportConstants._DIGITALOUTPUT81 = ReportConstants._DIGITALOUTPUT81 + 1;
                emsMaster.DIGITALOUTPUT81 += data.DIGITALOUTPUT81;
                if (data.DIGITALOUTPUT9 != 0)
                    ReportConstants._DIGITALOUTPUT9 = ReportConstants._DIGITALOUTPUT9 + 1;
                emsMaster.DIGITALOUTPUT9 += data.DIGITALOUTPUT9;
                if (data.DIGITALOUTPUT91 != 0)
                    ReportConstants._DIGITALOUTPUT91 = ReportConstants._DIGITALOUTPUT91 + 1;
                emsMaster.DIGITALOUTPUT91 += data.DIGITALOUTPUT91;
                if (data.DIGITALOUTPUT10 != 0)
                    ReportConstants._DIGITALOUTPUT10 = ReportConstants._VLLAVG + 1;
                emsMaster.DIGITALOUTPUT10 += data.DIGITALOUTPUT10;
                if (data.DIGITALOUTPUT101 != 0)
                    ReportConstants._DIGITALOUTPUT101 = ReportConstants._DIGITALOUTPUT101 + 1;
                emsMaster.DIGITALOUTPUT101 += data.DIGITALOUTPUT101;
                if (data.DIGITALOUTPUT11 != 0)
                    ReportConstants._DIGITALOUTPUT11 = ReportConstants._DIGITALOUTPUT11 + 1;
                emsMaster.DIGITALOUTPUT11 += data.DIGITALOUTPUT11;
                if (data.DIGITALOUTPUT111 != 0)
                    ReportConstants._DIGITALOUTPUT111 = ReportConstants._DIGITALOUTPUT111 + 1;
                emsMaster.DIGITALOUTPUT111 += data.DIGITALOUTPUT111;
                if (data.DIGITALOUTPUT12 != 0)
                    ReportConstants._DIGITALOUTPUT12 = ReportConstants._DIGITALOUTPUT12 + 1;
                emsMaster.DIGITALOUTPUT12 += data.DIGITALOUTPUT12;
                if (data.PULSEOUTPUT1 != 0)
                    ReportConstants._PULSEOUTPUT1 = ReportConstants._PULSEOUTPUT1 + 1;
                emsMaster.PULSEOUTPUT1 += data.PULSEOUTPUT1;
                if (data.PULSEOUTPUT2 != 0)
                    ReportConstants._PULSEOUTPUT2 = ReportConstants._PULSEOUTPUT2 + 1;
                emsMaster.PULSEOUTPUT2 += data.PULSEOUTPUT2;
                if (data.PULSEOUTPUT3 != 0)
                    ReportConstants._PULSEOUTPUT3 = ReportConstants._PULSEOUTPUT3 + 1;
                emsMaster.PULSEOUTPUT3 += data.PULSEOUTPUT3;
                if (data.PULSEOUTPUT4 != 0)
                    ReportConstants._PULSEOUTPUT4 = ReportConstants._PULSEOUTPUT4 + 1;
                emsMaster.PULSEOUTPUT4 += data.PULSEOUTPUT4;
                if (data.PULSEOUTPUT5 != 0)
                    ReportConstants._PULSEOUTPUT5 = ReportConstants._PULSEOUTPUT5 + 1;
                emsMaster.PULSEOUTPUT5 += data.PULSEOUTPUT5;
                if (data.PULSEOUTPUT6 != 0)
                    ReportConstants._PULSEOUTPUT6 = ReportConstants._PULSEOUTPUT6 + 1;
                emsMaster.PULSEOUTPUT6 += data.PULSEOUTPUT6;
                if (data.ABTBLOCK1 != 0)
                    ReportConstants._ABTBLOCK1 = ReportConstants._ABTBLOCK1 + 1;
                emsMaster.ABTBLOCK1 += data.ABTBLOCK1;
                if (data.ABTBLOCK2 != 0)
                    ReportConstants._ABTBLOCK2 = ReportConstants._ABTBLOCK2 + 1;
                emsMaster.ABTBLOCK2 += data.ABTBLOCK2;
                if (data.ABTBLOCK3 != 0)
                    ReportConstants._ABTBLOCK3 = ReportConstants._ABTBLOCK3 + 1;
                emsMaster.ABTBLOCK3 += data.ABTBLOCK3;
                if (data.ABTBLOCK4 != 0)
                    ReportConstants._ABTBLOCK4 = ReportConstants._ABTBLOCK4 + 1;
                emsMaster.ABTBLOCK4 += data.ABTBLOCK4;
                if (data.ABTBLOCK5 != 0)
                    ReportConstants._ABTBLOCK5 = ReportConstants._ABTBLOCK5 + 1;
                emsMaster.ABTBLOCK5 += data.ABTBLOCK5;
                if (data.ABTBLOCK6 != 0)
                    ReportConstants._ABTBLOCK6 = ReportConstants._ABTBLOCK6 + 1;
                emsMaster.ABTBLOCK6 += data.ABTBLOCK6;
                if (data.ABTBLOCK7 != 0)
                    ReportConstants._ABTBLOCK7 = ReportConstants._ABTBLOCK7 + 1;
                emsMaster.ABTBLOCK7 += data.ABTBLOCK7;
                if (data.ABTBLOCK8 != 0)
                    ReportConstants._ABTBLOCK8 = ReportConstants._ABTBLOCK8 + 1;
                emsMaster.ABTBLOCK8 += data.ABTBLOCK8;
                if (data.ABTBLOCK9 != 0)
                    ReportConstants._ABTBLOCK9 = ReportConstants._ABTBLOCK9 + 1;
                emsMaster.ABTBLOCK9 += data.ABTBLOCK9;
                if (data.ABTBLOCK10 != 0)
                    ReportConstants._ABTBLOCK10 = ReportConstants._ABTBLOCK10 + 1;
                emsMaster.ABTBLOCK10 += data.ABTBLOCK10;
                if (data.ABTBLOCK11 != 0)
                    ReportConstants._ABTBLOCK11 = ReportConstants._ABTBLOCK11 + 1;
                emsMaster.ABTBLOCK11 += data.ABTBLOCK11;
                if (data.ABTBLOCK12 != 0)
                    ReportConstants._ABTBLOCK12 = ReportConstants._ABTBLOCK12 + 1;
                emsMaster.ABTBLOCK12 += data.ABTBLOCK12;
                if (data.ABTBLOCK13 != 0)
                    ReportConstants._ABTBLOCK13 = ReportConstants._ABTBLOCK13 + 1;
                emsMaster.ABTBLOCK13 += data.ABTBLOCK13;
                if (data.ABTBLOCK14 != 0)
                    ReportConstants._ABTBLOCK14 = ReportConstants._ABTBLOCK14 + 1;
                emsMaster.ABTBLOCK14 += data.ABTBLOCK14;
                if (data.ABTBLOCK15 != 0)
                    ReportConstants._ABTBLOCK15 = ReportConstants._ABTBLOCK15 + 1;
                emsMaster.ABTBLOCK15 += data.ABTBLOCK15;
                if (data.ABTBLOCK16 != 0)
                    ReportConstants._ABTBLOCK16 = ReportConstants._ABTBLOCK16 + 1;
                emsMaster.ABTBLOCK16 += data.ABTBLOCK16;
                if (data.ABTBLOCK17 != 0)
                    ReportConstants._ABTBLOCK17 = ReportConstants._ABTBLOCK17 + 1;
                emsMaster.ABTBLOCK17 += data.ABTBLOCK17;
                if (data.ABTBLOCK18 != 0)
                    ReportConstants._ABTBLOCK18 = ReportConstants._ABTBLOCK18 + 1;
                emsMaster.ABTBLOCK18 += data.ABTBLOCK18;
                if (data.ABTBLOCK19 != 0)
                    ReportConstants._ABTBLOCK19 = ReportConstants._ABTBLOCK19 + 1;
                emsMaster.ABTBLOCK19 += data.ABTBLOCK19;
                if (data.ABTBLOCK20 != 0)
                    ReportConstants._ABTBLOCK20 = ReportConstants._ABTBLOCK20 + 1;
                emsMaster.ABTBLOCK20 += data.ABTBLOCK20;
                if (data.ABTBLOCK21 != 0)
                    ReportConstants._ABTBLOCK21 = ReportConstants._ABTBLOCK21 + 1;
                emsMaster.ABTBLOCK21 += data.ABTBLOCK21;
                if (data.ABTBLOCK22 != 0)
                    ReportConstants._ABTBLOCK22 = ReportConstants._ABTBLOCK22 + 1;
                emsMaster.ABTBLOCK22 += data.ABTBLOCK22;
                if (data.ABTBLOCK23 != 0)
                    ReportConstants._ABTBLOCK23 = ReportConstants._ABTBLOCK23 + 1;
                emsMaster.ABTBLOCK23 += data.ABTBLOCK23;
                if (data.ABTBLOCK24 != 0)
                    ReportConstants._ABTBLOCK24 = ReportConstants._ABTBLOCK24 + 1;
                emsMaster.ABTBLOCK24 += data.ABTBLOCK24;
                if (data.ABTBLOCK25 != 0)
                    ReportConstants._ABTBLOCK25 = ReportConstants._ABTBLOCK25 + 1;
                emsMaster.ABTBLOCK25 += data.ABTBLOCK25;
                if (data.ABTBLOCK26 != 0)
                    ReportConstants._ABTBLOCK26 = ReportConstants._ABTBLOCK26 + 1;
                emsMaster.ABTBLOCK26 += data.ABTBLOCK26;
                if (data.ABTBLOCK27 != 0)
                    ReportConstants._ABTBLOCK27 = ReportConstants._ABTBLOCK27 + 1;
                emsMaster.ABTBLOCK27 += data.ABTBLOCK27;
                if (data.ABTBLOCK28 != 0)
                    ReportConstants._ABTBLOCK28 = ReportConstants._ABTBLOCK28 + 1;
                emsMaster.ABTBLOCK28 += data.ABTBLOCK28;
                if (data.ABTBLOCK29 != 0)
                    ReportConstants._ABTBLOCK29 = ReportConstants._ABTBLOCK29 + 1;
                emsMaster.ABTBLOCK29 += data.ABTBLOCK29;
                if (data.ABTBLOCK30 != 0)
                    ReportConstants._ABTBLOCK30 = ReportConstants._ABTBLOCK30 + 1;
                emsMaster.ABTBLOCK30 += data.ABTBLOCK30;
                if (data.ABTBLOCK31 != 0)
                    ReportConstants._ABTBLOCK31 = ReportConstants._ABTBLOCK31 + 1;
                emsMaster.ABTBLOCK31 += data.ABTBLOCK31;
                if (data.ABTBLOCK32 != 0)
                    ReportConstants._ABTBLOCK32 = ReportConstants._ABTBLOCK32 + 1;
                emsMaster.ABTBLOCK32 += data.ABTBLOCK32;
                if (data.ABTBLOCK33 != 0)
                    ReportConstants._ABTBLOCK33 = ReportConstants._ABTBLOCK33 + 1;
                emsMaster.ABTBLOCK33 += data.ABTBLOCK33;
                if (data.ABTBLOCK34 != 0)
                    ReportConstants._ABTBLOCK34 = ReportConstants._ABTBLOCK34 + 1;
                emsMaster.ABTBLOCK34 += data.ABTBLOCK34;
                if (data.ABTBLOCK35 != 0)
                    ReportConstants._ABTBLOCK35 = ReportConstants._ABTBLOCK35 + 1;
                emsMaster.ABTBLOCK35 += data.ABTBLOCK35;
                if (data.ABTBLOCK36 != 0)
                    ReportConstants._ABTBLOCK36 = ReportConstants._ABTBLOCK36 + 1;
                emsMaster.ABTBLOCK36 += data.ABTBLOCK36;
                if (data.ABTBLOCK37 != 0)
                    ReportConstants._ABTBLOCK37 = ReportConstants._ABTBLOCK37 + 1;
                emsMaster.ABTBLOCK37 += data.ABTBLOCK37;
                if (data.ABTBLOCK38 != 0)
                    ReportConstants._ABTBLOCK38 = ReportConstants._ABTBLOCK38 + 1;
                emsMaster.ABTBLOCK38 += data.ABTBLOCK38;
                if (data.ABTBLOCK39 != 0)
                    ReportConstants._ABTBLOCK39 = ReportConstants._ABTBLOCK39 + 1;
                emsMaster.ABTBLOCK39 += data.ABTBLOCK39;
                if (data.ABTBLOCK40 != 0)
                    ReportConstants._ABTBLOCK40 = ReportConstants._ABTBLOCK40 + 1;
                emsMaster.ABTBLOCK40 += data.ABTBLOCK40;
                if (data.ABTBLOCK41 != 0)
                    ReportConstants._ABTBLOCK41 = ReportConstants._ABTBLOCK41 + 1;
                emsMaster.ABTBLOCK41 += data.ABTBLOCK41;
                if (data.ABTBLOCK42 != 0)
                    ReportConstants._ABTBLOCK42 = ReportConstants._ABTBLOCK42 + 1;
                emsMaster.ABTBLOCK42 += data.ABTBLOCK42;
                if (data.ABTBLOCK43 != 0)
                    ReportConstants._ABTBLOCK43 = ReportConstants._ABTBLOCK43 + 1;
                emsMaster.ABTBLOCK43 += data.ABTBLOCK43;
                if (data.ABTBLOCK44 != 0)
                    ReportConstants._ABTBLOCK44 = ReportConstants._ABTBLOCK44 + 1;
                emsMaster.ABTBLOCK44 += data.ABTBLOCK44;
                if (data.ABTBLOCK45 != 0)
                    ReportConstants._ABTBLOCK45 = ReportConstants._ABTBLOCK45 + 1;
                emsMaster.ABTBLOCK45 += data.ABTBLOCK45;
                if (data.ABTBLOCK46 != 0)
                    ReportConstants._ABTBLOCK46 = ReportConstants._ABTBLOCK46 + 1;
                emsMaster.ABTBLOCK46 += data.ABTBLOCK46;
                if (data.ABTBLOCK47 != 0)
                    ReportConstants._ABTBLOCK47 = ReportConstants._ABTBLOCK47 + 1;
                emsMaster.ABTBLOCK47 += data.ABTBLOCK47;
                if (data.ABTBLOCK48 != 0)
                    ReportConstants._ABTBLOCK48 = ReportConstants._ABTBLOCK48 + 1;
                emsMaster.ABTBLOCK48 += data.ABTBLOCK48;
                if (data.ABTBLOCK49 != 0)
                    ReportConstants._ABTBLOCK49 = ReportConstants._ABTBLOCK49 + 1;
                emsMaster.ABTBLOCK49 += data.ABTBLOCK49;
                if (data.ABTBLOCK50 != 0)
                    ReportConstants._ABTBLOCK50 = ReportConstants._ABTBLOCK50 + 1;
                emsMaster.ABTBLOCK50 += data.ABTBLOCK50;
                if (data.ABTBLOCK51 != 0)
                    ReportConstants._ABTBLOCK51 = ReportConstants._ABTBLOCK51 + 1;
                emsMaster.ABTBLOCK51 += data.ABTBLOCK51;
                if (data.ABTBLOCK52 != 0)
                    ReportConstants._ABTBLOCK52 = ReportConstants._ABTBLOCK52 + 1;
                emsMaster.ABTBLOCK52 += data.ABTBLOCK52;
                if (data.ABTBLOCK53 != 0)
                    ReportConstants._ABTBLOCK53 = ReportConstants._ABTBLOCK53 + 1;
                emsMaster.ABTBLOCK53 += data.ABTBLOCK53;
                if (data.ABTBLOCK54 != 0)
                    ReportConstants._ABTBLOCK54 = ReportConstants._ABTBLOCK54 + 1;
                emsMaster.ABTBLOCK54 += data.ABTBLOCK54;
                if (data.ABTBLOCK55 != 0)
                    ReportConstants._ABTBLOCK55 = ReportConstants._ABTBLOCK55 + 1;
                emsMaster.ABTBLOCK55 += data.ABTBLOCK55;
                if (data.ABTBLOCK56 != 0)
                    ReportConstants._ABTBLOCK56 = ReportConstants._ABTBLOCK56 + 1;
                emsMaster.ABTBLOCK56 += data.ABTBLOCK56;
                if (data.ABTBLOCK57 != 0)
                    ReportConstants._ABTBLOCK57 = ReportConstants._ABTBLOCK57 + 1;
                emsMaster.ABTBLOCK57 += data.ABTBLOCK57;
                if (data.ABTBLOCK58 != 0)
                    ReportConstants._ABTBLOCK58 = ReportConstants._ABTBLOCK58 + 1;
                emsMaster.ABTBLOCK58 += data.ABTBLOCK58;
                if (data.ABTBLOCK59 != 0)
                    ReportConstants._ABTBLOCK59 = ReportConstants._ABTBLOCK59 + 1;
                emsMaster.ABTBLOCK59 += data.ABTBLOCK59;
                if (data.ABTBLOCK60 != 0)
                    ReportConstants._ABTBLOCK60 = ReportConstants._ABTBLOCK60 + 1;
                emsMaster.ABTBLOCK60 += data.ABTBLOCK60;
                if (data.ABTBLOCK61 != 0)
                    ReportConstants._ABTBLOCK61 = ReportConstants._ABTBLOCK61 + 1;
                emsMaster.ABTBLOCK61 += data.ABTBLOCK61;
                if (data.ABTBLOCK62 != 0)
                    ReportConstants._ABTBLOCK62 = ReportConstants._ABTBLOCK62 + 1;
                emsMaster.ABTBLOCK62 += data.ABTBLOCK62;
                if (data.ABTBLOCK63 != 0)
                    ReportConstants._ABTBLOCK63 = ReportConstants._ABTBLOCK63 + 1;
                emsMaster.ABTBLOCK63 += data.ABTBLOCK63;
                if (data.ABTBLOCK64 != 0)
                    ReportConstants._ABTBLOCK64 = ReportConstants._ABTBLOCK64 + 1;
                emsMaster.ABTBLOCK64 += data.ABTBLOCK64;
                if (data.ABTBLOCK65 != 0)
                    ReportConstants._ABTBLOCK65 = ReportConstants._ABTBLOCK65 + 1;
                emsMaster.ABTBLOCK65 += data.ABTBLOCK65;
                if (data.ABTBLOCK66 != 0)
                    ReportConstants._ABTBLOCK66 = ReportConstants._ABTBLOCK66 + 1;
                emsMaster.ABTBLOCK66 += data.ABTBLOCK66;
                if (data.ABTBLOCK67 != 0)
                    ReportConstants._ABTBLOCK67 = ReportConstants._ABTBLOCK67 + 1;
                emsMaster.ABTBLOCK67 += data.ABTBLOCK67;
                if (data.ABTBLOCK68 != 0)
                    ReportConstants._ABTBLOCK68 = ReportConstants._ABTBLOCK68 + 1;
                emsMaster.ABTBLOCK68 += data.ABTBLOCK68;
                if (data.ABTBLOCK69 != 0)
                    ReportConstants._ABTBLOCK69 = ReportConstants._ABTBLOCK69 + 1;
                emsMaster.ABTBLOCK69 += data.ABTBLOCK69;
                if (data.ABTBLOCK70 != 0)
                    ReportConstants._ABTBLOCK70 = ReportConstants._ABTBLOCK70 + 1;
                emsMaster.ABTBLOCK70 += data.ABTBLOCK70;
                if (data.ABTBLOCK71 != 0)
                    ReportConstants._ABTBLOCK71 = ReportConstants._ABTBLOCK71 + 1;
                emsMaster.ABTBLOCK71 += data.ABTBLOCK71;
                if (data.ABTBLOCK72 != 0)
                    ReportConstants._ABTBLOCK72 = ReportConstants._ABTBLOCK72 + 1;
                emsMaster.ABTBLOCK72 += data.ABTBLOCK72;
                if (data.ABTBLOCK73 != 0)
                    ReportConstants._ABTBLOCK73 = ReportConstants._ABTBLOCK73 + 1;
                emsMaster.ABTBLOCK73 += data.ABTBLOCK73;
                if (data.ABTBLOCK74 != 0)
                    ReportConstants._ABTBLOCK74 = ReportConstants._ABTBLOCK74 + 1;
                emsMaster.ABTBLOCK74 += data.ABTBLOCK74;
                if (data.ABTBLOCK75 != 0)
                    ReportConstants._ABTBLOCK75 = ReportConstants._ABTBLOCK75 + 1;
                emsMaster.ABTBLOCK75 += data.ABTBLOCK75;
                if (data.ABTBLOCK76 != 0)
                    ReportConstants._ABTBLOCK76 = ReportConstants._ABTBLOCK76 + 1;
                emsMaster.ABTBLOCK76 += data.ABTBLOCK76;
                if (data.ABTBLOCK77 != 0)
                    ReportConstants._ABTBLOCK77 = ReportConstants._ABTBLOCK77 + 1;
                emsMaster.ABTBLOCK77 += data.ABTBLOCK77;
                if (data.ABTBLOCK78 != 0)
                    ReportConstants._ABTBLOCK78 = ReportConstants._ABTBLOCK78 + 1;
                emsMaster.ABTBLOCK78 += data.ABTBLOCK78;
                if (data.ABTBLOCK79 != 0)
                    ReportConstants._ABTBLOCK79 = ReportConstants._ABTBLOCK79 + 1;
                emsMaster.ABTBLOCK79 += data.ABTBLOCK79;
                if (data.ABTBLOCK80 != 0)
                    ReportConstants._ABTBLOCK80 = ReportConstants._ABTBLOCK80 + 1;
                emsMaster.ABTBLOCK80 += data.ABTBLOCK80;
                if (data.ABTBLOCK81 != 0)
                    ReportConstants._ABTBLOCK81 = ReportConstants._ABTBLOCK81 + 1;
                emsMaster.ABTBLOCK81 += data.ABTBLOCK81;
                if (data.ABTBLOCK82 != 0)
                    ReportConstants._ABTBLOCK82 = ReportConstants._ABTBLOCK82 + 1;
                emsMaster.ABTBLOCK82 += data.ABTBLOCK82;
                if (data.ABTBLOCK83 != 0)
                    ReportConstants._ABTBLOCK83 = ReportConstants._ABTBLOCK83 + 1;
                emsMaster.ABTBLOCK83 += data.ABTBLOCK83;
                if (data.ABTBLOCK84 != 0)
                    ReportConstants._ABTBLOCK84 = ReportConstants._ABTBLOCK84 + 1;
                emsMaster.ABTBLOCK84 += data.ABTBLOCK84;
                if (data.ABTBLOCK85 != 0)
                    ReportConstants._ABTBLOCK85 = ReportConstants._ABTBLOCK85 + 1;
                emsMaster.ABTBLOCK85 += data.ABTBLOCK85;
                if (data.ABTBLOCK86 != 0)
                    ReportConstants._ABTBLOCK86 = ReportConstants._ABTBLOCK86 + 1;
                emsMaster.ABTBLOCK86 += data.ABTBLOCK86;
                if (data.ABTBLOCK87 != 0)
                    ReportConstants._ABTBLOCK87 = ReportConstants._ABTBLOCK87 + 1;
                emsMaster.ABTBLOCK87 += data.ABTBLOCK87;
                if (data.ABTBLOCK88 != 0)
                    ReportConstants._ABTBLOCK88 = ReportConstants._ABTBLOCK88 + 1;
                emsMaster.ABTBLOCK88 += data.ABTBLOCK88;
                if (data.ABTBLOCK89 != 0)
                    ReportConstants._ABTBLOCK89 = ReportConstants._ABTBLOCK89 + 1;
                emsMaster.ABTBLOCK89 += data.ABTBLOCK89;
                if (data.ABTBLOCK90 != 0)
                    ReportConstants._ABTBLOCK90 = ReportConstants._ABTBLOCK90 + 1;
                emsMaster.ABTBLOCK90 += data.ABTBLOCK90;
                if (data.ABTBLOCK91 != 0)
                    ReportConstants._ABTBLOCK91 = ReportConstants._ABTBLOCK91 + 1;
                emsMaster.ABTBLOCK91 += data.ABTBLOCK91;
                if (data.ABTBLOCK92 != 0)
                    ReportConstants._ABTBLOCK92 = ReportConstants._ABTBLOCK92 + 1;
                emsMaster.ABTBLOCK92 += data.ABTBLOCK92;
                if (data.ABTBLOCK93 != 0)
                    ReportConstants._ABTBLOCK93 = ReportConstants._ABTBLOCK93 + 1;
                emsMaster.ABTBLOCK93 += data.ABTBLOCK93;
                if (data.ABTBLOCK94 != 0)
                    ReportConstants._ABTBLOCK94 = ReportConstants._ABTBLOCK94 + 1;
                emsMaster.ABTBLOCK94 += data.ABTBLOCK94;
                if (data.ABTBLOCK95 != 0)
                    ReportConstants._ABTBLOCK95 = ReportConstants._ABTBLOCK95 + 1;
                emsMaster.ABTBLOCK95 += data.ABTBLOCK95;
                if (data.ABTBLOCK96 != 0)
                    ReportConstants._ABTBLOCK96 = ReportConstants._ABTBLOCK96 + 1;
                emsMaster.ABTBLOCK96 += data.ABTBLOCK96;
                foreach (PropertyInfo prop in data.GetType().GetProperties())
                {
                    switch (prop.Name)
                    {
                        case ReportConstants._VAHCB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHCB))
                                    keyValuePairs.Add(ReportConstants._VAHCB, new EnergyStartEndRecord { StartRecord = data.VAHCB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHCB].endRecord = data.VAHCB;
                                emsMaster.VAHCB = keyValuePairs[ReportConstants._VAHCB].endRecord > keyValuePairs[ReportConstants._VAHCB].StartRecord ? keyValuePairs[ReportConstants._VAHCB].endRecord - keyValuePairs[ReportConstants._VAHCB].StartRecord : keyValuePairs[ReportConstants._VAHCB].endRecord;

                            }
                            break;
                        case ReportConstants._VAHCONTOT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHCONTOT))
                                    keyValuePairs.Add(ReportConstants._VAHCONTOT, new EnergyStartEndRecord { StartRecord = data.VAHCONTOT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHCONTOT].endRecord = data.VAHCONTOT;
                                emsMaster.VAHCONTOT = keyValuePairs[ReportConstants._VAHCONTOT].endRecord > keyValuePairs[ReportConstants._VAHCONTOT].StartRecord ? keyValuePairs[ReportConstants._VAHCONTOT].endRecord - keyValuePairs[ReportConstants._VAHCONTOT].StartRecord : keyValuePairs[ReportConstants._VAHCONTOT].endRecord;
                            }
                            break;
                        case ReportConstants._VAHCR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHCR))
                                    keyValuePairs.Add(ReportConstants._VAHCR, new EnergyStartEndRecord { StartRecord = data.VAHCR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHCR].endRecord = data.VAHCR;
                                emsMaster.VAHCR = keyValuePairs[ReportConstants._VAHCR].endRecord > keyValuePairs[ReportConstants._VAHCR].StartRecord ? keyValuePairs[ReportConstants._VAHCR].endRecord - keyValuePairs[ReportConstants._VAHCR].StartRecord : keyValuePairs[ReportConstants._VAHCR].endRecord;
                            }
                            break;
                        case ReportConstants._VAHGB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHGB))
                                    keyValuePairs.Add(ReportConstants._VAHGB, new EnergyStartEndRecord { StartRecord = data.VAHGB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHGB].endRecord = data.VAHGB;
                                emsMaster.VAHGB = keyValuePairs[ReportConstants._VAHGB].endRecord > keyValuePairs[ReportConstants._VAHGB].StartRecord ? keyValuePairs[ReportConstants._VAHGB].endRecord - keyValuePairs[ReportConstants._VAHGB].StartRecord : keyValuePairs[ReportConstants._VAHGB].endRecord;
                            }
                            break;
                        case ReportConstants._VAHGENTOT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHGENTOT))
                                    keyValuePairs.Add(ReportConstants._VAHGENTOT, new EnergyStartEndRecord { StartRecord = data.VAHGENTOT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHGENTOT].endRecord = data.VAHGENTOT;
                                emsMaster.VAHGENTOT = keyValuePairs[ReportConstants._VAHGENTOT].endRecord > keyValuePairs[ReportConstants._VAHGENTOT].StartRecord ? keyValuePairs[ReportConstants._VAHGENTOT].endRecord - keyValuePairs[ReportConstants._VAHGENTOT].StartRecord : keyValuePairs[ReportConstants._VAHGENTOT].endRecord;
                            }
                            break;
                        case ReportConstants._VAHGR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHGR))
                                    keyValuePairs.Add(ReportConstants._VAHGR, new EnergyStartEndRecord { StartRecord = data.VAHGR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHGR].endRecord = data.VAHGR;
                                emsMaster.VAHGR = keyValuePairs[ReportConstants._VAHGR].endRecord > keyValuePairs[ReportConstants._VAHGR].StartRecord ? keyValuePairs[ReportConstants._VAHGR].endRecord - keyValuePairs[ReportConstants._VAHGR].StartRecord : keyValuePairs[ReportConstants._VAHGR].endRecord;
                            }
                            break;
                        case ReportConstants._VAHGY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VAHGY))
                                    keyValuePairs.Add(ReportConstants._VAHGY, new EnergyStartEndRecord { StartRecord = data.VAHGY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VAHGY].endRecord = data.VAHGY;
                                emsMaster.VAHGY = keyValuePairs[ReportConstants._VAHGY].endRecord > keyValuePairs[ReportConstants._VAHGY].StartRecord ? keyValuePairs[ReportConstants._VAHGY].endRecord - keyValuePairs[ReportConstants._VAHGY].StartRecord : keyValuePairs[ReportConstants._VAHGY].endRecord;
                            }
                            break;
                        case ReportConstants._VARHB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHB))
                                    keyValuePairs.Add(ReportConstants._VARHB, new EnergyStartEndRecord { StartRecord = data.VARHB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHB].endRecord = data.VARHB;
                                emsMaster.VARHB = keyValuePairs[ReportConstants._VARHB].endRecord > keyValuePairs[ReportConstants._VARHB].StartRecord ? keyValuePairs[ReportConstants._VARHB].endRecord - keyValuePairs[ReportConstants._VARHB].StartRecord : keyValuePairs[ReportConstants._VARHB].endRecord;
                            }
                            break;
                        case ReportConstants._VARHCAPB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHCAPB))
                                    keyValuePairs.Add(ReportConstants._VARHCAPB, new EnergyStartEndRecord { StartRecord = data.VARHCAPB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHCAPB].endRecord = data.VARHCAPB;
                                emsMaster.VARHCAPB = keyValuePairs[ReportConstants._VARHCAPB].endRecord > keyValuePairs[ReportConstants._VARHCAPB].StartRecord ? keyValuePairs[ReportConstants._VARHCAPB].endRecord - keyValuePairs[ReportConstants._VARHCAPB].StartRecord : keyValuePairs[ReportConstants._VARHCAPB].endRecord;
                            }
                            break;
                        case ReportConstants._VARHCAPR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHCAPR))
                                    keyValuePairs.Add(ReportConstants._VARHCAPR, new EnergyStartEndRecord { StartRecord = data.VARHCAPR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHCAPR].endRecord = data.VARHCAPR;
                                emsMaster.VARHCAPR = keyValuePairs[ReportConstants._VARHCAPR].endRecord > keyValuePairs[ReportConstants._VARHCAPR].StartRecord ? keyValuePairs[ReportConstants._VARHCAPR].endRecord - keyValuePairs[ReportConstants._VARHCAPR].StartRecord : keyValuePairs[ReportConstants._VARHCAPR].endRecord;
                            }
                            break;
                        case ReportConstants._VARHCAPT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHCAPT))
                                    keyValuePairs.Add(ReportConstants._VARHCAPT, new EnergyStartEndRecord { StartRecord = data.VARHCAPT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHCAPT].endRecord = data.VARHCAPT;
                                emsMaster.VARHCAPT = keyValuePairs[ReportConstants._VARHCAPT].endRecord > keyValuePairs[ReportConstants._VARHCAPT].StartRecord ? keyValuePairs[ReportConstants._VARHCAPT].endRecord - keyValuePairs[ReportConstants._VARHCAPT].StartRecord : keyValuePairs[ReportConstants._VARHCAPT].endRecord;
                            }
                            break;
                        case ReportConstants._VARHCAPY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHCAPY))
                                    keyValuePairs.Add(ReportConstants._VARHCAPY, new EnergyStartEndRecord { StartRecord = data.VARHCAPY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHCAPY].endRecord = data.VARHCAPY;
                                emsMaster.VARHCAPY = keyValuePairs[ReportConstants._VARHCAPY].endRecord > keyValuePairs[ReportConstants._VARHCAPY].StartRecord ? keyValuePairs[ReportConstants._VARHCAPY].endRecord - keyValuePairs[ReportConstants._VARHCAPY].StartRecord : keyValuePairs[ReportConstants._VARHCAPY].endRecord;
                            }
                            break;
                        case ReportConstants._VARHINDB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHINDB))
                                    keyValuePairs.Add(ReportConstants._VARHINDB, new EnergyStartEndRecord { StartRecord = data.VARHINDB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHINDB].endRecord = data.VARHINDB;
                                emsMaster.VARHINDB = keyValuePairs[ReportConstants._VARHINDB].endRecord > keyValuePairs[ReportConstants._VARHINDB].StartRecord ? keyValuePairs[ReportConstants._VARHINDB].endRecord - keyValuePairs[ReportConstants._VARHINDB].StartRecord : keyValuePairs[ReportConstants._VARHINDB].endRecord;
                            }
                            break;
                        case ReportConstants._VARHINDR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHINDR))
                                    keyValuePairs.Add(ReportConstants._VARHINDR, new EnergyStartEndRecord { StartRecord = data.VARHINDR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHINDR].endRecord = data.VARHINDR;
                                emsMaster.VARHINDR = keyValuePairs[ReportConstants._VARHINDR].endRecord > keyValuePairs[ReportConstants._VARHINDR].StartRecord ? keyValuePairs[ReportConstants._VARHINDR].endRecord - keyValuePairs[ReportConstants._VARHINDR].StartRecord : keyValuePairs[ReportConstants._VARHINDR].endRecord;
                            }
                            break;
                        case ReportConstants._VARHINDT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHINDT))
                                    keyValuePairs.Add(ReportConstants._VARHINDT, new EnergyStartEndRecord { StartRecord = data.VARHINDT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHINDT].endRecord = data.VARHINDT;
                                emsMaster.VARHINDT = keyValuePairs[ReportConstants._VARHINDT].endRecord > keyValuePairs[ReportConstants._VARHINDT].StartRecord ? keyValuePairs[ReportConstants._VARHINDT].endRecord - keyValuePairs[ReportConstants._VARHINDT].StartRecord : keyValuePairs[ReportConstants._VARHINDT].endRecord;
                            }
                            break;
                        case ReportConstants._VARHINDY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHINDY))
                                    keyValuePairs.Add(ReportConstants._VARHINDY, new EnergyStartEndRecord { StartRecord = data.VARHINDY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHINDY].endRecord = data.VARHINDY;
                                emsMaster.VARHINDY = keyValuePairs[ReportConstants._VARHINDY].endRecord > keyValuePairs[ReportConstants._VARHINDY].StartRecord ? keyValuePairs[ReportConstants._VARHINDY].endRecord - keyValuePairs[ReportConstants._VARHINDY].StartRecord : keyValuePairs[ReportConstants._VARHINDY].endRecord;
                            }
                            break;
                        case ReportConstants._VARHR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHR))
                                    keyValuePairs.Add(ReportConstants._VARHR, new EnergyStartEndRecord { StartRecord = data.VARHR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHR].endRecord = data.VARHR;
                                emsMaster.VARHR = keyValuePairs[ReportConstants._VARHR].endRecord > keyValuePairs[ReportConstants._VARHR].StartRecord ? keyValuePairs[ReportConstants._VARHR].endRecord - keyValuePairs[ReportConstants._VARHR].StartRecord : keyValuePairs[ReportConstants._VARHR].endRecord;
                            }
                            break;
                        case ReportConstants._VARHTOT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHTOT))
                                    keyValuePairs.Add(ReportConstants._VARHTOT, new EnergyStartEndRecord { StartRecord = data.VARHTOT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHTOT].endRecord = data.VARHTOT;
                                emsMaster.VARHTOT = keyValuePairs[ReportConstants._VARHTOT].endRecord > keyValuePairs[ReportConstants._VARHTOT].StartRecord ? keyValuePairs[ReportConstants._VARHTOT].endRecord - keyValuePairs[ReportConstants._VARHTOT].StartRecord : keyValuePairs[ReportConstants._VARHTOT].endRecord;
                            }
                            break;
                        case ReportConstants._VARHY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._VARHY))
                                    keyValuePairs.Add(ReportConstants._VARHY, new EnergyStartEndRecord { StartRecord = data.VARHY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._VARHY].endRecord = data.VARHY;
                                emsMaster.VARHY = keyValuePairs[ReportConstants._VARHY].endRecord > keyValuePairs[ReportConstants._VARHY].StartRecord ? keyValuePairs[ReportConstants._VARHY].endRecord - keyValuePairs[ReportConstants._VARHY].StartRecord : keyValuePairs[ReportConstants._VARHY].endRecord;
                            }
                            break;
                        case ReportConstants._WHCB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHCB))
                                    keyValuePairs.Add(ReportConstants._WHCB, new EnergyStartEndRecord { StartRecord = data.WHCB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHCB].endRecord = data.WHCB;
                                emsMaster.WHCB = keyValuePairs[ReportConstants._WHCB].endRecord > keyValuePairs[ReportConstants._WHCB].StartRecord ? keyValuePairs[ReportConstants._WHCB].endRecord - keyValuePairs[ReportConstants._WHCB].StartRecord : keyValuePairs[ReportConstants._WHCB].endRecord;
                            }
                            break;
                        case ReportConstants._WHCONTOT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHCONTOT))
                                    keyValuePairs.Add(ReportConstants._WHCONTOT, new EnergyStartEndRecord { StartRecord = data.WHCONTOT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHCONTOT].endRecord = data.WHCONTOT;
                                emsMaster.WHCONTOT = keyValuePairs[ReportConstants._WHCONTOT].endRecord > keyValuePairs[ReportConstants._WHCONTOT].StartRecord ? keyValuePairs[ReportConstants._WHCONTOT].endRecord - keyValuePairs[ReportConstants._WHCONTOT].StartRecord : keyValuePairs[ReportConstants._WHCONTOT].endRecord;
                            }
                            break;
                        case ReportConstants._WHCR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHCR))
                                    keyValuePairs.Add(ReportConstants._WHCR, new EnergyStartEndRecord { StartRecord = data.WHCR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHCR].endRecord = data.WHCR;
                                emsMaster.WHCR = keyValuePairs[ReportConstants._WHCR].endRecord > keyValuePairs[ReportConstants._WHCR].StartRecord ? keyValuePairs[ReportConstants._WHCR].endRecord - keyValuePairs[ReportConstants._WHCR].StartRecord : keyValuePairs[ReportConstants._WHCR].endRecord;
                            }
                            break;
                        case ReportConstants._WHCY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHCY))
                                    keyValuePairs.Add(ReportConstants._WHCY, new EnergyStartEndRecord { StartRecord = data.WHCY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHCY].endRecord = data.WHCY;
                                emsMaster.WHCY = keyValuePairs[ReportConstants._WHCY].endRecord > keyValuePairs[ReportConstants._WHCY].StartRecord ? keyValuePairs[ReportConstants._WHCY].endRecord - keyValuePairs[ReportConstants._WHCY].StartRecord : keyValuePairs[ReportConstants._WHCY].endRecord;
                            }
                            break;
                        case ReportConstants._WHGB:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHGB))
                                    keyValuePairs.Add(ReportConstants._WHGB, new EnergyStartEndRecord { StartRecord = data.WHGB });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHGB].endRecord = data.WHGB;
                                emsMaster.WHGB = keyValuePairs[ReportConstants._WHGB].endRecord > keyValuePairs[ReportConstants._WHGB].StartRecord ? keyValuePairs[ReportConstants._WHGB].endRecord - keyValuePairs[ReportConstants._WHGB].StartRecord : keyValuePairs[ReportConstants._WHGB].endRecord;
                            }
                            break;
                        case ReportConstants._WHGENTOT:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHGENTOT))
                                    keyValuePairs.Add(ReportConstants._WHGENTOT, new EnergyStartEndRecord { StartRecord = data.WHGENTOT });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHGENTOT].endRecord = data.WHGENTOT;
                                emsMaster.WHGENTOT = keyValuePairs[ReportConstants._WHGENTOT].endRecord > keyValuePairs[ReportConstants._WHGENTOT].StartRecord ? keyValuePairs[ReportConstants._WHGENTOT].endRecord - keyValuePairs[ReportConstants._WHGENTOT].StartRecord : keyValuePairs[ReportConstants._WHGENTOT].endRecord;
                            }
                            break;
                        case ReportConstants._WHGR:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHGR))
                                    keyValuePairs.Add(ReportConstants._WHGR, new EnergyStartEndRecord { StartRecord = data.WHGR });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHGR].endRecord = data.WHGR;
                                emsMaster.WHGR = keyValuePairs[ReportConstants._WHGR].endRecord > keyValuePairs[ReportConstants._WHGR].StartRecord ? keyValuePairs[ReportConstants._WHGR].endRecord - keyValuePairs[ReportConstants._WHGR].StartRecord : keyValuePairs[ReportConstants._WHGR].endRecord;
                            }
                            break;
                        case ReportConstants._WHGY:
                            if (i == 0)
                            {
                                if (!keyValuePairs.ContainsKey(ReportConstants._WHGY))
                                    keyValuePairs.Add(ReportConstants._WHGY, new EnergyStartEndRecord { StartRecord = data.WHGY });
                            }
                            if (i == emsMasters.Count - 1)
                            {
                                keyValuePairs[ReportConstants._WHGY].endRecord = data.WHGY;
                                emsMaster.WHGY = keyValuePairs[ReportConstants._WHGY].endRecord > keyValuePairs[ReportConstants._WHGY].StartRecord ? keyValuePairs[ReportConstants._WHGY].endRecord - keyValuePairs[ReportConstants._WHGY].StartRecord : keyValuePairs[ReportConstants._WHGY].endRecord;
                            }
                            break;

                    }

                }
                i++;
            }
            var avgData=GetAverage(emsMaster);
            return avgData;
        }
        public static EmsMaster GetAverage(EmsMaster emsMaster)
        {
            EmsMaster master = new EmsMaster
            {
                 SlaveId=emsMaster.SlaveId,
                 DeviceId=emsMaster.DeviceId,
                 DateEms=emsMaster.DateEms,
                VLLAVG = ReportConstants._VLLAVG != 0 ? emsMaster.VLLAVG / ReportConstants._VLLAVG : emsMaster.VLLAVG,
                VRY = ReportConstants._VRY != 0 ? emsMaster.VRY / ReportConstants._VRY : emsMaster.VRY,
                VYB = ReportConstants._VYB != 0 ? emsMaster.VYB / ReportConstants._VYB : emsMaster.VYB,
                VBR = ReportConstants._VBR != 0 ? emsMaster.VBR / ReportConstants._VBR : emsMaster.VBR,
                VLNAVG = ReportConstants._VLNAVG != 0 ? emsMaster.VLNAVG / ReportConstants._VLNAVG : emsMaster.VLNAVG,
                VR = ReportConstants._VR != 0 ? emsMaster.VR / ReportConstants._VR : emsMaster.VR,
                VY = ReportConstants._VY != 0 ? emsMaster.VY / ReportConstants._VY : emsMaster.VY,
                VB = ReportConstants._VB != 0 ? emsMaster.VB / ReportConstants._VB : emsMaster.VB,
                IAVG = ReportConstants._IAVG != 0 ? emsMaster.IAVG / ReportConstants._IAVG : emsMaster.IAVG,
                IR = ReportConstants._IR != 0 ? emsMaster.IR / ReportConstants._IR : emsMaster.IR,
                IY = ReportConstants._IY != 0 ? emsMaster.IY / ReportConstants._IY : emsMaster.IY,
                IB = ReportConstants._VLLAVG != 0 ? emsMaster.IB / ReportConstants._VLLAVG : emsMaster.IB,
                HZ = ReportConstants._HZ != 0 ? emsMaster.HZ / ReportConstants._HZ : emsMaster.HZ,
                PFAVG = ReportConstants._PFAVG != 0 ? emsMaster.PFAVG / ReportConstants._PFAVG : emsMaster.PFAVG,
                PFR = ReportConstants._PFR != 0 ? emsMaster.PFR / ReportConstants._PFR : emsMaster.PFR,
                PFY = ReportConstants._PFY != 0 ? emsMaster.PFY / ReportConstants._PFY : emsMaster.PFY,
                PFB = ReportConstants._PFB != 0 ? emsMaster.PFB / ReportConstants._PFB : emsMaster.PFB,
                WattsTot = ReportConstants._WattsTot != 0 ? emsMaster.WattsTot / ReportConstants._WattsTot : emsMaster.WattsTot,
                WR = ReportConstants._WR != 0 ? emsMaster.WR / ReportConstants._WR : emsMaster.WR,
                WY = ReportConstants._WY != 0 ? emsMaster.WY / ReportConstants._WY : emsMaster.WY,
                WB = ReportConstants._WB != 0 ? emsMaster.WB / ReportConstants._WB : emsMaster.WB,
                VATOT = ReportConstants._VATOT != 0 ? emsMaster.VATOT / ReportConstants._VATOT : emsMaster.VATOT,
                VAR = ReportConstants._VAR != 0 ? emsMaster.VAR / ReportConstants._VAR : emsMaster.VAR,
                VAY = ReportConstants._VAY != 0 ? emsMaster.VAY / ReportConstants._VAY : emsMaster.VAY,
                VAB = ReportConstants._VAB != 0 ? emsMaster.VAB / ReportConstants._VAB : emsMaster.VAB,
                VARTOT = ReportConstants._VARTOT != 0 ? emsMaster.VARTOT / ReportConstants._VARTOT : emsMaster.VARTOT,
                VARR = ReportConstants._VARR != 0 ? emsMaster.VARR / ReportConstants._VARR : emsMaster.VARR,
                VARY = ReportConstants._VARY != 0 ? emsMaster.VARY / ReportConstants._VARY : emsMaster.VARY,
                VARB = ReportConstants._VARB != 0 ? emsMaster.VARB / ReportConstants._VARB : emsMaster.VARB,
                RPM = ReportConstants._RPM != 0 ? emsMaster.RPM / ReportConstants._RPM : emsMaster.RPM,
                UNBALANCEVOLTAGEVLL = ReportConstants._UNBALANCEVOLTAGEVLL != 0 ? emsMaster.UNBALANCEVOLTAGEVLL / ReportConstants._UNBALANCEVOLTAGEVLL : emsMaster.UNBALANCEVOLTAGEVLL,
                UNBALANCEVOLTAGEVLN = ReportConstants._UNBALANCEVOLTAGEVLN != 0 ? emsMaster.UNBALANCEVOLTAGEVLN / ReportConstants._UNBALANCEVOLTAGEVLN : emsMaster.UNBALANCEVOLTAGEVLN,
                UNBALANCECURRENTAMPS = ReportConstants._UNBALANCECURRENTAMPS != 0 ? emsMaster.UNBALANCECURRENTAMPS / ReportConstants._UNBALANCECURRENTAMPS : emsMaster.UNBALANCECURRENTAMPS,
                NEUTRALCURRENTLN = ReportConstants._NEUTRALCURRENTLN != 0 ? emsMaster.NEUTRALCURRENTLN / ReportConstants._NEUTRALCURRENTLN : emsMaster.NEUTRALCURRENTLN,
                MAXIMAMDEMAND = ReportConstants._MAXIMAMDEMAND != 0 ? emsMaster.MAXIMAMDEMAND / ReportConstants._MAXIMAMDEMAND : emsMaster.MAXIMAMDEMAND,
                RISINGDEMAND = ReportConstants._RISINGDEMAND != 0 ? emsMaster.RISINGDEMAND / ReportConstants._RISINGDEMAND : emsMaster.RISINGDEMAND,
                DEMAND1 = ReportConstants._DEMAND1 != 0 ? emsMaster.DEMAND1 / ReportConstants._DEMAND1 : emsMaster.DEMAND1,
                DEMAND2 = ReportConstants._DEMAND2 != 0 ? emsMaster.DEMAND2 / ReportConstants._DEMAND2 : emsMaster.DEMAND2,
                DEMAND3 = ReportConstants._DEMAND3 != 0 ? emsMaster.DEMAND3 / ReportConstants._DEMAND3 : emsMaster.DEMAND3,
                THDVOLTAGEVLL = ReportConstants._THDVOLTAGEVLL != 0 ? emsMaster.THDVOLTAGEVLL / ReportConstants._THDVOLTAGEVLL : emsMaster.THDVOLTAGEVLL,
                THDVOLTAGEVLN = ReportConstants._THDVOLTAGEVLN != 0 ? emsMaster.THDVOLTAGEVLN / ReportConstants._THDVOLTAGEVLN : emsMaster.THDVOLTAGEVLN,
                THDCURRENTA = ReportConstants._THDCURRENTA != 0 ? emsMaster.THDCURRENTA / ReportConstants._THDCURRENTA : emsMaster.THDCURRENTA,
                FIRSTSTHRVRY = ReportConstants._FIRSTSTHRVRY != 0 ? emsMaster.FIRSTSTHRVRY / ReportConstants._FIRSTSTHRVRY : emsMaster.FIRSTSTHRVRY,
                FIRSTSTHRVYB = ReportConstants._FIRSTSTHRVYB != 0 ? emsMaster.FIRSTSTHRVYB / ReportConstants._FIRSTSTHRVYB : emsMaster.FIRSTSTHRVYB,
                FIRSTSTHRVBR = ReportConstants._FIRSTSTHRVBR != 0 ? emsMaster.FIRSTSTHRVBR / ReportConstants._FIRSTSTHRVBR : emsMaster.FIRSTSTHRVBR,
                FIRSTSTHRIR = ReportConstants._FIRSTSTHRIR != 0 ? emsMaster.FIRSTSTHRIR / ReportConstants._FIRSTSTHRIR : emsMaster.FIRSTSTHRIR,
                FIRSTSTHRIY = ReportConstants._FIRSTSTHRIY != 0 ? emsMaster.FIRSTSTHRIY / ReportConstants._FIRSTSTHRIY : emsMaster.FIRSTSTHRIY,
                FIRSTSTHRIB = ReportConstants._FIRSTSTHRIB != 0 ? emsMaster.FIRSTSTHRIB / ReportConstants._FIRSTSTHRIB : emsMaster.FIRSTSTHRIB,
                SECONDHARVRY = ReportConstants._SECONDHARVRY != 0 ? emsMaster.SECONDHARVRY / ReportConstants._SECONDHARVRY : emsMaster.SECONDHARVRY,
                SECONDHARVYB = ReportConstants._SECONDHARVYB != 0 ? emsMaster.SECONDHARVYB / ReportConstants._SECONDHARVYB : emsMaster.SECONDHARVYB,
                SECONDHARVBR = ReportConstants._SECONDHARVBR != 0 ? emsMaster.SECONDHARVBR / ReportConstants._SECONDHARVBR : emsMaster.SECONDHARVBR,
                SECONDHARIR = ReportConstants._SECONDHARIR != 0 ? emsMaster.SECONDHARIR / ReportConstants._SECONDHARIR : emsMaster.SECONDHARIR,
                SECONDHARIY = ReportConstants._SECONDHARIY != 0 ? emsMaster.SECONDHARIY / ReportConstants._SECONDHARIY : emsMaster.SECONDHARIY,
                SECONDHARIB = ReportConstants._SECONDHARIB != 0 ? emsMaster.SECONDHARIB / ReportConstants._SECONDHARIB : emsMaster.SECONDHARIB,
                THIRDHARVRY = ReportConstants._THIRDHARVRY != 0 ? emsMaster.THIRDHARVRY / ReportConstants._THIRDHARVRY : emsMaster.THIRDHARVRY,
                THIRDHARVYB = ReportConstants._THIRDHARVYB != 0 ? emsMaster.THIRDHARVYB / ReportConstants._THIRDHARVYB : emsMaster.THIRDHARVYB,
                THIRDHARVBR = ReportConstants._THIRDHARVBR != 0 ? emsMaster.THIRDHARVBR / ReportConstants._THIRDHARVBR : emsMaster.THIRDHARVBR,
                THIRDHARIR = ReportConstants._THIRDHARIR != 0 ? emsMaster.THIRDHARIR / ReportConstants._THIRDHARIR : emsMaster.THIRDHARIR,
                THIRDHARIY = ReportConstants._THIRDHARIY != 0 ? emsMaster.THIRDHARIY / ReportConstants._THIRDHARIY : emsMaster.THIRDHARIY,
                THIRDHARIB = ReportConstants._THIRDHARIB != 0 ? emsMaster.THIRDHARIB / ReportConstants._THIRDHARIB : emsMaster.THIRDHARIB,
                FOURTHHARVRY = ReportConstants._FOURTHHARVRY != 0 ? emsMaster.FOURTHHARVRY / ReportConstants._FOURTHHARVRY : emsMaster.FOURTHHARVRY,
                FOURTHARVYB = ReportConstants._FOURTHARVYB != 0 ? emsMaster.FOURTHARVYB / ReportConstants._FOURTHARVYB : emsMaster.FOURTHARVYB,
                THIRDDHARVBR = ReportConstants._THIRDDHARVBR != 0 ? emsMaster.THIRDDHARVBR / ReportConstants._THIRDDHARVBR : emsMaster.THIRDDHARVBR,
                FOURTHHARIR = ReportConstants._FOURTHHARIR != 0 ? emsMaster.FOURTHHARIR / ReportConstants._FOURTHHARIR : emsMaster.FOURTHHARIR,
                FOURTHHARIY = ReportConstants._FOURTHHARIY != 0 ? emsMaster.FOURTHHARIY / ReportConstants._FOURTHHARIY : emsMaster.FOURTHHARIY,
                FOURTHHARIB = ReportConstants._FOURTHHARIB != 0 ? emsMaster.FOURTHHARIB / ReportConstants._FOURTHHARIB : emsMaster.FOURTHHARIB,
                FIFTHHARVRY = ReportConstants._FIFTHHARVRY != 0 ? emsMaster.FIFTHHARVRY / ReportConstants._FIFTHHARVRY : emsMaster.FIFTHHARVRY,
                FIFTHHARVYB = ReportConstants._FIFTHHARVYB != 0 ? emsMaster.FIFTHHARVYB / ReportConstants._FIFTHHARVYB : emsMaster.FIFTHHARVYB,
                FIFTHHARVBR = ReportConstants._FIFTHHARVBR != 0 ? emsMaster.FIFTHHARVBR / ReportConstants._FIFTHHARVBR : emsMaster.FIFTHHARVBR,
                FIFTHHARIR = ReportConstants._FIFTHHARIR != 0 ? emsMaster.FIFTHHARIR / ReportConstants._FIFTHHARIR : emsMaster.FIFTHHARIR,
                FIFTHHARIY = ReportConstants._FIFTHHARIY != 0 ? emsMaster.FIFTHHARIY / ReportConstants._FIFTHHARIY : emsMaster.FIFTHHARIY,
                FIFTHHARIB = ReportConstants._FIFTHHARIB != 0 ? emsMaster.FIFTHHARIB / ReportConstants._FIFTHHARIB : emsMaster.FIFTHHARIB,
                SIXTHHARVRY = ReportConstants._SIXTHHARVRY != 0 ? emsMaster.SIXTHHARVRY / ReportConstants._SIXTHHARVRY : emsMaster.SIXTHHARVRY,
                SIXTHHARVYB = ReportConstants._SIXTHHARVYB != 0 ? emsMaster.SIXTHHARVYB / ReportConstants._SIXTHHARVYB : emsMaster.SIXTHHARVYB,
                SIXTHHARVBR = ReportConstants._SIXTHHARVBR != 0 ? emsMaster.SIXTHHARVBR / ReportConstants._SIXTHHARVBR : emsMaster.SIXTHHARVBR,
                SIXTHHARIR = ReportConstants._SIXTHHARIR != 0 ? emsMaster.SIXTHHARIR / ReportConstants._SIXTHHARIR : emsMaster.SIXTHHARIR,
                SIXTHHARIY = ReportConstants._SIXTHHARIY != 0 ? emsMaster.SIXTHHARIY / ReportConstants._SIXTHHARIY : emsMaster.SIXTHHARIY,
                SIXTHHARIB = ReportConstants._SIXTHHARIB != 0 ? emsMaster.SIXTHHARIB / ReportConstants._SIXTHHARIB : emsMaster.SIXTHHARIB,
                SEVENTHHARVRY = ReportConstants._SEVENTHHARVRY != 0 ? emsMaster.SEVENTHHARVRY / ReportConstants._SEVENTHHARVRY : emsMaster.SEVENTHHARVRY,
                SEVENTHHARVYB = ReportConstants._SEVENTHHARVYB != 0 ? emsMaster.SEVENTHHARVYB / ReportConstants._SEVENTHHARVYB : emsMaster.SEVENTHHARVYB,
                SEVENTHHARVBR = ReportConstants._SEVENTHHARVBR != 0 ? emsMaster.SEVENTHHARVBR / ReportConstants._SEVENTHHARVBR : emsMaster.SEVENTHHARVBR,
                SEVENTHHARIR = ReportConstants._SEVENTHHARIR != 0 ? emsMaster.SEVENTHHARIR / ReportConstants._SEVENTHHARIR : emsMaster.SEVENTHHARIR,
                SEVENTHHARIY = ReportConstants._SEVENTHHARIY != 0 ? emsMaster.SEVENTHHARIY / ReportConstants._SEVENTHHARIY : emsMaster.SEVENTHHARIY,
                SEVENTHHARIB = ReportConstants._SEVENTHHARIB != 0 ? emsMaster.SEVENTHHARIB / ReportConstants._SEVENTHHARIB : emsMaster.SEVENTHHARIB,
                EIGHTHARVRY = ReportConstants._EIGHTHARVRY != 0 ? emsMaster.EIGHTHARVRY / ReportConstants._EIGHTHARVRY : emsMaster.EIGHTHARVRY,
                EIGHTHARVYB = ReportConstants._EIGHTHARVYB != 0 ? emsMaster.EIGHTHARVYB / ReportConstants._EIGHTHARVYB : emsMaster.EIGHTHARVYB,
                EIGHTHARVBR = ReportConstants._EIGHTHARVBR != 0 ? emsMaster.EIGHTHARVBR / ReportConstants._EIGHTHARVBR : emsMaster.EIGHTHARVBR,
                EIGHTHARIR = ReportConstants._EIGHTHARIR != 0 ? emsMaster.EIGHTHARIR / ReportConstants._EIGHTHARIR : emsMaster.EIGHTHARIR,
                EIGHTHARIY = ReportConstants._EIGHTHARIY != 0 ? emsMaster.EIGHTHARIY / ReportConstants._EIGHTHARIY : emsMaster.EIGHTHARIY,
                EIGHTHARIB = ReportConstants._EIGHTHARIB != 0 ? emsMaster.EIGHTHARIB / ReportConstants._EIGHTHARIB : emsMaster.EIGHTHARIB,
                NINTHHARVRY = ReportConstants._NINTHHARVRY != 0 ? emsMaster.NINTHHARVRY / ReportConstants._NINTHHARVRY : emsMaster.NINTHHARVRY,
                NINTHHARVYB = ReportConstants._NINTHHARVYB != 0 ? emsMaster.NINTHHARVYB / ReportConstants._NINTHHARVYB : emsMaster.NINTHHARVYB,
                NINTHHARVBR = ReportConstants._NINTHHARVBR != 0 ? emsMaster.NINTHHARVBR / ReportConstants._NINTHHARVBR : emsMaster.NINTHHARVBR,
                NINTHHARIR = ReportConstants._NINTHHARIR != 0 ? emsMaster.NINTHHARIR / ReportConstants._NINTHHARIR : emsMaster.NINTHHARIR,
                NINTHHARIY = ReportConstants._NINTHHARIY != 0 ? emsMaster.NINTHHARIY / ReportConstants._NINTHHARIY : emsMaster.NINTHHARIY,
                NINTHHARIB = ReportConstants._NINTHHARIB != 0 ? emsMaster.NINTHHARIB / ReportConstants._NINTHHARIB : emsMaster.NINTHHARIB,
                TENTHHARVRY = ReportConstants._TENTHHARVRY != 0 ? emsMaster.TENTHHARVRY / ReportConstants._TENTHHARVRY : emsMaster.TENTHHARVRY,
                TENTHHARVYB = ReportConstants._TENTHHARVYB != 0 ? emsMaster.TENTHHARVYB / ReportConstants._TENTHHARVYB : emsMaster.TENTHHARVYB,
                TENTHHARVBR = ReportConstants._TENTHHARVBR != 0 ? emsMaster.TENTHHARVBR / ReportConstants._TENTHHARVBR : emsMaster.TENTHHARVBR,
                TENTHHARIR = ReportConstants._TENTHHARIR != 0 ? emsMaster.TENTHHARIR / ReportConstants._TENTHHARIR : emsMaster.TENTHHARIR,
                TENTHHARIY = ReportConstants._TENTHHARIY != 0 ? emsMaster.TENTHHARIY / ReportConstants._TENTHHARIY : emsMaster.TENTHHARIY,
                TENTHHARIB = ReportConstants._TENTHHARIB != 0 ? emsMaster.TENTHHARIB / ReportConstants._TENTHHARIB : emsMaster.TENTHHARIB,
                ELEVENTHHARVRY = ReportConstants._ELEVENTHHARVRY != 0 ? emsMaster.ELEVENTHHARVRY / ReportConstants._ELEVENTHHARVRY : emsMaster.ELEVENTHHARVRY,
                ELEVENTHHARVYB = ReportConstants._ELEVENTHHARVYB != 0 ? emsMaster.ELEVENTHHARVYB / ReportConstants._ELEVENTHHARVYB : emsMaster.ELEVENTHHARVYB,
                ELEVENTHHARVBR = ReportConstants._ELEVENTHHARVBR != 0 ? emsMaster.ELEVENTHHARVBR / ReportConstants._ELEVENTHHARVBR : emsMaster.ELEVENTHHARVBR,
                ELEVENTHHARIR = ReportConstants._ELEVENTHHARIR != 0 ? emsMaster.ELEVENTHHARIR / ReportConstants._ELEVENTHHARIR : emsMaster.ELEVENTHHARIR,
                ELEVENTHHARIY = ReportConstants._ELEVENTHHARIY != 0 ? emsMaster.ELEVENTHHARIY / ReportConstants._ELEVENTHHARIY : emsMaster.ELEVENTHHARIY,
                ELEVENTHHARIB = ReportConstants._ELEVENTHHARIB != 0 ? emsMaster.ELEVENTHHARIB / ReportConstants._ELEVENTHHARIB : emsMaster.ELEVENTHHARIB,
                TWELVEHARVRY = ReportConstants._TWELVEHARVRY != 0 ? emsMaster.TWELVEHARVRY / ReportConstants._TWELVEHARVRY : emsMaster.TWELVEHARVRY,
                TWELVEHARVYB = ReportConstants._TWELVEHARVYB != 0 ? emsMaster.TWELVEHARVYB / ReportConstants._TWELVEHARVYB : emsMaster.TWELVEHARVYB,
                TWELVEHARVBR = ReportConstants._TWELVEHARVBR != 0 ? emsMaster.TWELVEHARVBR / ReportConstants._TWELVEHARVBR : emsMaster.TWELVEHARVBR,
                TWELVEHARIR = ReportConstants._TWELVEHARIR != 0 ? emsMaster.TWELVEHARIR / ReportConstants._TWELVEHARIR : emsMaster.TWELVEHARIR,
                TWELVEHARIY = ReportConstants._TWELVEHARIY != 0 ? emsMaster.TWELVEHARIY / ReportConstants._TWELVEHARIY : emsMaster.TWELVEHARIY,
                TWELVEHARIB = ReportConstants._TWELVEHARIB != 0 ? emsMaster.TWELVEHARIB / ReportConstants._TWELVEHARIB : emsMaster.TWELVEHARIB,
                THIRTEENHARVRY = ReportConstants._THIRTEENHARVRY != 0 ? emsMaster.THIRTEENHARVRY / ReportConstants._THIRTEENHARVRY : emsMaster.THIRTEENHARVRY,
                THIRTEENHARVYB = ReportConstants._THIRTEENHARVYB != 0 ? emsMaster.THIRTEENHARVYB / ReportConstants._THIRTEENHARVYB : emsMaster.THIRTEENHARVYB,
                THIRTEENHARVBR = ReportConstants._THIRTEENHARVBR != 0 ? emsMaster.THIRTEENHARVBR / ReportConstants._THIRTEENHARVBR : emsMaster.THIRTEENHARVBR,
                THIRTEENHARIR = ReportConstants._THIRTEENHARIR != 0 ? emsMaster.THIRTEENHARIR / ReportConstants._THIRTEENHARIR : emsMaster.THIRTEENHARIR,
                THIRTEENHARIY = ReportConstants._THIRTEENHARIY != 0 ? emsMaster.THIRTEENHARIY / ReportConstants._THIRTEENHARIY : emsMaster.THIRTEENHARIY,
                THIRTEENHARIB = ReportConstants._THIRTEENHARIB != 0 ? emsMaster.THIRTEENHARIB / ReportConstants._THIRTEENHARIB : emsMaster.THIRTEENHARIB,
                FOURTEENHARVRY = ReportConstants._FOURTEENHARVRY != 0 ? emsMaster.FOURTEENHARVRY / ReportConstants._FOURTEENHARVRY : emsMaster.FOURTEENHARVRY,
                FOURTEENHARVYB = ReportConstants._FOURTEENHARVYB != 0 ? emsMaster.FOURTEENHARVYB / ReportConstants._FOURTEENHARVYB : emsMaster.FOURTEENHARVYB,
                FOURTEENHARVBR = ReportConstants._FOURTEENHARVBR != 0 ? emsMaster.FOURTEENHARVBR / ReportConstants._FOURTEENHARVBR : emsMaster.FOURTEENHARVBR,
                FOURTEENHARIR = ReportConstants._FOURTEENHARIR != 0 ? emsMaster.FOURTEENHARIR / ReportConstants._FOURTEENHARIR : emsMaster.FOURTEENHARIR,
                FOURTEENHARIY = ReportConstants._FOURTEENHARIY != 0 ? emsMaster.FOURTEENHARIY / ReportConstants._FOURTEENHARIY : emsMaster.FOURTEENHARIY,
                FOURTEENHARIB = ReportConstants._FOURTEENHARIB != 0 ? emsMaster.FOURTEENHARIB / ReportConstants._FOURTEENHARIB : emsMaster.FOURTEENHARIB,
                FIFTHEENHARVRY = ReportConstants._FIFTHEENHARVRY != 0 ? emsMaster.FIFTHEENHARVRY / ReportConstants._FIFTHEENHARVRY : emsMaster.FIFTHEENHARVRY,
                FIFTHEENHARVYB = ReportConstants._FIFTHEENHARVYB != 0 ? emsMaster.FIFTHEENHARVYB / ReportConstants._FIFTHEENHARVYB : emsMaster.FIFTHEENHARVYB,
                FIFTHEENHARVBR = ReportConstants._FIFTHEENHARVBR != 0 ? emsMaster.FIFTHEENHARVBR / ReportConstants._FIFTHEENHARVBR : emsMaster.FIFTHEENHARVBR,
                FIFTHEENHARIR = ReportConstants._FIFTHEENHARIR != 0 ? emsMaster.FIFTHEENHARIR / ReportConstants._FIFTHEENHARIR : emsMaster.FIFTHEENHARIR,
                FIFTHEENHARIY = ReportConstants._FIFTHEENHARIY != 0 ? emsMaster.FIFTHEENHARIY / ReportConstants._FIFTHEENHARIY : emsMaster.FIFTHEENHARIY,
                FIFTHEENHARIB = ReportConstants._FIFTHEENHARIB != 0 ? emsMaster.FIFTHEENHARIB / ReportConstants._FIFTHEENHARIB : emsMaster.FIFTHEENHARIB,
                SIXTHEENHARVRY = ReportConstants._SIXTHEENHARVRY != 0 ? emsMaster.SIXTHEENHARVRY / ReportConstants._SIXTHEENHARVRY : emsMaster.SIXTHEENHARVRY,
                SIXTHEENHARVYB = ReportConstants._SIXTHEENHARVYB != 0 ? emsMaster.SIXTHEENHARVYB / ReportConstants._SIXTHEENHARVYB : emsMaster.SIXTHEENHARVYB,
                SIXTHEENHARVBR = ReportConstants._SIXTHEENHARVBR != 0 ? emsMaster.SIXTHEENHARVBR / ReportConstants._SIXTHEENHARVBR : emsMaster.SIXTHEENHARVBR,
                SIXTHEENHARIR = ReportConstants._SIXTHEENHARIR != 0 ? emsMaster.SIXTHEENHARIR / ReportConstants._SIXTHEENHARIR : emsMaster.SIXTHEENHARIR,
                SIXTHEENHARIY = ReportConstants._SIXTHEENHARIY != 0 ? emsMaster.SIXTHEENHARIY / ReportConstants._SIXTHEENHARIY : emsMaster.SIXTHEENHARIY,
                SIXTHEENHARIB = ReportConstants._SIXTHEENHARIB != 0 ? emsMaster.SIXTHEENHARIB / ReportConstants._SIXTHEENHARIB : emsMaster.SIXTHEENHARIB,
                SEVENTHEENHARVRY = ReportConstants._SEVENTHEENHARVRY != 0 ? emsMaster.SEVENTHEENHARVRY / ReportConstants._SEVENTHEENHARVRY : emsMaster.SEVENTHEENHARVRY,
                SEVENTHEENHARVYB = ReportConstants._SEVENTHEENHARVYB != 0 ? emsMaster.SEVENTHEENHARVYB / ReportConstants._SEVENTHEENHARVYB : emsMaster.SEVENTHEENHARVYB,
                SEVENTHEENHARVBR = ReportConstants._SEVENTHEENHARVBR != 0 ? emsMaster.SEVENTHEENHARVBR / ReportConstants._SEVENTHEENHARVBR : emsMaster.SEVENTHEENHARVBR,
                SEVENTHEENHARIB = ReportConstants._SEVENTHEENHARIB != 0 ? emsMaster.SEVENTHEENHARIB / ReportConstants._SEVENTHEENHARIB : emsMaster.SEVENTHEENHARIB,
                EIGHTHEENHARVRY = ReportConstants._EIGHTHEENHARVRY != 0 ? emsMaster.EIGHTHEENHARVRY / ReportConstants._EIGHTHEENHARVRY : emsMaster.EIGHTHEENHARVRY,
                EIGHTHEENHARVYB = ReportConstants._EIGHTHEENHARVYB != 0 ? emsMaster.EIGHTHEENHARVYB / ReportConstants._EIGHTHEENHARVYB : emsMaster.EIGHTHEENHARVYB,
                EIGHTHEENHARVBR = ReportConstants._EIGHTHEENHARVBR != 0 ? emsMaster.EIGHTHEENHARVBR / ReportConstants._EIGHTHEENHARVBR : emsMaster.EIGHTHEENHARVBR,
                EIGHTHEENHARIR = ReportConstants._EIGHTHEENHARIR != 0 ? emsMaster.EIGHTHEENHARIR / ReportConstants._EIGHTHEENHARIR : emsMaster.EIGHTHEENHARIR,
                EIGHTHEENHARIY = ReportConstants._EIGHTHEENHARIY != 0 ? emsMaster.EIGHTHEENHARIY / ReportConstants._EIGHTHEENHARIY : emsMaster.EIGHTHEENHARIY,
                EIGHTEENHARIB = ReportConstants._EIGHTEENHARIB != 0 ? emsMaster.EIGHTEENHARIB / ReportConstants._EIGHTEENHARIB : emsMaster.EIGHTEENHARIB,
                NINTHEENHARVRY = ReportConstants._NINTHEENHARVRY != 0 ? emsMaster.NINTHEENHARVRY / ReportConstants._NINTHEENHARVRY : emsMaster.NINTHEENHARVRY,
                NINTHEENHARVYB = ReportConstants._NINTHEENHARVYB != 0 ? emsMaster.NINTHEENHARVYB / ReportConstants._NINTHEENHARVYB : emsMaster.NINTHEENHARVYB,
                NINTHEENHARVBR = ReportConstants._NINTHEENHARVBR != 0 ? emsMaster.NINTHEENHARVBR / ReportConstants._NINTHEENHARVBR : emsMaster.NINTHEENHARVBR,
                NINTHEENHARIR = ReportConstants._NINTHEENHARIR != 0 ? emsMaster.NINTHEENHARIR / ReportConstants._NINTHEENHARIR : emsMaster.NINTHEENHARIR,
                NINTHEENHARIY = ReportConstants._NINTHEENHARIY != 0 ? emsMaster.NINTHEENHARIY / ReportConstants._NINTHEENHARIY : emsMaster.NINTHEENHARIY,
                NINTHEENHARIB = ReportConstants._NINTHEENHARIB != 0 ? emsMaster.NINTHEENHARIB / ReportConstants._NINTHEENHARIB : emsMaster.NINTHEENHARIB,
                TWENTYHARVRY = ReportConstants._TWENTYHARVRY != 0 ? emsMaster.TWENTYHARVRY / ReportConstants._TWENTYHARVRY : emsMaster.TWENTYHARVRY,
                TWENTYHARVYB = ReportConstants._TWENTYHARVYB != 0 ? emsMaster.TWENTYHARVYB / ReportConstants._TWENTYHARVYB : emsMaster.TWENTYHARVYB,
                TWENTYHARVBR = ReportConstants._TWENTYHARVBR != 0 ? emsMaster.TWENTYHARVBR / ReportConstants._TWENTYHARVBR : emsMaster.TWENTYHARVBR,
                TWENTYHARIR = ReportConstants._TWENTYHARIR != 0 ? emsMaster.TWENTYHARIR / ReportConstants._TWENTYHARIR : emsMaster.TWENTYHARIR,
                TWENTYHARIY = ReportConstants._TWENTYHARIY != 0 ? emsMaster.TWENTYHARIY / ReportConstants._TWENTYHARIY : emsMaster.TWENTYHARIY,
                TWENTYHARIB = ReportConstants._TWENTYHARIB != 0 ? emsMaster.TWENTYHARIB / ReportConstants._TWENTYHARIB : emsMaster.TWENTYHARIB,
                TWENTY1HARVRY = ReportConstants._TWENTY1HARVRY != 0 ? emsMaster.TWENTY1HARVRY / ReportConstants._TWENTY1HARVRY : emsMaster.TWENTY1HARVRY,
                TWENTY1HARVYB = ReportConstants._TWENTY1HARVYB != 0 ? emsMaster.TWENTY1HARVYB / ReportConstants._TWENTY1HARVYB : emsMaster.TWENTY1HARVYB,
                TWENTY1HARVBR = ReportConstants._TWENTY1HARVBR != 0 ? emsMaster.TWENTY1HARVBR / ReportConstants._TWENTY1HARVBR : emsMaster.TWENTY1HARVBR,
                TWENTY1HARIR = ReportConstants._TWENTY1HARIR != 0 ? emsMaster.TWENTY1HARIR / ReportConstants._TWENTY1HARIR : emsMaster.TWENTY1HARIR,
                TWENTY1HARIY = ReportConstants._TWENTY1HARIY != 0 ? emsMaster.TWENTY1HARIY / ReportConstants._TWENTY1HARIY : emsMaster.TWENTY1HARIY,
                TWENTY1HARIB = ReportConstants._TWENTY1HARIB != 0 ? emsMaster.TWENTY1HARIB / ReportConstants._TWENTY1HARIB : emsMaster.TWENTY1HARIB,
                TWENTY2HARVRY = ReportConstants._TWENTY2HARVRY != 0 ? emsMaster.TWENTY2HARVRY / ReportConstants._TWENTY2HARVRY : emsMaster.TWENTY2HARVRY,
                TWENTY2HARVYB = ReportConstants._TWENTY2HARVYB != 0 ? emsMaster.TWENTY2HARVYB / ReportConstants._TWENTY2HARVYB : emsMaster.TWENTY2HARVYB,
                TWENTY2HARVBR = ReportConstants._TWENTY2HARVBR != 0 ? emsMaster.TWENTY2HARVBR / ReportConstants._TWENTY2HARVBR : emsMaster.TWENTY2HARVBR,
                TWENTY2HARIR = ReportConstants._TWENTY2HARIR != 0 ? emsMaster.TWENTY2HARIR / ReportConstants._TWENTY2HARIR : emsMaster.TWENTY2HARIR,
                TWENTY2HARIY = ReportConstants._TWENTY2HARIY != 0 ? emsMaster.TWENTY2HARIY / ReportConstants._TWENTY2HARIY : emsMaster.TWENTY2HARIY,
                TWENTY2HARIB = ReportConstants._TWENTY2HARIB != 0 ? emsMaster.TWENTY2HARIB / ReportConstants._TWENTY2HARIB : emsMaster.TWENTY2HARIB,
                TWENTY3HARVRY = ReportConstants._TWENTY3HARVRY != 0 ? emsMaster.TWENTY3HARVRY / ReportConstants._TWENTY3HARVRY : emsMaster.TWENTY3HARVRY,
                TWENTY3HARVYB = ReportConstants._TWENTY3HARVYB != 0 ? emsMaster.TWENTY3HARVYB / ReportConstants._TWENTY3HARVYB : emsMaster.TWENTY3HARVYB,
                TWENTY3HARVBR = ReportConstants._TWENTY3HARVBR != 0 ? emsMaster.TWENTY3HARVBR / ReportConstants._TWENTY3HARVBR : emsMaster.TWENTY3HARVBR,
                TWENTY3HARIR = ReportConstants._TWENTY3HARIR != 0 ? emsMaster.TWENTY3HARIR / ReportConstants._TWENTY3HARIR : emsMaster.TWENTY3HARIR,
                TWENTY3HARIY = ReportConstants._TWENTY3HARIY != 0 ? emsMaster.TWENTY3HARIY / ReportConstants._TWENTY3HARIY : emsMaster.TWENTY3HARIY,
                TWENTY3HARIB = ReportConstants._TWENTY3HARIB != 0 ? emsMaster.TWENTY3HARIB / ReportConstants._TWENTY3HARIB : emsMaster.TWENTY3HARIB,
                TWENTY4HARVRY = ReportConstants._TWENTY4HARVRY != 0 ? emsMaster.TWENTY4HARVRY / ReportConstants._TWENTY4HARVRY : emsMaster.TWENTY4HARVRY,
                TWENTY4HARVYB = ReportConstants._TWENTY4HARVYB != 0 ? emsMaster.TWENTY4HARVYB / ReportConstants._TWENTY4HARVYB : emsMaster.TWENTY4HARVYB,
                TWENTY4HARVBR = ReportConstants._TWENTY4HARVBR != 0 ? emsMaster.TWENTY4HARVBR / ReportConstants._TWENTY4HARVBR : emsMaster.TWENTY4HARVBR,
                TWENTY4HARIR = ReportConstants._TWENTY4HARIR != 0 ? emsMaster.TWENTY4HARIR / ReportConstants._TWENTY4HARIR : emsMaster.TWENTY4HARIR,
                TWENTY4HARIY = ReportConstants._TWENTY4HARIY != 0 ? emsMaster.TWENTY4HARIY / ReportConstants._TWENTY4HARIY : emsMaster.TWENTY4HARIY,
                TWENTY4HARIB = ReportConstants._TWENTY4HARIB != 0 ? emsMaster.TWENTY4HARIB / ReportConstants._TWENTY4HARIB : emsMaster.TWENTY4HARIB,
                TWENTY5HARVRY = ReportConstants._TWENTY5HARVRY != 0 ? emsMaster.TWENTY5HARVRY / ReportConstants._TWENTY5HARVRY : emsMaster.TWENTY5HARVRY,
                TWENTY5HARVYB = ReportConstants._TWENTY5HARVYB != 0 ? emsMaster.TWENTY5HARVYB / ReportConstants._TWENTY5HARVYB : emsMaster.TWENTY5HARVYB,
                TWENTY5HARVBR = ReportConstants._TWENTY5HARVBR != 0 ? emsMaster.TWENTY5HARVBR / ReportConstants._TWENTY5HARVBR : emsMaster.TWENTY5HARVBR,
                TWENTY5HARIR = ReportConstants._TWENTY5HARIR != 0 ? emsMaster.TWENTY5HARIR / ReportConstants._TWENTY5HARIR : emsMaster.TWENTY5HARIR,
                TWENTY5HARIY = ReportConstants._TWENTY5HARIY != 0 ? emsMaster.TWENTY5HARIY / ReportConstants._TWENTY5HARIY : emsMaster.TWENTY5HARIY,
                TWENTY5HARIB = ReportConstants._TWENTY5HARIB != 0 ? emsMaster.TWENTY5HARIB / ReportConstants._TWENTY5HARIB : emsMaster.TWENTY5HARIB,
                TWENTY6HARVRY = ReportConstants._TWENTY6HARVRY != 0 ? emsMaster.TWENTY6HARVRY / ReportConstants._TWENTY6HARVRY : emsMaster.TWENTY6HARVRY,
                TWENTY6HARVYB = ReportConstants._TWENTY6HARVYB != 0 ? emsMaster.TWENTY6HARVYB / ReportConstants._TWENTY6HARVYB : emsMaster.TWENTY6HARVYB,
                TWENTY6HARVBR = ReportConstants._TWENTY6HARVBR != 0 ? emsMaster.TWENTY6HARVBR / ReportConstants._TWENTY6HARVBR : emsMaster.TWENTY6HARVBR,
                TWENTY6HARIR = ReportConstants._TWENTY6HARIR != 0 ? emsMaster.TWENTY6HARIR / ReportConstants._TWENTY6HARIR : emsMaster.TWENTY6HARIR,
                TWENTY6HARIY = ReportConstants._TWENTY6HARIY != 0 ? emsMaster.TWENTY6HARIY / ReportConstants._TWENTY6HARIY : emsMaster.TWENTY6HARIY,
                TWENTY6HARIB = ReportConstants._TWENTY6HARIB != 0 ? emsMaster.TWENTY6HARIB / ReportConstants._TWENTY6HARIB : emsMaster.TWENTY6HARIB,
                TWENTY7HARVRY = ReportConstants._TWENTY7HARVYB != 0 ? emsMaster.TWENTY7HARVRY / ReportConstants._TWENTY7HARVRY : emsMaster.TWENTY7HARVRY,
                TWENTY7HARVYB = ReportConstants._TWENTY7HARVYB != 0 ? emsMaster.TWENTY7HARVYB / ReportConstants._TWENTY7HARVYB : emsMaster.TWENTY7HARVYB,
                TWENTY7HARVBR = ReportConstants._TWENTY7HARVBR != 0 ? emsMaster.TWENTY7HARVBR / ReportConstants._TWENTY7HARVBR : emsMaster.TWENTY7HARVBR,
                TWENTY7HARIR = ReportConstants._TWENTY7HARIR != 0 ? emsMaster.TWENTY7HARIR / ReportConstants._TWENTY7HARIR : emsMaster.TWENTY7HARIR,
                TWENTY7HARIY = ReportConstants._TWENTY7HARIY != 0 ? emsMaster.TWENTY7HARIY / ReportConstants._TWENTY7HARIY : emsMaster.TWENTY7HARIY,
                TWENTY7HARIB = ReportConstants._TWENTY7HARIB != 0 ? emsMaster.TWENTY7HARIB / ReportConstants._TWENTY7HARIB : emsMaster.TWENTY7HARIB,
                TWENTY8HARVRY = ReportConstants._TWENTY8HARVRY != 0 ? emsMaster.TWENTY8HARVRY / ReportConstants._TWENTY8HARVRY : emsMaster.TWENTY8HARVRY,
                TWENTY8HARVYB = ReportConstants._TWENTY8HARVYB != 0 ? emsMaster.TWENTY8HARVYB / ReportConstants._TWENTY8HARVYB : emsMaster.TWENTY8HARVYB,
                TWENTY8HARVBR = ReportConstants._TWENTY8HARVBR != 0 ? emsMaster.TWENTY8HARVBR / ReportConstants._TWENTY8HARVBR : emsMaster.TWENTY8HARVBR,
                TWENTY8HARIR = ReportConstants._TWENTY8HARIR != 0 ? emsMaster.TWENTY8HARIR / ReportConstants._TWENTY8HARIR : emsMaster.TWENTY8HARIR,
                TWENTY8HARIY = ReportConstants._TWENTY8HARIY != 0 ? emsMaster.TWENTY8HARIY / ReportConstants._TWENTY8HARIY : emsMaster.TWENTY8HARIY,
                TWENTY8HARIB = ReportConstants._TWENTY8HARIB != 0 ? emsMaster.TWENTY8HARIB / ReportConstants._TWENTY8HARIB : emsMaster.TWENTY8HARIB,
                TWENTY9HARVRY = ReportConstants._TWENTY9HARVRY != 0 ? emsMaster.TWENTY9HARVRY / ReportConstants._TWENTY9HARVRY : emsMaster.TWENTY9HARVRY,
                TWENTY9HARVYB = ReportConstants._TWENTY9HARVYB != 0 ? emsMaster.TWENTY9HARVYB / ReportConstants._TWENTY9HARVYB : emsMaster.TWENTY9HARVYB,
                TWENTY9HARVBR = ReportConstants._TWENTY9HARVBR != 0 ? emsMaster.TWENTY9HARVBR / ReportConstants._TWENTY9HARVBR : emsMaster.TWENTY9HARVBR,
                TWENTY9HARIR = ReportConstants._TWENTY9HARIR != 0 ? emsMaster.TWENTY9HARIR / ReportConstants._TWENTY9HARIR : emsMaster.TWENTY9HARIR,
                TWENTY9HARIY = ReportConstants._TWENTY9HARIY != 0 ? emsMaster.TWENTY9HARIY / ReportConstants._TWENTY9HARIY : emsMaster.TWENTY9HARIY,
                TWENTY9HARIB = ReportConstants._TWENTY9HARIB != 0 ? emsMaster.TWENTY9HARIB / ReportConstants._TWENTY9HARIB : emsMaster.TWENTY9HARIB,
                THIRTYHARVRY = ReportConstants._THIRTYHARVRY != 0 ? emsMaster.THIRTYHARVRY / ReportConstants._THIRTYHARVRY : emsMaster.THIRTYHARVRY,
                THIRTYHARVYB = ReportConstants._THIRTYHARVYB != 0 ? emsMaster.THIRTYHARVYB / ReportConstants._THIRTYHARVYB : emsMaster.THIRTYHARVYB,
                THIRTYHARVBR = ReportConstants._THIRTYHARVBR != 0 ? emsMaster.THIRTYHARVBR / ReportConstants._THIRTYHARVBR : emsMaster.THIRTYHARVBR,
                THIRTYHARIR = ReportConstants._THIRTYHARIR != 0 ? emsMaster.THIRTYHARIR / ReportConstants._THIRTYHARIR : emsMaster.THIRTYHARIR,
                THIRTYHARIY = ReportConstants._THIRTYHARIY != 0 ? emsMaster.THIRTYHARIY / ReportConstants._THIRTYHARIY : emsMaster.THIRTYHARIY,
                THIRTYHARIB = ReportConstants._THIRTYHARIB != 0 ? emsMaster.THIRTYHARIB / ReportConstants._THIRTYHARIB : emsMaster.THIRTYHARIB,
                THIRTY1HARVRY = ReportConstants._THIRTY1HARVRY != 0 ? emsMaster.THIRTY1HARVRY / ReportConstants._THIRTY1HARVRY : emsMaster.THIRTY1HARVRY,
                THIRTY1HARVYB = ReportConstants._THIRTY1HARVYB != 0 ? emsMaster.THIRTY1HARVYB / ReportConstants._THIRTY1HARVYB : emsMaster.THIRTY1HARVYB,
                THIRTY1HARVBR = ReportConstants._THIRTY1HARVBR != 0 ? emsMaster.THIRTY1HARVBR / ReportConstants._THIRTY1HARVBR : emsMaster.THIRTY1HARVBR,
                THIRTY1HARIR = ReportConstants._THIRTY1HARIR != 0 ? emsMaster.THIRTY1HARIR / ReportConstants._THIRTY1HARIR : emsMaster.THIRTY1HARIR,
                THIRTY1HARIY = ReportConstants._THIRTY1HARIY != 0 ? emsMaster.THIRTY1HARIY / ReportConstants._THIRTY1HARIY : emsMaster.THIRTY1HARIY,
                THIRTY1HARIB = ReportConstants._THIRTY1HARIB != 0 ? emsMaster.THIRTY1HARIB / ReportConstants._THIRTY1HARIB : emsMaster.THIRTY1HARIB,
                THIRTY2HARVRY = ReportConstants._THIRTY2HARVRY != 0 ? emsMaster.THIRTY2HARVRY / ReportConstants._THIRTY2HARVRY : emsMaster.THIRTY2HARVRY,
                THIRTY2HARVYB = ReportConstants._THIRTY2HARVYB != 0 ? emsMaster.THIRTY2HARVYB / ReportConstants._THIRTY2HARVYB : emsMaster.THIRTY2HARVYB,
                THIRTY2HARVBR = ReportConstants._THIRTY2HARVBR != 0 ? emsMaster.THIRTY2HARVBR / ReportConstants._THIRTY2HARVBR : emsMaster.THIRTY2HARVBR,
                THIRTY2HARIR = ReportConstants._THIRTY2HARIR != 0 ? emsMaster.THIRTY2HARIR / ReportConstants._THIRTY2HARIR : emsMaster.THIRTY2HARIR,
                THIRTY2HARIY = ReportConstants._THIRTY2HARIY != 0 ? emsMaster.THIRTY2HARIY / ReportConstants._THIRTY2HARIY : emsMaster.THIRTY2HARIY,
                THIRTY2HARIB = ReportConstants._THIRTY2HARIB != 0 ? emsMaster.THIRTY2HARIB / ReportConstants._THIRTY2HARIB : emsMaster.THIRTY2HARIB,
                THIRTY3HARVRY = ReportConstants._THIRTY3HARVRY != 0 ? emsMaster.THIRTY3HARVRY / ReportConstants._THIRTY3HARVRY : emsMaster.THIRTY3HARVRY,
                THIRTY3HARVYB = ReportConstants._THIRTY3HARVYB != 0 ? emsMaster.THIRTY3HARVYB / ReportConstants._THIRTY3HARVYB : emsMaster.THIRTY3HARVYB,
                THIRTY3HARVBR = ReportConstants._THIRTY3HARVBR != 0 ? emsMaster.THIRTY3HARVBR / ReportConstants._THIRTY3HARVBR : emsMaster.THIRTY3HARVBR,
                THIRTY3HARIR = ReportConstants._THIRTY3HARIR != 0 ? emsMaster.THIRTY3HARIR / ReportConstants._THIRTY3HARIR : emsMaster.THIRTY3HARIR,
                THIRTY3HARIY = ReportConstants._THIRTY3HARIY != 0 ? emsMaster.THIRTY3HARIY / ReportConstants._THIRTY3HARIY : emsMaster.THIRTY3HARIY,
                THIRTY3HARIB = ReportConstants._THIRTY3HARIB != 0 ? emsMaster.THIRTY3HARIB / ReportConstants._THIRTY3HARIB : emsMaster.THIRTY3HARIB,
                ANALOGINPUT1 = ReportConstants._ANALOGINPUT1 != 0 ? emsMaster.ANALOGINPUT1 / ReportConstants._ANALOGINPUT1 : emsMaster.ANALOGINPUT1,
                ANALOGINPUT2 = ReportConstants._ANALOGINPUT2 != 0 ? emsMaster.ANALOGINPUT2 / ReportConstants._ANALOGINPUT2 : emsMaster.ANALOGINPUT2,
                ANALOGINPUT21 = ReportConstants._ANALOGINPUT21 != 0 ? emsMaster.ANALOGINPUT21 / ReportConstants._ANALOGINPUT21 : emsMaster.ANALOGINPUT21,
                ANALOGINPUT3 = ReportConstants._ANALOGINPUT3 != 0 ? emsMaster.ANALOGINPUT3 / ReportConstants._ANALOGINPUT3 : emsMaster.ANALOGINPUT3,
                ANALOGINPUT31 = ReportConstants._ANALOGINPUT31 != 0 ? emsMaster.ANALOGINPUT31 / ReportConstants._ANALOGINPUT31 : emsMaster.ANALOGINPUT31,
                ANALOGINPUT4 = ReportConstants._ANALOGINPUT4 != 0 ? emsMaster.ANALOGINPUT4 / ReportConstants._ANALOGINPUT4 : emsMaster.ANALOGINPUT4,
                ANALOGINPUT41 = ReportConstants._ANALOGINPUT41 != 0 ? emsMaster.ANALOGINPUT41 / ReportConstants._ANALOGINPUT41 : emsMaster.ANALOGINPUT41,
                ANALOGINPUT5 = ReportConstants._ANALOGINPUT5 != 0 ? emsMaster.ANALOGINPUT5 / ReportConstants._ANALOGINPUT5 : emsMaster.ANALOGINPUT5,
                ANALOGINPUT51 = ReportConstants._ANALOGINPUT5 != 0 ? emsMaster.ANALOGINPUT51 / ReportConstants._ANALOGINPUT5 : emsMaster.ANALOGINPUT51,
                ANALOGINPUT6 = ReportConstants._ANALOGINPUT6 != 0 ? emsMaster.ANALOGINPUT6 / ReportConstants._ANALOGINPUT6 : emsMaster.ANALOGINPUT6,
                ANALOGINPUT61 = ReportConstants._ANALOGINPUT61 != 0 ? emsMaster.ANALOGINPUT61 / ReportConstants._ANALOGINPUT61 : emsMaster.ANALOGINPUT61,
                ANALOGINPUT7 = ReportConstants._ANALOGINPUT7 != 0 ? emsMaster.ANALOGINPUT7 / ReportConstants._ANALOGINPUT7 : emsMaster.ANALOGINPUT7,
                ANALOGINPUT71 = ReportConstants._ANALOGINPUT71 != 0 ? emsMaster.ANALOGINPUT71 / ReportConstants._ANALOGINPUT71 : emsMaster.ANALOGINPUT71,
                ANALOGINPUT8 = ReportConstants._ANALOGINPUT8 != 0 ? emsMaster.ANALOGINPUT8 / ReportConstants._ANALOGINPUT8 : emsMaster.ANALOGINPUT8,
                ANALOGINPUT81 = ReportConstants._ANALOGINPUT81 != 0 ? emsMaster.ANALOGINPUT81 / ReportConstants._ANALOGINPUT81 : emsMaster.ANALOGINPUT81,
                ANALOGINPUT9 = ReportConstants._ANALOGINPUT9 != 0 ? emsMaster.ANALOGINPUT9 / ReportConstants._ANALOGINPUT9 : emsMaster.ANALOGINPUT9,
                ANALOGINPUT91 = ReportConstants._ANALOGINPUT91 != 0 ? emsMaster.ANALOGINPUT91 / ReportConstants._ANALOGINPUT91 : emsMaster.ANALOGINPUT91,
                ANALOGINPUT10 = ReportConstants._ANALOGINPUT10 != 0 ? emsMaster.ANALOGINPUT10 / ReportConstants._ANALOGINPUT10 : emsMaster.ANALOGINPUT10,
                ANALOGINPUT101 = ReportConstants._ANALOGINPUT101 != 0 ? emsMaster.ANALOGINPUT101 / ReportConstants._ANALOGINPUT101 : emsMaster.ANALOGINPUT101,
                ANALOGINPUT11 = ReportConstants._ANALOGINPUT11 != 0 ? emsMaster.ANALOGINPUT11 / ReportConstants._ANALOGINPUT11 : emsMaster.ANALOGINPUT11,
                ANALOGINPUT111 = ReportConstants._ANALOGINPUT111 != 0 ? emsMaster.ANALOGINPUT111 / ReportConstants._ANALOGINPUT111 : emsMaster.ANALOGINPUT111,
                ANALOGINPUT12 = ReportConstants._ANALOGINPUT12 != 0 ? emsMaster.ANALOGINPUT12 / ReportConstants._ANALOGINPUT12 : emsMaster.ANALOGINPUT12,
                DIGITALINPUT1 = ReportConstants._DIGITALINPUT1 != 0 ? emsMaster.DIGITALINPUT1 / ReportConstants._DIGITALINPUT1 : emsMaster.DIGITALINPUT1,
                DIGITALINPUT2 = ReportConstants._DIGITALINPUT2 != 0 ? emsMaster.DIGITALINPUT2 / ReportConstants._DIGITALINPUT2 : emsMaster.DIGITALINPUT2,
                DIGITALINPUT21 = ReportConstants._DIGITALINPUT21 != 0 ? emsMaster.DIGITALINPUT21 / ReportConstants._DIGITALINPUT21 : emsMaster.DIGITALINPUT21,
                DIGITALINPUT3 = ReportConstants._DIGITALINPUT3 != 0 ? emsMaster.DIGITALINPUT3 / ReportConstants._DIGITALINPUT3 : emsMaster.DIGITALINPUT3,
                DIGITALINPUT31 = ReportConstants._DIGITALINPUT31 != 0 ? emsMaster.DIGITALINPUT31 / ReportConstants._DIGITALINPUT31 : emsMaster.DIGITALINPUT31,
                DIGITALINPUT4 = ReportConstants._DIGITALINPUT4 != 0 ? emsMaster.DIGITALINPUT4 / ReportConstants._DIGITALINPUT4 : emsMaster.DIGITALINPUT4,
                DIGITALINPUT41 = ReportConstants._DIGITALINPUT41 != 0 ? emsMaster.DIGITALINPUT41 / ReportConstants._DIGITALINPUT41 : emsMaster.DIGITALINPUT41,
                DIGITALINPUT5 = ReportConstants._DIGITALINPUT5 != 0 ? emsMaster.DIGITALINPUT5 / ReportConstants._DIGITALINPUT5 : emsMaster.DIGITALINPUT5,
                DIGITALINPUT51 = ReportConstants._DIGITALINPUT51 != 0 ? emsMaster.DIGITALINPUT51 / ReportConstants._DIGITALINPUT51 : emsMaster.DIGITALINPUT51,
                DIGITALINPUT6 = ReportConstants._DIGITALINPUT6 != 0 ? emsMaster.DIGITALINPUT6 / ReportConstants._DIGITALINPUT6 : emsMaster.DIGITALINPUT6,
                DIGITALINPUT61 = ReportConstants._DIGITALINPUT61 != 0 ? emsMaster.DIGITALINPUT61 / ReportConstants._DIGITALINPUT61 : emsMaster.DIGITALINPUT61,
                DIGITALINPUT7 = ReportConstants._DIGITALINPUT7 != 0 ? emsMaster.DIGITALINPUT7 / ReportConstants._DIGITALINPUT7 : emsMaster.DIGITALINPUT7,
                DIGITALINPUT71 = ReportConstants._DIGITALINPUT71 != 0 ? emsMaster.DIGITALINPUT71 / ReportConstants._DIGITALINPUT71 : emsMaster.DIGITALINPUT71,
                DIGITALINPUT8 = ReportConstants._DIGITALINPUT8 != 0 ? emsMaster.DIGITALINPUT8 / ReportConstants._DIGITALINPUT8 : emsMaster.DIGITALINPUT8,
                DIGITALINPUT81 = ReportConstants._DIGITALINPUT81 != 0 ? emsMaster.DIGITALINPUT81 / ReportConstants._DIGITALINPUT81 : emsMaster.DIGITALINPUT81,
                DIGITALINPUT9 = ReportConstants._DIGITALINPUT9 != 0 ? emsMaster.DIGITALINPUT9 / ReportConstants._DIGITALINPUT9 : emsMaster.DIGITALINPUT9,
                DIGITALINPUT91 = ReportConstants._DIGITALINPUT91 != 0 ? emsMaster.DIGITALINPUT91 / ReportConstants._DIGITALINPUT91 : emsMaster.DIGITALINPUT91,
                DIGITALINPUT10 = ReportConstants._DIGITALINPUT10 != 0 ? emsMaster.DIGITALINPUT10 / ReportConstants._DIGITALINPUT10 : emsMaster.DIGITALINPUT10,
                DIGITALINPUT101 = ReportConstants._DIGITALINPUT101 != 0 ? emsMaster.DIGITALINPUT101 / ReportConstants._DIGITALINPUT101 : emsMaster.DIGITALINPUT101,
                DIGITALINPUT11 = ReportConstants._DIGITALINPUT11 != 0 ? emsMaster.DIGITALINPUT11 / ReportConstants._DIGITALINPUT11 : emsMaster.DIGITALINPUT11,
                DIGITALINPUT111 = ReportConstants._DIGITALINPUT111 != 0 ? emsMaster.DIGITALINPUT111 / ReportConstants._DIGITALINPUT111 : emsMaster.DIGITALINPUT111,
                DIGITALINPUT12 = ReportConstants._DIGITALINPUT12 != 0 ? emsMaster.DIGITALINPUT12 / ReportConstants._DIGITALINPUT12 : emsMaster.DIGITALINPUT12,
                DIGITALOUTPUT1 = ReportConstants._DIGITALOUTPUT1 != 0 ? emsMaster.DIGITALOUTPUT1 / ReportConstants._DIGITALOUTPUT1 : emsMaster.DIGITALOUTPUT1,
                DIGITALOUTPUT2 = ReportConstants._DIGITALOUTPUT2 != 0 ? emsMaster.DIGITALOUTPUT2 / ReportConstants._DIGITALOUTPUT2 : emsMaster.DIGITALOUTPUT2,
                DIGITALOUTPUT21 = ReportConstants._DIGITALOUTPUT21 != 0 ? emsMaster.DIGITALOUTPUT21 / ReportConstants._DIGITALOUTPUT21 : emsMaster.DIGITALOUTPUT21,
                DIGITALOUTPUT3 = ReportConstants._DIGITALOUTPUT3 != 0 ? emsMaster.DIGITALOUTPUT3 / ReportConstants._DIGITALOUTPUT3 : emsMaster.DIGITALOUTPUT3,
                DIGITALOUTPUT31 = ReportConstants._DIGITALOUTPUT31 != 0 ? emsMaster.DIGITALOUTPUT31 / ReportConstants._DIGITALOUTPUT31 : emsMaster.DIGITALOUTPUT31,
                DIGITALOUTPUT4 = ReportConstants._DIGITALOUTPUT4 != 0 ? emsMaster.DIGITALOUTPUT4 / ReportConstants._DIGITALOUTPUT4 : emsMaster.DIGITALOUTPUT4,
                DIGITALOUTPUT41 = ReportConstants._DIGITALOUTPUT41 != 0 ? emsMaster.DIGITALOUTPUT41 / ReportConstants._DIGITALOUTPUT41 : emsMaster.DIGITALOUTPUT41,
                DIGITALOUTPUT5 = ReportConstants._DIGITALOUTPUT5 != 0 ? emsMaster.DIGITALOUTPUT5 / ReportConstants._DIGITALOUTPUT5 : emsMaster.DIGITALOUTPUT5,
                DIGITALOUTPUT51 = ReportConstants._DIGITALOUTPUT51 != 0 ? emsMaster.DIGITALOUTPUT51 / ReportConstants._DIGITALOUTPUT51 : emsMaster.DIGITALOUTPUT51,
                DIGITALOUTPUT6 = ReportConstants._DIGITALOUTPUT6 != 0 ? emsMaster.DIGITALOUTPUT6 / ReportConstants._DIGITALOUTPUT6 : emsMaster.DIGITALOUTPUT6,
                DIGITALOUTPUT61 = ReportConstants._DIGITALOUTPUT61 != 0 ? emsMaster.DIGITALOUTPUT61 / ReportConstants._DIGITALOUTPUT61 : emsMaster.DIGITALOUTPUT61,
                DIGITALOUTPUT7 = ReportConstants._DIGITALOUTPUT7 != 0 ? emsMaster.DIGITALOUTPUT7 / ReportConstants._DIGITALOUTPUT7 : emsMaster.DIGITALOUTPUT7,
                DIGITALOUTPUT71 = ReportConstants._DIGITALOUTPUT71 != 0 ? emsMaster.DIGITALOUTPUT71 / ReportConstants._DIGITALOUTPUT71 : emsMaster.DIGITALOUTPUT71,
                DIGITALOUTPUT8 = ReportConstants._DIGITALOUTPUT8 != 0 ? emsMaster.DIGITALOUTPUT8 / ReportConstants._DIGITALOUTPUT8 : emsMaster.DIGITALOUTPUT8,
                DIGITALOUTPUT81 = ReportConstants._DIGITALOUTPUT81 != 0 ? emsMaster.DIGITALOUTPUT81 / ReportConstants._DIGITALOUTPUT81 : emsMaster.DIGITALOUTPUT81,
                DIGITALOUTPUT9 = ReportConstants._DIGITALOUTPUT9 != 0 ? emsMaster.DIGITALOUTPUT9 / ReportConstants._DIGITALOUTPUT9 : emsMaster.DIGITALOUTPUT9,
                DIGITALOUTPUT91 = ReportConstants._DIGITALOUTPUT91 != 0 ? emsMaster.DIGITALOUTPUT91 / ReportConstants._DIGITALOUTPUT91 : emsMaster.DIGITALOUTPUT91,
                DIGITALOUTPUT10 = ReportConstants._DIGITALOUTPUT10 != 0 ? emsMaster.DIGITALOUTPUT10 / ReportConstants._DIGITALOUTPUT10 : emsMaster.DIGITALOUTPUT10,
                DIGITALOUTPUT101 = ReportConstants._DIGITALOUTPUT101 != 0 ? emsMaster.DIGITALOUTPUT101 / ReportConstants._DIGITALOUTPUT101 : emsMaster.DIGITALOUTPUT101,
                DIGITALOUTPUT11 = ReportConstants._DIGITALOUTPUT11 != 0 ? emsMaster.DIGITALOUTPUT11 / ReportConstants._DIGITALOUTPUT11 : emsMaster.DIGITALOUTPUT111,
                DIGITALOUTPUT111 = ReportConstants._DIGITALOUTPUT111 != 0 ? emsMaster.DIGITALOUTPUT111 / ReportConstants._DIGITALOUTPUT111 : emsMaster.DIGITALOUTPUT111,
                DIGITALOUTPUT12 = ReportConstants._DIGITALOUTPUT12 != 0 ? emsMaster.DIGITALOUTPUT12 / ReportConstants._DIGITALOUTPUT12 : emsMaster.DIGITALOUTPUT12,
                PULSEOUTPUT1 = ReportConstants._PULSEOUTPUT1 != 0 ? emsMaster.PULSEOUTPUT1 / ReportConstants._PULSEOUTPUT1 : emsMaster.PULSEOUTPUT1,
                PULSEOUTPUT2 = ReportConstants._PULSEOUTPUT2 != 0 ? emsMaster.PULSEOUTPUT2 / ReportConstants._PULSEOUTPUT2 : emsMaster.PULSEOUTPUT2,
                PULSEOUTPUT3 = ReportConstants._PULSEOUTPUT3 != 0 ? emsMaster.PULSEOUTPUT3 / ReportConstants._PULSEOUTPUT3 : emsMaster.PULSEOUTPUT3,
                PULSEOUTPUT4 = ReportConstants._PULSEOUTPUT4 != 0 ? emsMaster.PULSEOUTPUT4 / ReportConstants._PULSEOUTPUT4 : emsMaster.PULSEOUTPUT4,
                PULSEOUTPUT5 = ReportConstants._PULSEOUTPUT5 != 0 ? emsMaster.PULSEOUTPUT5 / ReportConstants._PULSEOUTPUT5 : emsMaster.PULSEOUTPUT5,
                PULSEOUTPUT6 = ReportConstants._PULSEOUTPUT6 != 0 ? emsMaster.PULSEOUTPUT6 / ReportConstants._PULSEOUTPUT6 : emsMaster.PULSEOUTPUT6,
                ABTBLOCK1 = ReportConstants._ABTBLOCK1 != 0 ? emsMaster.ABTBLOCK1 / ReportConstants._ABTBLOCK1 : emsMaster.ABTBLOCK1,
                ABTBLOCK2 = ReportConstants._ABTBLOCK2 != 0 ? emsMaster.ABTBLOCK2 / ReportConstants._ABTBLOCK2 : emsMaster.ABTBLOCK2,
                ABTBLOCK3 = ReportConstants._ABTBLOCK3 != 0 ? emsMaster.ABTBLOCK3 / ReportConstants._ABTBLOCK3 : emsMaster.ABTBLOCK3,
                ABTBLOCK4 = ReportConstants._ABTBLOCK4 != 0 ? emsMaster.ABTBLOCK4 / ReportConstants._ABTBLOCK4 : emsMaster.ABTBLOCK4,
                ABTBLOCK5 = ReportConstants._ABTBLOCK5 != 0 ? emsMaster.ABTBLOCK5 / ReportConstants._ABTBLOCK5 : emsMaster.ABTBLOCK5,
                ABTBLOCK6 = ReportConstants._ABTBLOCK6 != 0 ? emsMaster.ABTBLOCK6 / ReportConstants._ABTBLOCK6 : emsMaster.ABTBLOCK6,
                ABTBLOCK7 = ReportConstants._ABTBLOCK7 != 0 ? emsMaster.ABTBLOCK7 / ReportConstants._ABTBLOCK7 : emsMaster.ABTBLOCK7,
                ABTBLOCK8 = ReportConstants._ABTBLOCK8 != 0 ? emsMaster.ABTBLOCK8 / ReportConstants._ABTBLOCK8 : emsMaster.ABTBLOCK8,
                ABTBLOCK9 = ReportConstants._ABTBLOCK9 != 0 ? emsMaster.ABTBLOCK9 / ReportConstants._ABTBLOCK9 : emsMaster.ABTBLOCK9,
                ABTBLOCK10 = ReportConstants._ABTBLOCK10 != 0 ? emsMaster.ABTBLOCK10 / ReportConstants._ABTBLOCK10 : emsMaster.ABTBLOCK10,
                ABTBLOCK11 = ReportConstants._ABTBLOCK11 != 0 ? emsMaster.ABTBLOCK11 / ReportConstants._ABTBLOCK11 : emsMaster.ABTBLOCK11,
                ABTBLOCK12 = ReportConstants._ABTBLOCK12 != 0 ? emsMaster.ABTBLOCK12 / ReportConstants._ABTBLOCK12 : emsMaster.ABTBLOCK12,
                ABTBLOCK13 = ReportConstants._ABTBLOCK13 != 0 ? emsMaster.ABTBLOCK13 / ReportConstants._ABTBLOCK13 : emsMaster.ABTBLOCK13,
                ABTBLOCK14 = ReportConstants._ABTBLOCK14 != 0 ? emsMaster.ABTBLOCK14 / ReportConstants._ABTBLOCK14 : emsMaster.ABTBLOCK14,
                ABTBLOCK15 = ReportConstants._ABTBLOCK15 != 0 ? emsMaster.ABTBLOCK15 / ReportConstants._ABTBLOCK15 : emsMaster.ABTBLOCK15,
                ABTBLOCK16 = ReportConstants._ABTBLOCK16 != 0 ? emsMaster.ABTBLOCK16 / ReportConstants._ABTBLOCK16 : emsMaster.ABTBLOCK16,
                ABTBLOCK17 = ReportConstants._ABTBLOCK17 != 0 ? emsMaster.ABTBLOCK17 / ReportConstants._ABTBLOCK17 : emsMaster.ABTBLOCK17,
                ABTBLOCK18 = ReportConstants._ABTBLOCK18 != 0 ? emsMaster.ABTBLOCK18 / ReportConstants._ABTBLOCK18 : emsMaster.ABTBLOCK18,
                ABTBLOCK19 = ReportConstants._ABTBLOCK19 != 0 ? emsMaster.ABTBLOCK19 / ReportConstants._ABTBLOCK19 : emsMaster.ABTBLOCK19,
                ABTBLOCK20 = ReportConstants._ABTBLOCK20 != 0 ? emsMaster.ABTBLOCK20 / ReportConstants._ABTBLOCK20 : emsMaster.ABTBLOCK20,
                ABTBLOCK21 = ReportConstants._ABTBLOCK21 != 0 ? emsMaster.ABTBLOCK21 / ReportConstants._ABTBLOCK21 : emsMaster.ABTBLOCK21,
                ABTBLOCK22 = ReportConstants._ABTBLOCK22 != 0 ? emsMaster.ABTBLOCK22 / ReportConstants._ABTBLOCK22 : emsMaster.ABTBLOCK22,
                ABTBLOCK23 = ReportConstants._ABTBLOCK23 != 0 ? emsMaster.ABTBLOCK23 / ReportConstants._ABTBLOCK23 : emsMaster.ABTBLOCK23,
                ABTBLOCK24 = ReportConstants._ABTBLOCK24 != 0 ? emsMaster.ABTBLOCK24 / ReportConstants._ABTBLOCK24 : emsMaster.ABTBLOCK24,
                ABTBLOCK25 = ReportConstants._ABTBLOCK25 != 0 ? emsMaster.ABTBLOCK25 / ReportConstants._ABTBLOCK25 : emsMaster.ABTBLOCK25,
                ABTBLOCK26 = ReportConstants._ABTBLOCK26 != 0 ? emsMaster.ABTBLOCK26 / ReportConstants._ABTBLOCK26 : emsMaster.ABTBLOCK26,
                ABTBLOCK27 = ReportConstants._ABTBLOCK27 != 0 ? emsMaster.ABTBLOCK27 / ReportConstants._ABTBLOCK27 : emsMaster.ABTBLOCK27,
                ABTBLOCK28 = ReportConstants._ABTBLOCK28 != 0 ? emsMaster.ABTBLOCK28 / ReportConstants._ABTBLOCK28 : emsMaster.ABTBLOCK28,
                ABTBLOCK29 = ReportConstants._ABTBLOCK29 != 0 ? emsMaster.ABTBLOCK29 / ReportConstants._ABTBLOCK29 : emsMaster.ABTBLOCK29,
                ABTBLOCK30 = ReportConstants._ABTBLOCK30 != 0 ? emsMaster.ABTBLOCK30 / ReportConstants._ABTBLOCK30 : emsMaster.ABTBLOCK30,
                ABTBLOCK31 = ReportConstants._ABTBLOCK31 != 0 ? emsMaster.ABTBLOCK31 / ReportConstants._ABTBLOCK31 : emsMaster.ABTBLOCK31,
                ABTBLOCK32 = ReportConstants._ABTBLOCK32 != 0 ? emsMaster.ABTBLOCK32 / ReportConstants._ABTBLOCK32 : emsMaster.ABTBLOCK32,
                ABTBLOCK33 = ReportConstants._ABTBLOCK33 != 0 ? emsMaster.ABTBLOCK33 / ReportConstants._ABTBLOCK33 : emsMaster.ABTBLOCK33,
                ABTBLOCK34 = ReportConstants._ABTBLOCK34 != 0 ? emsMaster.ABTBLOCK34 / ReportConstants._ABTBLOCK34 : emsMaster.ABTBLOCK34,
                ABTBLOCK35 = ReportConstants._ABTBLOCK35 != 0 ? emsMaster.ABTBLOCK35 / ReportConstants._ABTBLOCK35 : emsMaster.ABTBLOCK35,
                ABTBLOCK36 = ReportConstants._ABTBLOCK36 != 0 ? emsMaster.ABTBLOCK36 / ReportConstants._ABTBLOCK36 : emsMaster.ABTBLOCK36,
                ABTBLOCK37 = ReportConstants._ABTBLOCK37 != 0 ? emsMaster.ABTBLOCK37 / ReportConstants._ABTBLOCK37 : emsMaster.ABTBLOCK37,
                ABTBLOCK38 = ReportConstants._ABTBLOCK38 != 0 ? emsMaster.ABTBLOCK38 / ReportConstants._ABTBLOCK38 : emsMaster.ABTBLOCK38,
                ABTBLOCK39 = ReportConstants._ABTBLOCK39 != 0 ? emsMaster.ABTBLOCK39 / ReportConstants._ABTBLOCK39 : emsMaster.ABTBLOCK39,
                ABTBLOCK40 = ReportConstants._ABTBLOCK40 != 0 ? emsMaster.ABTBLOCK40 / ReportConstants._ABTBLOCK40 : emsMaster.ABTBLOCK40,
                ABTBLOCK41 = ReportConstants._ABTBLOCK41 != 0 ? emsMaster.ABTBLOCK41 / ReportConstants._ABTBLOCK41 : emsMaster.ABTBLOCK41,
                ABTBLOCK42 = ReportConstants._ABTBLOCK42 != 0 ? emsMaster.ABTBLOCK42 / ReportConstants._ABTBLOCK42 : emsMaster.ABTBLOCK42,
                ABTBLOCK43 = ReportConstants._ABTBLOCK43 != 0 ? emsMaster.ABTBLOCK43 / ReportConstants._ABTBLOCK43 : emsMaster.ABTBLOCK43,
                ABTBLOCK44 = ReportConstants._ABTBLOCK44 != 0 ? emsMaster.ABTBLOCK44 / ReportConstants._ABTBLOCK44 : emsMaster.ABTBLOCK44,
                ABTBLOCK45 = ReportConstants._ABTBLOCK45 != 0 ? emsMaster.ABTBLOCK45 / ReportConstants._ABTBLOCK45 : emsMaster.ABTBLOCK45,
                ABTBLOCK46 = ReportConstants._ABTBLOCK46 != 0 ? emsMaster.ABTBLOCK46 / ReportConstants._ABTBLOCK46 : emsMaster.ABTBLOCK46,
                ABTBLOCK47 = ReportConstants._ABTBLOCK47 != 0 ? emsMaster.ABTBLOCK47 / ReportConstants._ABTBLOCK47 : emsMaster.ABTBLOCK47,
                ABTBLOCK48 = ReportConstants._ABTBLOCK48 != 0 ? emsMaster.ABTBLOCK48 / ReportConstants._ABTBLOCK48 : emsMaster.ABTBLOCK48,
                ABTBLOCK49 = ReportConstants._ABTBLOCK49 != 0 ? emsMaster.ABTBLOCK49 / ReportConstants._ABTBLOCK49 : emsMaster.ABTBLOCK49,
                ABTBLOCK50 = ReportConstants._ABTBLOCK50 != 0 ? emsMaster.ABTBLOCK50 / ReportConstants._ABTBLOCK50 : emsMaster.ABTBLOCK50,
                ABTBLOCK51 = ReportConstants._ABTBLOCK51 != 0 ? emsMaster.ABTBLOCK51 / ReportConstants._ABTBLOCK51 : emsMaster.ABTBLOCK51,
                ABTBLOCK52 = ReportConstants._ABTBLOCK52 != 0 ? emsMaster.ABTBLOCK52 / ReportConstants._ABTBLOCK52 : emsMaster.ABTBLOCK52,
                ABTBLOCK53 = ReportConstants._ABTBLOCK53 != 0 ? emsMaster.ABTBLOCK53 / ReportConstants._ABTBLOCK53 : emsMaster.ABTBLOCK53,
                ABTBLOCK54 = ReportConstants._ABTBLOCK54 != 0 ? emsMaster.ABTBLOCK54 / ReportConstants._ABTBLOCK54 : emsMaster.ABTBLOCK54,
                ABTBLOCK55 = ReportConstants._ABTBLOCK55 != 0 ? emsMaster.ABTBLOCK55 / ReportConstants._ABTBLOCK55 : emsMaster.ABTBLOCK55,
                ABTBLOCK56 = ReportConstants._ABTBLOCK56 != 0 ? emsMaster.ABTBLOCK56 / ReportConstants._ABTBLOCK56 : emsMaster.ABTBLOCK56,
                ABTBLOCK57 = ReportConstants._ABTBLOCK57 != 0 ? emsMaster.ABTBLOCK57 / ReportConstants._ABTBLOCK57 : emsMaster.ABTBLOCK57,
                ABTBLOCK58 = ReportConstants._ABTBLOCK58 != 0 ? emsMaster.ABTBLOCK58 / ReportConstants._ABTBLOCK58 : emsMaster.ABTBLOCK58,
                ABTBLOCK59 = ReportConstants._ABTBLOCK59 != 0 ? emsMaster.ABTBLOCK59 / ReportConstants._ABTBLOCK59 : emsMaster.ABTBLOCK59,
                ABTBLOCK60 = ReportConstants._ABTBLOCK60 != 0 ? emsMaster.ABTBLOCK60 / ReportConstants._ABTBLOCK60 : emsMaster.ABTBLOCK60,
                ABTBLOCK61 = ReportConstants._ABTBLOCK61 != 0 ? emsMaster.ABTBLOCK61 / ReportConstants._ABTBLOCK61 : emsMaster.ABTBLOCK61,
                ABTBLOCK62 = ReportConstants._ABTBLOCK62 != 0 ? emsMaster.ABTBLOCK62 / ReportConstants._ABTBLOCK62 : emsMaster.ABTBLOCK62,
                ABTBLOCK63 = ReportConstants._ABTBLOCK63 != 0 ? emsMaster.ABTBLOCK63 / ReportConstants._ABTBLOCK63 : emsMaster.ABTBLOCK63,
                ABTBLOCK64 = ReportConstants._ABTBLOCK64 != 0 ? emsMaster.ABTBLOCK64 / ReportConstants._ABTBLOCK64 : emsMaster.ABTBLOCK64,
                ABTBLOCK65 = ReportConstants._ABTBLOCK65 != 0 ? emsMaster.ABTBLOCK65 / ReportConstants._ABTBLOCK65 : emsMaster.ABTBLOCK65,
                ABTBLOCK66 = ReportConstants._ABTBLOCK66 != 0 ? emsMaster.ABTBLOCK66 / ReportConstants._ABTBLOCK66 : emsMaster.ABTBLOCK66,
                ABTBLOCK67 = ReportConstants._ABTBLOCK67 != 0 ? emsMaster.ABTBLOCK67 / ReportConstants._ABTBLOCK67 : emsMaster.ABTBLOCK67,
                ABTBLOCK68 = ReportConstants._ABTBLOCK68 != 0 ? emsMaster.ABTBLOCK68 / ReportConstants._ABTBLOCK68 : emsMaster.ABTBLOCK68,
                ABTBLOCK69 = ReportConstants._ABTBLOCK69 != 0 ? emsMaster.ABTBLOCK69 / ReportConstants._ABTBLOCK69 : emsMaster.ABTBLOCK69,
                ABTBLOCK70 = ReportConstants._ABTBLOCK70 != 0 ? emsMaster.ABTBLOCK70 / ReportConstants._ABTBLOCK70 : emsMaster.ABTBLOCK70,
                ABTBLOCK71 = ReportConstants._ABTBLOCK71 != 0 ? emsMaster.ABTBLOCK71 / ReportConstants._ABTBLOCK71 : emsMaster.ABTBLOCK71,
                ABTBLOCK72 = ReportConstants._ABTBLOCK72 != 0 ? emsMaster.ABTBLOCK72 / ReportConstants._ABTBLOCK72 : emsMaster.ABTBLOCK72,
                ABTBLOCK73 = ReportConstants._ABTBLOCK73 != 0 ? emsMaster.ABTBLOCK73 / ReportConstants._ABTBLOCK73 : emsMaster.ABTBLOCK73,
                ABTBLOCK74 = ReportConstants._ABTBLOCK74 != 0 ? emsMaster.ABTBLOCK74 / ReportConstants._ABTBLOCK74 : emsMaster.ABTBLOCK74,
                ABTBLOCK75 = ReportConstants._ABTBLOCK75 != 0 ? emsMaster.ABTBLOCK75 / ReportConstants._ABTBLOCK75 : emsMaster.ABTBLOCK75,
                ABTBLOCK76 = ReportConstants._ABTBLOCK76 != 0 ? emsMaster.ABTBLOCK76 / ReportConstants._ABTBLOCK76 : emsMaster.ABTBLOCK76,
                ABTBLOCK77 = ReportConstants._ABTBLOCK77 != 0 ? emsMaster.ABTBLOCK77 / ReportConstants._ABTBLOCK77 : emsMaster.ABTBLOCK77,
                ABTBLOCK78 = ReportConstants._ABTBLOCK78 != 0 ? emsMaster.ABTBLOCK78 / ReportConstants._ABTBLOCK78 : emsMaster.ABTBLOCK78,
                ABTBLOCK79 = ReportConstants._ABTBLOCK79 != 0 ? emsMaster.ABTBLOCK79 / ReportConstants._ABTBLOCK79 : emsMaster.ABTBLOCK79,
                ABTBLOCK80 = ReportConstants._ABTBLOCK80 != 0 ? emsMaster.ABTBLOCK80 / ReportConstants._ABTBLOCK80 : emsMaster.ABTBLOCK80,
                ABTBLOCK81 = ReportConstants._ABTBLOCK81 != 0 ? emsMaster.ABTBLOCK81 / ReportConstants._ABTBLOCK81 : emsMaster.ABTBLOCK81,
                ABTBLOCK82 = ReportConstants._ABTBLOCK82 != 0 ? emsMaster.ABTBLOCK82 / ReportConstants._ABTBLOCK82 : emsMaster.ABTBLOCK82,
                ABTBLOCK83 = ReportConstants._ABTBLOCK83 != 0 ? emsMaster.ABTBLOCK83 / ReportConstants._ABTBLOCK83 : emsMaster.ABTBLOCK83,
                ABTBLOCK84 = ReportConstants._ABTBLOCK84 != 0 ? emsMaster.ABTBLOCK84 / ReportConstants._ABTBLOCK84 : emsMaster.ABTBLOCK84,
                ABTBLOCK85 = ReportConstants._ABTBLOCK85 != 0 ? emsMaster.ABTBLOCK85 / ReportConstants._ABTBLOCK85 : emsMaster.ABTBLOCK85,
                ABTBLOCK86 = ReportConstants._ABTBLOCK86 != 0 ? emsMaster.ABTBLOCK86 / ReportConstants._ABTBLOCK86 : emsMaster.ABTBLOCK86,
                ABTBLOCK87 = ReportConstants._ABTBLOCK87 != 0 ? emsMaster.ABTBLOCK87 / ReportConstants._ABTBLOCK87 : emsMaster.ABTBLOCK87,
                ABTBLOCK88 = ReportConstants._ABTBLOCK88 != 0 ? emsMaster.ABTBLOCK88 / ReportConstants._ABTBLOCK88 : emsMaster.ABTBLOCK88,
                ABTBLOCK89 = ReportConstants._ABTBLOCK89 != 0 ? emsMaster.ABTBLOCK89 / ReportConstants._ABTBLOCK89 : emsMaster.ABTBLOCK89,
                ABTBLOCK90 = ReportConstants._ABTBLOCK90 != 0 ? emsMaster.ABTBLOCK90 / ReportConstants._ABTBLOCK90 : emsMaster.ABTBLOCK90,
                ABTBLOCK91 = ReportConstants._ABTBLOCK91 != 0 ? emsMaster.ABTBLOCK91 / ReportConstants._ABTBLOCK91 : emsMaster.ABTBLOCK91,
                ABTBLOCK92 = ReportConstants._ABTBLOCK92 != 0 ? emsMaster.ABTBLOCK92 / ReportConstants._ABTBLOCK92 : emsMaster.ABTBLOCK92,
                ABTBLOCK93 = ReportConstants._ABTBLOCK93 != 0 ? emsMaster.ABTBLOCK93 / ReportConstants._ABTBLOCK93 : emsMaster.ABTBLOCK93,
                ABTBLOCK94 = ReportConstants._ABTBLOCK94 != 0 ? emsMaster.ABTBLOCK94 / ReportConstants._ABTBLOCK94 : emsMaster.ABTBLOCK94,
                ABTBLOCK95 = ReportConstants._ABTBLOCK95 != 0 ? emsMaster.ABTBLOCK95 / ReportConstants._ABTBLOCK95 : emsMaster.ABTBLOCK95,
                ABTBLOCK96 = ReportConstants._ABTBLOCK96 != 0 ? emsMaster.ABTBLOCK96 / ReportConstants._ABTBLOCK96 : emsMaster.ABTBLOCK96,
                SEVENTHEENHARIR = ReportConstants._SEVENTHEENHARIR != 0 ? emsMaster.SEVENTHEENHARIR / ReportConstants._SEVENTHEENHARIR : emsMaster.SEVENTHEENHARIR,
                SEVENTHEENHARIY = ReportConstants._SEVENTHEENHARIY != 0 ? emsMaster.SEVENTHEENHARIY / ReportConstants._SEVENTHEENHARIY : emsMaster.SEVENTHEENHARIY,
                 VAHCB=emsMaster.VAHCB,
                 VAHCONTOT=emsMaster.VAHCONTOT,
                  VAHCR=emsMaster.VAHCR,
                  VAHCY=emsMaster.VAHCY,
                  VAHGB=emsMaster.VAHGB,
                  VAHGENTOT=emsMaster.VAHGENTOT,
                  VAHGR=emsMaster.VAHGR,
                  VAHGY=emsMaster.VAHGY,
                  VARHB=emsMaster.VARHB,
                  VARHCAPB=emsMaster.VARHCAPB,
                  VARHCAPR=emsMaster.VARHCAPR,
                  VARHCAPT=emsMaster.VARHCAPT,
                  VARHCAPY=emsMaster.VARHCAPY,
                  VARHINDB=emsMaster.VARHINDB,
                  VARHINDR=emsMaster.VARHINDR,
                  VARHINDT=emsMaster.VARHINDT,
                  VARHINDY=emsMaster.VARHINDY,
                  VARHR=emsMaster.VARHR,
                  VARHTOT=emsMaster.VARHTOT,
                  VARHY=emsMaster.VARHY,
                  WHCB=emsMaster.WHCB,
                  WHCONTOT=emsMaster.WHCONTOT,
                  WHCR=emsMaster.WHCR,
                  WHCY=emsMaster.WHCY,
                  WHGB=emsMaster.WHGB,
                  WHGENTOT=emsMaster.WHGENTOT,
                  WHGR=emsMaster.WHGR,
                  WHGY=emsMaster.WHGY
            };

            return master;
        }
    }
    public class EnergyStartEndRecord
    {
        public float StartRecord { get; set; }
        public float endRecord { get; set; }
    }
}
