using AdanUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static AdanUI.Domain.AppConstants;
using static AdanUI.Domain.Util;


namespace AdanUI.ViewModels
{
    public class AdanViewModel : ViewModelBase
    {
        public ObservableCollection<AdanModel> AdanCollection { get; set; }

        //public ICommand PerformSearch => new Command<string>((string query) =>
        //{
        //    SearchResults = DataService.GetSearchResults(query);
        //});

        //private List<string> searchResults = DataService.Fruits;
        //public List<string> SearchResults
        //{
        //    get => searchResults;
        //    set => SetProperty(ref searchResults, value);
        //}
   
        public AdanViewModel()
        {
            initiateAdanCollection();
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
                        AdanTime = DateTime.Now.ToString(TimeOnlyFormat),
                        ProgressColor = Colors.Azure,
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
    }
}