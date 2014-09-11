using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamFeed.Core.Models;

namespace XamFeed.Droid
{
    public class RssItemAdapter : BaseAdapter<RssItem> {
        private List<RssItem> _items;
        private Activity _activity;

        public RssItemAdapter( List<RssItem> items, Activity activity  ) {
            _items = items;
            _activity = activity;
        }

        public override RssItem this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position) {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent) {
            var view = convertView;

            if ( view == null ) {
                view = _activity.LayoutInflater.Inflate( Android.Resource.Layout.SimpleListItem2, null );
            }

            view.FindViewById<TextView>( Android.Resource.Id.Text1 ).Text = _items[position].Title;
            view.FindViewById<TextView>( Android.Resource.Id.Text2 ).Text = string.Format( "{0} on {1}", _items[position].Creator, _items[position].PubDate );

            return view;
        }
    }
}