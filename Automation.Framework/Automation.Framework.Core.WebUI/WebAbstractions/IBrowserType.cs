using Automation.Framework.Core.WebUI.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Framework.Core.WebUI.WebAbstractions
{
    public interface IBrowserType
    {
        Browsers GetBrowserType(string browserName)
    }
}
