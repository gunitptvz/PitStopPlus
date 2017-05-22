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
        // ПОИСК ШИН

        // Проверка предупреждения об отсутствии параметров поиска
        public void TiresFind()
        {
            string xpathbutton = ".//*[@id='filt_sub']";
            string xpathsearchresult = ".//*[@id='filter-result']";
            string expectedresult = "Абракадабра";

            try
            {
                element = browser.FindElement(By.XPath(xpathbutton));
                Reports.AddLogPass("Actual Result1: Кнопка 'Найти' найдена");

                element.Click();
                Reports.AddLogPass("Actual Result2: Нажитие на кнопку 'Найти' завершилось успешно");

                element = browser.FindElement(By.XPath(xpathsearchresult));
                Reports.AddLogPass("Actual Result3: " + element.Text);

                if (element.Text.Contains(expectedresult))
                {
                    Reports.AddLogPass("Actual Result4: Текст содержит: " + element.Text);
                }
                else Reports.AddLogFail("Actual Result: Текст не содержит: " + element.Text);
            }
            catch(Exception e)
            {
                Reports.AddLogFail("Actual Result: " + e.Message);
            }
            
        }

        // Поиск по бренду
        public void TiresFind(Enum brandname)
        {
            string xpathselectlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            string xpathselectoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";

            element = browser.FindElement(By.XPath(xpathselectlist));
            element.Click();
            
            Wait.ElementIsVisible(xpathselectoption);

            List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectoption)).ToList();
            foreach(IWebElement element in brand)
            {
                if(element.Text.Contains(brandname.ToString()))
                {
                    element.Click();
                    Reports.AddLog("Actual Result: " + element.Text);
                    break;
                }
            }
        }

        public void TiresFind(string tirewidth)
        {

        }
    }
}
