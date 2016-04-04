using MdApp.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace MdApp.Core
{
    public class App : MvxApplication
    {

        public App()
        {
            //Mvx.RegisterType<IServicioDatos, ServicioDatos>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<MainViewModel>());
        }
    }
}