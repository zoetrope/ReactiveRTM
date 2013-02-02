using Common.Logging.Simple;
using ReactiveRTM.OpenRTM;
using System;
using System.Text;

namespace ReactiveRTM.Utility
{

    internal sealed class RtcLogger : AbstractSimpleLogger
    {
        private Logger _logger;
        private string _rtcName;

        internal RtcLogger(string typeName, string rtcName, Common.Logging.LogLevel logLevel, bool showLevel, bool showDateTime, bool showLogName, string dateTimeFormat)
            : base(typeName, logLevel, showLevel, showDateTime, showLogName, dateTimeFormat)
        {
            _rtcName = rtcName;
        }

        protected override void WriteInternal(Common.Logging.LogLevel targetLevel, object message, Exception e)
        {
            var sb = new StringBuilder();
            FormatOutput(sb, targetLevel, message, e);

            var record = new LogRecord() { 
                Level = (ReactiveRTM.OpenRTM.LogLevel)targetLevel,
                Message = sb.ToString(),
                Loggername = _rtcName,
                Time = DateTime.Now
            };

            _logger.Publish(record);
        }
    }
}
