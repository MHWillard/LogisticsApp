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
            driver.Url = "https://www.saucelabs.com";

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
        }
    }
}
