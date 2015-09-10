using IconDemo.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace IconDemo
{
    public sealed partial class MainPage : Page
    {
        private ViewModel _pageVM;
        public ViewModel PageVM
        {
            get
            {
                return _pageVM;
            }

            set
            {
                _pageVM = value;
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            PageVM = new ViewModel();
            this.DataContext = PageVM;
        }

        

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            //await PageVM.LoadIcons();
        }
    }
}
