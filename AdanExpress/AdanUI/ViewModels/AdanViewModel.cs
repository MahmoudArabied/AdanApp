using AdanUI.Domain;
using AdanUI.Domain.API.Aladhan;
using AdanUI.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;
using static AdanUI.Domain.AppConstants;

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

        /// <summary>
        /// The current pray zone 
        /// </summary>
        private AppConstants.eTimes m_eCurrentPrayZone;

        /// <summary>
        /// The remain time for the next pray time
        /// </summary>
        private TimeSpan m_tsRemainForNextPray;

        /// <summary>
        /// The total time for the next pray time
        /// </summary>
        private TimeSpan m_tsToalTimeForNextPray;

        /// <summary>
        /// The remain for the next pray as minutes 
        /// </summary>
        private double m_dProgressRemaining;

        /// <summary>
        /// The max value of the progress bar
        /// </summary>
        private double m_dProgressMax;

        public AdanViewModel()
        {
            initiateAdanCollection();
            m_strApplLocation = "Loading";
            UpdateLocationButEnabled = false;
            UpdateLocationButCommand = new DelegateCommand(OnUpdateLocationButClicked);
            m_oLocationUtil = new LocationUtil();

            m_dtUpdatePrayTime = Application.Current.Dispatcher.CreateTimer();
            m_dtUpdatePrayTime.Interval = new TimeSpan(0, 0, 0, 5);
            m_dtUpdatePrayTime.Tick += OnUpdatePrayTime_Tick;
            m_dtUpdatePrayTime.Start();
        }

        #region Bind Variables
        private string m_strApplLocation;
        public string AppLocation
        {
            get => m_strApplLocation;
            set => SetProperty(ref m_strApplLocation, value);
        }

        public DelegateCommand UpdateLocationButCommand;

        private bool m_bUpdateLocationButEnabled;
        public bool UpdateLocationButEnabled
        {
            get => m_bUpdateLocationButEnabled;
            set => SetProperty(ref m_bUpdateLocationButEnabled, value);
        }
        #endregion Bind Variables

        private void OnUpdateLocationButClicked(object obj)
        {
            Debug.WriteLine("AdanViewModel: OnUpdateLocationButClicked");
            _ = Task.Run(GetCurrentLocation);
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
                        AdanTime = "",//DateTime.Now.ToString(TimeOnlyFormat),
                        ProgressColor = Colors.White,
                        ProgressValue = 0,
                        ProgressIsVisible = false,
                        BorderColor = Colors.White,
                        CardBackgroundColor = Colors.White,
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
                    UpdateLocationButEnabled = true;
                }
                else
                {
                    m_dtUpdatePrayTime.Start();
                    UpdateLocationButEnabled = false;
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

        /// <summary>
        /// Get the assigned image path for the given pray zone
        /// </summary>
        /// <param name="eTime">enum time <see cref="eTimes"/> </param>
        /// <param name="bIsOn">Is the current time zone</param>
        /// <returns></returns>
        private string GetBackgroundImage(eTimes eTime, bool bIsOn)
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
        /// Get the assigned image path for the given pray zone
        /// </summary>
        /// <param name="eTime">enum time <see cref="eTimes"/> </param>
        /// <param name="bIsOn">Is the current time zone</param>
        /// <returns></returns>
        private eTimes GetNextTimePrayZone(eTimes eTime)
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

        private async Task UpdatePrayView()
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                if (m_ApiAladhanResponse == null) { return; }

                foreach (var item in AdanCollection)
                {
                    string strTime = GetDefinedTime(item.AdanTag, m_ApiAladhanResponse.data.timings);
                    Debug.WriteLine($"Tage: {item.AdanTag} Time: {strTime}");
                    item.m_dtPrayDateTime = DateTime.Parse(strTime);
                    item.AdanTime = GetDefinedTime(item.AdanTag, m_ApiAladhanResponse.data.timings);

                }


                UpdateCurrentPrayZone();
            });
        }

        /// <summary>
        /// find which current zone of pray
        /// </summary>
        private void UpdateCurrentPrayZone()
        {
            try
            {
                foreach (var item in AdanCollection)
                {
                    DateTime dtNextTimeZone = AdanCollection.First(x => x.AdanTag == GetNextTimePrayZone(item.AdanTag)).m_dtPrayDateTime;
                    if (DateTime.Now >= item.m_dtPrayDateTime && DateTime.Now < dtNextTimeZone)
                    {
                        // Current Pray Zone
                        item.BackgroundImage = GetBackgroundImage(item.AdanTag, true);
                        item.ProgressColor = Colors.Gold;
                        item.BorderColor = Colors.Gold;
                        item.CardBackgroundColor = Colors.LawnGreen;
                        double dRemaingMinutes = (dtNextTimeZone - DateTime.Now).TotalMinutes;
                        double dDuration = (dtNextTimeZone - item.m_dtPrayDateTime).TotalMinutes;
                        item.ProgressValue = (dDuration - dRemaingMinutes) / dDuration;
                        Debug.WriteLine($"Duration : {dDuration}  Remain:{dRemaingMinutes} Progress:{item.ProgressValue}");
                        item.ProgressIsVisible = true;
                    }
                    else
                    {
                        item.BackgroundImage = GetBackgroundImage(item.AdanTag, false);
                        item.ProgressColor = Colors.White;
                        item.BorderColor = Colors.White;
                        item.CardBackgroundColor = Colors.White;
                        item.ProgressValue = 0;
                        item.ProgressIsVisible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }
    }
}