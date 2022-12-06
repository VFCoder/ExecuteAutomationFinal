using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    class LoginPageObject1      
    {

        public LoginPageObject1()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);  
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPageObjects Login(string userName, string password) 
        {

            txtUserName.EnterText(userName);        //add extension methods
            txtPassword.EnterText(password);
            btnLogin.Submit(); //click or clicks doesn't work


/*            txtUserName.SendKeys(userName);   //simplify with extension methods from setmethods
            txtPassword.SendKeys(password);
            btnLogin.Submit();
*/
            return new EAPageObjects();  
        }
    }
}