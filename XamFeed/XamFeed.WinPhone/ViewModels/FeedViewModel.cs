using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamFeed.Core.Models;

namespace XamFeed.WinPhone.ViewModels
{
    public class FeedViewModel
    {
        public ObservableCollection<RssItem> RssItems { get; set; } 
    }
}
