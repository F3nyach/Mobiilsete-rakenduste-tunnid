using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;

namespace Kodutoo_3_ListView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var listView = FindViewById<ListView>(Resource.Id.listView1);

            var snList = new List<SocialNetwork>
            {
                new SocialNetwork() { Portrait = Resource.Drawable.elon, ScreenName = "Elon Musk", Tag = "@elonmusk", PostText = "I am pleased to announce the Tesla CyberTruck. Pre-order one today", Date = "22.11.2019", Image = Resource.Drawable.tesla },
                new SocialNetwork() { Portrait = Resource.Drawable.twitter, ScreenName = "John Doe", Tag = "@johndoe", PostText = "Shut up and take my money!", Date = "22.11.2019", Image = Resource.Drawable.money },
                new SocialNetwork() { Portrait = Resource.Drawable.pewdiepie, ScreenName = "ƿ૯ωძɿ૯ƿɿ૯", Tag = "@pewdiepie", PostText = "Does it allow attachments? Either way I want one!", Date = "23.11.2019", Image = Resource.Drawable.halo },
                new SocialNetwork() { Portrait = Resource.Drawable.twitter, ScreenName = "Mr X", Tag = "@misterx", PostText = "I can't stop laughingh at this :D", Date = "27.11.2019", Image = Resource.Drawable.tombraider },
                new SocialNetwork() { Portrait = Resource.Drawable.twitter, ScreenName = "random guy", Tag = "@randomizer9000", PostText = "Thank you Elon, for these amazing memes!", Date = "01.12.2019", Image = Resource.Drawable.chicken },
                new SocialNetwork() { Portrait = Resource.Drawable.ussr, ScreenName = "CCCP", Tag = "@borninussr", PostText = "Screw the cybertruck, Niva is where it's at!", Date = "31.31.3131", Image = Resource.Drawable.niva },
            };


            listView.Adapter = new BasicAdapter(this, snList);

            listView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                var position = args.Position;
                var imageResource = snList[position].Image;

                var intent = new Intent(this, typeof(ImageActivity));
                intent.PutExtra("imageResource", imageResource);
                StartActivity(intent);
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}