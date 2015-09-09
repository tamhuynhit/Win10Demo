using HtmlAgilityPack;
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
        public const string Url = "http://modernicons.io/segoe-mdl2/cheatsheet/";

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

        public async Task LoadIcons()
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            
            HtmlNode node = htmlDoc.GetElementbyId("iconList");

            string html = node.InnerHtml;
            foreach (var child in node.ChildNodes)
            {
                string name = child.GetAttributeValue("data-name", null);
                string hex = child.GetAttributeValue("class", null);
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
