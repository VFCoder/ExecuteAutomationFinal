using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal 
    
    //custom methods to set (input) values (text box, drop down menu, check box)
    //custom methods to get values (read values previously input)
    //refactor custom methods (reduce parameters, strongly typed parameters, more reusable)
{
    class Program
    {
        //IWebDriver driver = new ChromeDriver(); remove this, now using PropertiesCollections.drive

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            //initialize new instance of driver here:
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html"); //replace "driver"

            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //title
            SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", "Id"); //remove drivers

            Console.WriteLine("Title value is: " + SeleniumGetMethods.GetTextFromDropDown("TitleId","Id")); 


            //initial
            SeleniumSetMethods.EnterText("Initial", "UserText.", "Name");

            Console.WriteLine("Initial value is: " + SeleniumGetMethods.GetText("Initial", "Name")); 


            //click
            SeleniumSetMethods.Click("Save", "Name");

            Console.WriteLine("Executed Test");


        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close(); //replace driver

            Console.WriteLine("Closed browser");
        }
    }
}
