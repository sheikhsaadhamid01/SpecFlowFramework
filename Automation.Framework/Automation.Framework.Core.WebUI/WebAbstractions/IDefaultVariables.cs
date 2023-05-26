using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.WebAbstractions
{
    public interface IDefaultVariables
    {
         string Log { get; }
         string Resources { get; }
        string GridHubUrl { get; }

        string Region { get; }

        string LogLevel { get; }

        string FilePath { get; }

        string DonwloadPath { get; }
    }
}
