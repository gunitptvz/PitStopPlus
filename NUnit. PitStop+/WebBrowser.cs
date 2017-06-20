using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using NUnit.Framework.Interfaces;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnit.PitStop_
{
    class WebBrowser : DataClass
    {
        public static void Openbrowser()
        {
            browser = new ChromeDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("http://pitstopplus.ru/");
        }

        public static void Closebrowser()
        {
            Thread.Sleep(1000);
            browser.Quit();
        }

        public static void ButtonClick(string xpath)
        {
            Wait.ElementIsVisible(xpath);
            element = browser.FindElement(By.XPath(xpath));
            if (element != null)
            {
                Wait.ElementToBeClickable(xpath);
                element.Click();
            }
            else Assert.Fail("Кнопка не активна");
        }

        public static void ElementClick(string xpath)
        {
            Wait.ElementIsVisible(xpath);
            element = browser.FindElement(By.XPath(xpath));
            Wait.ElementToBeClickable(xpath);
            element.Click();
        }
    }
}
