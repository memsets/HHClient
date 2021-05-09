using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HHClient
{
    class HHClient
    {
        private CookieContainer cookies = new();
        private HttpClientHandler handler = new();
        private HttpClient client;
        private Uri uri;
        private string clientId;
        private string clientSecret;
        private string accessToken;

        public HHClient()
        {
            handler.CookieContainer = cookies;
            handler.UseCookies = true;
            client = new HttpClient(handler);

            clientId = "KEE06R38HQV44AOK5MSU0S0A8MEN7DRMSS4LNEGAF3ET0EUVIND8GITQDC8RR4JH";
            clientSecret = "JNJ2SEGE66SL324O4PATMCIEE7FJ8UHBBSQ42879U1E7Q7A8SJBLLTHJE0UMT34G";
            accessToken = "SO0RTSMPC8RBE7SB5HKU04KVRI88GLK1PAF5OVNURULRVRD65715GUL2PU88NNQH";
        }

        public Token HHAplicationAuth()
        {
            uri = new Uri("https://hh.ru/oauth/token");
            var stringContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", clientId),
                new KeyValuePair<string, string>("client_secret", clientSecret)
            });

            var response = client.PostAsync(uri, stringContent);
            var text = response.Result.Content.ReadAsStringAsync().Result;

            var token = JsonSerializer.Deserialize<Token>(text);

            return token;
        }

        public Rootobject GetVacancies(string searchText, string perPage, string page = null)
        {
            uri = new Uri("https://api.hh.ru/vacancies/?text=" + searchText + 
                "&per_page=" + perPage + "&page=" + page);
            
            client.DefaultRequestHeaders.Add("User-Agent", "api-test-agent");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            
            var result = client.GetAsync(uri).Result.Content.ReadAsStringAsync().Result;
            var rootObject = JsonSerializer.Deserialize<Rootobject>(result);
            return rootObject;
        }
    }
}
