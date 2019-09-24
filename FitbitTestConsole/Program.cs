using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FitbitAPITestConsole
{
    class Program
    {
        private static string apiUrl = "https://api.fitbit.com/1/user/-/profile.json";
        private static string clientID = "";
        private static string clientSecret = "";
        private static string redirectUrl = "";
        private static string scopes = "heartrate weight profile nutrition activity sleep settings social location";
        private static long expires = 604800;
        private static string token;

        static async void Main(string[] args)
        {
            string authUrl = "https://www.fitbit.com/oauth2/authorize?response_type=token&client_id=" + clientID;
            authUrl += "&redirect_uri=" + Uri.EscapeDataString(redirectUrl);
            authUrl += "&scope=" + Uri.EscapeDataString(scopes) + "&expires_in=" + expires;
            //auth via browser -> code
            token = @"";
            HttpClient c = new HttpClient();
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, apiUrl);
            httpRequest.Headers.Add("Authorization", "Bearer " + token);
            using (HttpResponseMessage res = await c.SendAsync(httpRequest))
            {
                string resText = await res.Content.ReadAsStringAsync();
                FitbitUser user = JsonConvert.DeserializeObject<FitbitUserWrapper>(resText).User;

            }
        }
    }
}
