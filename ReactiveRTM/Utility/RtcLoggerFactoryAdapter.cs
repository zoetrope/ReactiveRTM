using Common.Logging;
using Common.Logging.Simple;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Utility
{
    /// <summary>
    /// LoggerFactoryAdapter for use of the RtcLogger
    /// </summary>
    public sealed class RtcLoggerFactoryAdapter : AbstractSimpleLoggerFactoryAdapter
    {
        public RtcLoggerFactoryAdapter()
            : base(null)
        {

        }

        public RtcLoggerFactoryAdapter(NameValueCollection properties)
            : base(properties)
        {
        }

        protected override ILog CreateLogger(string name, Common.Logging.LogLevel level, bool showLevel, bool showDateTime, bool showLogName, string dateTimeFormat)
        {
            var names = name.Split('@');

            string rtcName;
            string typeName;

            if (names.Length == 2)
            {
                typeName = names[0];
                rtcName = names[1];
            }
            else
            {
                typeName = name;
                rtcName = "unknown";
            }

            return new RtcLogger(typeName, rtcName, level, showLevel, showDateTime, showLogName, dateTimeFormat);
        }
    }
}
