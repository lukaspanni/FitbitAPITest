using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using FitbitTestConsole.Properties;
using System.IO;

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

        static void Main(string[] args)
        {
            Settings settings = Settings.Default;
            clientID = settings.ClientID;
            clientSecret = settings.ClientSecret;
            redirectUrl = settings.RedirectUrl;
            scopes = settings.Scopes;
            expires = settings.Expires;
            string authUrl = "https://www.fitbit.com/oauth2/authorize?response_type=token&client_id=" + clientID + "&redirect_uri=" + Uri.EscapeDataString(redirectUrl) + "&scope=" + Uri.EscapeDataString(scopes) + "&expires_in=" + expires;
            if (settings.TokenExpires < DateTime.Now)
            {
                Console.WriteLine("Go to: \n" + authUrl + "\nand paste the url after the redirect below");
                //https://stackoverflow.com/a/16638000
                int bufferSize = 1024;
                Stream inputStream = Console.OpenStandardInput(bufferSize);
                Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, bufferSize));
                string urlInput = Console.ReadLine().Trim();
                if (urlInput.Contains("#access_token="))
                {
                    //get token from url and save as setting
                    int tokenStart = urlInput.IndexOf("#access_token=") + "#access_token=".Length;
                    token = urlInput.Substring(tokenStart, urlInput.IndexOf('&') - tokenStart);
                    settings.Token = token;
                    settings.TokenExpires = DateTime.Now.AddSeconds(expires);
                    settings.Save();
                }
                else
                {
                    Console.WriteLine("Input not valid");
                }
            }
            else
            {
                token = settings.Token;
            }
            GetUserData();
            Console.ReadKey(true);
        }

        private static async void GetUserData()
        {
            HttpClient c = new HttpClient();
           HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, userDataUrl);
            httpRequest.Headers.Add("Authorization", "Bearer " + token);
            using (HttpResponseMessage res = await c.SendAsync(httpRequest))
            {
                string resText = await res.Content.ReadAsStringAsync();
                FitbitUser user = JsonConvert.DeserializeObject<FitbitUserWrapper>(resText).User;
                Console.WriteLine("Data recieved from Fitbit user "+user.FullName+" ("+user.DisplayName+")");
                Console.WriteLine("Born: " + user.DateOfBirth.ToString("dd.MM.yyyy") + " (Age: " + user.Age + ")");
                Console.WriteLine("Average Daily Steps: " + user.AverageDailySteps);
            }
        }
    }
}
