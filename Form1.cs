using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;


namespace RapidApiCurrencyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string currency;
        private async void GetResponseData()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from={currency}&to=TRY&amount=1"),
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
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                if (currency == "USD")
                {
                    lblDolar.Text = value.ToString();
                }
                if (currency == "EUR")
                {
                    label3.Text = value.ToString();
                }
                if (currency == "GBP")
                {
                    label4.Text = value.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice=decimal.Parse(txtUnitPrice.Text);
            decimal dollar = decimal.Parse(lblDolar.Text);
            decimal euro = decimal.Parse(label3.Text);
            decimal sterlin = decimal.Parse(label4.Text);
            decimal totalPrice = 0;
            if (radioBtnUsd.Checked)
            {
                totalPrice = unitPrice * dollar;
            }
            if (radioBtnEuro.Checked)
            {
                totalPrice=unitPrice * euro;
            }
            if (radioBtnGbp.Checked)
            {
                totalPrice= unitPrice * sterlin;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currency = "GBP";
            GetResponseData();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            currency = "USD";
            GetResponseData();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currency = "EUR";
            GetResponseData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTotalPrice.Enabled = false;
        }
    }
}