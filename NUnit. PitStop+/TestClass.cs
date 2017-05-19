using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NUnit.PitStop_
{
    [TestFixture]
    public class TestClass : DataClass
    {
        [Test] // Подбор шин на главной странице
        public void TestMethod()
        {
            element = browser.FindElement(By.XPath(".//*[@class='pseudo-select w313']"));
            element.Click();
            element = browser.FindElement(By.XPath(".//div[@class='pseudo-select w313']//div[@class='options']//div[@value='8793']"));
            element.Click();


            

        }

        [SetUp]
        public void Openbrowser()
        {
            browser = new FirefoxDriver();
            browser.Manage().Window.Maximize();
            browser.Navigate().GoToUrl("http://pitstopplus.ru/");
        }

        [TearDown]
        public void Closebrowser()
        {
           // browser.Quit();
        }
    }
}
