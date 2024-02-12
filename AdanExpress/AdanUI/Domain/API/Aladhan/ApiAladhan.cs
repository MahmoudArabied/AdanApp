using Kotlin.System;
using static AdanUI.Domain.API.PrayerTimes.ApiPrayer;

namespace AdanUI.Domain.API.Aladhan
{
    /// <summary>
    /// Based on documentation from https://aladhan.com/prayer-times-api
    /// </summary>
    public static class ApiAladhan
    {
        /**
         * 
         *  Prayer Times Calendar - https://api.aladhan.com/v1/calendar/:year/:month
         *  Prayer Times Calendar by address - https://api.aladhan.com/v1/calendarByAddress/:year/:month
         *  Prayer Times Calendar by city - https://api.aladhan.com/v1/calendarByCity/:year/:month
         *  Prayer Times Hijri Calendar - https://api.aladhan.com/v1/hijriCalendar/:year/:month
         *  Prayer Times Hijri Calendar by address - https://api.aladhan.com/v1/hijriCalendarByAddress/:year/:month
         *  Prayer Times Hijri Calendar by city - https://api.aladhan.com/v1/hijriCalendarByCity/:year/:month
         *  Prayer Times Methods - https://api.aladhan.com/v1/methods
         *  Timings - https://api.aladhan.com/v1/timings/:date
         *  Timings By Address - https://api.aladhan.com/v1/timingsByAddress/:date
         *  Timings By City - https://api.aladhan.com/v1/timingsByCity/:date
         * 
         * */

        /// <summary>
        /// Define type of Times request
        /// </summary>
        public enum enumApiAladhanRequestOption
        {
            /// <summary>
            /// Returns all prayer times for a specific calendar month
            /// 
            /// "latitude" (decimal) -  The decimal value for the latitude co-ordinate of the location you want the time computed for. Example: 51.75865125
            /// "longitude" (decimal) - The decimal value for the longitude co-ordinate of the location you want the time computed for. Example: -1.25387785
            /// "month" (number) - Optional.A gregorian calendar month.Example: 8 or 08 for August.If not specified, an annual calendar will be returned.
            /// "year" (number) - A gregorian calendar year. Example: 2014
            /// 
            /// Example
            /// https://api.aladhan.com/v1/calendar/2024/4?latitude=51.508515&longitude=-0.1254872&method=2
            /// </summary>
            Calendar,

            /// <summary>
            /// Returns all prayer times for a specific calendar month at a particular address
            /// 
            /// "address" (string) - An address string. Example: 1420 Austin Bluffs Parkway, Colorado Springs, CO OR 25 Hampstead High Street, London, NW3 1RL, United Kingdom OR Sultanahmet Mosque, Istanbul, Turkey
            /// "month" (number) - Optional.A gregorian calendar month.Example: 8 or 08 for August.If not specified, an annual calendar will be returned.
            /// "year" (number) - A gregorian calendar year. Example: 2024
            /// 
            /// Example
            /// https://api.aladhan.com/v1/calendarByAddress/2024/4?address=Sultanahmet%20Mosque,%20Istanbul,%20Turkey&method=2
            /// </summary>
            calendarByAddress,

            /// <summary>
            /// Returns all prayer times for a specific calendar month by City
            /// city" (string) - A city name. Example: London 
            /// "country" (string) - A country name or 2 character alpha ISO 3166 code.Examples: GB or United Kindom 
            /// "state" (string) - State or province.A state name or abbreviation.Examples: Colorado / CO / Punjab / Bengal 
            /// "month" (number) - Optional.A gregorian calendar month.Example: 8 or 08 for August.If not specified, an annual calendar will be returned. 
            /// "year" (number) - A gregorian calendar year. Example: 2024
            /// 
            /// Example
            /// https://api.aladhan.com/v1/calendarByCity/2024/4?city=London&country=United%20Kingdom&method=2
            /// </summary>
            calendarByCity,

            /// <summary>
            /// Returns all prayer times for a specific Hijri calendar month
            /// 
            /// "latitude" (decimal) -  The decimal value for the latitude co-ordinate of the location you want the time computed for. Example: 51.75865125 
            /// "longitude" (decimal) - The decimal value for the longitude co-ordinate of the location you want the time computed for. Example: -1.25387785 
            /// "month" (number) - Optional.A Hijri calendar month.Example: 9 or 09 for Ramadan.If not specified, an annual calendar will be returned. 
            /// "year" (number) - A Hijri calendar year. Example: 1445
            /// 
            /// Example
            /// https://api.aladhan.com/v1/hijriCalendar/1445/4?latitude=51.508515&longitude=-0.1254872&method=2
            /// </summary>
            hijriCalendar,

            /// <summary>
            /// Returns all prayer times for a specific Hijri calendar month at a particular address
            /// 
            /// "address" (string) - An address string. Example: 1420 Austin Bluffs Parkway, Colorado Springs, 
            /// CO OR 25 Hampstead High Street, London, NW3 1RL, United Kingdom OR Sultanahmet Mosque, Istanbul, Turkey
            /// "month" (number) - Optional.A Hijri calendar month.Example: 9 or 09 for Ramadan.If not specified, an annual calendar will be returned.
            /// "year" (number) - A Hijri calendar year. Example: 1437
            /// </summary>
            hijriCalendarByAddress,

            /// <summary>
            /// Returns all prayer times for a specific Hijri calendar month by City
            /// 
            /// "city" (string) -  A city name. Example: London 
            /// "country" (string) - A country name or 2 character alpha ISO 3166 code.Examples: GB or United Kindom 
            /// "state" (string) - State or province.A state name or abbreviation.Examples: Colorado / CO / Punjab / Bengal 
            /// "month" (number) - Optional.A Hijri calendar month.Example: 9 or 09 for Ramadan.If not specified, an annual calendar will be returned. 
            /// year" (number) - A Hijri calendar year. Example: 1445
            /// 
            /// Example
            /// https://api.aladhan.com/v1/hijriCalendarByAddress/1445/4?address=Sultanahmet%20Mosque,%20Istanbul,%20Turkey&method=2
            /// </summary>
            hijriCalendarByCity,

            /// <summary>
            /// Returns all the prayer times calculation methods supported by this API. For more information on how to use custom methods
            /// See https://aladhan.com/calculation-methods
            /// 
            /// Example 
            /// https://api.aladhan.com/v1/methods
            /// 
            /// 1 - University of Islamic Sciences, Karachi
            /// 2 - Islamic Society of North America
            /// 3 - Muslim World League
            /// 4 - Umm Al-Qura University, Makkah
            /// 5 - Egyptian General Authority of Survey
            /// 7 - Institute of Geophysics, University of Tehran
            /// 8 - Gulf Region
            /// 9 - Kuwait
            /// 10 - Qatar
            /// 11 - Majlis Ugama Islam Singapura, Singapore
            /// 12 - Union Organization islamic de France
            /// 13 - Diyanet İşleri Başkanlığı, Turkey
            /// 14 - Spiritual Administration of Muslims of Russia
            /// 15 - Moonsighting Committee Worldwide (also requires shafaq parameter)
            /// </summary>
            methods,

            /// <summary>
            /// Returns all prayer times for a specific date
            /// 
            /// "date" (string) - A date in the DD-MM-YYYY format. Default's to the current date via an HTTP 301. 
            /// "latitude" (decimal) - The decimal value for the latitude co-ordinate of the location you want the time computed for. Example: 51.75865125 
            /// "longitude" (decimal) - The decimal value for the longitude co-ordinate of the location you want the time computed for. Example: -1.25387785
            /// 
            /// Example
            /// https://api.aladhan.com/v1/timings/12-02-2024?latitude=51.508515&longitude=-0.1254872&method=2
            /// </summary>
            timings,

            /// <summary>
            /// Returns all prayer times for a specific date at a particular address
            /// 
            /// "date" (string) - A date in the DD-MM-YYYY format. Default's to the current date via an HTTP 301.
            /// "address" (string) - An address string. 
            /// 
            /// Example: 1420 Austin Bluffs Parkway, Colorado Springs, CO OR 25 Hampstead High Street, London, NW3 1RL, United Kingdom OR Sultanahmet Mosque, Istanbul, Turkey
            /// https://api.aladhan.com/v1/timingsByAddress/12-02-2024?address=Regents+Park+Mosque%2C+London%2C+UK
            /// </summary>
            timingsByAddress,

            /// <summary>
            /// Returns all prayer times for a specific date in a particular city
            /// 
            /// "date" (string) -  A date in the DD-MM-YYYY format. Default's to the current date via an HTTP 301. 
            /// "city" (string) - A city name.Example: London
            /// "country" (string) - A country name or 2 character alpha ISO 3166 code.Examples: GB or United Kindom
            /// </summary>
            timingsByCity,
        }

        /// <summary>
        /// A unqiue app key
        /// </summary>
        private const string KEY = "&AdanExpressAPP";

        /// <summary>
        /// The main API's URL of the Pray Zone service 
        /// </summary>
        private const string MAIN_API_URL = "https://api.aladhan.com/v1/";

        /// <summary>
        /// The extension of any URL's requet
        /// </summary>
        private const string URL_END = ".json";

        /// <summary>
        /// Get Today times
        /// </summary>
        private const string TODAY = "today";

        /// <summary>
        /// Get Tomorrow times
        /// </summary>
        private const string TOMORROW = "tomorrow";

        /// <summary>
        /// Get this week times
        /// </summary>
        private const string THIS_WEEK = "this_week";

        /// <summary>
        /// Get this month times
        /// </summary>
        private const string THIS_MONTH = "this_month";

        /// <summary>
        /// Get define period of times based on dates
        /// </summary>
        private const string DATES = "dates";

        /// <summary>
        /// Get define day ?
        /// </summary>
        private const string DAY = "day";

        /// <summary>
        /// Get define times for a given month
        /// </summary>
        private const string MONTH = "month";

        /// <summary>
        /// Get the main request URL 
        /// </summary>
        /// <param name="eRequestOption">The time definition <see cref="enumApiAladhanRequestOption"/></param>
        /// <param name="arrLocationInput">Parameters of Location</param>
        /// <param name="iMethod">The prayer times calculation method 1 - 15 </param>
        /// index_0: city, 
        /// Or: index_0: longitude, index_1:latitude, index_2: elevation
        /// Or: index_0: IP addrese version 4</param>
        /// 
        /// Prayer Times Calendar - https://api.aladhan.com/v1/calendar/:year/:month
        /// Prayer Times Calendar by address - https://api.aladhan.com/v1/calendarByAddress/:year/:month
        /// Prayer Times Calendar by city - https://api.aladhan.com/v1/calendarByCity/:year/:month
        /// Prayer Times Hijri Calendar - https://api.aladhan.com/v1/hijriCalendar/:year/:month
        /// Prayer Times Hijri Calendar by address - https://api.aladhan.com/v1/hijriCalendarByAddress/:year/:month
        /// Prayer Times Hijri Calendar by city - https://api.aladhan.com/v1/hijriCalendarByCity/:year/:month
        /// Prayer Times Methods - https://api.aladhan.com/v1/methods
        /// Timings - https://api.aladhan.com/v1/timings/:date
        /// Timings By Address - https://api.aladhan.com/v1/timingsByAddress/:date
        /// Timings By City - https://api.aladhan.com/v1/timingsByCity/:date
        /// <returns>The API request URL, it can be null</returns>
        public static string? getUrlRequest(enumApiAladhanRequestOption eRequestOption, string argsDateOptions, string arrLocationInput, int iMethod = 3)
        {
            if (!string.IsNullOrEmpty(arrLocationInput) && !string.IsNullOrEmpty(arrLocationInput))
            {
                return MAIN_API_URL + eRequestOption + "/" + argsDateOptions + "?" + arrLocationInput + "&method=" + iMethod;
            }
            else
            {
                return null;
            }
        }
    }
}
