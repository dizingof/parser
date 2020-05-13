using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZapuskApp();
        }

        private async Task  ZapuskApp()
        {
            int count = 2200;

            
            for (int i = 0; i < count; i++)
            {
                textBox1.Text = i.ToString();
                string myUrl = $"https://developers.ria.com/auto/search?api_key=F8dBEnGN8H9LmXtgConMAp9QH85TbP3Dh6lUaCV5&countpage=100&page={i}";
                WebRequest requestGET = WebRequest.Create(myUrl);
                WebResponse response = requestGET.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader streamReadResult = new StreamReader(stream);
                string stringJson = streamReadResult.ReadToEnd();
                Console.WriteLine(stringJson);
                richTextBox1.Text = stringJson;
                Rootjson resultdeserializedObj = JsonConvert.DeserializeObject<Rootjson>(stringJson);
                var massivId = resultdeserializedObj.Result.SearchResult.Ids;
                foreach (var item in massivId)
                {
                    richTextBox2.Text += item + "\r\n";
                    string writePath = @"C:\SomeDir\hta.txt";
                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                    {
                        sw.WriteLine(item);
                    }

                }
                
                Random randomValue = new Random();
                var valueSleep = randomValue.Next(5000, 20000);
                
                Task task = Task.Delay(valueSleep);
                await task;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
