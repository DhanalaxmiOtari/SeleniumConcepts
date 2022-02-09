using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
namespace SeleniumConceptPractice
{

    [TestClass]
    public class SeleniumTestscipts
    {
        public static string title = "Testing Controls";
        public static string URL = "http://www.uitestpractice.com/Students/Switchto";
        // Selenium Concept - WindowsHandles
        [TestMethod]
        public void multipleBrowser()
        {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL,title);
            Console.WriteLine("count = "+WebHelp.WebDriver.WindowHandles.Count);
            foreach(var n in WebHelp.WebDriver.WindowHandles)
            {
                Console.WriteLine("WebHelp.WebDriver.WindowHandles = "+WebHelp.WebDriver.CurrentWindowHandle);
            }
            WebHelp.WebDriver.FindElement(By.LinkText("Opens in a new window")).Click();
            Thread.Sleep(5000);
            Console.WriteLine("count = " + WebHelp.WebDriver.WindowHandles.Count);
            foreach (var n in WebHelp.WebDriver.WindowHandles)
            {
                Console.WriteLine("WebHelp.WebDriver.WindowHandles = " + WebHelp.WebDriver.CurrentWindowHandle);
            }
            //WebHelp.WebDriver.SwitchTo().Window(title);
            WebHelp.WebDriver.SwitchTo().Window(WebHelp.WebDriver.WindowHandles[1]);
            Console.WriteLine(WebHelp.WebDriver.FindElement(By.Id("draggable")).Text);
            Thread.Sleep(5000);
            WebHelp.WebDriver.SwitchTo().Window(WebHelp.WebDriver.WindowHandles[0]);
            Console.WriteLine(WebHelp.WebDriver.FindElement(By.LinkText("Opens in a new window")).Text);

            WebHelp.TearDown();
        }
        
        [TestMethod]
        public static void iJavaScrinptMethodsTests()
        {

            WebHelp.launchBrowser();
            WebHelp.WebDriver.Navigate().GoToUrl("https://designsystem.digital.gov/components/radio-buttons/");


        }
        

    }
}
