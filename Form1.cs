using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RapidApiCurrencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetResponseData()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "55c6fcf8a4mshcbae495cb9210fcp1d4d97jsn3670f85038cf" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json=JObject.Parse(body);
                var value = json["result"].ToString();
                lblDolar.Text = value.ToString();


            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            GetResponseData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
