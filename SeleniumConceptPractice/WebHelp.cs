using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumConceptPractice
{
    public class WebHelp
    {
        
        public StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        public IWebDriver WebDriver { get; set; }
        //Selenium Concept => WebDriverManager

        public void launchBrowser()
        {
            //Chrome notification popup disabled
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            new DriverManager().SetUpDriver(new ChromeConfig());
            WebDriver = new ChromeDriver(options);
            WebDriver.Manage().Window.Maximize();
        }

        //[Test]
        public void openBrowser(string URL, string title)
        {
            WebDriver.Navigate().GoToUrl(URL);
            //Assert.IsTrue(WebDriver.Title.Contains(title));
        }
        public void TeardownTest()
        {
            try
            {
                WebDriver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        public static void acceptingbrowserAlter()
        {

        }

    }
}
