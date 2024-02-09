namespace AdanUI.Domain.API.PrayerTimes
{
    /// <summary>
    /// Auto generated response based on defined json objects
    /// </summary>
    public class PrayApiResponse
    {
        public int code { get; set; }
        public string status { get; set; }
        public Results results { get; set; }
    }

    public class Results
    {
        public List<Datetime> datetime { get; set; }
        public Location location { get; set; }
        public Settings settings { get; set; }
    }

    public class Times
    {
        public string Imsak { get; set; }
        public string Sunrise { get; set; }
        public string Fajr { get; set; }
        public string Dhuhr { get; set; }
        public string Asr { get; set; }
        public string Sunset { get; set; }
        public string Maghrib { get; set; }
        public string Isha { get; set; }
        public string Midnight { get; set; }
    }

    public class Date
    {
        public int timestamp { get; set; }
        public string gregorian { get; set; }
        public string hijri { get; set; }
    }

    public class Datetime
    {
        public Times times { get; set; }
        public Date date { get; set; }
    }

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double elevation { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string timezone { get; set; }
        public double local_offset { get; set; }
    }

    public class Settings
    {
        public string timeformat { get; set; }
        public string school { get; set; }
        public string juristic { get; set; }
        public string highlat { get; set; }
        public double fajr_angle { get; set; }
        public double isha_angle { get; set; }
    }

}