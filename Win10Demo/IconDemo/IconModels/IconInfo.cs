using System.ComponentModel;

namespace IconDemo.IconModels
{
    public class IconInfo : INotifyPropertyChanged
    {
        #region Properties
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
                NotifyPropertyChanged("Name");
            }
        }

        private string _hexCode;
        public string HexCode
        {
            get
            {
                return _hexCode;
            }

            set
            {
                _hexCode = value;
                NotifyPropertyChanged("HexCode");
            }
        }

        private string _deccCode;
        public string DecCode
        {
            get
            {
                return _deccCode;
            }

            set
            {
                _deccCode = value;
                NotifyPropertyChanged("DecCode");
            }
        }
        #endregion

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
