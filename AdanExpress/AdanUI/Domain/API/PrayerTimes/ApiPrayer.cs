using static AdanUI.Domain.API.PrayerTimes.ApiPrayer;

namespace AdanUI.Domain.API.PrayerTimes
{
    /// <summary>
    /// Based on documentation from https://prayertimes.date/api
    /// </summary>
    static class ApiPrayer
    {
        /// <summary>
        /// Define type of Times request
        /// </summary>
        public enum enumApiPrayerTimesOption
        {
            /// <summary>
            /// Get Today Times
            /// </summary>
            Today,

            /// <summary>
            /// Get Tomorrow Times
            /// </summary>
            Tomorrow,

            /// <summary>
            /// Get This week Times
            /// </summary>
            ThisWeek,

            /// <summary>
            /// Get this month times
            /// </summary>
            ThisMonth,

            /// <summary>
            /// Define by start - end dates 
            /// </summary>
            Dates,

            /// <summary>
            /// Defined by given day date
            /// </summary>
            Day,

            /// <summary>
            /// Defined by a given month date
            /// </summary>
            Month,
        }

        public enum enumApiPrayerLocationType
        {
            /// <summary>
            /// Location by City
            /// </summary>
            City,

            /// <summary>
            /// Location by longitude, latitude, and elavation
            /// </summary>
            LongLatitudeElavation,

            /// <summary>
            /// Location by IP address: only IP ver4
            /// </summary>
            IP,
        }

        /// <summary>
        /// A unqiue app key
        /// </summary>
        private const string KEY = "&AdanExpressAPP";

        /// <summary>
        /// The main API's URL of the Pray Zone service 
        /// </summary>
        private const string MAIN_API_URL = "https://api.pray.zone/v2/times/";

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
        /// <param name="eTime">The time definition <see cref="enumApiPrayerTimesOption"/></param>
        /// <param name="eLocationType">The location definition <see cref="enumApiPrayerLocationType"/></param>
        /// <param name="arrLocationInput">Parameters of Location</param>
        /// <param name="iSchool">The school name</param>
        /// index_0: city, 
        /// Or: index_0: longitude, index_1:latitude, index_2: elevation
        /// Or: index_0: IP addrese version.4</param>
        /// <returns>The API request URL, it can be null</returns>
        public static string? getUrlRequest(enumApiPrayerTimesOption eTime, enumApiPrayerLocationType eLocationType, string[] arrLocationInput, string[] argsDateOptions, int iSchool = 4)
        {
            string strRequestUrl = MAIN_API_URL + GetTimePart(eTime) + URL_END + "?";
            string? strParameters = GetLocationPart(eLocationType, arrLocationInput);

            if (strParameters != null)
            {
                strRequestUrl += strParameters;

                // Time and date options
                if (argsDateOptions != null)
                {
                    for (int i = 0; i < argsDateOptions.Length; i++)
                    {
                        strRequestUrl += "&" + argsDateOptions[i];
                    }
                }

                // School options
                string strSchool = "&school=" + ((iSchool >= 0 && iSchool <= 12) ? iSchool : 0);
                strRequestUrl += strSchool + KEY;

                return strRequestUrl;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Get school name as defined in API
        /// </summary>
        /// <param name="iSchool"></param>
        /// <returns></returns>
        public static string GetSchoolName(int iSchool)
        {
            return iSchool switch
            {
                0 => "Ithna Ashari",
                1 => "University of Islamic Sciences, Karachi",
                2 => "Islamic Society of North America",
                3 => "Muslim World League",
                4 => "Umm Al-Qura University, Mecca",
                5 => "Egyptian General Authority of Survey",
                6 => "",
                7 => "Institute of Geophysics, University of Tehran",
                8 => "Morocco",
                9 => "Department of Islamic Advancement, Malaysia (JAKIM)",
                10 => "Majlis Ugama Islam Singapura",
                11 => "Union des Organisations Islamiques de France",
                12 => "Turkey",
                _ => "Undefined",
            };
        }

        /// <summary>
        /// Get the time base part of the URL
        /// </summary>
        /// <param name="eTime">enum option of time <see cref="enumApiPrayerTimesOption"/></param>
        /// <returns>Defined part of times URL, possible of undefined</returns>
        private static string GetTimePart(enumApiPrayerTimesOption eTime)
        {
            return eTime switch
            {
                enumApiPrayerTimesOption.Today => TODAY,
                enumApiPrayerTimesOption.Tomorrow => TOMORROW,
                enumApiPrayerTimesOption.ThisWeek => THIS_WEEK,
                enumApiPrayerTimesOption.ThisMonth => THIS_MONTH,
                enumApiPrayerTimesOption.Dates => DATES,
                enumApiPrayerTimesOption.Day => DAY,
                enumApiPrayerTimesOption.Month => MONTH,
                _ => "UNDEFINED",
            };
        }

        /// <summary>
        /// Prepare the location part of API URL request
        /// </summary>
        /// <param name="eLocationType">The location part of URL <see cref="enumApiPrayerLocationType"/></param>
        /// <param name="args">Parameters of location: 
        /// index_0 : city, 
        /// Or: index_0: longitude, index_1:latitude, index_2: elevation
        /// Or: index_0: IP addrese version 4</param>
        /// <returns></returns>
        private static string? GetLocationPart(enumApiPrayerLocationType eLocationType, string[] args)
        {
            if (args.Length == 0)
            {
                return null;
            }

            return eLocationType switch
            {
                enumApiPrayerLocationType.City => "city=" + args[0],
                enumApiPrayerLocationType.LongLatitudeElavation => "longitude=" + args[0] + "&latitude=" + args[1] + "&elevation=" + args[2],
                enumApiPrayerLocationType.IP => "ip=" + args[0],
                _ => null,
            };
        }
    }
}
