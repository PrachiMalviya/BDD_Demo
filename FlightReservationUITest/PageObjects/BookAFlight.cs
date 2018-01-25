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
//   Class:          FlightFinderPage
//   Description:    Class contains all objects and related operation for book a flight
//   Author:         Prachi                    Date: 23/01/2018
//   Change History:
//   Name:           Date:        Description:
//-----------------------------------------------------------------
namespace FlightReservationUITest.PageObjects
{
    public class BookAFlight
    {
        private IWebDriver driver;
        private WebDriverWait dynamicWait;
        //Constructor to initialise the driver
        public BookAFlight(IWebDriver browser)
        {
            this.driver = browser;
            this.dynamicWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(browser, this);            
        }
        //Objects
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'passFirst0')]")]
        public IWebElement firstName { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'passLast0')]")]
        public IWebElement LastName { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'creditCard')]")]
        public IWebElement CreditCardType { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'creditnumber')]")]
        public IWebElement creditnumber { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'ticketLess')]")]
        public IWebElement ticketLess { get; set; }        
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'buyFlights')]")]
        public IWebElement buyFlights { get; set; }
        //-----------------------------------------------------------------
        //   Function Name:  enterFirstLastName
        //   Description:    Enter First Name Last Name
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void enterFirstLastName(String Name1, String Name2)
        {
            try
            {
                if (CommonFunctions.CommonFunctions.dynamicSync(firstName, dynamicWait))
                    Assert.IsTrue(firstName.Displayed, "Book a flight page is Loaded");
                if (firstName.Displayed)
                    firstName.SendKeys(Name1);
                if (LastName.Displayed)
                    LastName.SendKeys(Name2);
                Console.WriteLine("First and Last Name entered Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("First and Last Name was not entered + " + e);
            }
        }
        //-----------------------------------------------------------------
        //   Function Name:  enterCreditCard
        //   Description:    Enter credit card
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void enterCreditCard()
        {
            try
            {                
                if (creditnumber.Displayed)
                    creditnumber.SendKeys("987698769876");
                if (ticketLess.Displayed)
                    ticketLess.Click();
                Console.WriteLine("Credit card entered and ticketless chosen Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Credit card entered and ticketless not entered + " + e);
            }
        }
        //-----------------------------------------------------------------
        //   Function Name:  fbuyFlights
        //   Description:    Buy Flights
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void fbuyFlights()
        {
            try
            {
                if (buyFlights.Displayed)
                    buyFlights.Click();
                Console.WriteLine("buy flights was clicked Successfull");
            }
            catch (Exception e)
            {
                Console.WriteLine("buy flights was not clicked  + " + e);
            }
        }

    }
}
