using SplitViewDemo.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SplitViewDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Shell : Page
    {
        public Shell()
        {
            this.InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;

            if (frame?.CanGoBack == true)
            {
                frame.GoBack();
            }
        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            AppMenu.IsPaneOpen = !AppMenu.IsPaneOpen;
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(HomePage))
            {
                frame.Navigate(typeof(HomePage));
            }
        }

        private void CallBtn_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(CallPage))
            {
                frame.Navigate(typeof(CallPage));
            }
        }

        private void ContactBtn_Click(object sender, RoutedEventArgs e)
        {
            var frame = this.DataContext as Frame;
            Page page = frame?.Content as Page;
            if (page?.GetType() != typeof(ContactPage))
            {
                frame.Navigate(typeof(ContactPage));
            }
        }
    }
}
