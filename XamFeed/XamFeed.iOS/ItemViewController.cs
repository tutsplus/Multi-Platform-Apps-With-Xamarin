using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using XamFeed.Core.Services;

namespace XamFeed.iOS
{
    public class ItemViewController : UITableViewController {

        private FeedService _feedService;
        public ItemViewController( ) {
            _feedService = new FeedService( );
        }

        public async override void ViewDidLoad( ) {
            base.ViewDidLoad( );

            var items = await _feedService.GetItemsAsync( "http://blog.xamarin.com/feed" );

            Title = "Xamarin Blog";
            TableView.Source = new ItemSource( items );
            TableView.ReloadData( );
        }
    }
}