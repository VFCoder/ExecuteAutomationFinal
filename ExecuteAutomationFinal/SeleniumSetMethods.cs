using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    class SeleniumSetMethods
    {

        //  custom method to enter text:
        //  EnterText(element (text box), value (text to input), type (Id, Name, etc.))
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
           if (elementType == "Id")
            driver.FindElement(By.Id(element)).SendKeys(value);

            if (elementType == "Name") 
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //  click button method
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();

            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //  select drop down menu
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementType)
        {

            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
