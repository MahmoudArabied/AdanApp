using AdanUI.Domain;
using System.Diagnostics;

namespace AdanUI.Pages
{
    public partial class MainPage : ContentPage
    {
        private LocationUtil m_oLocation;

        public MainPage()
        {
            InitializeComponent();
            m_oLocation = new LocationUtil();
           // _ = Task.Run(GetCurrentLocation);
        }

        private async void GetCurrentLocation()
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                string strText = await m_oLocation.GetCurrentLocation();
                Debug.WriteLine($"MainPage: GetCurrentLocation: {strText}");
                locationText.Text = strText;
            });
        }

        /// <summary>
        /// Listen to click of Location Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LocationBut_Clicked(object sender, EventArgs e)
        {
            UpdateLocationBut.IsEnabled = false;
            _ = Task.Run(GetCurrentLocation);

            Debug.WriteLine("LocationBut_Clicked");

            UpdateLocationBut.IsEnabled = true;
        }
    }

}
