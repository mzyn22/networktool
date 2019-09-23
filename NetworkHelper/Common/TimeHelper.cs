using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetworkHelper.Common
{
    public class TimeHelper
    {
        public static string GetDayString(long milliseconds)
        {
            int millisecondsPerDay = 24 * 60 * 60 * 1000;
            int day = (int)(milliseconds / millisecondsPerDay);
            int millisecondLeft = (int)(milliseconds % millisecondsPerDay);
            int millisecondsPerHour = 60 * 60 * 1000;
            int hour = millisecondLeft / millisecondsPerHour;
            millisecondLeft = millisecondLeft % millisecondsPerHour;
            int millisecondsPerMinute = 60 * 1000;
            int minute = millisecondLeft / millisecondsPerMinute;
            millisecondLeft = millisecondLeft % millisecondsPerMinute;
            int second = millisecondLeft / 1000;
            return day + "天" + hour + "小时" + minute + "分" + second + "秒";
        }
    }
}
