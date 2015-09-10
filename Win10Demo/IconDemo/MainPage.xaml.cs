using System;
using Windows.UI.Xaml.Controls;

namespace IconDemo
{
    public sealed partial class MainPage : Page
    {
        public string[] Symbols
        {
            get
            {
                return Enum.GetNames(typeof(Symbol));
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }
    }
}
