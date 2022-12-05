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

            PropertiesCollection.driver.Navigate().GoToUrl("https://demosite.executeautomation.com/Login.html"); //open login page

            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {

            LoginPageObject1 pageLogin = new LoginPageObject1();        //initialize login object page
            EAPageObjects pageEA = pageLogin.Login("MyUserName", "MyPassword");   //pass login method and link to EA object page

            //now create method in EA page objects

            pageEA.FillUserForm("F", "Vince", "Field");
            

        }
       /* [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close(); 

            Console.WriteLine("Closed browser");
        }*/
    }
}
