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
//   Description:    Class contains all objects and related operation for flight finder
//   Author:         Prachi                    Date: 23/01/2018
//   Change History:
//   Name:           Date:        Description:
//-----------------------------------------------------------------
namespace FlightReservationUITest.PageObjects
{
    public class FlightFinderPage
    {
        private IWebDriver driver;
        private WebDriverWait dynamicWait;
        //Constructor to initialise the driver
        public FlightFinderPage(IWebDriver browser)
        {
            this.driver = browser;
            this.dynamicWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            PageFactory.InitElements(browser, this);            
        }
        //Objects
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'oneway')]")]
        public IWebElement oneWayRadioButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'fromPort')]")]
        public IWebElement fromPort { get; set; }
        [FindsBy(How = How.XPath, Using = "//select[contains(@name,'toPort')]")]
        public IWebElement toPort { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'First')]")]
        public IWebElement firstClass { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'findFlights')]")]
        public IWebElement findFlightsButton { get; set; }
        
        //Operations
        //----------------------------------------------------------------
        //   Function Name:  selectOneWayButton
        //   Description:    Select One Way
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void selectOneWayButton()
        {
            try
            {
                if (CommonFunctions.CommonFunctions.dynamicSync(oneWayRadioButton, dynamicWait))
                    Assert.IsTrue(oneWayRadioButton.Displayed, "Flight Finder page is Loaded");
                if (oneWayRadioButton.Displayed)
                    oneWayRadioButton.Click();
                Console.WriteLine("One way selection Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("One way selection unsuccessfull + " + e);
            }
        }
        //-----------------------------------------------------------------
        //   Function Name:  selectFromToPort
        //   Description:    Select from to port
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void selectFromToPort(String from, String to)
        {
            try
            {
                if (fromPort.Displayed)
                    fromPort.SendKeys(from);
                if (toPort.Displayed)
                    toPort.SendKeys(to);
                Console.WriteLine("From and to port selection Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("From and to selection unsuccessfull + " + e);
            }
        }
        //-----------------------------------------------------------------
        //   Function Name:  selectFirstClass
        //   Description:    Select First class
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void selectFirstClass()
        {
            try
            {
                if (firstClass.Displayed)
                    firstClass.Click();                
                Console.WriteLine("From and to port selection Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("From and to selection unsuccessfull + " + e);
            }
        }
        //-----------------------------------------------------------------
        //   Function Name:  FindFlightButtonClick
        //   Description:    Find flight button
        //   Author:         Prachi       Date: 23/01/2018
        //   Change History:
        //   Name:           Date:        Description:
        //----------------------------------------------------------------
        public void FindFlightButtonClick()
        {
            try
            {
                if (findFlightsButton.Displayed)
                    findFlightsButton.Click();
                Console.WriteLine("findFlights Button click Successful");
            }
            catch (Exception e)
            {
                Console.WriteLine("findFlights Button click UnSuccessful + " + e);
            }
        }
    }
}
