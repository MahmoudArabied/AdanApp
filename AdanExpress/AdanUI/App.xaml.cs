using AdanUI.Pages;

namespace AdanUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppTabbedPage();
        }
    }
}
