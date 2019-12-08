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
    //[Activity(Label = "SocialNetwork")]
    public class SocialNetwork //: Activity
    {
        public int Portrait { get; set; }
        public string ScreenName { get; set; }
        public string PostText { get; set; }
        public string Tag { get; set; }
        public string Date { get; set; }
        public int Image { get; set; }
        //protected override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your application here
        //}
    }
}