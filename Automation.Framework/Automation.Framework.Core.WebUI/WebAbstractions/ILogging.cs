using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.WebAbstractions
{
    internal interface ILogging
    {
        void SetLogLevel(string loglevel);
        void Debug(string message);
        void Information(string message);
        void Warning(string message);
        void Error(string message);
        void Fatal(string message);
    }
}
