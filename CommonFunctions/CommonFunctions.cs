using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightReservationUITest.CommonFunctions
{
    public class CommonFunctions
    {
        //-----------------------------------------------------------------
        //   Function Name:  dynamicSync
        //   Description:    wait until page is in ready state
        //   Author:         Raj       Date: 10/04/2017
        //   Change History:
        //   Name:           Date:        Description:
        //-----------------------------------------------------------------
        public static bool dynamicSync(IWebElement webElement, WebDriverWait dynamicWait)
        {
            try
            {
                bool syncCheck;
                syncCheck = dynamicWait.Until(d => (bool)(webElement as IWebElement).Displayed);
                Thread.Sleep(5000);
                return syncCheck;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:-" + e);
                return false;
            }
        }
    }
}
