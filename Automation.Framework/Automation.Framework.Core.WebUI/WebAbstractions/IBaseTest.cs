using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.WebAbstractions
{
    public interface ITestBase
    {
       // FeatureContext _featureContext;
        //Dictionary<string, string> _dataset;

        void SetContext(FeatureContext featureContext);
        FeatureContext GetContext();

        void SetDataSet(string key, string value);

        string GetDataSet(string key);

    }
}
