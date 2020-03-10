using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace testinFF
{
    [TestClass]
    public class GoogleSearchEngineUsingFirefox
    {
        [TestMethod]
        public void Shoud_Search_Using_Firefox()
        {
            // Initialize the Firefox Driver
            using (var driver = new FirefoxDriver())
            {


                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));

                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Google" homepage
                driver.Navigate().GoToUrl("http://www.google.com");

                // 3. Find the search textbox (by ID) on the homepage

                var searchBox = driver.FindElementByName("q");
                wait.Until(ExpectedConditions.ElementToBeClickable(searchBox));

                // 4. Enter the text (to search for) in the textbox
                searchBox.SendKeys("Automation using selenium 3.0 in C#");

                // 5. Find the search button (by Name) on the homepage
                var searchButton = driver.FindElementByName("btnK");
                wait.Until(ExpectedConditions.ElementToBeClickable(searchButton));

                // 6. Click "Submit" to start the search
                searchButton.Submit();

                // 7. Find the "Id" of the "Div" containing results stats,
                // located just above the results table.



            }
        }


    }




}