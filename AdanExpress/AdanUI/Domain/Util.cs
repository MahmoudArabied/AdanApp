using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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


        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return source.ToString();
            }
        }

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

    }
}
