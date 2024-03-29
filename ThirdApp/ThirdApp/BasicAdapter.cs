﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ThirdApp
{
    public class BasicAdapter : BaseAdapter<Car>
    {
        List<Car> _items;
        Activity _context;
        public BasicAdapter(Activity context, List<Car> items) :base()
        {
            this._context = context;
            this._items = items;
        }

        public override Car this[int position] 
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.car_rule_layout, null);
            view.FindViewById<TextView>(Resource.Id.manufacturerTextView).Text = _items[position].Manufacturer;
            view.FindViewById<TextView>(Resource.Id.modelTextView).Text = _items[position].Model;
            view.FindViewById<TextView>(Resource.Id.kwTextView).Text = _items[position].KW.ToString();
            return view;
        }
    }
}