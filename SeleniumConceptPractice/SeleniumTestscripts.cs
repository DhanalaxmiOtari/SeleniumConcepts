using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Interactions;

namespace SeleniumConceptPractice
{

    [TestClass]
    public class SeleniumTestscipt
    {
        public static string title = "Testing Controls";
        public static string URL = "http://www.uitestpractice.com/Students/Switchto";
        public static string URL1 = "https://www.justdial.com/Pune/Institutions-For-Aged-in-Baner/nct-10270422";

        WebHelp WebHelp = new WebHelp();
        
        [TestMethod]
        public void OneJustDialElderlyHomeAddress()
        {
            WebHelp.launchBrowser();
            Thread.Sleep(5000);
            WebHelp.openBrowser(URL1, title);
            Thread.Sleep(5000);     
            WebHelp.WebDriver.FindElement(By.XPath("//section[@id='best_deal_div']//section[@class='jpbg']//span[@class='jcl'][contains(text(),'X')]")).Click();
            Console.WriteLine("******************************************************");
            Thread.Sleep(5000);
            JustMouseHoverOver();
        }

        [TestMethod]
        //This test practiced FilndElements, ForEach, Action class mouse hoverover
        // This test collect data from the tooltip

        public void MouseHoverOverTextList()
        {
            WebHelp.launchBrowser();
            Thread.Sleep(1000);
            WebHelp.openBrowser(URL1, title);
            Thread.Sleep(5000);
            WebHelp.WebDriver.FindElement(By.XPath("//section[@id='best_deal_div']//section[@class='jpbg']//span[@class='jcl'][contains(text(),'X')]")).Click();
            Thread.Sleep(3000);
            IWebElement TextinSelectedArea = WebHelp.WebDriver.FindElement(By.XPath("//ul[contains(@class,'rsl col-md-12 padding0')]"));
            //Console.WriteLine(TextinSelectedArea.Text);
            Thread.Sleep(1000);
            Actions actions = new Actions(WebHelp.WebDriver);
            //Console.WriteLine(TextinSelectedArea);
            Console.WriteLine("******************************************************");
            Thread.Sleep(5000);
            //string text = "//span[@class=\"lng_commn_all\"]";
            string text = "//span[@class='lng_commn_all'][normalize-space()='more..']";
            IList<IWebElement> morelinks = WebHelp.WebDriver.FindElements(By.XPath(text));
            Console.WriteLine("textToPrint count= " + morelinks.Count());
            Thread.Sleep(5000);
            int MoreCount = morelinks.Count();
             //foreach (var link in morelinks)
             for(int i=1; i< MoreCount; i++)
             {
                IWebElement moreHoverOver = WebHelp.WebDriver.FindElement(By.XPath("//span[@id='morehvr_add_cont"+ i +"']"));
                actions.MoveToElement(moreHoverOver).Perform(); // Mouse Hoverover
                Console.WriteLine("Addresses at " + i + " = " + moreHoverOver.Text + "\n");
                Console.WriteLine("-----------------------------------------------------");
                }

            } 
        
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
            WebHelp.TeardownTest();

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
        public void seleniumPopupHandling()
        {
            WebHelp.launchBrowser();
            WebHelp.openBrowser(URL1, title);
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

        public static void JustMouseHoverOver()
        {
            //WebDriverWait wait = new WebDriverWait(WebHelp.WebDriver, TimeSpan.FromSeconds(10));
            //var MoreHoverOverAddress = wait.Until(ExpectedConditions.ElementIsVisible(FindE))
            Thread.Sleep(5000);
            Actions action = new Actions(WebHelp.WebDriver);
            IWebElement MoreInfo = WebHelp.WebDriver.FindElement(By.XPath("(//span[@class='lng_commn_all'][normalize-space()='more..'])[1]"));
            IWebElement MoreInfoText = WebHelp.WebDriver.FindElement(By.XPath("//span[@id='morehvr_add_cont0']"));
            action.MoveToElement(MoreInfo).Perform();
            Console.WriteLine("More Info Tool tip " + MoreInfo.Text + "\n");
            Console.WriteLine("More Info Tool tip text " + MoreInfoText.Text);
            
        }
        

            public void TheLoginTest()
            {
                WebHelp.Navigate().GoToUrl("http://azure.csm.test4/");
                driver.FindElement(By.XPath("//input[@name='SIG_USER']")).Clear();
                driver.FindElement(By.XPath("//input[@name='SIG_USER']")).SendKeys("superviser");
                driver.FindElement(By.XPath("//input[@name='SIG_PASS']")).Clear()
                driver.FindElement(By.XPath("//input[@name='SIG_PASS']")).SendKeys("password");

                driver.FindElement(By.Id("button-1014-btnEl")).Click();
                driver.FindElement(By.XPath("//span[contains(text(),'Studies')]")).Click();
                driver.FindElement(By.XPath("//div[@class="x - column - header - trigger" and @xpath=1]")).Click();
                driver.FindElement(By.XPath("//span/@class='x-menu-item-text x-menu-item-text-default x-menu-item-indent x-menu-item-indent-right-arrow' and @xpath = 2]")).Click();
                driver.FindElement(By.XPath("//input[@placeholder="Enter Filter Text..."]")).SendKeys("DH");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/")).Click();
                driver.FindElement(By.Id("button-1114-btnInnerEl")).Click();
                driver.FindElement(By.Id("ext-351-inputEl")).Click();
                driver.FindElement(By.Id("ext-351-inputEl")).Click();
                driver.FindElement(By.Id("ext-351-inputEl")).Click();
                driver.FindElement(By.Id("ext-351-inputEl")).Clear();
                driver.FindElement(By.Id("ext-351-inputEl")).SendKeys("DH_Ames_Study_1_Ex_SetUp");
                driver.FindElement(By.Id("button-1202-btnInnerEl")).Click();
                driver.FindElement(By.Id("ext-element-96")).Click();
                driver.FindElement(By.Id("button-1005-btnEl")).Click();
                driver.FindElement(By.Id("button-1141-btnInnerEl")).Click();
                driver.FindElement(By.Id("ext-element-96")).Click();
                driver.FindElement(By.XPath("//table[@id='tableview-1222-record-170']/tbody/tr[2]/td[2]/div")).Click();
                driver.FindElement(By.Id("button-1252-btnIconEl")).Click();
                driver.FindElement(By.Id("button-1077-btnInnerEl")).Click();
                driver.FindElement(By.Id("messagebox-1001-toolbar")).Click();
                driver.FindElement(By.Id("button-1006-btnInnerEl")).Click();
                driver.Close();
            }
            private bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            private bool IsAlertPresent()
            {
                try
                {
                    WebHelp.SwitchTo().Alert();
                    return true;
                }
                catch (NoAlertPresentException)
                {
                    return false;
                }
            }

            private string CloseAlertAndGetItsText()
            {
                try
                {
                    IAlert alert = driver.SwitchTo().Alert();
                    string alertText = alert.Text;
                    if (acceptNextAlert)
                    {
                        alert.Accept();
                    }
                    else
                    {
                        alert.Dismiss();
                    }
                    return alertText;
                }
                finally
                {
                    acceptNextAlert = true;
                }
            }
        }
    }



}

    
