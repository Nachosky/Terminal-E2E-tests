using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;

namespace BTCSKioskTests.Screens
{
    public class SomethingWentWrongScreen
    {
        private WindowsDriver<WindowsElement> driver;

        public SomethingWentWrongScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public bool SomethingWentWrongIsVisible()
        {
            return driver.FindElementByName("Sorry!Looks like something went").Displayed;
        }

        public void GoBackToWelcomeScreen()
        {
            driver.FindElementByName("END").Click();
        }
    }
}
