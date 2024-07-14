using System.Diagnostics;

namespace AdanUI.Pages;

public partial class AppTabbedPage
{
    public AppTabbedPage()
    {
        InitializeComponent();

        ThemeSettings();
        Application.Current.RequestedThemeChanged += (s, a) =>
        {
            // Respond to the theme change
            ThemeSettings();
        };
    }

    /// <summary>
    /// Apply setting to the theme based on the current settings
    /// </summary>
    private void ThemeSettings()
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        AppTheme currentTheme = Application.Current.RequestedTheme;
        if (currentTheme == AppTheme.Light)
        {
            Debug.WriteLine("ThemeSettings Light ");
            if (mergedDictionaries != null)
            {
                Application.Current.UserAppTheme = AppTheme.Light;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new Resources.Styles.LightTheme());
            }
        }
        else if (currentTheme == AppTheme.Dark)
        {
            Debug.WriteLine("ThemeSettings Dark ");

            if (mergedDictionaries != null)
            {
                Application.Current.UserAppTheme = AppTheme.Dark;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new Resources.Styles.DarkTheme());
            }
        }
        else
        {
            Debug.WriteLine("ThemeSettings Unspecified ");

            // Set Default Light
            if (mergedDictionaries != null)
            {
                Application.Current.UserAppTheme = AppTheme.Unspecified;
                mergedDictionaries.Clear();
                mergedDictionaries.Add(new Resources.Styles.LightTheme());
            }

        }
    }
}