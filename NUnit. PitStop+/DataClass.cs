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

    // Enum Tires brand
    enum BrandName
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

    public class DataClass
    {
        // DATA

        public static IWebDriver browser;
        public IWebElement element;

        public static ExtentReports extent;
        public static ExtentTest test;
    }
        
    }
