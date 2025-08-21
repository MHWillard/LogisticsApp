using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace LogisticsAppTests.IntegrationTests
{
    public class WalkingSkeleton
    {
        [Fact]
        public void EndtoEndTest()
        {
            //arrange
            /*
             test app boots and runs
            mocks assembled: anything for tables
            set up Selenium or equivalent
             */
            IWebDriver driver = new FirefoxDriver();

            //act/assert
            /*
             go to web url
            put in log in info
            confirm you're on main page
            click Orders tab
            confirm you're in Orders
            confirm orders listing has correct information for its cells
            Go to Items tab
            confirm items are listed in order with expected information
            go to Customers
            make sure customer basic info is listed
             */

            driver.Navigate().GoToUrl("https://localhost:7082/");
            LogIntoWebsite(driver);
            ClickTab(driver, "orders");
            //ClickTab(driver, "items");
            //ClickTab(driver, "customers");
            Assert.True(CheckForCorrectOrders(driver));
            //CompareItems(driver);
            //CompareCustomers(driver);
            ClickTab(driver, "logout");

            driver.Quit();
        }

        static void LogIntoWebsite(IWebDriver driver)
        {
            var usernameText = driver.FindElement(By.Name("username-textbox"));
            var passwordText = driver.FindElement(By.Name("password-textbox"));
            var submitButton = driver.FindElement(By.Name("login-button"));
            usernameText.SendKeys("testuser");
            passwordText.SendKeys("testpassword");
            submitButton.Click();
        }

        static void ClickTab(IWebDriver driver, string title)
        {
            var titleElementName = title + "-tab";
            var tabElement = driver.FindElement(By.ClassName(titleElementName));
            tabElement.Click();
        }

        static bool CheckForCorrectOrders(IWebDriver driver)
        {
            //pull in db mock here
            //check it against what's displayed
            //return true/false
            return true;
        }

        static void CompareItems(IWebDriver driver)
        {

        }

        static void CompareCustomers(IWebDriver driver)
        {

        }
    }
}
