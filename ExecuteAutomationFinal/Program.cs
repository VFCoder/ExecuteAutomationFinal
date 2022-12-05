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
            EAPageObjects page = new EAPageObjects();       //create instance of page objects class with new methods

            page.txtInitial.SendKeys("UserInputText");

            page.btnSave.Click();

            


            /*            //title
                        SeleniumSetMethods.SelectDropDown("TitleId", "Ms.", PropertyType.Id); 
                        Console.WriteLine("Title value is: " + SeleniumGetMethods.GetTextFromDropDown("TitleId", PropertyType.Id)); 
                        //initial
                        SeleniumSetMethods.EnterText("Initial", "UserText.", PropertyType.Name);
                        Console.WriteLine("Initial value is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name)); 
                        //click
                        SeleniumSetMethods.Click("Save", PropertyType.Name);
                        Console.WriteLine("Executed Test");
            */

        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close(); 

            Console.WriteLine("Closed browser");
        }
    }
}
