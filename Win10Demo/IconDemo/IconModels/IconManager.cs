using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IconDemo.IconModels
{
    public class IconManager : INotifyPropertyChanged
    {
        public const string Url = "http://modernicons.io/segoe-mdl2/cheatsheet/";
        public const string FilePath = "Assets/icons.txt";

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

        public IconManager()
        {
            Icons = new ObservableCollection<IconInfo>();
        }

        public async Task LoadIcons()
        {
            //HtmlDocument htmlDoc = new HtmlDocument();
            //string html = File.ReadAllText("Assets/html.txt");
            //htmlDoc.LoadHtml(html);
            //HtmlNode node = htmlDoc.GetElementbyId("iconList");
            //foreach (var child in node.ChildNodes)
            //{
            //    IconInfo Icon = new IconInfo();
            //    Icon.Name = child.GetAttributeValue("data-name", null);

            //    HtmlNode Code = child.ChildNodes.First(c => c.Name.CompareTo("code") == 0);
            //    string[] str = Code.InnerHtml.Split(new string[1] { "<br>" }, StringSplitOptions.RemoveEmptyEntries);
            //    Icon.HexCode = str[0].Trim('\"').Replace("amp;", "");
            //    Icon.DecCode = str[1].Trim('\"').Replace("amp;", "");

            //    Icons.Add(Icon);
            //}

            //string json = await JsonConvert.SerializeObjectAsync(Icons);
            //File.WriteAllText("D:/result.txt", json);

            string text = File.ReadAllText("Assets/icons.txt").Replace("\\", "");
            Icons = await JsonConvert.DeserializeObjectAsync<ObservableCollection<IconInfo>>(text);
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
