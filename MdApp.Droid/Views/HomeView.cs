using Android.OS;
using Android.Runtime;
using Android.Views;
using MdApp.Core.ViewModels;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.Fragging.Fragments;

namespace MdApp.Droid.Views
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.frameLayout)]
    [Register("mdapp.droid.views.HomeView")]
    public class HomeView : MvxFragment<HomeViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.Home, container, false);
        }
    }
}