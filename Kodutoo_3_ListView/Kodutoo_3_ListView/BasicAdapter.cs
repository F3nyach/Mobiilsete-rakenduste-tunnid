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

namespace Kodutoo_3_ListView
{
    public class BasicAdapter : BaseAdapter<SocialNetwork>
    {
        List<SocialNetwork> _items;
        Activity _context;
        public BasicAdapter(Activity context, List<SocialNetwork> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override SocialNetwork this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = _context.LayoutInflater.Inflate(Resource.Layout.social_network_layout, null);
            view.FindViewById<ImageView>(Resource.Id.portrait).SetImageResource(_items[position].Portrait);
            view.FindViewById<TextView>(Resource.Id.ScreenNameTextView).Text = _items[position].ScreenName;
            view.FindViewById<TextView>(Resource.Id.TagTextView).Text = _items[position].Tag;
            view.FindViewById<TextView>(Resource.Id.PostTextTextView).Text = _items[position].PostText;
            view.FindViewById<TextView>(Resource.Id.DateTextView).Text = _items[position].Date;
            view.FindViewById<ImageView>(Resource.Id.postImg).SetImageResource(_items[position].Image);
            return view;
        }
    }
}