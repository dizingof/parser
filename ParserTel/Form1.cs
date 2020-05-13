using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserTel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();

        }

        public async Task Start()
        {
            string path = @"C:\SomeDir\hta.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null)
                {
                    richTextBox1.Text = line;
                    string myUrl = $"https://developers.ria.com/auto/info?api_key=F8dBEnGN8H9LmXtgConMAp9QH85TbP3Dh6lUaCV5&auto_id={line}";
                    WebRequest requestGET = WebRequest.Create(myUrl);
                    WebResponse response = requestGET.GetResponse();
                    Stream stream = response.GetResponseStream();
                    StreamReader streamReadResult = new StreamReader(stream);
                    string stringJson = streamReadResult.ReadToEnd();


                }

            }
        }
    }
}
