using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdanUI.Domain
{
    public class LocationUtil
    {
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
                Location location = await Geolocation.Default.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
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

        private CancellationTokenSource _cancelTokenSource;
        private bool _isCheckingLocation;
        public async Task GetCurrentLocation()
        {
            try
            {
                _isCheckingLocation = true;

                GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));

                _cancelTokenSource = new CancellationTokenSource();

                Location location = await Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

                if (location != null && location.IsFromMockProvider)
                {
                    // location is from a mock provider
                    Debug.WriteLine(" location is from a mock provider ");
                }

                if (location != null)
                {
                    Debug.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
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
            }
            finally
            {
                _isCheckingLocation = false;
            }
        }

        public void CancelRequest()
        {
            if (_isCheckingLocation && _cancelTokenSource != null && _cancelTokenSource.IsCancellationRequested == false)
            {
                _cancelTokenSource.Cancel();
            }
        }
    }
}
