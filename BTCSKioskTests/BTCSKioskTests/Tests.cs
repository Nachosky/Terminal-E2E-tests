using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;

namespace BTCSKioskTests
{
    [TestFixture]
    public class Tests
    {
        public WindowsDriver<WindowsElement> driver;
        

        [SetUp]
        public void SetUp()
        {
            AppiumServerConfig.StartAppiumServer();
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), AppiumServerConfig.Capabilities());
        }
        
        [Test]
        public void WelcomeScreenIsVisibleInEnglishAtStart()
        {
         //prepare   
            var welcomeScreen = new Screens.WelcomeScreen(driver);

        //run

        //assert
           Assert.IsTrue(welcomeScreen.VerifyIfWelcomeScreenIsDisplayedInEnglish());
        }

        [Test]
        public void LicensePlateEnterScreenIsVisible()
        {
            //prepare   
            var welcomeScreen = new Screens.WelcomeScreen(driver);
            var licensePlateEnterScreen = new Screens.LicensePlateEnterScreen(driver);

            //run
            welcomeScreen
                .GoToLicensePlateEnterScreen();

            //assert
            Assert.IsTrue(licensePlateEnterScreen.VerifyLicensePlateEnterScreenIsVisible());
        }

        [Test]
        public void SomethingWentWrongScreenIsVisible()
        {
            //prepare   
            var welcomeScreen = new Screens.WelcomeScreen(driver);
            var licensePlateEnterScreen = new Screens.LicensePlateEnterScreen(driver);
            var somethingWentWrongScreen = new Screens.SomethingWentWrongScreen(driver);
            //run
            welcomeScreen
                .GoToLicensePlateEnterScreen();

            licensePlateEnterScreen
                .EnterValidLicensePlate();

            //assert
            Assert.IsTrue((somethingWentWrongScreen.SomethingWentWrongIsVisible()));
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
