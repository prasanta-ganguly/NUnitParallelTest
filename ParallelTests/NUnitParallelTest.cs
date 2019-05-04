using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelTests
{
    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTest : Base
    {
        [Test]
        public void googleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Test Automation" + Keys.Enter);
            //searchBox.SendKeys(Keys.Enter);
            Console.WriteLine("PASSED");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTestTwo : Base
    {
        [Test]
        public void youtubeSearch()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com");
            driver.FindElement(By.Id("search")).SendKeys("Selenium Training" + Keys.Enter);
            Console.WriteLine("PASSED");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTestThree : Base
    {
        [Test]
        public void msnSearch()
        {
            driver.Navigate().GoToUrl("https://msn.com");
            driver.FindElement(By.Id("q")).SendKeys("Selenium" + Keys.Enter);
            Console.WriteLine("PASSED");
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTestFour : Base
    {
        [Test]
        public void rediffSearch()
        {
            driver.Navigate().GoToUrl("https://www.rediff.com");
            driver.FindElement(By.Id("srchword")).SendKeys("Specflow" + Keys.Enter);
            Console.WriteLine("PASSED");
            
        }
    }
}
