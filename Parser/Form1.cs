using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Parser
{
    public partial class Form1 : Form
    {
        public enum TypeEnum { UsedAuto };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            string myUrl = $"https://developers.ria.com/auto/search?api_key=F8dBEnGN8H9LmXtgConMAp9QH85TbP3Dh6lUaCV5&category_id=1&bodystyle[0]=3&bodystyle[4]=2&;marka_id[0]=79&model_id[0]=0&s_yers[0]=2010&po_yers[0]=2017&;marka_id[1]=84&model_id[1]=0&s_yers[1]=2012&po_yers[1]=2016&brandOrigin[0]=276&brandOrigin[1]=392&price_ot=1000&;price_do=60000&currency=1&auctionPossible=1&with_real_exchange=1&with_exchange=1&exchange_filter[marka_id]=0&exchange_filter[model_id]=0&state[0]=1&city[0]=0&state[1]=2&city[1]=0&state[2]=10&city[2]=0&abroad=2&custom=1&auto_options[477]=477&type[0]=1&type[1]=2&type[3]=4&type[7]=8&gearbox[0]=1&gearbox[1]=2&gearbox[2]=3&engineVolumeFrom=1.4&engineVolumeTo=3.2&powerFrom=90&powerTo=250&power_name=1&countpage=50&with_photo=1&page={x}"; 
            WebRequest reqGET = WebRequest.Create(myUrl);
            WebResponse resp = reqGET.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            textBox1.Text = s;
            
            SearchResultClass a = JsonConvert.DeserializeObject<SearchResultClass>(s);
            Console.WriteLine(a.Ids);
            Console.ReadLine();
        }

       
    }
}
