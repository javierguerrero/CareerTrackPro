using MusicSchool.Mobile.Services;

namespace MusicSchool.Mobile.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Logout(object sender, EventArgs e)
        {
            var authService = new AuthService();
            authService.Logout();
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}