using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using SimplerSettings;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.Windows;

namespace BTCSKioskTests
{
    public static class AppiumServerConfig
    {
        private static Process _process;
        private static string _applicationPath;

        static AppiumServerConfig()
        {
            _applicationPath = AppSettings.Get("AppPath");
           
        }

        public static DesiredCapabilities Capabilities()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("app", _applicationPath);
            capabilities.SetCapability("deviceName", "WindowsPC");
            return capabilities;
        }

        public static void StartAppiumServer()
        {
            _process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.FileName = AppSettings.Get("AppiumWinDriverPath");
            _process.StartInfo = startInfo;
            _process.Start();
        }        

    }
}
