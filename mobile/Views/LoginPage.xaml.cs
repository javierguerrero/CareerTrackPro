using MusicSchool.Mobile.Services;
using MusicSchool.Mobile.ViewModels;

namespace MusicSchool.Mobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
        BindingContext = new LoginViewModel(this.Navigation);
    }
}