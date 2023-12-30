using CommunityToolkit.Mvvm.ComponentModel;
using MusicSchool.Mobile.Models;
using MusicSchool.Mobile.Services;
using MusicSchool.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MusicSchool.Mobile.ViewModels
{
    public class RegisterViewModel : ObservableObject
    {
        private readonly AuthService _authService;
        private readonly INavigation _navigation;
        private HttpClient _client;
        private JsonSerializerOptions _serializerOptions;
        private string baseUrl = "http://10.0.2.2:9020"; //<> http://localhost:9020

        public RegisterViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _authService = new AuthService();
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
        }
        
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICommand RegisterTapCommand => new Command(async () => 
        {
            var page = new RegisterPage();
            await _navigation.PushAsync(page);
        });


    }
}