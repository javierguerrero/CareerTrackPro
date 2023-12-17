using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSchool.Mobile.Services
{
    public class AuthService
    {
        private const string AuthStateKey = "AuthState";

        public async Task<bool> IsAuthenticatedAsync()
        {
            await Task.Delay(2000);

            var authState = Preferences.Default.Get<bool>(AuthStateKey, false);

            return authState;
        }

        public void Login()
        {
            Preferences.Default.Set<bool>(AuthStateKey, true);
        }

        public void Logout()
        {
            Preferences.Default.Remove(AuthStateKey);
        }

        public void SetToken(string token)
        {
            Preferences.Default.Set("Token", token);
        }

        public string GetToken()
        {
            return Preferences.Default.Get("Token", string.Empty);
        }
    }
}
