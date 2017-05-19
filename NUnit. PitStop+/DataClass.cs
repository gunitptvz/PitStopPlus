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

namespace NUnit.PitStop_
{
    public class DataClass
    {
       public IWebDriver browser;
        public IWebElement element;

        public List<object> TiresSearchParameters(string producer, double width, double protector, double diameter, string season)
        {
            List<object> tireschange = new List<object>();
            tireschange.Add(producer); // производитель
            tireschange.Add(width); // ширина
            tireschange.Add(protector); // профиль
            tireschange.Add(diameter); // диаметр
            tireschange.Add(season); // сезон
            return tireschange;
        }
    }
}
