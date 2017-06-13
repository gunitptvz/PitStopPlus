using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.PitStop_
{
    public class EnumParse : DataClass
    {
        public static string EnumTireWidth(TireWidth width)
        {
            switch (width)
            {
                case TireWidth.ширина:
                    {
                        return "ширина";
                    }
                case TireWidth.w7comma5:
                    {
                        return "7,5";
                    }
                case TireWidth.w12:
                    {
                        return "12";
                    }
                case TireWidth.w30:
                    {
                        return "30";
                    }
                case TireWidth.w30X9dot5:
                    {
                        return "30X9.5";
                    }
                case TireWidth.w31:
                    {
                        return "31";
                    }
                case TireWidth.w31X10dot5:
                    {
                        return "31X10.5";
                    }
                case TireWidth.w31X10dot50:
                    {
                        return "31X10.50";
                    }
                case TireWidth.w32:
                    {
                        return "32";
                    }
                case TireWidth.w32X11dot5:
                    {
                        return "32X11.5";
                    }
                case TireWidth.w32X11dot50:
                    {
                        return "32X11.50";
                    }
                case TireWidth.w33:
                    {
                        return "33";
                    }
                case TireWidth.w33X12dot5:
                    {
                        return "33X12.5";
                    }
                case TireWidth.w33X12dot50:
                    {
                        return "33X12.50";
                    }
                case TireWidth.w35:
                    {
                        return "35";
                    }
                case TireWidth.w35X12dot5:
                    {
                        return "35X12.5";
                    }
                case TireWidth.w37:
                    {
                        return "37";
                    }
                case TireWidth.w135:
                    {
                        return "135";
                    }
                case TireWidth.w145:
                    {
                        return "145";
                    }
                case TireWidth.w155:
                    {
                        return "155";
                    }
                case TireWidth.w165:
                    {
                        return "165";
                    }
                case TireWidth.w175:
                    {
                        return "175";
                    }
                case TireWidth.w185:
                    {
                        return "185";
                    }
                case TireWidth.w190:
                    {
                        return "190";
                    }
                case TireWidth.w195:
                    {
                        return "195";
                    }
                case TireWidth.w205:
                    {
                        return "205";
                    }
                case TireWidth.w215:
                    {
                        return "215";
                    }
                case TireWidth.w225:
                    {
                        return "225";
                    }
                case TireWidth.w235:
                    {
                        return "235";
                    }
                case TireWidth.w240:
                    {
                        return "240";
                    }
                case TireWidth.w245:
                    {
                        return "245";
                    }
                case TireWidth.w255:
                    {
                        return "255";
                    }
                case TireWidth.w265:
                    {
                        return "265";
                    }
                case TireWidth.w275:
                    {
                        return "275";
                    }
                case TireWidth.w285:
                    {
                        return "285";
                    }
                case TireWidth.w295:
                    {
                        return "295";
                    }
                case TireWidth.w305:
                    {
                        return "305";
                    }
                case TireWidth.w315:
                    {
                        return "315";
                    }
                case TireWidth.w325:
                    {
                        return "325";
                    }
                case TireWidth.w335:
                    {
                        return "335";
                    }
                case TireWidth.w355:
                    {
                        return "355";
                    }
            }

            return "0";
        }

        public static string EnumTireDiameter(TireDiameter diameter)
        {
            switch (diameter)
            {
                case TireDiameter.диаметр:
                    {
                        return "диаметр";
                    }
                case TireDiameter.R:
                    {
                        return "R";
                    }
                case TireDiameter.R12:
                    {
                        return "R12";
                    }
                case TireDiameter.R12C:
                    {
                        return "R12C";
                    }
                case TireDiameter.R13:
                    {
                        return "R13";
                    }
                case TireDiameter.R13C:
                    {
                        return "R13C";
                    }
                case TireDiameter.R14:
                    {
                        return "R14";
                    }
                case TireDiameter.R14C:
                    {
                        return "R14C";
                    }
                case TireDiameter.R15:
                    {
                        return "R15";
                    }
                case TireDiameter.R15C:
                    {
                        return "R15C";
                    }
                case TireDiameter.R16:
                    {
                        return "R16";
                    }
                case TireDiameter.R16C:
                    {
                        return "R16C";
                    }
                case TireDiameter.R17:
                    {
                        return "R17";
                    }
                case TireDiameter.R17comma5:
                    {
                        return "R17,5";
                    }
                case TireDiameter.R17dot5:
                    {
                        return "R17.5";
                    }
                case TireDiameter.R17dot5C:
                    {
                        return "R17.5C";
                    }
                case TireDiameter.R17C:
                    {
                        return "R17C";
                    }
                case TireDiameter.R18:
                    {
                        return "R18";
                    }
                case TireDiameter.R19:
                    {
                        return "R19";
                    }
                case TireDiameter.R19dot5:
                    {
                        return "R19.5";
                    }
                case TireDiameter.R20:
                    {
                        return "R20";
                    }
                case TireDiameter.R21:
                    {
                        return "R21";
                    }
                case TireDiameter.R22:
                    {
                        return "R22";
                    }
                case TireDiameter.R22comma5:
                    {
                        return "R22,5";
                    }
                case TireDiameter.R22dot5:
                    {
                        return "R22.5";
                    }
                case TireDiameter.R23:
                    {
                        return "R23";
                    }
                case TireDiameter.R24:
                    {
                        return "R24";
                    }
                case TireDiameter.R25:
                    {
                        return "R25";
                    }
                case TireDiameter.R26:
                    {
                        return "R26";
                    }
                case TireDiameter.R28:
                    {
                        return "R28";
                    }
                case TireDiameter.R32:
                    {
                        return "R32";
                    }
            }
            return "0";
        }
    }
}
