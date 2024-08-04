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
        }
    }
}
