using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    public static class SeleniumSetMethods //must be public static class
    {

        public static void EnterText(this IWebElement element, string value) //this = extension method
        {
            element.SendKeys(value);
        }

        public static void Clicks(this IWebElement element) //change to Click"s" to find the custom method in EAPageObjects
        {
            element.Click();
        }

        public static void SelectDropDown(this IWebElement element, string value) //add "this, now call method directly in EAPageObjects
        {
                new SelectElement(element).SelectByText(value);
        }
    }
}
