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
        public void TiresSearch()
        {
            string xpathsearchresult = ".//*[@id='filter-result']";
            string expectedresult = "Не заданы параметры поиска";
            string xpathbutton = ".//*[@id='filt_sub']";

            try
            {
                element = browser.FindElement(By.XPath(xpathbutton));
                element.Click();
                Reports.AddLogPass("Actual Result1: Нажатие на кнопку 'Найти' завершилось успешно");

                element = browser.FindElement(By.XPath(xpathsearchresult));
                if (element.Text == expectedresult)
                {
                    Reports.AddLogPass("Actual Result2: Текст содержит: " + element.Text);
                }
                else Reports.AddLogFail("Actual Result: Текст не содержит: " + element.Text);
            }
            catch(Exception e)
            {
                Reports.AddLogFail("Error Message: " + e.Message);
            }
            
        }

        // Поиск по бренду
        public void TiresSearch(Enum brandname)
        {
            string xpathselectlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            string xpathselectoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";
            string xpathbutton = ".//*[@id='filt_sub']";
            string xpathtireslist = ".//div[@class='tires_catalog_search']//a[@class='tires_catalog_name']";

            try
            {
                element = browser.FindElement(By.XPath(xpathselectlist));
                element.Click();

                Wait.ElementIsVisible(xpathselectoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);

                element = browser.FindElement(By.XPath(xpathbutton));
                element.Click();

                List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathtireslist)).ToList();
                if (tireslist != null)
                {
                    Reports.AddLogPass("Actual Result: Список шин данного бренда присутствует");
                }
                else Reports.AddLogFail("Actual Result: Список шин не обнаружен");
            }
            catch (Exception e)
            {
                Reports.AddLogFail("Error Message: " + e.Message);
            }
            }
        }

        /* public void TiresSearch(Enum brandname, string a)
        {

        } */
    }