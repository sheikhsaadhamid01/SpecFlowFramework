using Automation.Framework.Core.WebUI.Constants;
using Automation.Framework.Core.WebUI.WebAbstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Selenium.WebDrivers.LocalWebDriver
{
    public  class ChromeWebDriver : IDriver
    {


        public ChromeWebDriver() { }

        public IWebDriver GetWebDriver(DriverOptions options)
        {
             return new ChromeDriver((ChromeOptions)options);
        }

        public bool IsApplicable(Browsers browsers)
        {
            switch (browsers)
            {
                case Browsers.chrome:
               
                    return true;
                default:
                    return false;
            }
        }
    }
}
