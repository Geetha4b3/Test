using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craft.Base
{
    class BaseClass
    {

        public static IWebDriver driver;
        //public static string filepath = "C:\\Users\\P0151447\\source\\repos\\Craft\\Craft\\Resources\\Properties\\Config.Properties";

        [SetUp]
        public static void openBrowser()
        {
            driver = new ChromeDriver();
            //Properties prop = new Properties();
            driver.Navigate().GoToUrl("https://compassqa.myit.kraftheinz.com/");
            //driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(20));
            IWebElement element = driver.FindElement(By.Id("target"));
            element.Click();
            element.Click();
            element.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();

        }
    }
}
