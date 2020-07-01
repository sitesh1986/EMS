using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMS.Common.ViewModels.ParameterMapping
{
    public class HarmonicsParameterViewModel
    {
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
    }
}
