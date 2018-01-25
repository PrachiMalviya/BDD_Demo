using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
//-----------------------------------------------------------------
//   Namespace:      FlightReservationUITest.PageObjects
//   Class:          MercuryLoginPage
//   Description:    Class contains all objects and related operation for Login Pager
//   Author:         Prachi                    Date: 23/01/2018
//   Change History:
//   Name:           Date:        Description:
//-----------------------------------------------------------------
namespace FlightReservationUITest.PageObjects
{
    public class MercuryLoginPage
    {
        private IWebDriver driver;
        private WebDriverWait dynamicWait;
        //Constructor to initialise the driver
        public MercuryLoginPage(IWebDriver browser)
        {
            this.driver = browser;
            this.dynamicWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(browser, this);            
        }
        //Page Objects
        //Mercury tours
        [FindsBy(How = How.XPath, Using = "//img[contains(@alt,'Mercury Tours')]")]
        public IWebElement mecuryTours { get; set; }
        //Username
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'userName')]")]
        public IWebElement userName{get;set;}
        //Password
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'password')]")]
        public IWebElement password{get;set;}
        //SignIn Button
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'login')]")]
        public IWebElement signInButton{get;set;}

        //Operation
        //-----------------------------------------------------------------
        //   Function Name:  fLogin
        //   Description:    Login using username and password
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void fLogin(String UsrName, String Passwd)
        {
            try
            {
                if (CommonFunctions.CommonFunctions.dynamicSync(mecuryTours, dynamicWait))
                    Assert.IsTrue(mecuryTours.Displayed, "Login Page is Loaded");
                if (userName.Displayed)
                    userName.SendKeys(UsrName);
                if (password.Displayed)
                    password.SendKeys(Passwd);
                if (signInButton.Enabled)               
                    signInButton.Click();
                    Console.WriteLine("Login Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Login UnSuccessful + " + e);
            }
        }
    }
}
