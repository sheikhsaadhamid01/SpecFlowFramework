using Automation.Framework.Core.WebUI.DIContainer;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Test.Base;
using Automation.Framework.Core.WebUI.WebAbstractions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.Runner
{
    [Binding]
    public class SpecflowRunner
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ServiceProvider = ContainerConfig.ConfigureService();
            ServiceProvider.GetRequiredService<IGlobalProperties>();
           
           
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            UITestBase uiTestBase = (UITestBase)ServiceProvider.GetRequiredService<IUITestBase>();
            uiTestBase.SetContext(featureContext);
            ITestBaseManager testBaseManager = ServiceProvider.GetRequiredService<ITestBaseManager>();
            testBaseManager.SetTestBase(uiTestBase);



        }


    }
}
