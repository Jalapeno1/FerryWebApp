using System;
using FerryFrontend.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Toolbox3_Library_Hundige;

namespace FerryFrontend.Tests
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestInitialize]
        public void InitDriver()
        {
            //driver = new ChromeDriver();
        }

        [TestCleanup]
        public void Cleanup()
        {
            
        }

        [TestMethod]
        public void OpenBrowser()
        {
            //driver.Url = "http://localhost:49583/";
            //driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            //driver.FindElement(By.LinkText("Order Tickets »")).Click();
            //driver.Quit();
        }

        [TestMethod]
        public void WillAlwaysFail()
        {
            Assert.Fail();
            //Not working..
        }
    }
}
