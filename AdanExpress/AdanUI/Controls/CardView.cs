namespace AdanUI.Controls
{
    public class CardView : ContentView
    {
        public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty CardDescriptionProperty = BindableProperty.Create(nameof(CardDescription), typeof(string), typeof(CardView), string.Empty);
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CardView), Colors.DarkGray);
        public static readonly BindableProperty CardColorProperty = BindableProperty.Create(nameof(CardColor), typeof(Color), typeof(CardView), Colors.White);
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(CardView), default(ImageSource));
        public static readonly BindableProperty IconBackgroundColorProperty = BindableProperty.Create(nameof(IconBackgroundColor), typeof(Color), typeof(CardView), Colors.LightGray);
        public static readonly BindableProperty ProgressBarValueProperty = BindableProperty.Create(nameof(ProgressBarValue), typeof(double), typeof(CardView), 0.0);
        public static readonly BindableProperty ProgressBarIsVisibleProperty = BindableProperty.Create(nameof(ProgressBarIsVisible), typeof(bool), typeof(CardView), false);
        public static readonly BindableProperty ProgressBarColorProperty = BindableProperty.Create(nameof(ProgressBarColor), typeof(Color), typeof(CardView), Colors.White);


        public string CardTitle
        {
            get => (string)GetValue(CardTitleProperty);
            set => SetValue(CardTitleProperty, value);
        }

        public string CardDescription
        {
            get => (string)GetValue(CardDescriptionProperty);
            set => SetValue(CardDescriptionProperty, value);
        }

        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }

        public Color CardColor
        {
            get => (Color)GetValue(CardColorProperty);
            set => SetValue(CardColorProperty, value);
        }

        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }

        public Color IconBackgroundColor
        {
            get => (Color)GetValue(IconBackgroundColorProperty);
            set => SetValue(IconBackgroundColorProperty, value);
        }

        /// <summary>
        /// The progress value of progress bar
        /// </summary>
        public double ProgressBarValue
        {
            get => (double)GetValue(ProgressBarValueProperty);
            set => SetValue(ProgressBarValueProperty, value);
        }

        /// <summary>
        /// Is the progress bar visible or not
        /// </summary>
        public bool ProgressBarIsVisible
        {
            get => (bool)GetValue(ProgressBarIsVisibleProperty);
            set => SetValue(ProgressBarIsVisibleProperty, value);
        }

        public Color ProgressBarColor
        {
            get => (Color)GetValue(ProgressBarColorProperty);
            set => SetValue(ProgressBarColorProperty, value);
        }
    }
}
