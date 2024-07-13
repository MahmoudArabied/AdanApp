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

        private IDispatcherTimer m_dtUpdatePrayTime;

        public string AppLocation { get; set; }

        public AdanViewModel()
        {
            initiateAdanCollection();
            AppLocation = "Undefined";
            m_oLocationUtil = new LocationUtil();

            m_dtUpdatePrayTime = Application.Current.Dispatcher.CreateTimer();
            m_dtUpdatePrayTime.Interval = new TimeSpan(0, 0, 0, 10);
            m_dtUpdatePrayTime.Tick += OnUpdatePrayTime_Tick;
            m_dtUpdatePrayTime.Start();
        }

        private void OnUpdatePrayTime_Tick(object? sender, EventArgs e)
        {
            Debug.WriteLine("AdanViewMode: OnUpdatePrayTime_Tick ");
            // Updated location
            _ = Task.Run(GetCurrentLocation);
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
                        AdanTime = "", //DateTime.Now.ToString(TimeOnlyFormat),
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
            m_dtUpdatePrayTime.Stop();

            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                AppLocation = await m_oLocationUtil.GetCurrentLocation();
                Debug.WriteLine($"AdanViewModel: GetCurrentLocation {AppLocation}");

                if (m_oLocationUtil.m_oLocation != null)
                {
                    // Update Pray Time
                    _ = Task.Run(GetPrayUpdatesFromAPI);
                }
                else
                {
                    m_dtUpdatePrayTime.Start();
                }
            });
        }

        private async Task GetPrayUpdatesFromAPI()
        {
            if (m_oLocationUtil.m_oLocation == null)
            {
                Debug.WriteLine($"AdanViewModel: GetPrayUpdatesFromAPI location is null ");
                //_ = Task.Run(GetCurrentLocation);
                return;
            }

            Debug.WriteLine($"AdanViewModel: GetPrayUpdatesFromAPI location is not null ");

            string strLocationInput = "latitude=" + m_oLocationUtil.m_oLocation.Latitude.ToString(CultureInfo.InvariantCulture) +
                "&longitude=" + m_oLocationUtil.m_oLocation.Longitude.ToString(CultureInfo.InvariantCulture);
            string? strUrl = ApiAladhan.getUrlRequest(ApiAladhan.enumApiAladhanRequestOption.timings, DateTime.Today.ToString(Util.DateTimeAPIFormat2), strLocationInput);
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            string streamString = await s_httpClient.GetStringAsync(strUrl);
            m_ApiAladhanResponse = JsonSerializer.Deserialize<ApiAladhanResponse>(streamString);

            Debug.WriteLine($"AdanViewModel: GetPrayUpdatesFromAPI location is not null {strLocationInput}");
            Debug.WriteLine($"AdanViewModel: GetPrayUpdatesFromAPI location is not null {strUrl}");

            if (m_ApiAladhanResponse != null)
            {
                Debug.WriteLine($"GetPrayUpdatesFromAPI Fajr Time: {m_ApiAladhanResponse.data.timings.Fajr}");
                Debug.WriteLine($"GetPrayUpdatesFromAPI Dhurhr Time: {m_ApiAladhanResponse.data.timings.Dhuhr}");
                Debug.WriteLine($"GetPrayUpdatesFromAPI Asr Time: {m_ApiAladhanResponse.data.timings.Asr}");
                Debug.WriteLine($"GetPrayUpdatesFromAPI Maghrib Time: {m_ApiAladhanResponse.data.timings.Maghrib}");
                Debug.WriteLine($"GetPrayUpdatesFromAPI Isha Time: {m_ApiAladhanResponse.data.timings.Isha}");
                Debug.WriteLine($"GetPrayUpdatesFromAPI Mid Night Time: {m_ApiAladhanResponse.data.timings.Midnight}");
                _ = Task.Run(UpdatePrayView);
            }
        }

        /// <summary>
        /// Get the assinged time for a give time pray
        /// </summary>
        /// <param name="eTime">The time type <see cref="AppConstants.eTimes"/></param>
        /// <param name="times">The retrieved times from API <see cref="Times"/></param>
        /// <returns></returns>
        private string GetDefinedTime(eTimes eTime, Timings times)
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

        private async Task UpdatePrayView()
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                if (m_ApiAladhanResponse == null) { return; }

                foreach (var item in AdanCollection)
                {
                    string strTime = GetDefinedTime(item.AdanTag, m_ApiAladhanResponse.data.timings);
                    Debug.WriteLine($"Tage: {item.AdanTag} Time: {strTime}");
                    item.AdanTime = GetDefinedTime(item.AdanTag, m_ApiAladhanResponse.data.timings);
                }
            });
        }
    }
}