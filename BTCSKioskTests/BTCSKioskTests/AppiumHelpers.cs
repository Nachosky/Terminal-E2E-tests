using OpenQA.Selenium.Appium.Windows;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BTCSKioskTests
{
    public class AppiumHelpers
    {        
       public WindowsDriver<WindowsElement> driver { get; set; }

        public IWebElement FindAndroidElementWithWait(By by, TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver, timeout);

            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}
