using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;

namespace BTCSKioskTests.Screens
{
    public class WrongIdentificationScreen
    {
        private WindowsDriver<WindowsElement> driver;

        public WrongIdentificationScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public bool SomethingWentWrongPage()
        {
            return driver.FindElementByName("We are not able to identify entry").Displayed;
        }

        public void GoBackToWelcomeScreen()
        {
            driver.FindElementByName("END").Click();
        }

        public void GoBackToLicensePlateEnterScreen()
        {
            driver.FindElementByName("TRY AGAIN").Click();
        }

    }
}
