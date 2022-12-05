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
        // (old method): public static void EnterText(IWebDriver driver, string element, string value, string elementType) 
        // step 1: remove ÏWebDriver driver instances from all methods
        // step 2: create new class for IWebDriver: "PropertiesCollection"
        public static void EnterText(string element, string value, string elementType) //removed IWebDriver driver instances
        {
           if (elementType == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value); // replace "driver"with PropertiesCollection.driver

            if (elementType == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        public static void Click(string element, string elementType)
        {
            if (elementType == "Id")
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();

            if (elementType == "Name")
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        public static void SelectDropDown(string element, string value, string elementType)
        {

            if (elementType == "Id")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementType == "Name")
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
