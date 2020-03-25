using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace testinGoogle
{
    [TestClass]
    public class GoogleSearchEngineUsingChrome
    {
        private object useAutomationExtension;

        [TestMethod]
        public void Shoud_Search_Using_Chrome()
        {
            // Initialize the Chrome Driver
            var Options = new OpenQA.Selenium.Chrome.ChromeOptions();
            Options.AddAdditionalCapability("useAutomationExtension", false);
           // Options.AddArguments("--useAutomationExtension", "false");
            using (var driver = new OpenQA.Selenium.Chrome.ChromeDriver(Options))
              
            {

                WebDriverWait wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox (by ID) on the homepage

                var searchBox = driver.FindElementByName("q");
                wait.Until(ExpectedConditions.ElementToBeClickable(searchBox));
                // 4. Enter the text (to search for) in the textbox
                searchBox.SendKeys("Adriaan test 25 Maart Automation using selenium 3.0 in C#");

                // 5. Find the search button (by Name) on the homepage
                var searchButton = driver.FindElementByName("btnK");
                wait.Until(ExpectedConditions.ElementToBeClickable(searchButton));

                // 6. Click "Submit" to start the search
                searchButton.Submit();

                // 7. Find the "Id" of the "Div" containing results stats
                //var searchResults = driver.FindElementById("resultStats");
            }
        }
    }
}
