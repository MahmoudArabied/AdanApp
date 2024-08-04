using AdanUI.Domain.API.Aladhan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static AdanUI.Domain.AppConstants;

namespace AdanUI.Domain
{
    public static class Util
    {
        /// <summary>
        /// Format dateTime as date based on API format
        /// </summary>
        public static string DateTimeAPIFormat = "yyyy-MM-dd";

        public static string DateTimeAPIFormat2 = "dd-MM-yyyy";

        /// <summary>
        /// Format dateTime as time only 24H format
        /// </summary>
        public static string TimeOnlyFormat = "HH:mm:ss";

        //public static string DescriptionAttr<T>(this T source)
        //{
        //    FieldInfo fi = source.GetType().GetField(source.ToString());

        //    DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
        //        typeof(DescriptionAttribute), false);

        //    if (attributes != null && attributes.Length > 0)
        //    {
        //        return attributes[0].Description;
        //    }
        //    else
        //    {
        //        return source.ToString();
        //    }
        //}

        /// <summary>
        /// Get the related Hijri Month name in English
        /// </summary>
        /// <param name="iMonth">The monht index</param>
        /// <returns></returns>
        public static string GetHijriMonthName(int iMonth)
        {
            return iMonth switch
            {
                1 => "Muharram",
                2 => "Safar",
                3 => "Rabi al-Awwal",
                4 => "Rabi al-Thani",
                5 => "Jumada al-Awwal",
                6 => "Jumada al-Thani",
                7 => "Rajab",
                8 => "Shaban",
                9 => "Ramadan",
                10 => "Shawwal",
                11 => "Dhul Qadah",
                12 => "Dhul Hijjah",
                _ => "HijirMonth"
            };

        }

        /// <summary>
        /// Get the assigned image path for the given pray zone
        /// </summary>
        /// <param name="eTime">enum time <see cref="eTimes"/> </param>
        /// <returns></returns>
        public static eTimes GetNextTimePrayZone(eTimes eTime)
        {
            return eTime switch
            {
                eTimes.Fajr => eTimes.Sunrise,
                eTimes.Sunrise => eTimes.Dhuhr,
                eTimes.Dhuhr => eTimes.Asr,
                eTimes.Asr => eTimes.Maghrib,
                eTimes.Maghrib => eTimes.Isha,
                eTimes.Isha => eTimes.Sunrise,
                _ => eTimes.Sunrise,
            };
        }

        /// <summary>
        /// Get the assigned image path for the given pray zone
        /// </summary>
        /// <param name="eTime">enum time <see cref="eTimes"/> </param>
        /// <param name="bIsOn">Is the current time zone</param>
        /// <returns></returns>
        public static string GetBackgroundImage(eTimes eTime, bool bIsOn)
        {
            return eTime switch
            {
                eTimes.Sunrise => bIsOn ? "sunrise_on.png" : "sunrise_off.png",
                eTimes.Fajr => bIsOn ? "fajir_on.png" : "fajir_off.png",
                eTimes.Dhuhr => bIsOn ? "dahur_on.png" : "dahur_off.png",
                eTimes.Asr => bIsOn ? "asr_on.png" : "asr_off.png",
                eTimes.Maghrib => bIsOn ? "maghrib_on.png" : "maghrib_off.png",
                eTimes.Isha => bIsOn ? "isha_on.png" : "isha_off.png",
                _ => bIsOn ? "time_adan_on.png" : "time_adan_off.png",
            };
        }

        /// <summary>
        /// Get the assinged time for a give time pray
        /// </summary>
        /// <param name="eTime">The time type <see cref="AppConstants.eTimes"/></param>
        /// <param name="times">The retrieved times from API <see cref="Timings"/></param>
        /// <returns></returns>
        public static string GetDefinedTime(eTimes eTime, Timings times)
        {
            return eTime switch
            {
                eTimes.Imsak => times.Imsak,
                eTimes.Sunrise => times.Sunrise,
                eTimes.Fajr => times.Fajr,
                eTimes.Dhuhr => times.Dhuhr,
                eTimes.Asr => times.Asr,
                eTimes.Sunset => times.Sunset,
                eTimes.Maghrib => times.Maghrib,
                eTimes.Isha => times.Isha,
                eTimes.Midnight => times.Midnight,
                _ => "",
            };
        }
    }
}
