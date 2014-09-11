using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;
using XamFeed.Core.Models;
using System.Linq;

namespace XamFeed.Core.Services
{
    public class FeedService
    {
        public async Task<List<RssItem>> GetItemsAsync( string feedUrl ) {
            using ( var client = new HttpClient( ) ) {
                var xmlFeed = await client.GetStringAsync( feedUrl );
                var doc = XDocument.Parse( xmlFeed );

                XNamespace dc = "http://purl.org/dc/elements/1.1/";
                var items = ( from item in doc.Descendants( "item" )
                    select new RssItem {
                        Title = item.Element( "title" ).Value,
                        PubDate = DateTime.Parse( item.Element( "pubDate" ).Value ),
                        Creator = item.Element( dc + "creator" ).Value,
                        Link = item.Element( "link" ).Value
                    } ).ToList( );

                return items;
            }
        }
    }
}
