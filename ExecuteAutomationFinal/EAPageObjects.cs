using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteAutomationFinal
{
    class EAPageObjects           

    {

        public EAPageObjects()      
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using ="TitleId")]
        public IWebElement ddTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string firstName, string middleName)  
        {
            SeleniumSetMethods.EnterText(txtInitial, initial);          //create custom methods from set/get
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);


/*            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            btnSave.Click();*/
        }
    }
}
