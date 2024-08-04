using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AdanUI.Domain
{
    public class LocationUtil
    {
        /// <summary>
        /// An http client to get API update
        /// </summary>
        private static readonly HttpClient s_httpClient = new HttpClient();

        /// <summary>
        /// The main API's URL of the open street maps 
        /// </summary>
        private const string OPENSTREET_API_URL = "https://nominatim.openstreetmap.org/reverse?format=json&";

        /// <summary>
        /// The current location of device 
        /// </summary>
        public Location? m_oLocation { get; private set; }

        /// <summary>
        /// The assigned cancel token for get location
        /// </summary>
        private CancellationTokenSource? m_cancelTokenSourceGetLocation;

        /// <summary>
        /// Is the GEt location in progress
        /// </summary>
        private bool m_isCheckingLocation;

        /// <summary>
        /// Check if a device has a cached locaction value
        /// Depending on the device, not all location values may be available. 
        /// For example, the Altitude property might be null, have a value of 0, 
        /// or have a positive value indicating the meters above sea level. 
        /// Other values that may not be present include the Speed and Course properties.
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetCachedLocation()
        {
            try
            {
                Location? location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    m_oLocation = location;
                    return $"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}";
                }

                return "None";
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
                Debug.WriteLine(fnsEx.ToString());
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
                Debug.WriteLine(fneEx.ToString());
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
                Debug.WriteLine(pEx.ToString());
            }
            catch (Exception ex)
            {
                // Unable to get location
                Debug.WriteLine(ex.ToString());
            }

            return "None";
        }

        /// <summary>
        /// Get the current location of device
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetCurrentLocation()
        {
            try
            {
                m_isCheckingLocation = true;
                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                m_cancelTokenSourceGetLocation = new CancellationTokenSource();

                Location? location = await Geolocation.Default.GetLocationAsync(request, m_cancelTokenSourceGetLocation.Token);

                if (location != null && location.IsFromMockProvider)
                {
                    // location is from a mock provider
                    Debug.WriteLine(" location is from a mock provider ");
                }

                if (location != null)
                {
                    Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    m_oLocation = location;
                    return await GetGeocodeReverseDataOpenStreetAPI(location.Latitude, location.Longitude);
                }
            }
            // Catch one of the following exceptions:
            //   FeatureNotSupportedException
            //   FeatureNotEnabledException
            //   PermissionException
            catch (Exception ex)
            {
                // Unable to get location
                Debug.WriteLine(ex.ToString());
                return "None";
            }
            finally
            {
                m_isCheckingLocation = false;
            }
            return "None";
        }

        /// <summary>
        /// Cancel the get location request
        /// </summary>
        public void CancelRequest()
        {
            if (m_isCheckingLocation && m_cancelTokenSourceGetLocation != null && m_cancelTokenSourceGetLocation.IsCancellationRequested == false)
            {
                m_cancelTokenSourceGetLocation.Cancel();
            }
        }

        /// <summary>
        /// Get the location info using Google API: Not used requires access token
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        private async Task<string> GetGeocodeReverseDataGoogleAPI(double latitude = 47.673988, double longitude = -122.121513)
        {
            IEnumerable<Placemark> placemarks = await Geocoding.Default.GetPlacemarksAsync(latitude, longitude);

            Placemark? placemark = placemarks?.FirstOrDefault();

            if (placemark != null)
            {
                return
                    $"AdminArea:       {placemark.AdminArea}\n" +
                    $"CountryCode:     {placemark.CountryCode}\n" +
                    $"CountryName:     {placemark.CountryName}\n" +
                    $"FeatureName:     {placemark.FeatureName}\n" +
                    $"Locality:        {placemark.Locality}\n" +
                    $"PostalCode:      {placemark.PostalCode}\n" +
                    $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                    $"SubLocality:     {placemark.SubLocality}\n" +
                    $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                    $"Thoroughfare:    {placemark.Thoroughfare}\n";

            }

            return "";
        }

        /// <summary>
        /// Reverse geocoding generates an address from a coordinate given as latitude and longitude
        /// </summary>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        private async Task<string> GetGeocodeReverseDataOpenStreetAPI(double latitude = 53.264072, double longitude = 10.460492)
        {
            string strUrl = OPENSTREET_API_URL + "lat=" + latitude.ToString(CultureInfo.InvariantCulture) + "&lon=" + longitude.ToString(CultureInfo.InvariantCulture);

            Debug.WriteLine($"GetGeocodeReverseDataOpenStreetAPI: URL: {strUrl}");
            s_httpClient.DefaultRequestHeaders.Accept.Clear();
            string streamString = await s_httpClient.GetStringAsync(strUrl);
            GeoLocationOpenStreetResponse? response = JsonSerializer.Deserialize<GeoLocationOpenStreetResponse>(streamString);
            if (response != null)
            {
                Debug.WriteLine($"GetGeocodeReverseDataOpenStreetAPI: Reponse is not null : {response.address.town} ");
                if (response.address.town != null)
                {
                    return response.address.town;
                }
                else if (response.address.state != null)
                {
                    return response.address.state;
                }
                else
                {
                    return response.address.county;
                }
            }
            else
            {
                Debug.WriteLine($"GetGeocodeReverseDataOpenStreetAPI: Reponse is null ");
                return "Undefined";
            }
        }
    }
}
