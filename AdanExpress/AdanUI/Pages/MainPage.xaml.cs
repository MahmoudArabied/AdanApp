using AdanUI.Domain;
using System.Diagnostics;

namespace AdanUI.Pages
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            //if (count == 1)
            //    CounterBtn.Text = $"Clicked {count} time";
            //else
            //    CounterBtn.Text = $"Clicked {count} times";

            //SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            UpdateLocationBut.IsEnabled = false;

            LocationUtil oLocation = new LocationUtil();
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                string strText = await oLocation.GetCurrentLocation();
                Debug.WriteLine(strText);
                locationText.Text = strText;
            });

            Debug.WriteLine("Button Clicked");

            UpdateLocationBut.IsEnabled = true;


        }
    }

}
