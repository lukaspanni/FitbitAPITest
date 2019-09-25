using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FitbitTestConsole.Properties;

namespace FitbitAPITestConsole
{
    class Program
    {
        private static string userDataUrl = "https://api.fitbit.com/1/user/-/profile.json";
        private static string clientID;
        private static string clientSecret;
        private static string redirectUrl;
        private static string scopes;
        private static long expires;
        private static string token;

        static async void Main(string[] args)
        {
            Settings settings = Settings.Default;
            clientID = settings.ClientID;
            clientSecret = settings.ClientSecret;
            redirectUrl = settings.RedirectUrl;
            scopes = settings.Scopes;
            expires = settings.Expires;
            string authUrl = "https://www.fitbit.com/oauth2/authorize?response_type=token&client_id=" + clientID;
            authUrl += "&redirect_uri=" + Uri.EscapeDataString(redirectUrl);
            authUrl += "&scope=" + Uri.EscapeDataString(scopes) + "&expires_in=" + expires;
            //auth via browser -> code -> token
            token = settings.Token; //Debug -> Token saved in settings; TODO: get token from server -> OAUTH 2

            HttpClient c = new HttpClient();
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, userDataUrl);
            httpRequest.Headers.Add("Authorization", "Bearer " + token);
            using (HttpResponseMessage res = await c.SendAsync(httpRequest))
            {
                string resText = await res.Content.ReadAsStringAsync();
                FitbitUser user = JsonConvert.DeserializeObject<FitbitUserWrapper>(resText).User;

            }
        }
    }
}
