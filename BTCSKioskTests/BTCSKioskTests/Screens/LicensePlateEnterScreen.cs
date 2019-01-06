using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BTCSKioskTests.Screens
{
    public class LicensePlateEnterScreen
    {
        private WindowsDriver<WindowsElement> driver;

        public LicensePlateEnterScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
             
        }

        public bool VerifyLicensePlateEnterScreenIsVisible()
        {
            return driver.FindElementByClassName("Enter your licence plate number").Displayed;
        }

        public void EnterValidLicensePlate()
        {
            ClickWithTerminalDisplay("PV");
        }

        public void EnterInvalidLicensePlate()
        {
            ClickWithTerminalDisplay("Test123");
        }       
        

        public void GoToSummaryScreen()
        {
            driver.FindElementByName("CONTINUE").Click();
        }

        public void GoBackToWelcomeScreen()
        {
            driver.FindElementByName("CANCEL").Click();
        }

        private void ClickWithTerminalDisplay(string licensePlate)
        {
            foreach (char x in licensePlate)
            {
                var letter = x.ToString();
                driver.FindElementByName(letter).Click();
            }
        }

        
    }
}
