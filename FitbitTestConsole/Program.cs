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

            GetDataTest<FitbitUserWrapper>(APIEndpoints.UserDataPath, (userWrapper) => { Console.WriteLine("Data recieved from Fitbit user " + userWrapper.user.fullName + " (" + userWrapper.user.displayName + ")"); });
            GetDataTest<List<FitbitDevice>>(APIEndpoints.DevicesPath, (deviceList) => { Console.WriteLine(deviceList[0].lastSyncTime); });
            getSleepData();
            GetDataTest<HeartRateIntradayTimeSeries>(APIEndpoints.HeartRatePath(DateTime.Now,DateTime.Now), (heartRateData) => Console.WriteLine(heartRateData.activities_heart[0].value.restingHeartRate) );
            
            Console.ReadKey(true);
        }

        //test
        private static void getSleepData()
        {
            DateTime startDate = DateTime.Now.AddDays(-30);
            DateTime endDate = DateTime.Now;

            GetDataTest<FitbitSleepWrapper>(APIEndpoints.SleepDataPath(DateTime.Now), (sleep) =>
            {
                Array.Sort(sleep.sleep, Comparer<SleepData>.Create((x, y) => x.dateOfSleep.CompareTo(y.dateOfSleep)));
                //Use SleepLevelSummary Type to store total summary
                //Sleep Logs by Date Range returns individual summaries
                SleepLevelSummary sum = new SleepLevelSummary();
                sum.deep = new SleepLevelSummary.SleepPhaseData();
                sum.wake = new SleepLevelSummary.SleepPhaseData();
                sum.light = new SleepLevelSummary.SleepPhaseData();
                sum.rem = new SleepLevelSummary.SleepPhaseData();
                foreach (SleepData sd in sleep.sleep)
                {
                    Array.Sort(sd.levels.data, Comparer<SleepLevelData>.Create((x, y) => x.level.CompareTo(y.level)));
                    foreach (SleepLevelData sld in sd.levels.data)
                    {
                        Console.WriteLine("{0,-15}{1,10}{2,10}s", sld.dateTime, sld.level, sld.seconds);
                    }
                    sum += sd.levels.summary;
                    Console.WriteLine();
                }
                Console.WriteLine("Summary:");
                Console.WriteLine("{0,-10}{1,5}{2,20}", "Phase", "Count", "Duration [min]");
                Console.WriteLine(new string('=', 35));
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Deep:", sum.deep.count, sum.deep.minutes);
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Light:", sum.light.count, sum.light.minutes);
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "REM:", sum.rem.count, sum.rem.minutes); ;
                Console.WriteLine("{0,-10}{1,5}{2,20:N0}", "Wake:", sum.wake.count, sum.wake.minutes);
            });

        }

        private static async void GetDataTest<T>(string url, Action<T> action)
        {
            HttpClient c = new HttpClient();
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
            httpRequest.Headers.Add("Authorization", "Bearer " + token);
            using (HttpResponseMessage res = await c.SendAsync(httpRequest))
            {

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string resText = await res.Content.ReadAsStringAsync();
                    T returnObject = JsonConvert.DeserializeObject<T>(resText);
                    action?.Invoke(returnObject); 
                }
            }

        }
    }
}
