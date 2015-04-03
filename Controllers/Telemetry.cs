using Microsoft.ApplicationInsights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARMExplorer.Controllers
{
    public static class Telemetry
    {
        private static TelemetryClient _client;

        static Telemetry()
        {
            _client = new TelemetryClient();
        }

        public static void LogInfo(string eventName, IDictionary<string, string> eventDictionary)
        {
            _client.TrackEvent(eventName, eventDictionary);
        }

        public static void LogException(Exception e)
        {
            _client.TrackException(e);
        }
    }
}