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

            element = browser.FindElement(By.XPath(xpathbutton));
            element.Click();
            // Reports.AddLogPass("Actual Result1: Нажатие на кнопку 'Найти' завершилось успешно");

            element = browser.FindElement(By.XPath(xpathsearchresult));
            if (element.Text == expectedresult)
            {
                Assert.Pass("Текст 'Не заданы параметра поиска' присутствует");
                // Reports.AddLogPass("Actual Result2: Текст содержит: " + element.Text);
            }
            else Assert.Fail("Текст 'Не заданы параметра поиска' отсутствует");
            // Reports.AddLogFail("Actual Result: Текст не содержит: " + element.Text);

        }

        // Поиск по бренду
        public void TiresSearch(BrandName brandname)
        {
            string xpathselectlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            string xpathselectoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";
            string xpathbutton = ".//*[@id='filt_sub']";

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

            Wait.ElementIsVisible(xpathbutton);

            element = browser.FindElement(By.XPath(xpathbutton));
            if (element != null)
            {
                Wait.ElementToBeClickable(xpathbutton);
                element.Click();
            }
            else Assert.Fail("Кнопка не активна");

            SearchResult(".//div[@class='tires_catalog_search']//a[@class='tires_catalog_name']");
        }

        // Поиск по ширине (+ бренду)

        public void TiresSearch(BrandName brandname, TireWidth width)
        {
            string selectwidthlist = ".//div[@class='form f1']//div[@class='pseudo-select fl_left']";
            string selectwidthoption = ".//div[@class='form f1']//div[@class='pseudo-select fl_left']//div[@class='options']//div";
            string xpathbutton = ".//*[@id='filt_sub']";

            element = browser.FindElement(By.XPath(selectwidthlist));
            element.Click();

            Wait.ElementIsVisible(selectwidthoption);

            List<IWebElement> widthlist = browser.FindElements(By.XPath(selectwidthoption)).ToList();
            for (int i = 0; i < widthlist.Count; i++)
            {
                if (widthlist[i].Text == EnumParse.EnumTireWidth(width))
                {
                    element.Click();
                    break;
                }
                if(i > 40)
                {
                    break;
                }
            }

            element = browser.FindElement(By.XPath(xpathbutton));
            if (element != null)
            {
                Wait.ElementToBeClickable(xpathbutton);
                element.Click();
            }
            else Assert.Fail("Кнопка не активна");

            
            
        }

        // Проверка результатов поиска
            public void SearchResult(string xpathtireslist)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathtireslist)).ToList();
            if (tireslist != null)
            {
                Assert.Pass("Список шин указанного бренда не пустой");
            }
            else Assert.Fail("Список шин указанного бренда пустой");
        }

        // Возвращение значений ширины шин
     }
  }