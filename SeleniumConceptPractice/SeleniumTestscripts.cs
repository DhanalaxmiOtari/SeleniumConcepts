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
        public void IjavascriptExecutorTest()
        {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
            Console.WriteLine("count = " + WebHelp.WebDriver.WindowHandles.Count);
            foreach (var n in WebHelp.WebDriver.WindowHandles)
            {
                Console.WriteLine("WebHelp.WebDriver.WindowHandles = " + WebHelp.WebDriver.CurrentWindowHandle);
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

            //WebHelp.TearDown();
            //WebHelp.launchBrowser();
            //WebHelp.WebDriver.Navigate().GoToUrl("http://azure.csm.test4/");
            WebHelp.WebDriver.Navigate().GoToUrl(URL);
            //((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("alert('Hello')");
            //Thread.Sleep(5000);
            Thread.Sleep(3000);
            string textOnCSM = ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("return document.documentElement.innerText").ToString();
            string titleOnCSM = ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("return document.title").ToString();
            Console.WriteLine("textOnCSM" + textOnCSM + "\n" + "titleOnCSM");
            Thread.Sleep(7000);
            ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("history.go(0)");
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("history.back");
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("history.forward");
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("document.querySelector('p').style.backgroundColor = 'blue'");
            Thread.Sleep(7000);
            WebHelp.WebDriver.Navigate().GoToUrl("http://azure.csm.test4/");

            WebHelp.TearDown();

        }
        [TestMethod]
        public void multipleBrowser()
        {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
            Console.WriteLine("count = " + WebHelp.WebDriver.WindowHandles.Count);
            foreach (var n in WebHelp.WebDriver.WindowHandles)
            {
                Console.WriteLine("WebHelp.WebDriver.WindowHandles = " + WebHelp.WebDriver.CurrentWindowHandle);
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

            //WebHelp.TearDown();
            //WebHelp.launchBrowser();
            //WebHelp.WebDriver.Navigate().GoToUrl("http://azure.csm.test4/");

        }
        [TestMethod]
        public void seleniumPopupHandling() {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }
        [TestMethod]
        public void fileUpload() {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }

        [TestMethod]
        public void fileDownload() {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }
        [TestMethod]
        public void mouseClicks() {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }

        [TestMethod]
        public void actionDragdrop() 
        {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }

        [TestMethod]
        public void ijavaScriptCheckboxAndDropdownlist() {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL, title);
        }

    }
    }
