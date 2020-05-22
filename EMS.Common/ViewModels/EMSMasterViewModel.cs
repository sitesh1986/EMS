using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels
{
    public class EMSMasterViewModel
    {
        [JsonProperty("Date")]
        public DateTime DateEms { get; set; }
        [JsonProperty("VLL-Avg")]
        public float VLLAVG { get; set; }
        [JsonProperty("VRY")]
        public float VRY { get; set; }
        [JsonProperty("VYB")]
        public float VYB { get; set; }
        [JsonProperty("VBR")]
        public float VBR { get; set; }
        [JsonProperty("VLN-Avg")]
        public float VLNAVG { get; set; }
        [JsonProperty("VR")]
        public float VR { get; set; }
        [JsonProperty("VY")]
        public float VY { get; set; }
        [JsonProperty("VB")]
        public float VB { get; set; }
        [JsonProperty("Current-Avg")]
        public float IAVG { get; set; }
        [JsonProperty("Current-R")]
        public float IR { get; set; }
        [JsonProperty("Current-Y")]
        public float IY { get; set; }
        [JsonProperty("Current-B")]
        public float IB { get; set; }
        [JsonProperty("Frequency(Hz)")]
        public float HZ { get; set; }
        [JsonProperty("PF-Avg")]
        public float PFAVG { get; set; }
        [JsonProperty("PF-R")]
        public float PFR { get; set; }
        [JsonProperty("PF-Y")]
        public float PFY { get; set; }
        [JsonProperty("PF-B")]
        public float PFB { get; set; }
        [JsonProperty("Watts-Tot")]
        public float WattsTot { get; set; }
        [JsonProperty("W-R")]
        public float WR { get; set; }
        [JsonProperty("W-Y")]
        public float WY { get; set; }
        [JsonProperty("W-B")]
        public float WB { get; set; }
        [JsonProperty("VA-Tot")]
        public float VATOT { get; set; }
        [JsonProperty("VA-R")]
        public float VAR { get; set; }
        [JsonProperty("VA-Y")]
        public float VAY { get; set; }
        [JsonProperty("VA-B")]
        public float VAB { get; set; }
        [JsonProperty("VAR-Tot")]
        public float VARTOT { get; set; }
        [JsonProperty("VAR-R")]
        public float VARR { get; set; }
        [JsonProperty("VAR-Y")]
        public float VARY { get; set; }
        [JsonProperty("VAR-B")]
        public float VARB { get; set; }
        [JsonProperty("Wh(Consumed)-Total")]
        public float WHCONTOT { get; set; }
        [JsonProperty("Wh(C)-R")]
        public float WHCR { get; set; }
        [JsonProperty("Wh(C)-Y")]
        public float WHCY { get; set; }
        [JsonProperty("Wh(C)-B")]
        public float WHCB { get; set; }
        [JsonProperty("Wh(Generated)-Total")]
        public float WHGENTOT { get; set; }
        [JsonProperty("Wh(G)-R")]
        public float WHGR { get; set; }
        [JsonProperty("Wh(G)-Y")]
        public float WHGY { get; set; }
        [JsonProperty("Wh(G)-B")]
        public float WHGB { get; set; }
        [JsonProperty("Vah(Consumed)-Total")]
        public float VAHCONTOT { get; set; }
        [JsonProperty("Vah(C)-R")]
        public float VAHCR { get; set; }
        [JsonProperty("Vah(C)-Y")]
        public float VAHCY { get; set; }
        [JsonProperty("Vah(C)-B")]
        public float VAHCB { get; set; }
        [JsonProperty("Vah(Generated)-Total")]
        public float VAHGENTOT { get; set; }
        [JsonProperty("Vah(G)-R")]
        public float VAHGR { get; set; }
        [JsonProperty("Vah(G)-Y")]
        public float VAHGY { get; set; }
        [JsonProperty("Vah(G)-B")]
        public float VAHGB { get; set; }
        [JsonProperty("Varh-Total")]
        public float VARHTOT { get; set; }
        [JsonProperty("Varh-R")]
        public float VARHR { get; set; }
        [JsonProperty("Varh-Y")]
        public float VARHY { get; set; }
        [JsonProperty("Varh-B")]
        public float VARHB { get; set; }
        [JsonProperty("Varh-Cap-Total")]
        public float VARHCAPT { get; set; }
        [JsonProperty("Varh-Cap-R")]
        public float VARHCAPR { get; set; }
        [JsonProperty("Varh-Cap-Y")]
        public float VARHCAPY { get; set; }
        [JsonProperty("Varh-Cap-B")]
        public float VARHCAPB { get; set; }
        [JsonProperty("Varh-Ind-Total")]
        public float VARHINDT { get; set; }
        [JsonProperty("Varh-Ind-R")]
        public float VARHINDR { get; set; }
        [JsonProperty("Varh-Ind-Y")]
        public float VARHINDY { get; set; }
        [JsonProperty("Varh-Ind-B")]
        public float VARHINDB { get; set; }
        [JsonProperty("RPM")]
        public float RPM { get; set; }
        [JsonProperty("Un Balance Voltage Vll")]
        public float UNBALANCEVOLTAGEVLL { get; set; }
        [JsonProperty("Un Balance Voltage VlN")]
        public float UNBALANCEVOLTAGEVLN { get; set; }
        [JsonProperty("Un Balance Current Amps")]
        public float UNBALANCECURRENTAMPS { get; set; }
        [JsonProperty("Neutral Current (I-N)")]
        public float NEUTRALCURRENTLN { get; set; }
        [JsonProperty("Maximum Demand")]
        public float MAXIMAMDEMAND { get; set; }
        [JsonProperty("Rising Demand")]
        public float RISINGDEMAND { get; set; }
        [JsonProperty("Demand-1")]
        public float DEMAND1 { get; set; }
        [JsonProperty("Demand-2")]
        public float DEMAND2 { get; set; }
        [JsonProperty("Demand-3")]
        public float DEMAND3 { get; set; }
        [JsonProperty("THD Voltage(VLL) %")]
        public float THDVOLTAGEVLL { get; set; }
        [JsonProperty("THD Voltage(VLN) %")]
        public float THDVOLTAGEVLN { get; set; }
        [JsonProperty("THD Current(A) %")]
        public float THDCURRENTA { get; set; }
        [JsonProperty("1st Har VRY")]
        public float FIRSTSTHRVRY { get; set; }
        [JsonProperty("1st Har VYB")]
        public float FIRSTSTHRVYB { get; set; }
        [JsonProperty("1st Har VBR")]
        public float FIRSTSTHRVBR { get; set; }
        [JsonProperty("1st Har IR")]
        public float FIRSTSTHRIR { get; set; }
        [JsonProperty("1st Har IY")]
        public float FIRSTSTHRIY { get; set; }
        [JsonProperty("1st Har IB")]
        public float FIRSTSTHRIB { get; set; }
        [JsonProperty("2nd Har VRY")]
        public float SECONDHARVRY { get; set; }
        [JsonProperty("2nd Har VYB")]
        public float SECONDHARVYB { get; set; }
        [JsonProperty("2nd Har VBR")]
        public float SECONDHARVBR { get; set; }
        [JsonProperty("2nd Har IR")]
        public float SECONDHARIR { get; set; }
        [JsonProperty("2nd Har IY")]
        public float SECONDHARIY { get; set; }
        [JsonProperty("2nd Har IB")]
        public float SECONDHARIB { get; set; }
        [JsonProperty("3rd Har VRY")]
        public float THIRDHARVRY { get; set; }
        [JsonProperty("3rd Har VYB")]
        public float THIRDHARVYB { get; set; }
        [JsonProperty("3rd Har VBR")]
        public float THIRDHARVBR { get; set; }
        [JsonProperty("3rd Har IR")]
        public float THIRDHARIR { get; set; }
        [JsonProperty("3rd Har IY")]
        public float THIRDHARIY { get; set; }
        [JsonProperty("3rd Har IB")]
        public float THIRDHARIB { get; set; }
        [JsonProperty("4th Har VRY")]
        public float FOURTHHARVRY { get; set; }
        [JsonProperty("4th Har VYB")]
        public float FOURTHARVYB { get; set; }
        [JsonProperty("4th Har VBR")]
        public float THIRDDHARVBR { get; set; }
        [JsonProperty("4th Har IR")]
        public float FOURTHHARIR { get; set; }
        [JsonProperty("4th Har IY")]
        public float FOURTHHARIY { get; set; }
        [JsonProperty("4th Har IB")]
        public float FOURTHHARIB { get; set; }
        [JsonProperty("5th Har VRY")]
        public float FIFTHHARVRY { get; set; }
        [JsonProperty("5th Har VYB")]
        public float FIFTHHARVYB { get; set; }
        [JsonProperty("5th Har VBR")]
        public float FIFTHHARVBR { get; set; }
        [JsonProperty("5th Har IR")]
        public float FIFTHHARIR { get; set; }
        [JsonProperty("5th Har IY")]
        public float FIFTHHARIY { get; set; }
        [JsonProperty("5th Har IB")]
        public float FIFTHHARIB { get; set; }
        [JsonProperty("6th Har VRY")]
        public float SIXTHHARVRY { get; set; }
        [JsonProperty("6th Har VYB")]
        public float SIXTHHARVYB { get; set; }
        [JsonProperty("6th Har VBR")]
        public float SIXTHHARVBR { get; set; }
        [JsonProperty("6th Har IR")]
        public float SIXTHHARIR { get; set; }
        [JsonProperty("6th Har IY")]
        public float SIXTHHARIY { get; set; }
        [JsonProperty("6th Har IB")]
        public float SIXTHHARIB { get; set; }
        [JsonProperty("7th Har VRY")]
        public float SEVENTHHARVRY { get; set; }
        [JsonProperty("7th Har VYB")]
        public float SEVENTHHARVYB { get; set; }
        [JsonProperty("7th Har VBR")]
        public float SEVENTHHARVBR { get; set; }
        [JsonProperty("7th Har IR")]
        public float SEVENTHHARIR { get; set; }
        [JsonProperty("7th Har IY")]
        public float SEVENTHHARIY { get; set; }
        [JsonProperty("7th Har IB")]
        public float SEVENTHHARIB { get; set; }
        [JsonProperty("8th Har VRY")]
        public float EIGHTHARVRY { get; set; }
        [JsonProperty("8th Har VYB")]
        public float EIGHTHARVYB { get; set; }
        [JsonProperty("8th Har VBR")]
        public float EIGHTHARVBR { get; set; }
        [JsonProperty("8th Har IR")]
        public float EIGHTHARIR { get; set; }
        [JsonProperty("8th Har IY")]
        public float EIGHTHARIY { get; set; }
        [JsonProperty("8th Har IB")]
        public float EIGHTHARIB { get; set; }
        [JsonProperty("9th Har VRY")]
        public float NINTHHARVRY { get; set; }
        [JsonProperty("9th Har VYB")]
        public float NINTHHARVYB { get; set; }
        [JsonProperty("9th Har VBR")]
        public float NINTHHARVBR { get; set; }
        [JsonProperty("9th Har IR")]
        public float NINTHHARIR { get; set; }
        [JsonProperty("9th Har IY")]
        public float NINTHHARIY { get; set; }
        [JsonProperty("9th Har IB")]
        public float NINTHHARIB { get; set; }
        [JsonProperty("10th Har VRY")]
        public float TENTHHARVRY { get; set; }
        [JsonProperty("10th Har VYB")]
        public float TENTHHARVYB { get; set; }
        [JsonProperty("10th Har VBR")]
        public float TENTHHARVBR { get; set; }
        [JsonProperty("10th Har IR")]
        public float TENTHHARIR { get; set; }
        [JsonProperty("10th Har IY")]
        public float TENTHHARIY { get; set; }
        [JsonProperty("10th Har IB")]
        public float TENTHHARIB { get; set; }
        [JsonProperty("11th Har VRY")]
        public float ELEVENTHHARVRY { get; set; }
        [JsonProperty("11th Har VYB")]
        public float ELEVENTHHARVYB { get; set; }
        [JsonProperty("11th Har VBR")]
        public float ELEVENTHHARVBR { get; set; }
        [JsonProperty("11th Har IR")]
        public float ELEVENTHHARIR { get; set; }
        [JsonProperty("11th Har IY")]
        public float ELEVENTHHARIY { get; set; }
        [JsonProperty("11th Har IB")]
        public float ELEVENTHHARIB { get; set; }
        [JsonProperty("12th Har VRY")]
        public float TWELVEHARVRY { get; set; }
        [JsonProperty("12th Har VYB")]
        public float TWELVEHARVYB { get; set; }
        [JsonProperty("12th Har VBR")]
        public float TWELVEHARVBR { get; set; }
        [JsonProperty("12th Har IR")]
        public float TWELVEHARIR { get; set; }
        [JsonProperty("12th Har IY")]
        public float TWELVEHARIY { get; set; }
        [JsonProperty("12th Har IB")]
        public float TWELVEHARIB { get; set; }
        [JsonProperty("13th Har VRY")]
        public float THIRTEENHARVRY { get; set; }
        [JsonProperty("13th Har VYB")]
        public float THIRTEENHARVYB { get; set; }
        [JsonProperty("13th Har VBR")]
        public float THIRTEENHARVBR { get; set; }
        [JsonProperty("13th Har IR")]
        public float THIRTEENHARIR { get; set; }
        [JsonProperty("13th Har IY")]
        public float THIRTEENHARIY { get; set; }
        [JsonProperty("13th Har IB")]
        public float THIRTEENHARIB { get; set; }
        [JsonProperty("14th Har VRY")]
        public float FOURTEENHARVRY { get; set; }
        [JsonProperty("14th Har VYB")]
        public float FOURTEENHARVYB { get; set; }
        [JsonProperty("14th Har VBR")]
        public float FOURTEENHARVBR { get; set; }
        [JsonProperty("14th Har IR")]
        public float FOURTEENHARIR { get; set; }
        [JsonProperty("14th Har IY")]
        public float FOURTEENHARIY { get; set; }
        [JsonProperty("14th Har IB")]
        public float FOURTEENHARIB { get; set; }
        [JsonProperty("15th Har VRY")]
        public float FIFTHEENHARVRY { get; set; }
        [JsonProperty("15th Har VYB")]
        public float FIFTHEENHARVYB { get; set; }
        [JsonProperty("15th Har VBR")]
        public float FIFTHEENHARVBR { get; set; }
        [JsonProperty("15th Har IR")]
        public float FIFTHEENHARIR { get; set; }
        [JsonProperty("15th Har IY")]
        public float FIFTHEENHARIY { get; set; }
        [JsonProperty("15th Har IB")]
        public float FIFTHEENHARIB { get; set; }
        [JsonProperty("16th Har VRY")]
        public float SIXTHEENHARVRY { get; set; }
        [JsonProperty("16th Har VYB")]
        public float SIXTHEENHARVYB { get; set; }
        [JsonProperty("16th Har VBR")]
        public float SIXTHEENHARVBR { get; set; }
        [JsonProperty("16th Har IR")]
        public float SIXTHEENHARIR { get; set; }
        [JsonProperty("16th Har IY")]
        public float SIXTHEENHARIY { get; set; }
        [JsonProperty("16th Har IB")]
        public float SIXTHEENHARIB { get; set; }
        [JsonProperty("17th Har VRY")]
        public float SEVENTHEENHARVRY { get; set; }
        [JsonProperty("17th Har VYB")]
        public float SEVENTHEENHARVYB { get; set; }
        [JsonProperty("17th Har VBR")]
        public float SEVENTHEENHARVBR { get; set; }
        [JsonProperty("17th Har IR")]
        public float SEVENTHEENHARIR { get; set; }
        [JsonProperty("17th Har IY")]
        public float SEVENTHEENHARIY { get; set; }
        [JsonProperty("17th Har IB")]
        public float SEVENTHEENHARIB { get; set; }
        [JsonProperty("18th Har VRY")]
        public float EIGHTHEENHARVRY { get; set; }
        [JsonProperty("18th Har VYB")]
        public float EIGHTHEENHARVYB { get; set; }
        [JsonProperty("18th Har VBR")]
        public float EIGHTHEENHARVBR { get; set; }
        [JsonProperty("18th Har IR")]
        public float EIGHTHEENHARIR { get; set; }
        [JsonProperty("18th Har IY")]
        public float EIGHTHEENHARIY { get; set; }
        [JsonProperty("18th Har IB")]
        public float EIGHTEENHARIB { get; set; }
        [JsonProperty("19th Har VRY")]
        public float NINTHEENHARVRY { get; set; }
        [JsonProperty("19th Har VYB")]
        public float NINTHEENHARVYB { get; set; }
        [JsonProperty("19th Har VBR")]
        public float NINTHEENHARVBR { get; set; }
        [JsonProperty("19th Har IR")]
        public float NINTHEENHARIR { get; set; }
        [JsonProperty("19th Har IY")]
        public float NINTHEENHARIY { get; set; }
        [JsonProperty("19th Har IB")]
        public float NINTHEENHARIB { get; set; }
        [JsonProperty("20th Har VRY")]
        public float TWENTYHARVRY { get; set; }
        [JsonProperty("20th Har VYB")]
        public float TWENTYHARVYB { get; set; }
        [JsonProperty("20th Har VBR")]
        public float TWENTYHARVBR { get; set; }
        [JsonProperty("20th Har IR")]
        public float TWENTYHARIR { get; set; }
        [JsonProperty("20th Har IY")]
        public float TWENTYHARIY { get; set; }
        [JsonProperty("20th Har IB")]
        public float TWENTYHARIB { get; set; }
        [JsonProperty("21th Har VRY")]
        public float TWENTY1HARVRY { get; set; }
        [JsonProperty("21th Har VYB")]
        public float TWENTY1HARVYB { get; set; }
        [JsonProperty("21th Har VBR")]
        public float TWENTY1HARVBR { get; set; }
        [JsonProperty("21th Har IR")]
        public float TWENTY1HARIR { get; set; }
        [JsonProperty("21th Har IY")]
        public float TWENTY1HARIY { get; set; }
        [JsonProperty("21th Har IB")]
        public float TWENTY1HARIB { get; set; }
        [JsonProperty("22nd Har VRY")]
        public float TWENTY2HARVRY { get; set; }
        [JsonProperty("22nd Har VYB")]
        public float TWENTY2HARVYB { get; set; }
        [JsonProperty("22nd Har VBR")]
        public float TWENTY2HARVBR { get; set; }
        [JsonProperty("22nd Har IR")]
        public float TWENTY2HARIR { get; set; }
        [JsonProperty("22nd Har IY")]
        public float TWENTY2HARIY { get; set; }
        [JsonProperty("22nd Har IB")]
        public float TWENTY2HARIB { get; set; }
        [JsonProperty("23rd Har VRY")]
        public float TWENTY3HARVRY { get; set; }
        [JsonProperty("23rd Har VYB")]
        public float TWENTY3HARVYB { get; set; }
        [JsonProperty("23rd Har VBR")]
        public float TWENTY3HARVBR { get; set; }
        [JsonProperty("23rd Har IR")]
        public float TWENTY3HARIR { get; set; }
        [JsonProperty("23rd Har IY")]
        public float TWENTY3HARIY { get; set; }
        [JsonProperty("23rd Har IB")]
        public float TWENTY3HARIB { get; set; }
        [JsonProperty("24th Har VRY")]
        public float TWENTY4HARVRY { get; set; }
        [JsonProperty("24th Har VYB")]
        public float TWENTY4HARVYB { get; set; }
        [JsonProperty("24th Har VBR")]
        public float TWENTY4HARVBR { get; set; }
        [JsonProperty("24th Har IR")]
        public float TWENTY4HARIR { get; set; }
        [JsonProperty("24th Har IY")]
        public float TWENTY4HARIY { get; set; }
        [JsonProperty("24th Har IB")]
        public float TWENTY4HARIB { get; set; }
        [JsonProperty("25th Har VRY")]
        public float TWENTY5HARVRY { get; set; }
        [JsonProperty("25th Har VYB")]
        public float TWENTY5HARVYB { get; set; }
        [JsonProperty("25th Har VRR")]
        public float TWENTY5HARVBR { get; set; }
        [JsonProperty("25th Har IR")]
        public float TWENTY5HARIR { get; set; }
        [JsonProperty("25th Har IY")]
        public float TWENTY5HARIY { get; set; }
        [JsonProperty("25th Har IB")]
        public float TWENTY5HARIB { get; set; }
        [JsonProperty("26th Har VRY")]
        public float TWENTY6HARVRY { get; set; }
        [JsonProperty("26th Har VYB")]
        public float TWENTY6HARVYB { get; set; }
        [JsonProperty("26th Har VBR")]
        public float TWENTY6HARVBR { get; set; }
        [JsonProperty("26th Har IR")]
        public float TWENTY6HARIR { get; set; }
        [JsonProperty("26th Har IY")]
        public float TWENTY6HARIY { get; set; }
        [JsonProperty("26th Har IB")]
        public float TWENTY6HARIB { get; set; }
        [JsonProperty("27th Har VRY")]
        public float TWENTY7HARVRY { get; set; }
        [JsonProperty("27th Har VYB")]
        public float TWENTY7HARVYB { get; set; }
        [JsonProperty("27th Har VBR")]
        public float TWENTY7HARVBR { get; set; }
        [JsonProperty("27th Har IR")]
        public float TWENTY7HARIR { get; set; }
        [JsonProperty("27th Har IY")]
        public float TWENTY7HARIY { get; set; }
        [JsonProperty("27th Har IB")]
        public float TWENTY7HARIB { get; set; }
        [JsonProperty("28th Har VRY")]
        public float TWENTY8HARVRY { get; set; }
        [JsonProperty("28th Har VYB")]
        public float TWENTY8HARVYB { get; set; }
        [JsonProperty("28th Har VBR")]
        public float TWENTY8HARVBR { get; set; }
        [JsonProperty("28th Har IR")]
        public float TWENTY8HARIR { get; set; }
        [JsonProperty("28th Har IY")]
        public float TWENTY8HARIY { get; set; }
        [JsonProperty("28th Har IB")]
        public float TWENTY8HARIB { get; set; }
        [JsonProperty("29th Har VRY")]
        public float TWENTY9HARVRY { get; set; }
        [JsonProperty("29th Har VYB")]
        public float TWENTY9HARVYB { get; set; }
        [JsonProperty("29th Har VBR")]
        public float TWENTY9HARVBR { get; set; }
        [JsonProperty("29th Har IR")]
        public float TWENTY9HARIR { get; set; }
        [JsonProperty("29th Har IY")]
        public float TWENTY9HARIY { get; set; }
        [JsonProperty("29th Har IB")]
        public float TWENTY9HARIB { get; set; }
        [JsonProperty("30th Har VRY")]
        public float THIRTYHARVRY { get; set; }
        [JsonProperty("30th Har VYB")]
        public float THIRTYHARVYB { get; set; }
        [JsonProperty("30th Har VBR")]
        public float THIRTYHARVBR { get; set; }
        [JsonProperty("30th Har IR")]
        public float THIRTYHARIR { get; set; }
        [JsonProperty("30th Har IY")]
        public float THIRTYHARIY { get; set; }
        [JsonProperty("30th Har IB")]
        public float THIRTYHARIB { get; set; }
        [JsonProperty("31th Har VRY")]
        public float THIRTY1HARVRY { get; set; }
        [JsonProperty("31th Har VYB")]
        public float THIRTY1HARVYB { get; set; }
        [JsonProperty("31th Har VBR")]
        public float THIRTY1HARVBR { get; set; }
        [JsonProperty("31th Har IR")]
        public float THIRTY1HARIR { get; set; }
        [JsonProperty("31th Har IY")]
        public float THIRTY1HARIY { get; set; }
        [JsonProperty("31th Har IB")]
        public float THIRTY1HARIB { get; set; }
        [JsonProperty("32nd Har VRY")]
        public float THIRTY2HARVRY { get; set; }
        [JsonProperty("32nd Har VYB")]
        public float THIRTY2HARVYB { get; set; }
        [JsonProperty("32nd Har VBR")]
        public float THIRTY2HARVBR { get; set; }
        [JsonProperty("32nd Har IR")]
        public float THIRTY2HARIR { get; set; }
        [JsonProperty("32nd Har IY")]
        public float THIRTY2HARIY { get; set; }
        [JsonProperty("32nd Har IB")]
        public float THIRTY2HARIB { get; set; }
        [JsonProperty("33rd Har VRY")]
        public float THIRTY3HARVRY { get; set; }
        [JsonProperty("33rd Har VYB")]
        public float THIRTY3HARVYB { get; set; }
        [JsonProperty("33rd Har VBR")]
        public float THIRTY3HARVBR { get; set; }
        [JsonProperty("33rd Har IR")]
        public float THIRTY3HARIR { get; set; }
        [JsonProperty("33rd Har IY")]
        public float THIRTY3HARIY { get; set; }
        [JsonProperty("33rd Har IB")]
        public float THIRTY3HARIB { get; set; }
        [JsonProperty("Analog Input-1")]
        public float ANALOGINPUT1 { get; set; }
        [JsonProperty("Analog Input-2")]
        public float ANALOGINPUT2 { get; set; }
        [JsonProperty("Analog Input-2")]
        public float ANALOGINPUT21 { get; set; }
        [JsonProperty("Analog Input-3")]
        public float ANALOGINPUT3 { get; set; }
        [JsonProperty("Analog Input-3")]
        public float ANALOGINPUT31 { get; set; }
        [JsonProperty("Analog Input-4")]
        public float ANALOGINPUT4 { get; set; }
        [JsonProperty("Analog Input-4")]
        public float ANALOGINPUT41 { get; set; }
        [JsonProperty("Analog Input-5")]
        public float ANALOGINPUT5 { get; set; }
        [JsonProperty("Analog Input-5")]
        public float ANALOGINPUT51 { get; set; }
        [JsonProperty("Analog Input-6")]
        public float ANALOGINPUT6 { get; set; }
        [JsonProperty("Analog Input-6")]
        public float ANALOGINPUT61 { get; set; }
        [JsonProperty("Analog Input-7")]
        public float ANALOGINPUT7 { get; set; }
        [JsonProperty("Analog Input-7")]
        public float ANALOGINPUT71 { get; set; }
        [JsonProperty("Analog Input-8")]
        public float ANALOGINPUT8 { get; set; }
        [JsonProperty("Analog Input-8")]
        public float ANALOGINPUT81 { get; set; }
        [JsonProperty("Analog Input-9")]
        public float ANALOGINPUT9 { get; set; }
        [JsonProperty("Analog Input-9")]
        public float ANALOGINPUT91 { get; set; }
        [JsonProperty("Analog Input-10")]
        public float ANALOGINPUT10 { get; set; }
        [JsonProperty("Analog Input-10")]
        public float ANALOGINPUT101 { get; set; }
        [JsonProperty("Analog Input-11")]
        public float ANALOGINPUT11 { get; set; }
        [JsonProperty("Analog Input-11")]
        public float ANALOGINPUT111 { get; set; }
        [JsonProperty("Analog Input-12")]
        public float ANALOGINPUT12 { get; set; }
        [JsonProperty("Digital Input-1")]
        public float DIGITALINPUT1 { get; set; }
        [JsonProperty("Digital Input-2")]
        public float DIGITALINPUT2 { get; set; }
        [JsonProperty("Digital Input-2")]
        public float DIGITALINPUT21 { get; set; }
        [JsonProperty("Digital Input-3")]
        public float DIGITALINPUT3 { get; set; }
        [JsonProperty("Digital Input-3")]
        public float DIGITALINPUT31 { get; set; }
        [JsonProperty("Digital Input-4")]
        public float DIGITALINPUT4 { get; set; }
        [JsonProperty("Digital Input-4")]
        public float DIGITALINPUT41 { get; set; }
        [JsonProperty("Digital Input-5")]
        public float DIGITALINPUT5 { get; set; }
        [JsonProperty("Digital Input-5")]
        public float DIGITALINPUT51 { get; set; }
        [JsonProperty("Digital Input-6")]
        public float DIGITALINPUT6 { get; set; }
        [JsonProperty("Digital Input-6")]
        public float DIGITALINPUT61 { get; set; }
        [JsonProperty("Digital Input-7")]
        public float DIGITALINPUT7 { get; set; }
        [JsonProperty("Digital Input-7")]
        public float DIGITALINPUT71 { get; set; }
        [JsonProperty("Digital Input-8")]
        public float DIGITALINPUT8 { get; set; }
        [JsonProperty("Digital Input-8")]
        public float DIGITALINPUT81 { get; set; }
        [JsonProperty("Digital Input-9")]
        public float DIGITALINPUT9 { get; set; }
        [JsonProperty("Digital Input-9")]
        public float DIGITALINPUT91 { get; set; }
        [JsonProperty("Digital Input-10")]
        public float DIGITALINPUT10 { get; set; }
        [JsonProperty("Digital Input-10")]
        public float DIGITALINPUT101 { get; set; }
        [JsonProperty("Digital Input-11")]
        public float DIGITALINPUT11 { get; set; }
        [JsonProperty("Digital Input-11")]
        public float DIGITALINPUT111 { get; set; }
        [JsonProperty("Digital Input-12")]
        public float DIGITALINPUT12 { get; set; }
        [JsonProperty("Digital Output-1")]
        public float DIGITALOUTPUT1 { get; set; }
        [JsonProperty("Digital Output-2")]
        public float DIGITALOUTPUT2 { get; set; }
        [JsonProperty("Digital Output-2")]
        public float DIGITALOUTPUT21 { get; set; }
        [JsonProperty("Digital Output-3")]
        public float DIGITALOUTPUT3 { get; set; }
        [JsonProperty("Digital Output-3")]
        public float DIGITALOUTPUT31 { get; set; }
        [JsonProperty("Digital Output-4")]
        public float DIGITALOUTPUT4 { get; set; }
        [JsonProperty("Digital Output-4")]
        public float DIGITALOUTPUT41 { get; set; }
        [JsonProperty("Digital Output-5")]
        public float DIGITALOUTPUT5 { get; set; }
        [JsonProperty("Digital Output-5")]
        public float DIGITALOUTPUT51 { get; set; }
        [JsonProperty("Digital Output-6")]
        public float DIGITALOUTPUT6 { get; set; }
        [JsonProperty("Digital Output-6")]
        public float DIGITALOUTPUT61 { get; set; }
        [JsonProperty("Digital Output-7")]
        public float DIGITALOUTPUT7 { get; set; }
        [JsonProperty("Digital Output-7")]
        public float DIGITALOUTPUT71 { get; set; }
        [JsonProperty("Digital Output-8")]
        public float DIGITALOUTPUT8 { get; set; }
        [JsonProperty("Digital Output-8")]
        public float DIGITALOUTPUT81 { get; set; }
        [JsonProperty("Digital Output-9")]
        public float DIGITALOUTPUT9 { get; set; }
        [JsonProperty("Digital Output-9")]
        public float DIGITALOUTPUT91 { get; set; }
        [JsonProperty("Digital Output-10")]
        public float DIGITALOUTPUT10 { get; set; }
        [JsonProperty("Digital Output-10")]
        public float DIGITALOUTPUT101 { get; set; }
        [JsonProperty("Digital Output-11")]
        public float DIGITALOUTPUT11 { get; set; }
        [JsonProperty("Digital Output-11")]
        public float DIGITALOUTPUT111 { get; set; }
        [JsonProperty("Digital Output-12")]
        public float DIGITALOUTPUT12 { get; set; }
        [JsonProperty("Pulse Input-1")]
        public float PULSEOUTPUT1 { get; set; }
        [JsonProperty("Pulse Input-2")]
        public float PULSEOUTPUT2 { get; set; }
        [JsonProperty("Pulse Input-3")]
        public float PULSEOUTPUT3 { get; set; }
        [JsonProperty("Pulse Input-4")]
        public float PULSEOUTPUT4 { get; set; }
        [JsonProperty("Pulse Input-5")]
        public float PULSEOUTPUT5 { get; set; }
        [JsonProperty("Pulse Input-6")]
        public float PULSEOUTPUT6 { get; set; }
        [JsonProperty("ABT Block-1")]
        public float ABTBLOCK1 { get; set; }
        [JsonProperty("ABT Block-2")]
        public float ABTBLOCK2 { get; set; }
        [JsonProperty("ABT Block-3")]
        public float ABTBLOCK3 { get; set; }
        [JsonProperty("ABT Block-4")]
        public float ABTBLOCK4 { get; set; }
        [JsonProperty("ABT Block-5")]
        public float ABTBLOCK5 { get; set; }
        [JsonProperty("ABT Block-6")]
        public float ABTBLOCK6 { get; set; }
        [JsonProperty("ABT Block-7")]
        public float ABTBLOCK7 { get; set; }
        [JsonProperty("ABT Block-8")]
        public float ABTBLOCK8 { get; set; }
        [JsonProperty("ABT Block-9")]
        public float ABTBLOCK9 { get; set; }
        [JsonProperty("ABT Block-10")]
        public float ABTBLOCK10 { get; set; }
        [JsonProperty("ABT Block-11")]
        public float ABTBLOCK11 { get; set; }
        [JsonProperty("ABT Block-12")]
        public float ABTBLOCK12 { get; set; }
        [JsonProperty("ABT Block-13")]
        public float ABTBLOCK13 { get; set; }
        [JsonProperty("ABT Block-14")]
        public float ABTBLOCK14 { get; set; }
        [JsonProperty("ABT Block-15")]
        public float ABTBLOCK15 { get; set; }
        [JsonProperty("ABT Block-16")]
        public float ABTBLOCK16 { get; set; }
        [JsonProperty("ABT Block-17")]
        public float ABTBLOCK17 { get; set; }
        [JsonProperty("ABT Block-18")]
        public float ABTBLOCK18 { get; set; }
        [JsonProperty("ABT Block-19")]
        public float ABTBLOCK19 { get; set; }
        [JsonProperty("ABT Block-20")]
        public float ABTBLOCK20 { get; set; }
        [JsonProperty("ABT Block-21")]
        public float ABTBLOCK21 { get; set; }
        [JsonProperty("ABT Block-22")]
        public float ABTBLOCK22 { get; set; }
        [JsonProperty("ABT Block-23")]
        public float ABTBLOCK23 { get; set; }
        [JsonProperty("ABT Block-24")]
        public float ABTBLOCK24 { get; set; }
        [JsonProperty("ABT Block-25")]
        public float ABTBLOCK25 { get; set; }
        [JsonProperty("ABT Block-26")]
        public float ABTBLOCK26 { get; set; }
        [JsonProperty("ABT Block-27")]
        public float ABTBLOCK27 { get; set; }
        [JsonProperty("ABT Block-28")]
        public float ABTBLOCK28 { get; set; }
        [JsonProperty("ABT Block-29")]
        public float ABTBLOCK29 { get; set; }
        [JsonProperty("ABT Block-30")]
        public float ABTBLOCK30 { get; set; }
        [JsonProperty("ABT Block-31")]
        public float ABTBLOCK31 { get; set; }
        [JsonProperty("ABT Block-32")]
        public float ABTBLOCK32 { get; set; }
        [JsonProperty("ABT Block-33")]
        public float ABTBLOCK33 { get; set; }
        [JsonProperty("ABT Block-34")]
        public float ABTBLOCK34 { get; set; }
        [JsonProperty("ABT Block-35")]
        public float ABTBLOCK35 { get; set; }
        [JsonProperty("ABT Block-36")]
        public float ABTBLOCK36 { get; set; }
        [JsonProperty("ABT Block-37")]
        public float ABTBLOCK37 { get; set; }
        [JsonProperty("ABT Block-38")]
        public float ABTBLOCK38 { get; set; }
        [JsonProperty("ABT Block-39")]
        public float ABTBLOCK39 { get; set; }
        [JsonProperty("ABT Block-40")]
        public float ABTBLOCK40 { get; set; }
        [JsonProperty("ABT Block-41")]
        public float ABTBLOCK41 { get; set; }
        [JsonProperty("ABT Block-42")]
        public float ABTBLOCK42 { get; set; }
        [JsonProperty("ABT Block-43")]
        public float ABTBLOCK43 { get; set; }
        [JsonProperty("ABT Block-44")]
        public float ABTBLOCK44 { get; set; }
        [JsonProperty("ABT Block-45")]
        public float ABTBLOCK45 { get; set; }
        [JsonProperty("ABT Block-46")]
        public float ABTBLOCK46 { get; set; }
        [JsonProperty("ABT Block-47")]
        public float ABTBLOCK47 { get; set; }
        [JsonProperty("ABT Block-48")]
        public float ABTBLOCK48 { get; set; }
        [JsonProperty("ABT Block-49")]
        public float ABTBLOCK49 { get; set; }
        [JsonProperty("ABT Block-50")]
        public float ABTBLOCK50 { get; set; }
        [JsonProperty("ABT Block-51")]
        public float ABTBLOCK51 { get; set; }
        [JsonProperty("ABT Block-52")]
        public float ABTBLOCK52 { get; set; }
        [JsonProperty("ABT Block-53")]
        public float ABTBLOCK53 { get; set; }
        [JsonProperty("ABT Block-54")]
        public float ABTBLOCK54 { get; set; }
        [JsonProperty("ABT Block-55")]
        public float ABTBLOCK55 { get; set; }
        [JsonProperty("ABT Block-56")]
        public float ABTBLOCK56 { get; set; }
        [JsonProperty("ABT Block-57")]
        public float ABTBLOCK57 { get; set; }
        [JsonProperty("ABT Block-58")]
        public float ABTBLOCK58 { get; set; }
        [JsonProperty("ABT Block-59")]
        public float ABTBLOCK59 { get; set; }
        [JsonProperty("ABT Block-60")]
        public float ABTBLOCK60 { get; set; }
        [JsonProperty("ABT Block-61")]
        public float ABTBLOCK61 { get; set; }
        [JsonProperty("ABT Block-62")]
        public float ABTBLOCK62 { get; set; }
        [JsonProperty("ABT Block-63")]
        public float ABTBLOCK63 { get; set; }
        [JsonProperty("ABT Block-64")]
        public float ABTBLOCK64 { get; set; }
        [JsonProperty("ABT Block-65")]
        public float ABTBLOCK65 { get; set; }
        [JsonProperty("ABT Block-66")]
        public float ABTBLOCK66 { get; set; }
        [JsonProperty("ABT Block-67")]
        public float ABTBLOCK67 { get; set; }
        [JsonProperty("ABT Block-68")]
        public float ABTBLOCK68 { get; set; }
        [JsonProperty("ABT Block-69")]
        public float ABTBLOCK69 { get; set; }
        [JsonProperty("ABT Block-70")]
        public float ABTBLOCK70 { get; set; }
        [JsonProperty("ABT Block-71")]
        public float ABTBLOCK71 { get; set; }
        [JsonProperty("ABT Block-72")]
        public float ABTBLOCK72 { get; set; }
        [JsonProperty("ABT Block-73")]
        public float ABTBLOCK73 { get; set; }
        [JsonProperty("ABT Block-74")]
        public float ABTBLOCK74 { get; set; }
        [JsonProperty("ABT Block-75")]
        public float ABTBLOCK75 { get; set; }
        [JsonProperty("ABT Block-76")]
        public float ABTBLOCK76 { get; set; }
        [JsonProperty("ABT Block-77")]
        public float ABTBLOCK77 { get; set; }
        [JsonProperty("ABT Block-78")]
        public float ABTBLOCK78 { get; set; }
        [JsonProperty("ABT Block-79")]
        public float ABTBLOCK79 { get; set; }
        [JsonProperty("ABT Block-80")]
        public float ABTBLOCK80 { get; set; }
        [JsonProperty("ABT Block-81")]
        public float ABTBLOCK81 { get; set; }
        [JsonProperty("ABT Block-82")]
        public float ABTBLOCK82 { get; set; }
        [JsonProperty("ABT Block-83")]
        public float ABTBLOCK83 { get; set; }
        [JsonProperty("ABT Block-84")]
        public float ABTBLOCK84 { get; set; }
        [JsonProperty("ABT Block-85")]
        public float ABTBLOCK85 { get; set; }
        [JsonProperty("ABT Block-86")]
        public float ABTBLOCK86 { get; set; }
        [JsonProperty("ABT Block-87")]
        public float ABTBLOCK87 { get; set; }
        [JsonProperty("ABT Block-88")]
        public float ABTBLOCK88 { get; set; }
        [JsonProperty("ABT Block-89")]
        public float ABTBLOCK89 { get; set; }
        [JsonProperty("ABT Block-90")]
        public float ABTBLOCK90 { get; set; }
        [JsonProperty("ABT Block-91")]
        public float ABTBLOCK91 { get; set; }
        [JsonProperty("ABT Block-92")]
        public float ABTBLOCK92 { get; set; }
        [JsonProperty("ABT Block-93")]
        public float ABTBLOCK93 { get; set; }
        [JsonProperty("ABT Block-94")]
        public float ABTBLOCK94 { get; set; }
        [JsonProperty("ABT Block-95")]
        public float ABTBLOCK95 { get; set; }
        [JsonProperty("ABT Block-96")]
        public float ABTBLOCK96 { get; set; }
    }
}
