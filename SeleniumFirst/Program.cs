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
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executeautomation", "Name");

            Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL(driver, "TitleId", "Id"));

            Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name"));

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");

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
