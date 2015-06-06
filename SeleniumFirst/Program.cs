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
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {



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
