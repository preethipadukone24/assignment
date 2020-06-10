using System;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Configuration;
using Newtonsoft.Json.Linq;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtlat.Text.Length == 0 || txtlong.Text.Length == 0)
            {
                lblError.Text = "Please provide latitude longitude in correct format.";
            }
            else
            {
                lblError.Text = "";
                String callingResource = "json?lat=" + txtlat.Text + "&lng=" + txtlong.Text + "&date=today";

                using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
                {
                    client.BaseAddress = new Uri("https://api.sunrise-sunset.org/");
                    HttpResponseMessage response = client.GetAsync(callingResource).Result;
                    response.EnsureSuccessStatusCode();
                    string result = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("Result: " + result);
                    JObject joResponse = JObject.Parse(result);
                    JObject ojObject = (JObject)joResponse["results"];

                    lblsunrise.Text = (String)ojObject["sunrise"];
                    lblsunset.Text = (String)ojObject["sunset"];
                }
            }
        }

    }
}