using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumConceptPractice
{
    public static class WebHelp
    {
        public static IWebDriver WebDriver;

        //Selenium Concept => WebDriverManager
        public static void launchBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            new DriverManager().SetUpDriver(new ChromeConfig());
            WebDriver = new ChromeDriver(options);
            WebDriver.Manage().Window.Maximize();
        }

        //[Test]
        public  static void openBrowser(string URL, string title)
        {
            WebDriver.Navigate().GoToUrl(URL);
            //Assert.IsTrue(WebDriver.Title.Contains(title));
        }
        //[TearDown]
        public static void TearDown()
        {
            WebDriver.Quit();
        }
        //[Test]
        public static void acceptingbrowserAlter()
        {

        }
    }
}
