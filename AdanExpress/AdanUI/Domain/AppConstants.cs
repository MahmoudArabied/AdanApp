using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdanUI.Domain
{
    public static class AppConstants
    {
        public enum eTimes
        {
            /// <summary>
            /// Imsak time
            /// </summary>
            Imsak,

            /// <summary>
            /// Fajr time
            /// </summary>
            Fajr,

            /// <summary>
            /// Sunrise
            /// </summary>
            Sunrise,

            /// <summary>
            /// Dhuhr time
            /// </summary>
            Dhuhr,

            /// <summary>
            /// Asi time
            /// </summary>
            Asr,

            /// <summary>
            /// Sunset
            /// </summary>
            Sunset,

            /// <summary>
            /// Maghrib time
            /// </summary>
            Maghrib,

            /// <summary>
            /// Isha time
            /// </summary>
            Isha,

            /// <summary>
            /// Midnight
            /// </summary>
            Midnight,
        }
    }
}
