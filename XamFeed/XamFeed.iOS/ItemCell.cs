using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XamFeed.iOS
{
    public class ItemCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RssFeedItemCell");

        public ItemCell( ) : base(UITableViewCellStyle.Subtitle, Key) {
            
        }
    }
}