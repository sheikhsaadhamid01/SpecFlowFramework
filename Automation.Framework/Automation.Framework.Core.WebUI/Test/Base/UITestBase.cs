using Automation.Framework.Core.WebUI.WebAbstractions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Test.Base
{
    public class UITestBase : TestBase,IUITestBase
    {
       
        private IWebDriver _driver;
        private IDefaultVariables _variables;
        private IBrowserType _browserType;

        public UITestBase(IDefaultVariables defaultVariable, IBrowserType browserType)
        {
            _variables = defaultVariable;
            _browserType = browserType;
        }

        public IWebDriver GetWebDriver()
        {
            if(_driver == null)
            {
                GetNewWebDriver();
            }
            return _driver;
        }
        private void GetNewWebDriver()
        {
            _browserType.GetBrowserType(_variable)

        }
    }
}
