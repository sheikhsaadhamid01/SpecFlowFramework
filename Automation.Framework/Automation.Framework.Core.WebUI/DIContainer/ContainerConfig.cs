using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.Reporting;
using Automation.Framework.Core.WebUI.Test.Base;
using Automation.Framework.Core.WebUI.WebAbstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Automation.Framework.Core.WebUI.DIContainer
{
    internal class ContainerConfig
    {
        public static IServiceProvider ConfigureService()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IDefaultVariables, DefaultVariables>();
            serviceCollection.AddSingleton<ILogging, Logging>();
            serviceCollection.AddSingleton<IGlobalProperties, GlobalProperties>();
            serviceCollection.AddTransient<ITestBase, TestBase>();
            serviceCollection.AddTransient<IUITestBase, UITestBase>();
            serviceCollection.AddTransient<ITestBaseManager, TestBaseManager>();


            return serviceCollection.BuildServiceProvider();


        }
    }
}
