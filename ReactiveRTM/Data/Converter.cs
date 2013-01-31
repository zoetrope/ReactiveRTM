using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveRTM.Data
{
    public static class Converter
    {
        public static Dictionary<string, object> NVListToDictionary(global::org.omg.SDOPackage.NameValue[] nameValue)
        {
            return nameValue.ToDictionary(nv => nv.name, nv => nv.value);
        }

        public static global::org.omg.SDOPackage.NameValue[] DictionaryToNVList(Dictionary<string, object> dictionary)
        {
            return dictionary.Select(pair => new global::org.omg.SDOPackage.NameValue(pair.Key, pair.Value)).ToArray();
        }

        private const long UnixEpochBase = 621355968000000000;

        public static DateTime RtcTimeToDateTime(global::RTC.Time time)
        {
            return new DateTime(UnixEpochBase+((long)(time.sec) * 10000000 + ((long)time.nsec) / 100));
        }

        public static global::RTC.Time DateTimeToRtcTime(DateTime time)
        {
            global::RTC.Time ret;
            ret.sec = (int)((time.Ticks - UnixEpochBase) / 10000000);
            ret.nsec = (int)((time.Ticks % 10000000) * 100);
            return ret;
        }
    }
}
