using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamFeed.Core.Models;
using XamFeed.Core.Services;

namespace XamFeed.Droid
{
    [Activity(Label = "XamFeed.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : ListActivity {
        private FeedService _feedService;
        private List<RssItem> _items; 

        public MainActivity( ) {
            _feedService = new FeedService( );
            _items = new List<RssItem>( );
        }


        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            _items = await _feedService.GetItemsAsync( "http://blog.xamarin.com/feed" );
            ListAdapter = new RssItemAdapter( _items, this );
        }

        protected override void OnListItemClick( ListView l, View v, int position, long id ) {
            base.OnListItemClick( l, v, position, id );

            var item = _items[position];
            var uri = Android.Net.Uri.Parse( item.Link );

            var intent = new Intent( Intent.ActionView, uri );
            StartActivity( intent );
        }
    }
}

