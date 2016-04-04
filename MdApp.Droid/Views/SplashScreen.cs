using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace MdApp.Droid.Views
{
    [Activity(MainLauncher = true, NoHistory = true, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen() : base(Resource.Layout.Splash_screen) { }
    }
}