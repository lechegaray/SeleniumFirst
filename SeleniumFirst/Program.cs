using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        //create the reference for the browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {

        }
        [SetUp]
        public void Initialize()
        {

            //Navigate to Google Page
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opened URL");

        }
        [Test]
        public void ExecuteTest()
        {

            //Find Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operations
            element.SendKeys("executeautomation");

            Console.WriteLine("Executed Test");

        }

        [Test]
        public void NextText()
        {
            Console.WriteLine("Next Test Alert");
        }


        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("Closed Browser");

        }
    }
}
