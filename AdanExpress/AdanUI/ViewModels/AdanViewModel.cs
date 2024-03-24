using AdanUI.Domain;
using AdanUI.Domain.API.Aladhan;
using AdanUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;
using static AdanUI.Domain.AppConstants;
using static AdanUI.Domain.Util;


namespace AdanUI.ViewModels
{
    public class AdanViewModel : ViewModelBase
    {
        /// <summary>
        /// An http client to get API update
        /// </summary>
        private static readonly HttpClient s_httpClient = new HttpClient();

        /// <summary>
        /// A collection of <see cref="AdanModel"/>
        /// </summary>
        public ObservableCollection<AdanModel> AdanCollection { get; set; }

        /// <summary>
        /// The location util instance
        /// </summary>
        private LocationUtil m_oLocationUtil;

        /// <summary>
        /// The API response of <see cref="ApiAladhanResponse"/>
        /// </summary>
        private ApiAladhanResponse? m_ApiAladhanResponse;

        public string AppLocation { get; set; }

        public AdanViewModel()
        {
            initiateAdanCollection();
            AppLocation = "Undefined";
            m_oLocationUtil = new LocationUtil();

            // Updated location
            _ = Task.Run(GetCurrentLocation);

            // Update Pray Time
            _ = Task.Run(GetPrayUpdatesFromAPI);
        }

        private void initiateAdanCollection()
        {

            AdanCollection = new ObservableCollection<AdanModel>();

            foreach (eTimes timeType in Enum.GetValues(typeof(eTimes)))
            {
                if (timeType != eTimes.Imsak &&
                    //timeType != eTimes.Sunrise &&
                    timeType != eTimes.Sunset &&
                    timeType != eTimes.Midnight)
                {
                    AdanCollection.Add(new AdanModel
                    {
                        AdanTag = timeType,
                        AdanName = timeType.ToString(),
                        AdanTime = DateTime.Now.ToString(TimeOnlyFormat),
                        ProgressColor = Colors.Azure,
                        BackgroundImage = "time_adan_off.png"
                    });
                }
            }

            AdanCollection.First(x => x.AdanTag == eTimes.Fajr).BackgroundImage = "fajir_off.png";
            AdanCollection.First(x => x.AdanTag == eTimes.Sunrise).BackgroundImage = "sunrise_off.png";
            AdanCollection.First(x => x.AdanTag == eTimes.Dhuhr).BackgroundImage = "dahur_off.png";
            AdanCollection.First(x => x.AdanTag == eTimes.Asr).BackgroundImage = "asr_off.png";
            AdanCollection.First(x => x.AdanTag == eTimes.Maghrib).BackgroundImage = "maghrib_off.png";
            AdanCollection.First(x => x.AdanTag == eTimes.Isha).BackgroundImage = "isha_off.png";
        }

        public async void GetCurrentLocation()
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                AppLocation = await m_oLocationUtil.GetCurrentLocation();
                Debug.WriteLine($"AdanViewModel: {AppLocation}");
            });
        }

        private async Task GetPrayUpdatesFromAPI()
        {
            if (m_oLocationUtil.m_oLocation == null)
            {
                Debug.WriteLine($"AdanViewModel: location is null ");
                _ = Task.Run(GetCurrentLocation);
                return;
            }

            string strLocationInput = "latitude=" + m_oLocationUtil.m_oLocation.Latitude.ToString(CultureInfo.InvariantCulture) +
                "&longitude=" + m_oLocationUtil.m_oLocation.Longitude.ToString(CultureInfo.InvariantCulture);
            string? strUrl = ApiAladhan.getUrlRequest(ApiAladhan.enumApiAladhanRequestOption.timings, DateTime.Today.ToString(Util.DateTimeAPIFormat2), strLocationInput);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            string streamString = await s_httpClient.GetStringAsync(strUrl);
            m_ApiAladhanResponse = JsonSerializer.Deserialize<ApiAladhanResponse>(streamString);


            if (m_ApiAladhanResponse != null)
            {
                Debug.WriteLine($" Dhurhr Time: {m_ApiAladhanResponse.data.timings.Dhuhr}");
                Debug.WriteLine($" Asr Time: {m_ApiAladhanResponse.data.timings.Asr}");
            }
        }

        private async Task UpdatePrayView()
        {

        }
    }
}