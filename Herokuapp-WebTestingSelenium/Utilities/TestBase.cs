using NUnit.Framework;
using OpenQA.Selenium;
using Herokuapp_WebTestingSelenium.Drivers;

namespace Herokuapp_WebTestingSelenium.Utilities
{
    public class TestBase
    {
        protected IWebDriver Driver;

        [SetUp]
        public void SetUp()
        {
            Driver = DriverFactory.CreateDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}