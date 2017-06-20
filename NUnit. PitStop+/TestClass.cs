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
    [TestFixture]
    public class TestClass : Homepage
    {
        TiresSelection test1 = new TiresSelection();
        WheelsSelection test2 = new WheelsSelection();

        // Tires
        string xpathbrand = ".//div[@class='form f1']//fieldset[1]/div[1]";
        string xpathwidth = ".//div[@class='form f1']//fieldset[1]/div[2]";
        string xpathprofile = ".//div[@class='form f1']//fieldset[1]/div[3]";
        string xpathdiameter = ".//div[@class='form f1']//fieldset[1]/div[5]";
        string xpathseason = ".//div[@class='form f1']//fieldset[1]/div[6]";
        string xpaththorn = ".//div[@class='pseudo-select']";

        string xpathbrandoption = ".//div[@class='form f1']//div[1]//div[2]//div";
        string xpathwidthoption = ".//div[@class='form f1']//div[2]//div[2]//div";
        string xpathprofileoption = ".//div[@class='form f1']//div[3]//div[2]//div";
        string xpathdiameteroption = ".//div[@class='form f1']//div[5]//div[2]//div";
        string xpathseasonoption = ".//div[@class='form f1']//div[6]//div[2]//div";
        string xpaththornoption = ".//div[@class='pseudo-select']//div[2]//div";

        // Wheels
        string xpathwheelbrand = ".//div[@class='form f3']//fieldset[1]/div[1]";
        string xpathwheelwidth = ".//div[@class='form f3']//fieldset[1]/div[2]";
        string xpathwheeldiameter = ".//div[@class='form f3']//fieldset[1]/div[3]";
        string xpathfixture = ".//div[@class='form f3']//fieldset[1]/div[5]";
        string xpathradiusET = ".//div[@class='form f3']//fieldset[1]/div[6]";
        string xpathwheeldiameterPCD = ".//div[@class='form f3']//fieldset[1]/div[8]";
        string xpathweeldiameterCH = ".//div[@class='form f3']//fieldset[1]/div[9]";

        string xpathwheelbrandoption = ".//div[@class='form f3']//div[1]//div[2]//div";
        string xpathwheelwidthoption = ".//div[@class='form f3']//div[2]//div[2]//div";
        string xpathwheeldiameteroption = ".//div[@class='form f3']//div[3]//div[2]//div";
        string xpathfixtureoption = ".//div[@class='form f3']//div[5]//div[2]//div";
        string xpathradiusEToption = ".//div[@class='form f3']//div[6]//div[2]//div";
        string xpathwheeldiameterPCDoption = ".//div[@class='form f3']//div[8]//div[2]//div";
        string xpathweeldiameterCHoption = ".//div[@class='form f3']//div[9]//div[2]//div";

        // Car

        [Test] // Подбор шин на главной странице
        public void TestMethod1()
        {
            // Empty tire search exist warning "Не заданы параметры поиска" 
            test1.TiresSearch();
            // Data:
            // xpathlist = xpathbrand || xpathwidth || xpathprofile || etc.
            // xpathoption = xpathbrandoption || xpathwidthoption || xpathprofileoption || etc.
            test1.TiresSearch("Dunlop", xpathbrand, xpathbrandoption);
            test1.SearchResult();
            test1.SearchResult("Dunlop");
            test1.TiresSearch("Cooper", "285", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption);
            test1.TiresSearch("Cooper", "235", "65", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption);
            test1.TiresSearch("Cooper", "235", "65", "R16", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter, xpathdiameteroption);
            test1.TiresSearch("Cooper", "235", "65", "R16", "Зима", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter,
                              xpathdiameteroption, xpathseason, xpathseasonoption);
            test1.TiresSearch("Cooper", "235", "65", "R16", "Зимние", "Нет", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter,
                              xpathdiameteroption, xpathseason, xpathseasonoption, xpaththorn, xpaththornoption);
        }

        [Test]
        public void TestMethod2()
        {
            // Empty wheel search exist warning "Не заданы параметры поиска"
            //test2.WheelSearch();
            // Data:
            // xpathlist = xpathwheelbrand || xpathwheelwidth || xpathwheelprofile || etc.
            // xpathoption = xpathwheelbrandoption || xpathwheelwidthoption || xpathwheelprofileoption || etc.
            //test2.WheelSearch("Catwild", xpathwheelbrand, xpathwheelbrandoption);
            //test2.WheelSearch("Catwild", "6", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption);
            //test2.WheelSearch("Catwild", "6", "15", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption);
            /*test2.WheelSearch("Catwild", "6", "15", "5", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption);*/
            /*test2.WheelSearch("Catwild", "6", "15", "5", "39", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption);*/
            /*test2.WheelSearch("Catwild", "6", "15", "5", "39", "114,3", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption, xpathwheeldiameterPCD, xpathwheeldiameterPCDoption);*/
            test2.WheelSearch("Catwild", "6", "15", "5", "39", "114,3", "60,1", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption, xpathwheeldiameterPCD, xpathwheeldiameterPCDoption, xpathweeldiameterCH, xpathweeldiameterCHoption);

        }

        [Test]
        public void TestMethod15()
        {
            //Reports.StartTestReport("Тест-кейс_1", "Проверка кнопки 'Найти'", "Проверка работы кнопки поиска шин, Проверка предупреждения об отсутствии списка шин");
            //test1.TiresSearch(BrandName.Cooper);
            //test1.TiresSearch(TireWidth.w225);
            //test1.TiresSearch(TireDiameter.R);
            //test1.TiresSearch(TireProfile.p12comma5);
            //test1.TiresSearch(TireSeason.Летние);
            //test1.TiresSearch(TireSeason.Зимние, Studdedtires.шипы);
            //Reports.EndTestreport();

            //Reports.StartTestReport("Тест-кейс_2", "Выбор шин по бренду", "Проверка существования списка шин определенного бренда");
            //test1.TiresSearch(BrandName.Michelin, TireWidth.w215, TireProfile.p65, TireDiameter.R15C, TireSeason.Лето);
            //Reports.EndTestreport();
        }


        [SetUp]
        public void SetUpMetod()
        {
            WebBrowser.Openbrowser();
        }

        [TearDown]
        public void TearDownMetod()
        {
            WebBrowser.Closebrowser();
        }
    }
}
