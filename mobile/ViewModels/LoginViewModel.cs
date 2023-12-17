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
    public class LoginViewModel : ObservableObject
    {
        private readonly AuthService _authService;
        private HttpClient _client;
        private JsonSerializerOptions _serializerOptions;
        private string baseUrl = "http://10.0.2.2:9010"; //<> http://localhost:9010

        public LoginViewModel()
        {
            _authService = new AuthService();
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICommand LoginTapCommand => new Command(async () =>
        {
            try
            {
                var url = $"{baseUrl}/api/Authenticate/login";
                StringContent jsonContent = new(JsonSerializer.Serialize(new
                {
                    username = Username,
                    password = Password
                }), Encoding.UTF8, "application/json");

                var response = await _client.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                var user = JsonSerializer.Deserialize<User>(json, _serializerOptions);

                if (!string.IsNullOrEmpty(user.Token))
                {
                    _authService.SetToken(user.Token);
                    _authService.Login();
                    await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
                }
                else
                {
                    //TODO: Lanzar excepcion: no se pudo recuperar token
                }
            }
            catch (Exception ex)
            {
                //TODO: Logging
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }
        });
    }
}