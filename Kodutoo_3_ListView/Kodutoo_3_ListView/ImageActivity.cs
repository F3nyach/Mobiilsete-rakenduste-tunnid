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
    [Activity(Label = "ImageActivity")]
    public class ImageActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.image_activity_layout);

            var image = Intent.GetIntExtra("imageResource", 0);
            var postImg = FindViewById<ImageView>(Resource.Id.postImg);
            postImg.SetImageResource(image);
            var portrait = FindViewById<ImageView>(Resource.Id.portrait);
            portrait.SetImageResource(image);
            // Create your application here
        }
    }
}