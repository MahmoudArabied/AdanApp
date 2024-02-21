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
    }
}
