using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    class LoginPageObject       //create page objects for login page
    {

        public LoginPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);  //constructor to initialize objects
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObjects Login(string userName, string password) //create method to use in main class
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();

            return new EAPageObjects();   //initialize page objects and return instance of EA page from login
        }
    }
}
