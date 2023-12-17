using Android.App;
using Android.Runtime;

namespace MusicSchool.Mobile
{

    //TODO: https://github.com/dotnet/maui/issues/8379, https://www.youtube.com/watch?v=kvNhLKuAySA

    //[Application]
    [Application(UsesCleartextTraffic = true)]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
