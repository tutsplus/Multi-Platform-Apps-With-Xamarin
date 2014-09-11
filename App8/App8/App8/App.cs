using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App8
{
    public class RssItem {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Link { get; set; }
    }

	public class App
	{
       private static List<RssItem> _items = new List<RssItem> {
           new RssItem{Title = "Article1", Creator = "Derek Jensen", Link = "http://tutsplus.com"},
           new RssItem{Title = "Article2", Creator = "Derek Jensen", Link = "http://blog.xamarin.com"}
       }; 

		public static Page GetMainPage() {
		    var cell = new DataTemplate( typeof ( TextCell ) );
            cell.SetBinding(TextCell.TextProperty, "Title");
            cell.SetBinding(TextCell.DetailProperty, "Creator");

		    var listView = new ListView {
		        ItemsSource = _items,
                ItemTemplate = cell
		    };

			return new ContentPage
			{
				Content = listView
			};
		}
	}
}
