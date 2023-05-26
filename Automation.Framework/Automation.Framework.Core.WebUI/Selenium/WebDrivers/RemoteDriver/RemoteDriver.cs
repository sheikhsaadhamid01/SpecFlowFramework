using Automation.Framework.Core.WebUI.Constants;
using Automation.Framework.Core.WebUI.WebAbstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Selenium.WebDrivers.RemoteDriver
{
    internal class RemoteDriver : IDriver
    {
        IGlobalProperties _globalProperties;


        public RemoteDriver(IGlobalProperties globalProperties)
        {
            _globalProperties = globalProperties;
        }

        public IWebDriver GetWebDriver(DriverOptions options)
        {
            return new RemoteWebDriver(new Uri(_globalProperties.GridHubUrl), options);

        }


        public bool IsApplicable(Browsers browsers)
        {
            switch (browsers)
            {
                case Browsers.firefox:
                case Browsers.chrome:
                case Browsers.remotechrome:
                case Browsers.remotefirefox:

                    return true;
                default:
                    return false;
            }
        }

    }
}
