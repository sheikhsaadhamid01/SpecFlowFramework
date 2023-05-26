using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Framework.Core.WebUI.Params;
using Automation.Framework.Core.WebUI.WebAbstractions;
using Serilog;
using Serilog.Core;

namespace Automation.Framework.Core.WebUI.Reporting
{
    internal class Logging : ILogging
    {

        LoggingLevelSwitch _levelLoggingSwitch;
        IDefaultVariables _iDefaultVariables;

        public Logging(IDefaultVariables defaultVariables) 
        {
            _iDefaultVariables = defaultVariables;
            _levelLoggingSwitch = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Debug);
            Log.Logger = new LoggerConfiguration().MinimumLevel.ControlledBy(_levelLoggingSwitch).WriteTo
                .File(_iDefaultVariables.Log, outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .Enrich.WithThreadId().CreateLogger();
        }

        public void SetLogLevel(string loglevel)
        {
            switch (loglevel)
            {
                case "debug":
                    {
                         _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Debug;
                        break;

                        
                    }

                case "error":
                    {
                        _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Error;
                        break;
                    }

                case "warning":
                    {
                        _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Warning;
                        break;
                    }

                case "information":
                    {
                        _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Information;
                        break;
                    }

                case "fatal":
                    {
                        _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Fatal;
                        break;
                    }

                default:
                    {
                        _levelLoggingSwitch.MinimumLevel = Serilog.Events.LogEventLevel.Debug;
                        break;
                    }
            }
        }

        public void Debug(string message)
        {
            Log.Logger.Debug(message);
        }

        public void Information(string message)
        {
            Log.Logger.Information(message);
        }

        public void Error(string message) 
        {
            Log.Logger.Error(message);
        }

        public void Warning(string message)
        {
            Log.Logger.Warning(message);    
        }

        public void Fatal(string message)
        {
            Log.Logger.Fatal(message);
        }
    }
}
