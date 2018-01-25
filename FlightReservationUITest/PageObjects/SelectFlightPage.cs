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
//   Description:    Class contains all objects and related operation for select flight
//   Author:         Prachi                    Date: 23/01/2018
//   Change History:
//   Name:           Date:        Description:
//-----------------------------------------------------------------
namespace FlightReservationUITest.PageObjects
{
    public class SelectFlightPage
    {
        private IWebDriver driver;
        private WebDriverWait dynamicWait;
        //Constructor to initialise the driver
        public SelectFlightPage(IWebDriver browser)
        {
            this.driver = browser;
            this.dynamicWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(browser, this);            
        }
        //Objects
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Blue Skies Airlines$361')]")]
        public IWebElement BSAirline361 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Blue Skies Airlines$631')]")]
        public IWebElement BSAirline631 { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'reserveFlights')]")]
        public IWebElement reserveFlights { get; set; }
        
        //Operations    
        //-----------------------------------------------------------------
        //   Function Name:  SelectFlights
        //   Description:    Select Flights
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void SelectFlights()
        {
            try
            {
                if (CommonFunctions.CommonFunctions.dynamicSync(BSAirline361, dynamicWait))
                    Assert.IsTrue(BSAirline361.Displayed, "Flight selection page is Loaded");
                if (BSAirline361.Displayed)
                    BSAirline361.Click();
                if (BSAirline631.Displayed)
                    BSAirline631.Click();
                if (reserveFlights.Enabled)
                    reserveFlights.Click();
                Console.WriteLine("Flights selection Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("Flights selection unsuccessfull + " + e);
            }
        }        
        
    }
}
