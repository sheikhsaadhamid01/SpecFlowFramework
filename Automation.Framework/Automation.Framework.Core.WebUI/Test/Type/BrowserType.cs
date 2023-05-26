using Automation.Framework.Core.WebUI.Constants;
using Automation.Framework.Core.WebUI.WebAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Test.Type
{
    public class BrowserType : IBrowserType
    {

        public Browsers GetBrowserType(string browserName)
        {
            if (String.IsNullOrEmpty(browserName))
            {
                return Browsers.chrome;
            }
            else
            {
                string browser = browserName.ToLower();
                switch (browser)
                {
                    case "chrome":
                        return Browsers.chrome;
                    case "firefox":
                        return Browsers.firefox;
                    case "remotechrome":
                    case "remote-chrome":
                    case "remote chrome":
                        return Browsers.remotechrome;
                    case "remote firefox":
                    case "remote-firefox":
                    case "remotefirefox":
                        return Browsers.remotefirefox;
                    default:
                        return Browsers.chrome;
                }
            }
        }
    }
}
