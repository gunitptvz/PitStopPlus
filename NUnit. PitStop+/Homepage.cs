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
        // Data
        string xpathsearchresult = ".//*[@id='filter-result']";
        string expectedresult = "Не заданы параметры поиска";

        string xpathtirebutton = ".//*[@id='filt_sub']";
        string xpathwheelbutton = ".//div[@class='form f3']//button[1]";
        string xpathcarbutton = ".//div[@class='form f2']//button[1]";

        string xpathresultlist = ".//div[@class='tires_catalog_search']//a[@class='tires_catalog_name']";

        string xpathwheelselect = ".//p[@class='filter_h pd_bord']";
        string xpathcarselect = ".//div[@class='tab last selected expanded']//p[1]";

        // Result list is(not) empty
        public void SearchResult()
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            if (tireslist.Count != 0)
            {
                Assert.Pass("Список шин указанного бренда не пустой");
            }
            else Assert.Fail("Список шин указанного бренда пустой");
        }

        // Result list contains incoming parameters
        // 1 parameter
        public void SearchResult(string param1)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1))
                    {
                        Assert.Pass("Список содержит заданный параметр");
                    }
                    else Assert.Fail("Список не содержит заданного параметра");
                }
                else
                {
                    Assert.Pass("Список пустой");
                    break;
                }
            }
        }

        // 2 parameters
        public void SearchResult(string param1, string param2)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else
                {
                    Assert.Pass("Список пустой");
                    break;
                }
            }
        }

        // 3 parameters
        public void SearchResult(string param1, string param2, string param3)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2) & element.Text.Contains(param3))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else
                {
                    Assert.Pass("Список пустой");
                    break;
                }
            }
        }

        // 4 parameters
        public void SearchResult(string param1, string param2, string param3, string param4)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2) & element.Text.Contains(param3) & element.Text.Contains(param4))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else
                {
                    Assert.Pass("Список пустой");
                    break;
                }
            }
        }

        // 5 parameters
        public void SearchResult(string param1, string param2, string param3, string param4, string param5)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2) & element.Text.Contains(param3) & element.Text.Contains(param4) & element.Text.Contains(param5))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else
                {
                    Assert.Pass("Список пустой");
                    break;
                }
            }
        }

        // 6 parameters
        public void SearchResult(string param1, string param2, string param3, string param4, string param5, string param6)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2) & element.Text.Contains(param3) & element.Text.Contains(param4) & element.Text.Contains(param5)
                        & element.Text.Contains(param6))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else Assert.Pass("Список пустой");
            }
        }

        // 7 parameters
        public void SearchResult(string param1, string param2, string param3, string param4, string param5, string param6, string param7)
        {
            List<IWebElement> tireslist = browser.FindElements(By.XPath(xpathresultlist)).ToList();
            foreach (IWebElement element in tireslist)
            {
                if (tireslist.Count != 0)
                {
                    if (element.Text.Contains(param1) & element.Text.Contains(param2) & element.Text.Contains(param3) & element.Text.Contains(param4) & element.Text.Contains(param5)
                        & element.Text.Contains(param6) & element.Text.Contains(param7))
                    {
                        Assert.Pass("Список содержит заданные параметры");
                    }
                    else Assert.Fail("Список не содержит заданных параметров");
                }
                else Assert.Pass("Список пустой");
            }
        }

        public class TiresSelection : Homepage
        {
            /* Simple Search Methods */

            // Empty search result warning & buttonclick verification
            public void TiresSearch()
            {
                WebBrowser.ButtonClick(xpathtirebutton);
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

            // Search by 1 parameter
            public void TiresSearch(string param1, string xpathlist1, string xpathoption1)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1);
            }

            // Search by 2 parameters
            public void TiresSearch(string param1, string param2, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1, param2);
            }

            // Search by 3 parameters
            public void TiresSearch(string param1, string param2, string param3, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2, string xpathlist3, string xpathoption3)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1, param2, param3);
            }

            // Search by 4 parameters
            public void TiresSearch(string param1, string param2, string param3, string param4, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1, param2, param3, param4);
            }

            // Search by 5 parameters
            public void TiresSearch(string param1, string param2, string param3, string param4, string param5, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1, param2, param3, param4, param5);
            }

            // Search by 6 parameters
            public void TiresSearch(string param1, string param2, string param3, string param4, string param5, string param6, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5, string xpathlist6, string xpathoption6)
            {
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist6);
                Wait.ElementIsVisible(xpathoption6);

                List<IWebElement> list6 = browser.FindElements(By.XPath(xpathoption6)).ToList();
                foreach (IWebElement element in list6)
                {
                    if (element.Text.Contains(param6.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathtirebutton);
                SearchResult(param1, param2, param3, param4, param5, param6);
            }


            //// Data2
            //// string xpathbutton = "./[@id='filt_sub']";
            //// string xpathsearchresultlist = ".//div[@class='tires_catalog_search']//a[@class='tires_catalog_name']";

            //string xpathselectbrandlist = ".//div[@class='form f1']//div[@class='pseudo-select w313']";
            //string xpathselectbrandoption = ".//div[@class='form f1']//div[@class='pseudo-select w313']//div[@class='options']//div";

            //string xpathselectwidthlist = ".//div[@class='form f1']//fieldset[1]/div[2]";
            //string xpathselectwidthoption = ".//div[@class='form f1']//div[2]//div[@class='options']//div";

            //string xpathselectdiameterlist = ".//div[@class='form f1']//fieldset[1]/div[5]";
            //string xpathselectdiameteroption = ".//div[@class='form f1']//div[5]//div[@class='options']//div";

            //string xpathselectprofilelist = ".//div[@class='form f1']//fieldset[1]/div[3]";
            //string xpathselectprofileoption = ".//div[@class='form f1']//div[3]//div[@class='options']//div";

            //string xpathselectseasonlist = ".//div[@class='form f1']//fieldset[1]/div[6]";
            //string xpathselectseasonoption = ".//div[@class='form f1']//div[6]//div[@class='options']//div";

            //string xpathselectthornlist = ".//div[@class='pseudo-select']";
            //string xpathselectthornoption = ".//div[@class='pseudo-select']//div[@class='options']//div";

            ///* Difficult Search Methods 

            //// Search by TiresBrand
            //public void TiresSearch(BrandName brandname)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            ////Search by TiresWidth
            //public void TiresSearch(string width, string xpathlist1, string xpathoption1)
            //{
            //    WebBrowser.ElementClick(xpathlist1);
            //    Wait.ElementIsVisible(xpathoption1);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathoption1)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(width.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathtirebutton);
            //    WebBrowser.ButtonClick(xpathtirebutton);
            //    SearchResult(xpathresultlist);
            //}

            //// Search by TiresDiameter
            //public void TiresSearch(TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by TiresProfile
            //public void TiresSearch(TireProfile profile)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Season
            //public void TiresSearch(TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Winter Season
            //public void TiresSearch(TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Widht
            //public void TiresSearch(BrandName brandname, TireWidth width)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile
            //public void TiresSearch(BrandName brandname, TireProfile profile)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Diameter
            //public void TiresSearch(BrandName brandname, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Season
            //public void TiresSearch(BrandName brandname, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile
            //public void TiresSearch(TireWidth width, TireProfile profile)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Diameter
            //public void TiresSearch(TireWidth width, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Season
            //public void TiresSearch(TireWidth width, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Winter Season + Thorn
            //public void TiresSearch(TireWidth width, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Profile + Diameter
            //public void TiresSearch(TireProfile profile, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Profile + Season
            //public void TiresSearch(TireProfile profile, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Profile + Winter Season + Thorn
            //public void TiresSearch(TireProfile profile, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Diameter + Season
            //public void TiresSearch(TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Diameter + Winter Season + Thorn
            //public void TiresSearch(TireDiameter diameter, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Diameter
            //public void TiresSearch(BrandName brandname, TireWidth width, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Season
            //public void TiresSearch(BrandName brandname, TireWidth width, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireWidth width, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile + Diameter
            //public void TiresSearch(BrandName brandname, TireProfile profile, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile + Season
            //public void TiresSearch(BrandName brandname, TireProfile profile, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireProfile profile, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Diameter + Season
            //public void TiresSearch(BrandName brandname, TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Diameter + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireDiameter diameter, TireSeason season, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile + Diameter
            //public void TiresSearch(TireWidth width, TireProfile profile, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile + Season
            //public void TiresSearch(TireWidth width, TireProfile profile, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile + Winter Season + Thorn
            //public void TiresSearch(TireWidth width, TireProfile profile, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Profile + Diameter + Season
            //public void TiresSearch(TireProfile profile, TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Profile + Diameter + Winter Season + Thorn
            //public void TiresSearch(TireProfile profile, TireDiameter diameter, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile + Diameter
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile, TireDiameter diameter)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile + Season
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile + Diameter + Season
            //public void TiresSearch(BrandName brandname, TireProfile profile, TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Profile + Diameter + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireProfile profile, TireDiameter diameter, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile + Diameter + Season
            //public void TiresSearch(TireWidth width, TireProfile profile, TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Width + Profile + Diameter + Winter Season + Thorn
            //public void TiresSearch(TireWidth width, TireProfile profile, TireDiameter diameter, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile + Diameter + Season
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile, TireDiameter diameter, TireSeason season)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(season.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}

            //// Search by Brand + Width + Profile + Diameter + Winter Season + Thorn
            //public void TiresSearch(BrandName brandname, TireWidth width, TireProfile profile, TireDiameter diameter, TireSeason wintertires, Studdedtires thorn)
            //{
            //    Wait.ElementToBeClickable(xpathselectbrandlist);
            //    WebBrowser.ElementClick(xpathselectbrandlist);
            //    Wait.ElementIsVisible(xpathselectbrandoption);

            //    List<IWebElement> brand = browser.FindElements(By.XPath(xpathselectbrandoption)).ToList();
            //    foreach (IWebElement element in brand)
            //    {
            //        if (element.Text.Contains(brandname.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectwidthlist);
            //    WebBrowser.ElementClick(xpathselectwidthlist);
            //    Wait.ElementIsVisible(xpathselectwidthoption);

            //    List<IWebElement> widthlist = browser.FindElements(By.XPath(xpathselectwidthoption)).ToList();
            //    foreach (IWebElement element in widthlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireWidth(width)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectprofilelist);
            //    WebBrowser.ElementClick(xpathselectprofilelist);
            //    Wait.ElementIsVisible(xpathselectprofileoption);

            //    List<IWebElement> profilelist = browser.FindElements(By.XPath(xpathselectprofileoption)).ToList();
            //    foreach (IWebElement element in profilelist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireProfile(profile)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectdiameterlist);
            //    WebBrowser.ElementClick(xpathselectdiameterlist);
            //    Wait.ElementIsVisible(xpathselectdiameteroption);

            //    List<IWebElement> diameterlist = browser.FindElements(By.XPath(xpathselectdiameteroption)).ToList();
            //    foreach (IWebElement element in diameterlist)
            //    {
            //        if (element.Text.Contains(EnumParse.EnumTireDiameter(diameter)))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectseasonlist);
            //    WebBrowser.ElementClick(xpathselectseasonlist);
            //    Wait.ElementIsVisible(xpathselectseasonoption);

            //    List<IWebElement> seasonlist = browser.FindElements(By.XPath(xpathselectseasonoption)).ToList();

            //    foreach (IWebElement element in seasonlist)
            //    {
            //        if (element.Text.Contains(wintertires.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathselectthornlist);
            //    WebBrowser.ElementClick(xpathselectthornlist);
            //    Wait.ElementIsVisible(xpathselectthornoption);

            //    List<IWebElement> thornlist = browser.FindElements(By.XPath(xpathselectthornoption)).ToList();

            //    foreach (IWebElement element in thornlist)
            //    {
            //        if (element.Text.Contains(thorn.ToString()))
            //        {
            //            element.Click();
            //            break;
            //        }
            //    }

            //    Wait.ElementToBeClickable(xpathbutton);
            //    WebBrowser.ButtonClick(xpathbutton);
            //    SearchResult(xpathsearchresultlist);
            //}
        }

        public class WheelsSelection : Homepage
        {
            // Empty search result warning & buttonclick verification
            public void WheelSearch()
            {
                WebBrowser.ElementClick(xpathwheelselect);

                WebBrowser.ButtonClick(xpathwheelbutton);

                Wait.ElementIsVisible(xpathsearchresult);
                element = browser.FindElement(By.XPath(xpathsearchresult));
                if (element.Text == expectedresult)
                {
                    Assert.Pass("Текст 'Не заданы параметра поиска' присутствует");
                }
                else Assert.Fail("Текст 'Не заданы параметра поиска' отсутствует");
            }

            // Search by 1 parameter
            public void WheelSearch(string param1, string xpathlist1, string xpathoption1)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1);
            }

            // Search by 2 parameters
            public void WheelSearch(string param1, string param2, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2);
            }

            // Search by 3 parameters
            public void WheelSearch(string param1, string param2, string param3, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2, string xpathlist3, string xpathoption3)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2, param3);
            }

            // Search by 4 parameters
            public void WheelSearch(string param1, string param2, string param3, string param4, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2, param3, param4);
            }

            // Search by 5 parameters
            public void WheelSearch(string param1, string param2, string param3, string param4, string param5, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2, param3, param4, param5);
            }

            // Search by 6 parameters
            public void WheelSearch(string param1, string param2, string param3, string param4, string param5, string param6, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5, string xpathlist6, string xpathoption6)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist6);
                Wait.ElementIsVisible(xpathoption6);

                List<IWebElement> list6 = browser.FindElements(By.XPath(xpathoption6)).ToList();
                foreach (IWebElement element in list6)
                {
                    if (element.Text.Contains(param6.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2, param3, param4, param5, param6);
            }

            // Search by 7 parameters
            public void WheelSearch(string param1, string param2, string param3, string param4, string param5, string param6, string param7, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5, string xpathlist6, string xpathoption6,
            string xpathlist7, string xpathoption7)
            {
                WebBrowser.ElementClick(xpathwheelselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist6);
                Wait.ElementIsVisible(xpathoption6);

                List<IWebElement> list6 = browser.FindElements(By.XPath(xpathoption6)).ToList();
                foreach (IWebElement element in list6)
                {
                    if (element.Text.Contains(param6.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist7);
                Wait.ElementIsVisible(xpathoption7);

                List<IWebElement> list7 = browser.FindElements(By.XPath(xpathoption7)).ToList();
                foreach (IWebElement element in list7)
                {
                    if (element.Text.Contains(param7.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathwheelbutton);
                SearchResult(param1, param2, param3, param4, param5, param6, param7);
            }
        }

        public class CarSelection : Homepage
        {
            // Empty search result warning & buttonclick verification
            public void CarSearch()
            {
                WebBrowser.ElementClick(xpathcarselect);

                WebBrowser.ButtonClick(xpathcarbutton);

                Wait.ElementIsVisible(xpathsearchresult);
                element = browser.FindElement(By.XPath(xpathsearchresult));
                if (element.Text == expectedresult)
                {
                    Assert.Pass("Текст 'Не заданы параметра поиска' присутствует");
                }
                else Assert.Fail("Текст 'Не заданы параметра поиска' отсутствует");
            }

            // Search by 1 parameter
            public void CarSearch(string param1, string xpathlist1, string xpathoption1)
            {
                WebBrowser.ElementClick(xpathcarselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathcarbutton);
                SearchResult(param1);
            }

            // Search by 2 parameters
            public void CarSearch(string param1, string param2, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2)
            {
                WebBrowser.ElementClick(xpathcarselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathcarbutton);
                SearchResult(param1, param2);
            }

            // Search by 3 parameters
            public void CarSearch(string param1, string param2, string param3, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2, string xpathlist3, string xpathoption3)
            {
                WebBrowser.ElementClick(xpathcarselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathcarbutton);
                SearchResult(param1, param2, param3);
            }

            // Search by 4 parameters
            public void CarSearch(string param1, string param2, string param3, string param4, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4)
            {
                WebBrowser.ElementClick(xpathcarselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathcarbutton);
                SearchResult(param1, param2, param3, param4);
            }

            // Search by 5 parameters
            public void CarSearch(string param1, string param2, string param3, string param4, string param5, string xpathlist1, string xpathoption1, string xpathlist2, string xpathoption2,
            string xpathlist3, string xpathoption3, string xpathlist4, string xpathoption4, string xpathlist5, string xpathoption5)
            {
                WebBrowser.ElementClick(xpathcarselect);
                WebBrowser.ElementClick(xpathlist1);
                Wait.ElementIsVisible(xpathoption1);

                List<IWebElement> list = browser.FindElements(By.XPath(xpathoption1)).ToList();
                foreach (IWebElement element in list)
                {
                    if (element.Text.Contains(param1.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist2);
                Wait.ElementIsVisible(xpathoption2);

                List<IWebElement> list1 = browser.FindElements(By.XPath(xpathoption2)).ToList();
                foreach (IWebElement element in list1)
                {
                    if (element.Text.Contains(param2.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist3);
                Wait.ElementIsVisible(xpathoption3);

                List<IWebElement> list3 = browser.FindElements(By.XPath(xpathoption3)).ToList();
                foreach (IWebElement element in list3)
                {
                    if (element.Text.Contains(param3.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist4);
                Wait.ElementIsVisible(xpathoption4);

                List<IWebElement> list4 = browser.FindElements(By.XPath(xpathoption4)).ToList();
                foreach (IWebElement element in list4)
                {
                    if (element.Text.Contains(param4.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ElementClick(xpathlist5);
                Wait.ElementIsVisible(xpathoption5);

                List<IWebElement> list5 = browser.FindElements(By.XPath(xpathoption5)).ToList();
                foreach (IWebElement element in list5)
                {
                    if (element.Text.Contains(param5.ToString()))
                    {
                        element.Click();
                        break;
                    }
                }

                WebBrowser.ButtonClick(xpathcarbutton);
                SearchResult(param1, param2, param3, param4, param5);
            }
        }
    }
}
