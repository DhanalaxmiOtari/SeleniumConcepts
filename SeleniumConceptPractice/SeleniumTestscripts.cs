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
    public class SeleniumTestscipts
    {
        public static string title = "Testing Controls";
        public static string URL = "http://www.uitestpractice.com/Students/Switchto";
        public static string URL1 = "https://www.justdial.com/Pune/Institutions-For-Aged-in-Baner/nct-10270422";
        
        [TestMethod]
        public void OneJustDialElderlyHomeAddress()
        {
            WebHelp.launchBrowser();
            Thread.Sleep(5000);
            WebHelp.openBrowser(URL1, title);
            Thread.Sleep(5000);     
            WebHelp.WebDriver.FindElement(By.XPath("//section[@id='best_deal_div']//section[@class='jpbg']//span[@class='jcl'][contains(text(),'X')]")).Click();
            //IWebElement TextinSelectedArea = WebHelp.WebDriver.FindElement(By.XPath("(//div[@class='hotmetaSrchLeft col-md-12 rsp'])[1]"));
            /*Console.WriteLine(TextinSelectedArea.Text);
            Thread.Sleep(5000);
            string textOnJustDial = ((IJavaScriptExecutor)WebHelp.WebDriver).ExecuteScript("return document.documentElement.innerText").ToString();
            Console.WriteLine(textOnJustDial);*/
            Console.WriteLine("******************************************************");
            Thread.Sleep(5000);
            /* IList<IWebElement> morelinks = WebHelp.WebDriver.FindElements(By.XPath("//span[@class='cont_fl_addr']"));

             Console.WriteLine("textToPrint" + morelinks.Count());
             foreach (var link in morelinks)
             {
                 Console.WriteLine("Addresses at More = " + link.Text + "\n");
                 Console.WriteLine("-----------------------------------------------------");
             } */
            JustMouseHoverOver();
        }

        [TestMethod]
        //Deriving text 
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
                actions.MoveToElement(moreHoverOver).Perform();
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

    }
}

    
