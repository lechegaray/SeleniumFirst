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
            //create the reference for the browser
            IWebDriver driver = new ChromeDriver();

            //Navigate to Google Page
            driver.Navigate().GoToUrl("http://www.google.com");

            //Find Element
            IWebElement element = driver.FindElement(By.Name("q"));

            //Perform Operations
            element.SendKeys("executeautomation");

            driver.Close();
        }
    }
}
