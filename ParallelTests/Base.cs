using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParallelTests
{
    [TestFixture]
    public class Base
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void init()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void cleanUP()
        {
            driver.Quit();
        }
    }
}
