using Automation.Framework.Core.WebUI.DIContainer;
using Automation.Framework.Core.WebUI.Runner;
using Automation.Framework.Core.WebUI.WebAbstractions;
using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Analytics;
using static System.Net.Mime.MediaTypeNames;

namespace Automation.Framework.Core.WebUI.WebTests
{
    [Binding]
    public class SearchStepDefinition
    {


        private ITestBaseManager _iTestManager;
        private ILogging _iLogging;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _iTestManager = SpecflowRunner.ServiceProvider.GetRequiredService<ITestBaseManager>();
            _iLogging = SpecflowRunner.ServiceProvider.GetRequiredService<ILogging>();
        }
        [Given(@"User is on the page ""([^""]*)""")]
        public void GivenUserIsOnThePage(string url)
        {

            _iLogging.Debug($"About to Navigate to {url} ");
            _iTestManager.GetUITestBase().GetWebDriver().Navigate().GoToUrl(url);
            _iLogging.Debug($"Navigated to {url} successfully");
            _iLogging.Information("About to initiate wait for 2 seconds");
            Thread.Sleep(2000);
        }

        [When(@"User save value ""([^""]*)"" with key ""([^""]*)""")]
        public void WhenUserSaveValueWithKey(string value, string key)
        {
            _iLogging.Debug($"About to store {value} value in {key} using TestBase.SetDataSet Method");
            _iTestManager.GetTestBase().SetDataSet(key, value);
            _iLogging.Debug("Data stored successfully in Dictionary");
        }

        [When(@"User provides ""([^""]*)"" to locator ""([^""]*)""")]
        public void WhenUserProvidesToLocator(string text, string locator)
        {
            _iLogging.Debug($"About to provide {text} in {locator}");
            _iTestManager.GetUITestBase().GetWebDriver().FindElement(By.XPath(locator)).SendKeys(text);
            _iLogging.Debug($"{text} provided successfuly in {locator}");
        }

      

     

        [When(@"User fetch value of key ""([^""]*)"" and enter to locator ""([^""]*)""")]
        public void WhenUserFetchValueOfKeyAndEnterToLocator(string key, string locator)
        {
            _iLogging.Debug($"About to get stored data from dictionary for {key}");
            string value = _iTestManager.GetTestBase().GetDataSet(key);
            _iLogging.Debug($"About to provide {value} in Locator: {locator} to perform search");
            _iTestManager.GetUITestBase().GetWebDriver().FindElement(By.XPath(locator)).Clear();
            _iTestManager.GetUITestBase().GetWebDriver().FindElement(By.XPath(locator)).SendKeys(value);
            _iLogging.Debug($"Succesfully provided {value} in  Locator: {locator}");
        }


        [When(@"User clicks object ""([^""]*)""")]
        public void WhenUserClicksObject(string locator)
        {
            _iLogging.Debug($"About to click on  button with locator: {locator}");
            _iTestManager.GetUITestBase().GetWebDriver().FindElement(By.XPath(locator)).Click();
            _iLogging.Debug($"Button availabale at {locator} clicked successfully");
        }


        [Then(@"User close the browser")]
        public void WhenUserCloseTheBrowser()
        {
            _iLogging.Debug($"About to call Quit Method to close Browser");
            Thread.Sleep(2000);
            _iTestManager.GetUITestBase().GetWebDriver().Quit();
            _iLogging.Debug("Browser closed Successfully");
        }



    }
}
