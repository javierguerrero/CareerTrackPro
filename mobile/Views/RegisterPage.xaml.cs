using MusicSchool.Mobile.ViewModels;

namespace MusicSchool.Mobile.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
        BindingContext = new RegisterViewModel(this.Navigation);
    }
}