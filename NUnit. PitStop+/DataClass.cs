using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnit.PitStop_
{
    public class DataClass
    {
        // DATA

        public static IWebDriver browser;
        public IWebElement element;

        public static ExtentReports extent;
        public static ExtentTest test;

        // Enum Tires brand
        public enum BrandName
        {
            Achilles,
            BFGoodrich,
            Bridgestone,
            Continental,
            Cooper,
            Dunlop,
            Gislaved,
            Goodyear,
            Hankook,
            Kumho,
            MATADOR,
            Michelin,
            Nokian,
            Roadstone,
            Tigar,
            Yokohama
        }

        // Enum Tires width
        public enum TireWidth
        {
            seven_point_five,
            twelve,
            thirty,
            thirty_by_nine_point_five,
            thirtyone,
            thirtyone_by_ten_point_five,
            thirtyone_by_ten_point_fifty,
            thirtytwo,
            thirtytwo_by_eleven_point_five,
            thirtytwo_by_eleven_point_fifty,
            thirtythree,
            thirtythree_by_twelve_point_five,
            thirtythree_by_twelve_point_fifty,
            thirtyfive,
            thirtyfive_by_twelve_point_five,
            thirtyseven,
            one_hundred_thirtyfive,
            one_hundred_fourtyfive,
            one_hundred_fiftyfive,
            one_hundred_sixtyfive,
            one_hundred_seventyfive,
            one_hundred_eightyfive,
            one_hundred_ninty,
            one_hundred_nintyfive,
            two_hundred_five,
            two_hundred_fifteen,
            two_hundred_twentyfive,
            two_hundred_thirtyfive,
            two_hundred_fourty,
            two_hundred_fourtyfive,
            two_hundred_fiftyfive,
            two_hundred_sixtyfive,
            two_hundred_seventyfive,
            two_hundred_eightyfive,
            two_hundred_nintyfive,
            three_hundred_five,
            three_hundred_fifteen,
            three_hundred_twentyfive,
            three_hundred_thirtyfive,
            three_hundred_fiftyfive,
        }
    }
        
    }
