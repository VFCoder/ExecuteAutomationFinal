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

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();

            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/index.html");

            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            //title
            SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id); //use Strongly Typed Parameters in case values change, easy to fix

            Console.WriteLine("Title value is: " + SeleniumGetMethods.GetTextFromDropDown("TitleId", PropertyType.Id)); 


            //initial
            SeleniumSetMethods.EnterText("Initial", "UserText.", PropertyType.Name);

            Console.WriteLine("Initial value is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name)); 


            //click
            SeleniumSetMethods.Click("Save", PropertyType.Name);

            Console.WriteLine("Executed Test");


        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close(); 

            Console.WriteLine("Closed browser");
        }
    }
}
