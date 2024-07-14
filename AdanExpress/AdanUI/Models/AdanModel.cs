using static AdanUI.Domain.AppConstants;

namespace AdanUI.Models
{
    public class AdanModel : ViewModelBase
    {
        public AdanModel()
        {
            m_strAdanName = "";
            m_strAdanTime = "";
            m_progressColor = Colors.Wheat;
            m_strBackgroudImage = "";
            m_dtPrayDateTime = DateTime.Now;
            m_dProgressValue = 1;
        }

        /// <summary>
        /// The current pray time 
        /// </summary>
        public DateTime m_dtPrayDateTime { get; set; }

        /// <summary>
        /// Type of adan time
        /// </summary>
        public eTimes AdanTag { get; set; }

        /// <summary>
        /// The name of Adan
        /// </summary>
        private string m_strAdanName;
        public string AdanName
        {
            get => m_strAdanName;
            set => SetProperty(ref m_strAdanName, value);
        }

        /// <summary>
        /// Time of Adan
        /// </summary>
        private string m_strAdanTime;
        public string AdanTime
        {
            get => m_strAdanTime;
            set => SetProperty(ref m_strAdanTime, value);
        }

        /// <summary>
        /// The background color of progress bar
        /// </summary>
        private Color m_progressColor;
        public Color ProgressColor
        {
            get => m_progressColor;
            set => SetProperty(ref m_progressColor, value);
        }

        private double m_dProgressValue;
        /// <summary>
        /// The progress value of progress bar
        /// </summary>
        public double ProgressValue
        {
            get => m_dProgressValue;
            set => SetProperty(ref m_dProgressValue, value);
        }

        public bool m_bProgressIsVisible;
        /// <summary>
        /// Is the progress bar visible or not
        /// </summary>
        public bool ProgressIsVisible
        {
            get => m_bProgressIsVisible;
            set => SetProperty(ref m_bProgressIsVisible, value);
        }

        /// <summary>
        /// The background image of a given widget
        /// </summary>
        private string m_strBackgroudImage;
        public string BackgroundImage
        {
            get => m_strBackgroudImage;
            set => SetProperty(ref m_strBackgroudImage, value);
        }

        /// <summary>
        /// The border color 
        /// </summary>
        private Color m_oBorderColor;
        public Color BorderColor
        {
            get => m_oBorderColor;
            set => SetProperty(ref m_progressColor, value);
        }

        /// <summary>
        /// The card color of progress bar
        /// </summary>
        private Color m_CardBackgroundColor;
        public Color CardBackgroundColor
        {
            get => m_CardBackgroundColor;
            set => SetProperty(ref m_CardBackgroundColor, value);
        }
    }
}
