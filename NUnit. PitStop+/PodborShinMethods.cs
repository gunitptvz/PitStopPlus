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
    public class PodborShinMethods : DataClass
    {
        // Поиск шин по бренду
        public void BrandFind(string brandname)
        {
            string xpathselectlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            string xpathselectoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";

            Reports.StartTestReport("Выбор бренда шин", "Подбор бренда шин на главной странице");
            Reports.AddLog("Подбор бренда шин на главной странице");

            element = browser.FindElement(By.XPath(xpathselectlist));
            element.Click();
            
            Wait.ElementIsVisible(xpathselectoption);

            List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectoption)).ToList();
            foreach(IWebElement element in brand)
            {
                if(element.Text == brandname)
                {
                    element.Click();
                    break;
                }
            }
            Reports.AddLog(element.Text);
        }
    }
}
