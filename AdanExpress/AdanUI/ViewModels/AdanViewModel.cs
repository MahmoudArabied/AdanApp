using AdanUI.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static AdanUI.Domain.AppConstants;

namespace AdanUI.ViewModels
{
    public class AdanViewModel
    {
        public ObservableCollection<AdanModel> AdanCollection { get; set; }

        public ICommand DeletePersonCommand { get; private set; }

        public AdanViewModel()
        {
            AdanCollection = new ObservableCollection<AdanModel>();

            foreach (eTimes timeType in Enum.GetValues(typeof(eTimes)))
            {
                //string strPrayTime = GetDefinedTime(timeType, prayDatetime.times);

                if (timeType != eTimes.Imsak &&
                    timeType != eTimes.Sunrise &&
                    timeType != eTimes.Sunset &&
                    timeType != eTimes.Midnight)
                {
                    AdanModel oModel = new AdanModel()
                    {
                        AdanTag = timeType,
                        AdanName = timeType.ToString(),
                        AdanTime = DateTime.Now.ToString(),
                        BorderColor = Colors.Azure,
                    };
                    AdanCollection.Add(oModel);
                }
            }
        }
    }
}
