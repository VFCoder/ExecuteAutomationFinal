using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal //custom methods to set values (text box, drop down menu, check box)
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

            //initial
            SeleniumSetMethods.EnterText(driver, "Initial", "UserText.", "Name");

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
