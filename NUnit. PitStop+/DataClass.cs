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
        public static IWebElement element;

        public static ExtentReports extent;
        public static ExtentTest test;

        // Enum Tires brand
        public enum BrandName
        {
            производитель,
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
            ширина,
            w7comma5,
            w12,
            w30,
            w30X9dot5,
            w31,
            w31X10dot5,
            w31X10dot50,
            w32,
            w32X11dot5,
            w32X11dot50,
            w33,
            w33X12dot5,
            w33X12dot50,
            w35,
            w35X12dot5,
            w37,
            w135,
            w145,
            w155,
            w165,
            w175,
            w185,
            w190,
            w195,
            w205,
            w215,
            w225,
            w235,
            w240,
            w245,
            w255,
            w265,
            w275,
            w285,
            w295,
            w305,
            w315,
            w325,
            w335,
            w355
        }

        // Enum Tires diameter
        public enum TireDiameter
        {
            диаметр,
            R,
            R12,
            R12C,
            R13,
            R13C,
            R14,
            R14C,
            R15,
            R15C,
            R16,
            R16C,
            R17,
            R17comma5,
            R17dot5,
            R17dot5C,
            R17C,
            R18,
            R19,
            R19dot5,
            R20,
            R21,
            R22,
            R22comma5,
            R22dot5,
            R23,
            R24,
            R25,
            R26,
            R28,
            R32
        }

        // Enum Tires profile
        public enum TireProfile
        {
            профиль,
            p0,
            p9comma5,
            p9dot50,
            p10comma5,
            p11comma5,
            p12comma5,
            p25,
            p30,
            p35,
            p40,
            p45,
            p50,
            p55,
            p60,
            p65,
            p70,
            p75,
            p80,
            p85,
            p100,
            p560,
            p580,
            p610,
            p650
        }

        public enum TireSeason
        {
            сезон,
            Летние,
            Зимние,
            Всесезонные,
            Лето,
            Зима,
            спорт,
            грузовые
        }

        public enum Studdedtires
        {
            шипы,
            Да,
            Нет,
            Есть
        }
    }
        
    }
