﻿using NUnit.Framework;
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
        CarSelection test3 = new CarSelection();
        LeftAdvBlock test4 = new LeftAdvBlock();
        LinksTest test5 = new LinksTest();
        Searchstring test6 = new Searchstring();

        // Tires
        string xpathbrand = ".//div[@class='form f1']//fieldset[1]/div[1]";
        string xpathwidth = ".//div[@class='form f1']//fieldset[1]/div[2]";
        string xpathprofile = ".//div[@class='form f1']//fieldset[1]/div[3]";
        string xpathdiameter = ".//div[@class='form f1']//fieldset[1]/div[5]";
        string xpathseason = ".//div[@class='form f1']//fieldset[1]/div[6]";
        string xpaththorn = ".//div[@class='pseudo-select']";

        string xpathbrandoption = ".//div[@class='form f1']//div[1]//div[2]/div";
        string xpathwidthoption = ".//div[@class='form f1']//div[2]//div[2]/div";
        string xpathprofileoption = ".//div[@class='form f1']//div[3]//div[2]/div";
        string xpathdiameteroption = ".//div[@class='form f1']//div[5]//div[2]/div";
        string xpathseasonoption = ".//div[@class='form f1']//div[6]//div[2]/div";
        string xpaththornoption = ".//div[@class='pseudo-select']//div[2]/div";

        // Wheels
        string xpathwheelbrand = ".//div[@class='form f3']//fieldset[1]/div[1]";
        string xpathwheelwidth = ".//div[@class='form f3']//fieldset[1]/div[2]";
        string xpathwheeldiameter = ".//div[@class='form f3']//fieldset[1]/div[3]";
        string xpathfixture = ".//div[@class='form f3']//fieldset[1]/div[5]";
        string xpathradiusET = ".//div[@class='form f3']//fieldset[1]/div[6]";
        string xpathwheeldiameterPCD = ".//div[@class='form f3']//fieldset[1]/div[8]";
        string xpathweeldiameterCH = ".//div[@class='form f3']//fieldset[1]/div[9]";

        string xpathwheelbrandoption = ".//div[@class='form f3']//div[1]//div[2]/div";
        string xpathwheelwidthoption = ".//div[@class='form f3']//div[2]//div[2]/div";
        string xpathwheeldiameteroption = ".//div[@class='form f3']//div[3]//div[2]/div";
        string xpathfixtureoption = ".//div[@class='form f3']//div[5]//div[2]/div";
        string xpathradiusEToption = ".//div[@class='form f3']//div[6]//div[2]/div";
        string xpathwheeldiameterPCDoption = ".//div[@class='form f3']//div[8]//div[2]/div";
        string xpathweeldiameterCHoption = ".//div[@class='form f3']//div[9]//div[2]/div";

        // Car
        string xpathcar = ".//div[@class='pseudo-select w313 main']";
        string xpathcaroption = ".//div[@class='pd']/div[1]/div[2]/div";
        // For tires
        string xpathcarbrand = ".//div[@class='form f2']//fieldset[1]/div[1]";
        string xpathcarmodel = ".//div[@class='form f2']//fieldset[1]/div[2]";
        string xpathcaryear = ".//div[@class='form f2']//fieldset[1]/div[4]";
        string xpathcarmodif = ".//div[@class='form f2']//fieldset[1]/div[5]";

        string xpathcarbrandoption = ".//div[@class='form f2']//div[1]//div[2]/div";
        string xpathcarmodeloption = ".//div[@class='form f2']//div[2]//div[2]/div";
        string xpathcaryearoption = ".//div[@class='form f2']//div[4]//div[2]/div";
        string xpathcarmodifoption = ".//div[@class='form f2']//div[5]//div[2]/div";
        // For wheels
        string xpathcarbrand1 = ".//div[@class='form f4']//fieldset[1]/div[1]";
        string xpathcarmodel1 = ".//div[@class='form f4']//fieldset[1]/div[2]";
        string xpathcaryear1 = ".//div[@class='form f4']//fieldset[1]/div[4]";
        string xpathcarmodif1 = ".//div[@class='form f4']//fieldset[1]/div[5]";

        string xpathcarbrandoption1 = ".//div[@class='form f4']//div[1]//div[2]/div";
        string xpathcarmodeloption1 = ".//div[@class='form f4']//div[2]//div[2]/div";
        string xpathcaryearoption1 = ".//div[@class='form f4']//div[4]//div[2]/div";
        string xpathcarmodifoption1 = ".//div[@class='form f4']//div[5]//div[2]/div";

        // Tire or wheel config selection
        string xpathshowvarstock = ".//*[@id='filter-result']//li[1]/div[1]";
        string xpathshowvaraltern = ".//*[@id='filter-result']//li[2]/div[1]";

        string xpathshowvarstockoption = ".//*[@id='filter-result']//li[1]/div[1]//a";
        string xpathshowvaralternoption = ".//*[@id='filter-result']//li[2]/div[1]//a";

        // Filter by brand list
        string xpathbrandfilteroption = ".//*[@id='filter-result']//p[2]/span[2]/a";
        // Filter by season list
        string xpathseasonfilteroption = ".//*[@id='filter-result']//p[3]/span[2]/a";
        // Sort list
        string xpathsortfilteroption = ".//*[@id='filter-result']//p[1]//span[2]/a";

        // Homepage header links
        string favlink = "http://pitstopplus.ru/";
        string favlinkclass = "main_logo";
        string autorepairlink = "http://pitstopplus.ru/autorepair/";
        string autorepairlinkxpath = ".//*[@href='/autorepair/']";
        string aboutcompanylink = "http://pitstopplus.ru/about/";
        string aboutcompanylinkxpath = ".//*[@href='/about/']";
        string paymentlink = "http://pitstopplus.ru/payment-delivery/";
        string paymentlinkxpath = ".//*[@href='/payment-delivery/']";
        string vipcardlink = "http://pitstopplus.ru/vip-card/";
        string vipcardlinkxpath = ".//*[@href='/vip-card/']";
        string contactlink = "http://pitstopplus.ru/contacts/";
        string contactlinkxpath = ".//*[@href='/contacts/']";
        string buycreditlink = "http://pitstopplus.ru/";
        string buycreditlinkxpath = ".//*[@src='/bitrix/templates/two_column_orange/images/credit-1.jpg']";
        string tireslink = "http://pitstopplus.ru/tyres/";
        string tireslinkxpath = ".//*[@href='/tyres/']";
        string wheelslink = "http://pitstopplus.ru/wheels/";
        string wheelslinkxpath = ".//*[@href='/wheels/']";
        string actionlink = "http://pitstopplus.ru/actions/";
        string actionlinkxpath = ".//*[@href='/action/']";
        string autoservicelink = "http://pitstopplus.ru/autoservice/";
        string autoservicelinkxpath = ".//*[@href='/autoservice/']";

        // Homepage autoservice tabs links
        string tireservicelink = "http://pitstopplus.ru/autoservice/tire-service/";
        string tireservicelinkxpath = ".//*[@href='/autoservice/tire-service/']";
        string tirebalancelink = "http://pitstopplus.ru/autoservice/balancing-tyres/";
        string tirebalancelinkxpath = ".//*[@href='/autoservice/balancing-tyres/']";
        string tirerepairlink = "http://pitstopplus.ru/autoservice/repair-tyres/";
        string tirerepairlinkxpath = ".//*[@href='/autoservice/repair-tyres/']";
        string wheelsrepairlink = "http://pitstopplus.ru/autoservice/repair-wheels/";
        string wheelsrepairlinkxpath = ".//*[@href='/autoservice/repair-wheels/']";
        string wheelspaintlink = "http://pitstopplus.ru/autoservice/colored-wheels/";
        string wheelspaintlinkxpath = ".//*[@href='/autoservice/colored-wheels/']";
        string argonweldinglink = "http://pitstopplus.ru/autoservice/argon-welding/";
        string argonweldinglinkxpath = ".//*[@href='/autoservice/argon-welding/']";
        string seasontirereplacementlink = "http://pitstopplus.ru/autoservice/seasonal-tire-replacement/";
        string seasontirereplacementlinkxpath = ".//*[@href='/autoservice/seasonal-tire-replacement/']";
        string seasonalstoragelink = "http://pitstopplus.ru/autoservice/seasonal-storage/";
        string seasonalstoreagelinkxpath = ".//*[@href='/autoservice/seasonal-storage/']";
        string nitrogenpumpinglink = "http://pitstopplus.ru/autoservice/pumping-nitrogen/";
        string nitrogenpumpinglinkxpath = ".//*[@href='/autoservice/pumping-nitrogen/']";
        string chromiumplatinglink = "http://pitstopplus.ru/autoservice/chromium-plating/";
        string chromiumplatinglinkxpath = ".//*[@href='/autoservice/chromium-plating/']";

        // Homepage our services & offers links
        string tireservicelink2 = "http://pitstopplus.ru/autoservice/tire-service/";
        string tireservicelinkxpath2 = ".//*[@class='services']/a[1]";
        string tirerepairlink2 = "http://pitstopplus.ru/autoservice/repair-tyres/";
        string tirerepairlinkxpath2 = ".//*[@class='services']/a[2]";
        string seasonalstoragelink2 = "http://pitstopplus.ru/autoservice/seasonal-storage/";
        string seasonalstoreagelinkxpath2 = ".//*[@class='services']/a[3]";
        string comfortpaymentlink = "http://pitstopplus.ru/payment-delivery/";
        string comfortpaymentlinkxpath = ".//*[@class='services']/a[5]";
        string specialforviplink = "http://pitstopplus.ru/vip-card/";
        string specialforviplinkxpath = ".//*[@class='services']/a[6]";

        // Footer links
        string autorepairlink2 = "http://pitstopplus.ru/autorepair/";
        string autorepairlinkxpath2 = ".//*[@id='footer-nav']//li[1]//a[1]";
        string aboutcompanylink2 = "http://pitstopplus.ru/about/";
        string aboutcompanylinkxpath2 = ".//*[@id='footer-nav']//li[2]//a[1]";
        string paymentlink2 = "http://pitstopplus.ru/payment-delivery/";
        string paymentlinkxpath2 = ".//*[@id='footer-nav']//li[3]//a[1]";
        string vipcardlink2 = "http://pitstopplus.ru/vip-card/";
        string vipcardlinkxpath2 = ".//*[@id='footer-nav']//li[4]//a[1]";
        string contactlink2 = "http://pitstopplus.ru/contacts/";
        string contactlinkxpath2 = ".//*[@id='footer-nav']//li[5]//a[1]";

        // Search string
        string textboxxpath = ".//*[@id='title-search-input']";
        string searchxpath = ".//*[@id='search_sub']";
        string searchtext = "Cooper";

        [Test]
        public void TestMethod0()
        {
            
        }

        [Test, Description("Quick search form testing. Tires search")]
        public void TestMethod1()
        {
            // Empty tire search exists warning "Не заданы параметры поиска" 
            test1.TiresSearch();

            // Empty search result verification
            test1.SearchResult();

            // Data:
            // xpathlist = xpathbrand || xpathwidth || xpathprofile || etc.
            // xpathoption = xpathbrandoption || xpathwidthoption || xpathprofileoption || etc.

            // Tire search by brand
            test1.TiresSearch("Dunlop", xpathbrand, xpathbrandoption);

            // Tire search "by brand" result testing
            test1.SearchResult("Dunlop");

            // Tire search by brand & width
            test1.TiresSearch("Cooper", "285", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption);

            // Tire search by brand, width & profile
            test1.TiresSearch("Cooper", "235", "65", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption);

            // Tire search by brand, width, profile & diameter
            test1.TiresSearch("Cooper", "235", "65", "R16", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter, xpathdiameteroption);

            // Tire search by brand, width, profile, diameter & season
            test1.TiresSearch("Cooper", "235", "65", "R16", "Зима", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter,
                              xpathdiameteroption, xpathseason, xpathseasonoption);

            // Tire search by brand, width, profile, diameter, winter season & thorn
            test1.TiresSearch("Cooper", "235", "65", "R16", "Зимние", "Нет", xpathbrand, xpathbrandoption, xpathwidth, xpathwidthoption, xpathprofile, xpathprofileoption, xpathdiameter,
                              xpathdiameteroption, xpathseason, xpathseasonoption, xpaththorn, xpaththornoption);
        }

        [Test, Description("Quick search form testing. Wheels search")]
        public void TestMethod2()
        {
            // Empty tire search exists warning "Не заданы параметры поиска"
            test2.WheelSearch();

            // Empty search result verification
            test1.SearchResult();

            // Data:
            // xpathlist = xpathwheelbrand || xpathwheelwidth || xpathwheelprofile || etc.
            // xpathoption = xpathwheelbrandoption || xpathwheelwidthoption || xpathwheelprofileoption || etc.

            // Wheel search by brand
            test2.WheelSearch("Catwild", xpathwheelbrand, xpathwheelbrandoption);

            // Wheel search by brand & width
            test2.WheelSearch("Catwild", "6", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption);

            // Wheel search by brand, width & diameter
            test2.WheelSearch("Catwild", "6", "15", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption);

            // Wheel search by brand, width, diameter & fixture
            test2.WheelSearch("Catwild", "6", "15", "5", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption);

            // Wheel search by brand, width, diameter, fixture & radiusET
            test2.WheelSearch("Catwild", "6", "15", "5", "39", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption);

            // Wheel search by brand, width, diameter, fixture, radiusET & diameterPCD
            test2.WheelSearch("Catwild", "6", "15", "5", "39", "114,3", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption, xpathwheeldiameterPCD, xpathwheeldiameterPCDoption);

            // Wheel search by brand, width, diameter, fixture, radiusET, diameterPCD & diameterCH
            test2.WheelSearch("Catwild", "6", "15", "5", "39", "114,3", "60,1", xpathwheelbrand, xpathwheelbrandoption, xpathwheelwidth, xpathwheelwidthoption, xpathwheeldiameter, xpathwheeldiameteroption,
                              xpathfixture, xpathfixtureoption, xpathradiusET, xpathradiusEToption, xpathwheeldiameterPCD, xpathwheeldiameterPCDoption, xpathweeldiameterCH, xpathweeldiameterCHoption);

        }

        [Test, Description("Quick search form testing. Car search")]
        public void TestMethod3()
        {
            // Empty car search exists warning "Не заданы параметры поиска"
            test3.CarSearch();

            // Empty search result verification
            test3.SearchResult();

            // Data:
            // xpathlist = xpathcar || xpathcarmodel || xpathcaryear || etc.
            // xpathoption = xpathcaroption || xpathcarmodeloption || xpathcaryearoption || etc.

            // Stock and Alternative configuration lists existence
            test3.ConfigurationListsExist("диски", "Acura", "CL", "1998", "2.3 i", xpathcar, xpathcaroption, xpathcarbrand1, xpathcarbrandoption1, xpathcarmodel1, xpathcarmodeloption1,
                xpathcaryear1, xpathcaryearoption1, xpathcarmodif1, xpathcarmodifoption1);

            // Go to wheel search from tires search
            test3.GoToFromWheelsOrTires("шины", "Acura", "CL", "1998", "2.3 i", xpathcar, xpathcaroption, xpathcarbrand, xpathcarbrandoption, xpathcarmodel, xpathcarmodeloption, xpathcaryear,
            xpathcaryearoption, xpathcarmodif, xpathcarmodifoption);

            // Go to tires search from wheel search
            test3.GoToFromWheelsOrTires("диски", "Acura", "CL", "1998", "2.3 i", xpathcar, xpathcaroption, xpathcarbrand1, xpathcarbrandoption1, xpathcarmodel1, xpathcarmodeloption1,
                xpathcaryear1, xpathcaryearoption1, xpathcarmodif1, xpathcarmodifoption1);

            // Tires or wheels configuration selection
            test3.TireWheelConfigSelect("R17 215/45", xpathshowvaraltern, xpathshowvaralternoption);

            // Work of configuration selection filter with 1 parameter
            test3.ConfigSelectFilter("Continental", xpathbrandfilteroption);

            // Work of configuration selection filter with 2 parameters
            test3.ConfigSelectFilter("Continental", "Зимние шины", xpathbrandfilteroption, xpathseasonfilteroption);

            // Work of configuration selection filter with 3 parameters
            test3.ConfigSelectFilter("Continental", "Зимние шины", "по цене", xpathbrandfilteroption, xpathseasonfilteroption, xpathsortfilteroption, "8 775");
        }

        [Test, Description("Left Adv block testing")]
        public void TestMethod4()
        {
            test4.LeftAdvBlockTest();
        }

        [Test, Description("Autoservice homepage links testing")]
        public void TestMethod5()
        {
            test5.HomepageLinks(autorepairlink2, autorepairlinkxpath2, "XPath");
        }

        [Test, Description("Autoservice tabs testing")]
        public void TestMethod6()
        {
            test5.ServiceTabsClick(chromiumplatinglink, chromiumplatinglinkxpath);
        }

        [Test, Description("Search string testing")]
        public void TestMethod7()
        {
            //test6.EmptySearch(searchxpath);
            test6.ProductSearch(textboxxpath, searchtext);
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
