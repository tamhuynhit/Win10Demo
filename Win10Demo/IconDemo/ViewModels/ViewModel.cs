using IconDemo.IconModels;
using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace IconDemo.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public string[] Symbols
        {
            get
            {
                return Enum.GetNames(typeof(Symbol));
            }
        }

        //public IconManager Manager { get; set; }

        //private IconInfo _currentIcon;
        //public IconInfo CurrentIcon
        //{
        //    get
        //    {
        //        return _currentIcon;
        //    }

        //    set
        //    {
        //        _currentIcon = value;
        //        NotifyPropertyChanged("CurrentIcon");
        //    }
        //}

        public ViewModel()
        {
            //Manager = new IconManager();
        }

        //public async Task LoadIcons()
        //{
        //    await Manager.LoadIcons();
        //}

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
