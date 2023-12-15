using MusicSchool.Mobile.Services;

namespace MusicSchool.Mobile.Views;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;

    public LoadingPage(AuthService authService)
    {
        InitializeComponent();
        _authService = authService;
    }

    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (await _authService.IsAuthenticatedAsync())
        {
            // UserName is logged in
            // redirect to MainPage
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
        else
        {
            // UserName is not logged in
            // redirect to LoginPage
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}