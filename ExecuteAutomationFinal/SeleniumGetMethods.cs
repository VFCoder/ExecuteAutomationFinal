﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    class SeleniumGetMethods
    {
        public static string GetText(string element, string elementType) //remove IWebDriver drivers from methods, replace with PropertiesCollection.driver in code
        {
            if (elementType == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;
        }
        public static string GetTextFromDropDown(string element, string elementType) 
        {
            if (elementType == "Id")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == "Name")
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }

    }
}
