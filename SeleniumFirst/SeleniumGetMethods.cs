using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");


        }

        public static string GetTextFromDDL(IWebElement element) //probably not very DRY here
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

    }
}
