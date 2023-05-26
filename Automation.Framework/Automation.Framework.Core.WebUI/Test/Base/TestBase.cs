using Automation.Framework.Core.WebUI.WebAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Framework.Core.WebUI.Test.Base
{
    public class TestBase : ITestBase
    {
        private FeatureContext _featureContext;
        private Dictionary<string, string> _dataset;
        

        public TestBase() 
        {
            _dataset = new Dictionary<string, string>();
        }

        public void SetContext(FeatureContext featureContext) 
        {
            _featureContext = featureContext;
            
        }

        public FeatureContext GetContext()
        {
            return _featureContext;
        }


        public void SetDataSet(string key, string value)
        {
            if(!(string.IsNullOrEmpty(key) && string.IsNullOrEmpty(value)))
            {
                if (_dataset.ContainsKey(key))
                {
                    _dataset[key] = value;
                }
                else
                {
                    _dataset.Add(key, value);
                }
            }        
            
        }

        public string GetDataSet(string key)
        {
            return _dataset[key];
        }
    }
}
