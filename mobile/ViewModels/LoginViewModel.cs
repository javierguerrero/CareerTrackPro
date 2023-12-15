using CommunityToolkit.Mvvm.ComponentModel;
using MusicSchool.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicSchool.Mobile.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        public ICommand LoginTapCommand => new Command(OnTappedLogin);

        public string Email { get; set; }

        public string Password { get; set; }

        private async void OnTappedLogin()
        {
            try
            {
                //var config = new FirebaseAuthConfig
                //{
                //    ApiKey = Constants.WebApiKey,
                //    AuthDomain = Constants.AuthDomain,
                //    Providers = new FirebaseAuthProvider[]
                //    {
                //        new EmailProvider()
                //    }
                //};
                //var client = new FirebaseAuthClient(config);
                //var userCredential = await client.SignInWithEmailAndPasswordAsync(Email, Password);

                //_authService.SettUserUID(userCredential.User.Uid);
                //_authService.Login();

                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        }
    }
}