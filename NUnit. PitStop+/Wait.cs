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
    public class Wait : DataClass
    {
        // Задержка времени
        public static void ElementIsVisible(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(browser, TimeSpan.FromSeconds(15));
            IWebElement txt = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
        }
    }
}
