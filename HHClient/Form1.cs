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
        private HHClient client = new();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void HHGet_Click(object sender, EventArgs e) 
        {
            CookieArea.Text = "";
            richTextBox2.Text = "";

            for(int i = 0; i < 1; i++) // 5 is debug 
            {
                var content = client.GetVacancies("Программист С++", "100", "1");
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
            richTextBox2.Text = client.HHAplicationAuth().access_token;
        }

        private void richTextBox2_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", e.LinkText);
        }
    }
}
