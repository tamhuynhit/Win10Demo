using IconDemo.IconModels;
using System.ComponentModel;
using System.Threading.Tasks;

namespace IconDemo.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        private IconManager Manager;

        public ViewModel()
        {
            Manager = new IconManager();
        }

        public async Task LoadIcons()
        {
            await Manager.LoadIcons();
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
