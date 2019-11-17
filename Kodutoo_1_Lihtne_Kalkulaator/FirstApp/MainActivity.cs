using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace FirstApp
{
    [Activity(Label = "Lihtne kalkulaator", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.first_layout);

            var textView1 = FindViewById<TextView>(Resource.Id.textView1);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            var button2 = FindViewById<Button>(Resource.Id.button2);
            var button3 = FindViewById<Button>(Resource.Id.button3);
            var button4 = FindViewById<Button>(Resource.Id.button4);

            var textfield1 = FindViewById<EditText>(Resource.Id.editText1);
            var textfield2 = FindViewById<EditText>(Resource.Id.editText2);

            var value = textfield1.Text;

            button1.Click += delegate
            {
                var test = int.Parse(textfield1.Text) + int.Parse(textfield2.Text);
                textView1.Text = test.ToString();
            };

            button2.Click += delegate
            {
                var test = int.Parse(textfield1.Text) - int.Parse(textfield2.Text);
                textView1.Text = test.ToString();
            };

            button3.Click += delegate
            {
                var test = int.Parse(textfield1.Text) * int.Parse(textfield2.Text);
                textView1.Text = test.ToString();
            };

            button4.Click += delegate
            {
                if(textfield2.Text == "0")
                {
                    textView1.Text = "nulliga ei tohi jagada";
                }
                else
                {
                    var test = double.Parse(textfield1.Text) / double.Parse(textfield2.Text);
                    textView1.Text = test.ToString();
                }
            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}