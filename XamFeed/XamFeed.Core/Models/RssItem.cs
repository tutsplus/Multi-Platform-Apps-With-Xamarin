using System;
using System.Collections.Generic;
using System.Text;

namespace XamFeed.Core.Models
{
    public class RssItem
    {
        public string Title { get; set; }
        public DateTime PubDate { get; set; }
        public string Creator { get; set; }
        public string Link { get; set; }
    }
}
