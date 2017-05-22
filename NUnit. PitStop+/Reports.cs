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
    public class Reports : DataClass
    {
        public static void StartTestReport(string title, string description)
        {
            extent = new ExtentReports("D:\\Загрузки\\report.html");
            test = extent.StartTest(title, description);
        }

        public static void EndTestreport()
        {
            extent.EndTest(test);
            extent.Flush();
        }

        public static void AddLog(string logdescription)
        {
            test.Log(LogStatus.Info, logdescription);
        }

        public static void AddLog(string logdescription, string screenshotname)
        {
            ITakesScreenshot screenshotdriver = browser as ITakesScreenshot;
            Screenshot screenshot = screenshotdriver.GetScreenshot();
            screenshot.SaveAsFile("D:\\Загрузки\\" + screenshotname + ".gif", ScreenshotImageFormat.Gif);
            test.Log(LogStatus.Info, logdescription + test.AddScreenCapture("D:\\Загрузки\\" + screenshotname + ".gif"));
        }

        public static void AddLogPass(string logdescription)
        {
            test.Log(LogStatus.Pass, logdescription);
        }

        public static void AddLogFail(string logdescription)
        {
            test.Log(LogStatus.Fail, logdescription);
        }
    }
}
