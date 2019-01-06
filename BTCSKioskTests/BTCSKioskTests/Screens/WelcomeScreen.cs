using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Windows;

namespace BTCSKioskTests.Screens
{
    public class WelcomeScreen
    {
        private WindowsDriver<WindowsElement> driver;

        public WelcomeScreen(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }

        public void GoToLicensePlateEnterScreen()
        {
            driver.FindElementByClassName("WelcomeScreenView").Click();
        }

        public bool VerifyIfEnglishVersion()
        {
           return driver.FindElementByAccessibilityId("LastChild").Displayed;
        }

        public bool VerifyIfWelcomeScreenIsDisplayedInEnglish()
        {
            return driver.FindElementByName("Welcome!").Displayed;
        }
        
      }
    }

