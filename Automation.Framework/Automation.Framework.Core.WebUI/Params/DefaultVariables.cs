using Automation.Framework.Core.WebUI.WebAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.Params
{
     class DefaultVariables : IDefaultVariables
    {
        public string Results
        {
            get
            {
                return System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../")
                    .FullName + @"\Results\Reports_" + DateTime.Now.ToString("yymmdd hhmmss");
            }
        }

        public string Log { 
            get 
            {
                return Results + "\\log.txt";
            } 
        }

        public string Resources
        {
            get
            {
                return  System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../")
                    .FullName + @"\Resources";
            }
        }


        public string GridHubUrl
        {
            get
            {
                return "https://localhost:4444/wd/hub";
            }
        }

        public string Region
        {
            get
            {
                return "T2";
            }
        }


        public string LogLevel
        {
            get
            {
                return "Debug";
            }
        }

        public string FilePath
        {
            get
            {
                String path = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../").FullName + "\\DataSetLocation";

                return path;
            }
        }

        public string DonwloadPath
        {
            get
            {
                string path = System.IO.Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory + "../../../")
                    .FullName + @"\Results";
                return path;
            }
        }

        //public string log => throw new NotImplementedException();
    }
}
