using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconDemo.IconModels
{
    public class IconManager : INotifyPropertyChanged
    {
        private ObservableCollection<IconInfo> _icons;
        public ObservableCollection<IconInfo> Icons
        {
            get
            {
                return _icons;
            }

            set
            {
                _icons = value;
                NotifyPropertyChanged("Icons");
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion

    }
}
