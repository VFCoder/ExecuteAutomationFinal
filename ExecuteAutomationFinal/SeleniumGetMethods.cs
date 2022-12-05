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
        public static string GetText(string element, PropertyType elementType) //use strong typed parameter propertytype
        {
            if (elementType == PropertyType.Id)  //use PropertyType
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementType == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return string.Empty;
        }
        public static string GetTextFromDropDown(string element, PropertyType elementType) 
        {
            if (elementType == PropertyType.Id)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == PropertyType.Name)
                return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return string.Empty;
        }

    }
}
