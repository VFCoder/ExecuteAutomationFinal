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
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");

            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");

            Console.WriteLine("Title value is: " + SeleniumGetMethods.GetText(driver,"TitleId","Id")); //this gets all possible values but we only want the one selected


            //initial
            SeleniumSetMethods.EnterText(driver, "Initial", "UserText.", "Name");

            Console.WriteLine("Initial value is: " + SeleniumGetMethods.GetText(driver, "Initial", "Name")); //this returns nothing


            //click
            SeleniumSetMethods.Click(driver, "Save", "Name");

            Console.WriteLine("Executed Test");


        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();

            Console.WriteLine("Closed browser");
        }
    }
}
