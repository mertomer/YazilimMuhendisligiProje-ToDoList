using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimMuhendisligiProje_ToDoList.Presentation
{
    public partial class frmcoin : Form
    {

        private static readonly HttpClient client = new HttpClient();
        public frmcoin()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            var coins = await FetchCoinDataAsync();
            dataGridView1.DataSource = coins;
        }


        private async Task<List<Coin>> FetchCoinDataAsync()
        {
            string url = "https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page=10&page=1&sparkline=false";

            var request = new HttpRequestMessage(HttpMethod.Get, url);
            request.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var coins = JsonConvert.DeserializeObject<List<Coin>>(responseString);
            return coins;
        }

        private void frmcoin_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class Coin
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("market_cap")]
        public decimal MarketCap { get; set; }

        [JsonProperty("total_volume")]
        public decimal TotalVolume { get; set; }
    }
   
    }

