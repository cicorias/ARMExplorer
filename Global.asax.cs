﻿using ARMExplorer.App_Start;
using System.Configuration;
using System.Web.Http;

namespace ARMExplorer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start()
        {
            Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
                .Active.InstrumentationKey = ConfigurationManager.AppSettings["AppInsightKey"];

            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}