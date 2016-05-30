using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Forms.Droid
{
    [Activity (Label = "Forms", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate (Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

            global::Xamarin.Forms.Forms.Init (this, bundle);

            //TabLayoutResource = Resource.Layout.Tabbar;
            //ToolbarResource = Resource.Layout.Toolbar;

            LoadApplication (new App ());
        }
    }
}