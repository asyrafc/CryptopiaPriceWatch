using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptopiaCoinInfo
{
    public partial class Form1 : Form
    {
        System.Threading.Timer timer;

        public class Trade
        {
            public string tradePairID { get; set; }
            public string tradePair { get; set; }
            public double price { get; set; }
            public double volume { get; set; }
            public double Total { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            System.Net.ServicePointManager.ServerCertificateValidationCallback += (send, certificate, chain, sslPolicyErrors) => { return true; };
        }

        private void buttonGetInfo_ClickAsync(object sender, EventArgs e)
        {
            timer = new System.Threading.Timer(new TimerCallback(monitorPriceAsync), null, 0, 1000);
        }

        private void buttonStopTimer_Click(object sender, EventArgs e)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite); //disable
        }

        private async void monitorPriceAsync(object obj)
        {
            WebClient client = new WebClient();

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Uri uri = new Uri(textBoxEndpoint.Text.ToString(), UriKind.Absolute);

            string data = await client.DownloadStringTaskAsync(uri);

            var jsonObject = JsonConvert.DeserializeObject<dynamic>(data);
            //rtbData.AppendText(Convert.ToString(jsonObject.Success));

            var trade = JsonConvert.DeserializeObject<dynamic>(jsonObject.Data.ToString());

            var buy = JsonConvert.DeserializeObject<dynamic>(trade.Buy.ToString());

            var buyOrder = JsonConvert.DeserializeObject<List<Trade>>(buy.ToString());

            if(this.dataGridViewBuy.InvokeRequired)
            {
                dataGridViewBuy.Invoke(new Action(() =>
                {
                    this.dataGridViewBuy.Rows.Clear();
                    foreach (var order in buyOrder)
                    {
                        this.dataGridViewBuy.Rows.Add(order.price.ToString("0.00000000"), order.Total);
                    }
                }));
            }

            var sell = JsonConvert.DeserializeObject<dynamic>(trade.Sell.ToString());

            var sellOrder = JsonConvert.DeserializeObject<List<Trade>>(sell.ToString());

            if (this.dataGridViewSell.InvokeRequired)
            {
                dataGridViewSell.Invoke(new Action(() =>
                {
                    this.dataGridViewSell.Rows.Clear();
                    foreach (var order in sellOrder)
                    {
                        this.dataGridViewSell.Rows.Add(order.price.ToString("0.00000000"), order.Total);
                    }
                }));
            }
        }
    }
}
