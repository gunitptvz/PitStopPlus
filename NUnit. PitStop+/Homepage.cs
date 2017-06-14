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
    public class Homepage : DataClass
    {
        public class TiresSelection
        {
            // Data
            string xpathbutton = ".//*[@id='filt_sub']";
            string xpathsearchresultlist = ".//div[@class='tires_catalog_search']//a[@class='tires_catalog_name']";

            string xpathsearchresult = ".//*[@id='filter-result']";
            string expectedresult = "Не заданы параметры поиска";

            string xpathselectbrandtlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            string xpathselectbrandoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";

            string xpathselectwidthlist = ".//div[@class='form f1']//fieldset[1]/div[2]";
            string xpathselectwidthoption = ".//div[@class='form f1']//div[2]//div[@class='options']//div";

            string xpathselectdiameterlist = ".//div[@class='form f1']//fieldset[1]/div[5]";
            string xpathselectdiameteroption = ".//div[@class='form f1']//div[5]//div[@class='options']//div";

            string xpathselectprofilelist = ".//div[@class='form f1']//fieldset[1]/div[3]";
            string xpathselectprofileoption = ".//div[@class='form f1']//div[3]//div[@class='options']//div";

            string xpathselectseasonlist = ".//div[@class='form f1']//fieldset[1]/div[6]";
            string xpathselectseasonoption = ".//div[@class='form f1']//div[6]//div[@class='options']//div";

            string xpathselectthornlist = ".//div[@class='pseudo-select']";
            string xpathselectthornoption = ".//div[@class='pseudo-select']//div[@class='options']//div";


            // Search parameters isn't exist warning check
            public void TiresSearch()
            {
                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                // Reports.AddLogPass("Actual Result1: Нажатие на кнопку 'Найти' завершилось успешно");

                Wait.ElementIsVisible(xpathsearchresult);
                element = browser.FindElement(By.XPath(xpathsearchresult));
                if (element.Text == expectedresult)
                {
                    Assert.Pass("Текст 'Не заданы параметра поиска' присутствует");
                    // Reports.AddLogPass("Actual Result2: Текст содержит: " + element.Text);
                }
                else Assert.Fail("Текст 'Не заданы параметра поиска' отсутствует");
                // Reports.AddLogFail("Actual Result: Текст не содержит: " + element.Text);
            }

            // Search by TiresBrand
            public void TiresSearch(BrandName brandname)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by TiresWidth
            public void TiresSearch(TireWidth width)
            {
                Wait.ElementToBeClickable(xpathselectwidthlist);
                WebBrowser.ElementClick(xpathselectwidthlist);
                Wait.ElementIsVisible(xpathselectwidthoption);

                List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
                foreach (IWebElement element in widthlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by TiresDiameter
            public void TiresSearch(TireDiameter diameter)
            {
                Wait.ElementToBeClickable(xpathselectdiameterlist);
                WebBrowser.ElementClick(xpathselectdiameterlist);
                Wait.ElementIsVisible(xpathselectdiameteroption);

                List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
                foreach (IWebElement element in diameterlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by TiresProfile
            public void TiresSearch(TireProfile profile)
            {
                Wait.ElementToBeClickable(xpathselectprofilelist);
                WebBrowser.ElementClick(xpathselectprofilelist);
                Wait.ElementIsVisible(xpathselectprofileoption);

                List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
                foreach (IWebElement element in diameterlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Season
            public void TiresSearch(TireSeason season)
            {
                Wait.ElementToBeClickable(xpathselectseasonlist);
                WebBrowser.ElementClick(xpathselectseasonlist);
                Wait.ElementIsVisible(xpathselectseasonoption);

                List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

                foreach (IWebElement element in seasonlist)
                {
                    if (element.Text.Contains(season.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Winter Season
            public void TiresSearch(TireSeason wintertires, Studdedtires thorn)
            {
                Wait.ElementToBeClickable(xpathselectseasonlist);
                WebBrowser.ElementClick(xpathselectseasonlist);
                Wait.ElementIsVisible(xpathselectseasonoption);

                List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

                foreach (IWebElement element in seasonlist)
                {
                    if (element.Text.Contains(wintertires.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectthornlist);
                WebBrowser.ElementClick(xpathselectthornlist);
                Wait.ElementIsVisible(xpathselectthornoption);

                List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

                foreach (IWebElement element in thornlist)
                {
                    if (element.Text.Contains(thorn.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Brand + Widht
            public void TiresSearch(BrandName brandname, TireWidth width)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectwidthlist);
                WebBrowser.ElementClick(xpathselectwidthlist);
                Wait.ElementIsVisible(xpathselectwidthoption);

                List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
                foreach (IWebElement element in widthlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Brand + Profile
            public void TiresSearch(BrandName brandname, TireProfile profile)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectprofilelist);
                WebBrowser.ElementClick(xpathselectprofilelist);
                Wait.ElementIsVisible(xpathselectprofileoption);

                List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
                foreach (IWebElement element in diameterlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Brand + Diameter
            public void TiresSearch(BrandName brandname, TireDiameter diameter)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectdiameterlist);
                WebBrowser.ElementClick(xpathselectdiameterlist);
                Wait.ElementIsVisible(xpathselectdiameteroption);

                List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
                foreach (IWebElement element in diameterlist)
                {
                    if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Brand + Season
            public void TiresSearch(BrandName brandname, TireSeason season)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectseasonlist);
                WebBrowser.ElementClick(xpathselectseasonlist);
                Wait.ElementIsVisible(xpathselectseasonoption);

                List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

                foreach (IWebElement element in seasonlist)
                {
                    if (element.Text.Contains(season.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Brand + Winter Season + Thorn
            public void TiresSearch(BrandName brandname, TireSeason wintertires, Studdedtires thorn)
            {
                Wait.ElementToBeClickable(xpathselectbrandtlist);
                WebBrowser.ElementClick(xpathselectbrandtlist);
                Wait.ElementIsVisible(xpathselectbrandoption);

                List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
                foreach (IWebElement element in brand)
                {
                    if (element.Text.Contains(brandname.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectseasonlist);
                WebBrowser.ElementClick(xpathselectseasonlist);
                Wait.ElementIsVisible(xpathselectseasonoption);

                List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

                foreach (IWebElement element in seasonlist)
                {
                    if (element.Text.Contains(wintertires.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathselectthornlist);
                WebBrowser.ElementClick(xpathselectthornlist);
                Wait.ElementIsVisible(xpathselectthornoption);

                List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

                foreach (IWebElement element in thornlist)
                {
                    if (element.Text.Contains(thorn.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                Wait.ElementToBeClickable(xpathbutton);
                WebBrowser.ButtonClick(xpathbutton);
                SearchResult(xpathsearchresultlist);
            }

            // Search by Width + Profile

            // Search by Width + Diameter

            // Search by Width + Season

            // Search by Width + Winter Season + Thorn


            // Search result check
            public void SearchResult(string xpathresultlist)
            {
                List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
                if (tireslist.Count != 0)
                {
                    Assert.Pass("Список шин указанного бренда не пустой");
                }
                else Assert.Fail("Список шин указанного бренда пустой");
            }
        }

        public class WheelsSelection
        {

        }

        public class SelectionByCar
        {

        }
    }
}
