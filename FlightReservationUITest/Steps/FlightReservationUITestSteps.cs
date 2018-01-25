using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
//-----------------------------------------------------------------
//   Namespace:      FlightReservationUITest.Steps
//   Class:          FlightReservationUITestSteps
//   Description:    Class contains all steps definations
//   Author:         Prachi                    Date: 23/01/2018
//   Change History:
//   Name:           Date:        Description:
//-----------------------------------------------------------------
namespace FlightReservationUITest.Steps
{
    [Binding]
    public class FlightReservationUITestSteps
    {
        public IWebDriver driver;
        PageObjects.MercuryLoginPage loginObj;
        PageObjects.FlightFinderPage flightFinderObj;
        PageObjects.SelectFlightPage flightSelectObj;
        PageObjects.BookAFlight BookAFlightObj;
        [Given(@"Navigate to URL '(.*)'")]
        public void GivenNavigateToURL(string p0)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(p0);
        }
        
        [Given(@"Login into find a Flight authentication with Username '(.*)' and Password '(.*)'")]
        public void GivenLoginIntoFindAFlightAuthenticationWithUsernameAndPassword(string p0, string p1)
        {
            loginObj = new PageObjects.MercuryLoginPage(driver);
            loginObj.fLogin(p0,p1);
        }
        
        [When(@"Main Page is shown Select One Way radio button")]
        public void WhenMainPageIsShownSelectOneWayRadioButton()
        {
            flightFinderObj = new PageObjects.FlightFinderPage(driver);
            flightFinderObj.selectOneWayButton();
        }
        
        [Then(@"Select Depart from '(.*)' and Arrive to '(.*)'")]
        public void ThenSelectDepartFromAndArriveTo(string p0, string p1)
        {
            flightFinderObj.selectFromToPort(p0, p1);
        }
        
        [Then(@"Select '(.*)' Class")]
        public void ThenSelectClass(string p0)
        {
            flightFinderObj.selectFirstClass();
        }
        
        [Then(@"Click continue and navigate to Select Flight Page")]
        public void ThenClickContinueAndNavigateToSelectFlightPage()
        {
            flightFinderObj.FindFlightButtonClick();
        }
        
        [Then(@"Select Flight")]
        public void ThenSelectFlight()
        {
            flightSelectObj = new PageObjects.SelectFlightPage(driver);
            flightSelectObj.SelectFlights();
        }
        
        [Then(@"Enter '(.*)' and '(.*)'")]
        public void ThenEnterAnd(string p0, string p1)
        {
            BookAFlightObj = new PageObjects.BookAFlight(driver);
            BookAFlightObj.enterFirstLastName(p0, p1);
        }
        
        [Then(@"Provide Credit Card Details and check TicketLess Travel")]
        public void ThenProvideCreditCardDetailsAndCheckTicketLessTravel()
        {
            BookAFlightObj.enterCreditCard();
        }
        
        [Then(@"Click the Secure Purchase Button to finish booking")]
        public void ThenClickTheSecurePurchaseButtonToFinishBooking()
        {
            BookAFlightObj.fbuyFlights();
        }
    }
}
