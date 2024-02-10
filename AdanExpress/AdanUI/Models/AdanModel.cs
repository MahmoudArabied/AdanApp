using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdanUI.Domain.AppConstants;

namespace AdanUI.Models
{
    public class AdanModel : ViewModelBase
    {
        /// <summary>
        /// Type of adan time
        /// </summary>
        public eTimes AdanTag { get; set; }

        /// <summary>
        /// The name of Adan
        /// </summary>
        public string AdanName { get; set; }

        /// <summary>
        /// Time of Adan
        /// </summary>
        public string AdanTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Color BorderColor { get; set; }
    }
}
