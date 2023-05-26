using Automation.Framework.Core.WebUI.Constants;
using Automation.Framework.Core.WebUI.WebAbstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Selenium.BrowserProfiles
{
    public class ChromeProfile : IBrowserProfile
    {

        IGlobalProperties _globalProperties;

        public ChromeProfile(IGlobalProperties globalProperties)
        {
            _globalProperties = globalProperties;
        }
        public DriverOptions GetBrowserProfile()
        {
            ChromeOptions options = new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            options.AddArgument("disable-extensions");
            options.AddArgument("disable-infobars");
            options.AddArgument("disable-notifications");
            options.AddArgument("disable-web-security");
            options.AddArgument("dns-prefetch-disable");
            options.AddArgument("disable-browser-side-navigation");
            options.AddArgument("disable-gpu");
            options.AddArgument("always-authorize-plugins");
            options.AddUserProfilePreference("download.default_directory",_globalProperties.DownloadedLocation);

            return options;
            

        }

        public bool IsApplicable(Browsers browsers)
        {
            switch (browsers)
            {
                case Browsers.chrome:
                case Browsers.remotechrome:
                    return true;
                default:
                    return false;
            }
        }

    }
}
