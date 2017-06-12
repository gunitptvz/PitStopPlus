using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.PitStop_
{
    public class EnumParse : DataClass
    {
        public static string EnumTireWidth(TireWidth a)
        {
            switch (a)
            {
                case TireWidth.seven_point_five:
                    {
                        return "7,5";
                    }
                case TireWidth.twelve:
                    {
                        return "12";
                    }
                case TireWidth.thirty:
                    {
                        return "30";
                    }
                case TireWidth.thirty_by_nine_point_five:
                    {
                        return "30X9.5";
                    }
                case TireWidth.thirtyone:
                    {
                        return "31";
                    }
                case TireWidth.thirtyone_by_ten_point_five:
                    {
                        return "31X10.5";
                    }
                case TireWidth.thirtyone_by_ten_point_fifty:
                    {
                        return "31X10.50";
                    }
                case TireWidth.thirtytwo:
                    {
                        return "32";
                    }
                case TireWidth.thirtytwo_by_eleven_point_five:
                    {
                        return "32X11.5";
                    }
                case TireWidth.thirtytwo_by_eleven_point_fifty:
                    {
                        return "32X11.50";
                    }
                case TireWidth.thirtythree:
                    {
                        return "33";
                    }
                case TireWidth.thirtythree_by_twelve_point_five:
                    {
                        return "33X12.5";
                    }
                case TireWidth.thirtythree_by_twelve_point_fifty:
                    {
                        return "33X12.50";
                    }
                case TireWidth.thirtyfive:
                    {
                        return "35";
                    }
                case TireWidth.thirtyfive_by_twelve_point_five:
                    {
                        return "35X12.5";
                    }
                case TireWidth.thirtyseven:
                    {
                        return "37";
                    }
                case TireWidth.one_hundred_thirtyfive:
                    {
                        return "135";
                    }
                case TireWidth.one_hundred_fourtyfive:
                    {
                        return "145";
                    }
                case TireWidth.one_hundred_fiftyfive:
                    {
                        return "155";
                    }
                case TireWidth.one_hundred_sixtyfive:
                    {
                        return "165";
                    }
                case TireWidth.one_hundred_seventyfive:
                    {
                        return "175";
                    }
                case TireWidth.one_hundred_eightyfive:
                    {
                        return "185";
                    }
                case TireWidth.one_hundred_ninty:
                    {
                        return "190";
                    }
                case TireWidth.one_hundred_nintyfive:
                    {
                        return "195";
                    }
                case TireWidth.two_hundred_five:
                    {
                        return "205";
                    }
                case TireWidth.two_hundred_fifteen:
                    {
                        return "215";
                    }
                case TireWidth.two_hundred_twentyfive:
                    {
                        return "225";
                    }
                case TireWidth.two_hundred_thirtyfive:
                    {
                        return "235";
                    }
                case TireWidth.two_hundred_fourty:
                    {
                        return "240";
                    }
                case TireWidth.two_hundred_fourtyfive:
                    {
                        return "245";
                    }
                case TireWidth.two_hundred_fiftyfive:
                    {
                        return "255";
                    }
                case TireWidth.two_hundred_sixtyfive:
                    {
                        return "265";
                    }
                case TireWidth.two_hundred_seventyfive:
                    {
                        return "275";
                    }
                case TireWidth.two_hundred_eightyfive:
                    {
                        return "285";
                    }
                case TireWidth.two_hundred_nintyfive:
                    {
                        return "295";
                    }
                case TireWidth.three_hundred_five:
                    {
                        return "305";
                    }
                case TireWidth.three_hundred_fifteen:
                    {
                        return "315";
                    }
                case TireWidth.three_hundred_twentyfive:
                    {
                        return "325";
                    }
                case TireWidth.three_hundred_thirtyfive:
                    {
                        return "335";
                    }
                case TireWidth.three_hundred_fiftyfive:
                    {
                        return "355";
                    }
            }

            return "0";
        }
    }
}
