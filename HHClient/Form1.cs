using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHClient {
    public partial class Form1 : Form 
    {

        private CookieContainer cookies = new();
        private Token token = new();
        private string accessToken;
        private string client_id;
        private string client_secret;

        public Form1() 
        {
            accessToken = "SO0RTSMPC8RBE7SB5HKU04KVRI88GLK1PAF5OVNURULRVRD65715GUL2PU88NNQH";
            client_id = "KEE06R38HQV44AOK5MSU0S0A8MEN7DRMSS4LNEGAF3ET0EUVIND8GITQDC8RR4JH";
            client_secret = "JNJ2SEGE66SL324O4PATMCIEE7FJ8UHBBSQ42879U1E7Q7A8SJBLLTHJE0UMT34G";
            InitializeComponent();
        }

        private async void Auth()
        {
            var uri = new Uri("https://hh.ru/oauth/token");
            HttpClientHandler handler = new HttpClientHandler();
            var client = new HttpClient(handler);
            handler.CookieContainer = cookies;
            handler.UseCookies = true;

            var stringContent = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", client_id),
                new KeyValuePair<string, string>("client_secret", client_secret)
            });

            var response = await client.PostAsync(uri, stringContent);
            richTextBox2.Text = await response.Content.ReadAsStringAsync();
            token = JsonSerializer.Deserialize<Token>(richTextBox2.Text);

            JsonArea.Text = token.access_token;
        }

        private async void HHGet_Click(object sender, EventArgs e) 
        {
            CookieArea.Text = "";
            richTextBox2.Text = "";
            string uri = "https://api.hh.ru/vacancies/?text=программист&per_page=100";
            //string uri = "https://api.hh.ru/vacancies/pages";           
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;
            handler.UseCookies = true;

            var client = new HttpClient(handler);

            client.DefaultRequestHeaders.Add("User-Agent", "api-test-agent");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            
            

            var response = await client.GetAsync(uri);
            JsonArea.Text = await response.Content.ReadAsStringAsync();
            HeadersArea.Text = response.Headers.ToString();
            var content = JsonSerializer.Deserialize<Rootobject>(JsonArea.Text);
            richTextBox2.Text += content.pages;

            for(int i = 0; i < 1; i++) // 5 is debug 
            {
                uri = "https://api.hh.ru/vacancies/?text=\"программист C++\"&per_page=100&page=" + i.ToString();
                response = await client.GetAsync(uri);
                JsonArea.Text = await response.Content.ReadAsStringAsync();


                foreach (var item in content.items)
                {
                    richTextBox2.Text += item.name;
                    richTextBox2.Text += " " + item.alternate_url + "\n";
                }

            }
            //var url = new Uri(SearchString.Text);
            //richTextBox2.Text = cookies.GetCookies(url).Count().ToString();
            //IEnumerable<Cookie> responseCookies = cookies.GetCookies(url).Cast<Cookie>();
            //foreach (Cookie cookie in responseCookies)
            //CookieArea.Text += cookie.Name + ": " + cookie.Value;
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            Auth();
        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", e.LinkText);
        }
    }
}
