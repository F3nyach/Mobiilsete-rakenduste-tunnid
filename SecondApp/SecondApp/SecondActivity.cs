using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Essentials;

namespace SecondApp
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Second_layout);
            var text = Intent.GetStringExtra("edittextvalue");

            var textView = FindViewById<TextView>(Resource.Id.textView1);
            textView.Text = text;

            // XAMARIN ESSENTIALS OSA

            var appName = AppInfo.Name;
            var packageName = AppInfo.PackageName;
            var version = AppInfo.VersionString;
            var build = AppInfo.BuildString;

            AppInfo.ShowSettingsUI();

            var duration = TimeSpan.FromSeconds(10); //kui on vaja muuta vibratsiooni pikkust, järgmises reas sulgudesse panna kirja
            Vibration.Vibrate();
            await NavigateToBuilding();

        }

        public async Task NavigateToBuilding()
        {
            var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microsoft Building" };
            await Map.OpenAsync(location, options);
        }
    }
}