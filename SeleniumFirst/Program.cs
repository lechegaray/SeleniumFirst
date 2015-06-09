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
        static void Main(string[] args)
        {

        }

        [SetUp]
        public void Initialize()
        {

            PropertiesCollection.driver = new ChromeDriver();

            //Navigate to Google Page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");

        }

        [Test]
        public void ExecuteTest()
        {
            //login to app
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("execute", "automation");

            pageEA.FillUserForm("KK", "Karthik", "Automation");


            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetTextFromDDL("TitleId", PropertyType.Id));

            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);

        }

        [Test]
        public void NextText()
        {
            Console.WriteLine("Next Test Alert");
        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed Browser");

        }
    }
}
