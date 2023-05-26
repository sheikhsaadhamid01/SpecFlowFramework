using Automation.Framework.Core.WebUI.Reporting;
using Automation.Framework.Core.WebUI.WebAbstractions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Params
{
    internal class GlobalProperties : IGlobalProperties
    {
        IDefaultVariables _defaultVariables;
        ILogging _logging;

        public string BrowserType { get; set; }

        public string BrowserVersion { get; set; }

        public string GridHubUrl { get;  set; }

        public string Region { get; set; }

        public bool StepScreenShot { get; set; }
        public string ExtentReportPortalUrl { get; set; }

        public string ExtentReportToPortal { get; set; }

        public string LogLevel { get; set; }

        public string DataSetLocation { get; set; }

        public string DownloadedLocation { get; set; }

        

        public GlobalProperties(IDefaultVariables defaultVariable, ILogging logging) 
        {
            _defaultVariables = defaultVariable;
            _logging = logging;
            Configuration();
        }
        public void Configuration()
        {
            IConfiguration builder = null;
            IConfiguration regionConfiguration = null;
            try
            {
                builder = new ConfigurationBuilder()
                                .SetBasePath(_defaultVariables.Resources)
                                .AddJsonFile("frameworkSettings.json")
                                .Build();

                
            }
            catch(FileNotFoundException fe) 
            {
                _logging.Error($"frameworkSetting.json do not exists.{fe.Message}");
                System.Environment.Exit(0);
            }

            BrowserType = string.IsNullOrEmpty(builder["BrowserType"]) ? "chrome" : builder["BrowserType"];
            BrowserVersion = builder["BrowserVersion"];
            GridHubUrl = string.IsNullOrEmpty(builder["GridHubUrl"]) ? _defaultVariables.GridHubUrl : builder["GridHubUrl"];
            Region = builder["Region"];
            string stepScreenShotValue = string.IsNullOrEmpty(builder["StepScreenShot"]) ? "off" : builder["StepScreenShot"];
            StepScreenShot = stepScreenShotValue.ToLower().Equals("off") ? false : true;
            ExtentReportPortalUrl = builder["ExtendReportPortalUrl"];
            LogLevel = string.IsNullOrEmpty(builder["LogLevel"]) ? _defaultVariables.LogLevel : builder["LogLevel"];
            DataSetLocation = string.IsNullOrEmpty(builder["DataSetLocation"]) ? _defaultVariables.FilePath : builder["DataSetLocation"];
            DownloadedLocation = string.IsNullOrEmpty(builder["DownloadLocation"]) ? _defaultVariables.FilePath : builder["DownloadLocation"];

           if(Region == null)
            {
                _logging.Error("User has not provided the Region information");
                System.Environment.Exit(0);
            }

            else
            {
                _logging.SetLogLevel(LogLevel);
            }


            try
            {
                regionConfiguration = new ConfigurationBuilder()
                                .SetBasePath(_defaultVariables.Resources)
                                .AddJsonFile("applicationRegion.json")
                                .Build();
                regionConfiguration.GetSection(Region);


            }
            catch (FileNotFoundException fe)
            {
                _logging.Error($"ApplicationRegion.json do not exists.{fe.Message}");
                System.Environment.Exit(0);
            }


            _logging.Debug("********************************************************************************");
            _logging.Information("********************************************************************************");
            _logging.Information("Configuration |RUN PARAMETERS");
            _logging.Information("********************************************************************************");
            _logging.Information("Configuration|BROWSER TYPE: " + BrowserType);
            _logging.Information("Configuration|BROWSER VERSION: " + BrowserVersion);
            _logging.Information("Configuration|GRID HUB URL: " + GridHubUrl);
            _logging.Information("Configuration|REGION: " + builder["region"]);
            _logging.Information("Configuration|STEP SCREENSHOT: " + builder["StepScreenShot"]);
            _logging.Information("Configuration|EXTENT REPORT PORTAL URL: " + ExtentReportPortalUrl);
            _logging.Information("Configuration|EXTENT REPORT LOCALLY: " + builder["ExtentReportToPortal"]);
            _logging.Information("Configuration|LOG LEVEL: " + LogLevel);
            _logging.Information("Configuration|DATA SET LOCATION: " + DataSetLocation);
            _logging.Information("Configuration|DOWNLOADED LOCATION: " + DownloadedLocation);
            _logging.Information("********************************************************************************");
            _logging.Information("********************************************************************************");



        }
    }
}
