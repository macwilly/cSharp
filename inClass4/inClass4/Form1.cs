﻿using System;
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
using System.Xml;
using CookComputing.XmlRpc;

namespace inClass4
{
    [XmlRpcUrl("http://alvin.ist.rit.edu:8100")]
    public interface IBeers : IXmlRpcProxy
    {
        [XmlRpcMethod("beer.getBeers")]
        string[] getBeers();
    }
    public partial class formBeer : Form
    {
        public formBeer()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXMLRPC_Click(object sender, EventArgs e)
        {
            IBeers proxy = XmlRpcProxyGen.Create<IBeers>();
            string[] beers = proxy.getBeers();
            comboBoxXMLRPC.Items.Clear();
            for (int i = 0; i<beers.Length; i++)
            {
                comboBoxXMLRPC.Items.Add(beers[i]);
            }
        }

        private void buttonSOAP_Click(object sender, EventArgs e)
        {

            //is a Simple Object Access protocal
            //http://spf13.com/post/soap-vs-rest
            serviceBeer.BeerClient bc = new serviceBeer.BeerClient();
            string[] beers = bc.getBeers();
            comboBoxSOAP.Items.Clear();
            for (int i = 0; i<beers.Length; i++)
            {
                comboBoxSOAP.Items.Add(beers[i]);
            }
        }

        private void buttonRESTFUL_Click(object sender, EventArgs e)
        {
           //new way
            inClass4.BeerService myBeer = new inClass4.BeerService();
            string[] beers = myBeer.GetBeers();
            for(int i = 0;i<beers.Length;i++)
            {
                comboBoxRESTFUL.Items.Add(beers[i]);
            }
            
            
            //old way
            /*List<string> beers = new List<string>();
            string uri = "http://simon.ist.rit.edu:8080/BeerService/resources/Services/Beers";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            req.Method = "GET";

            try 
            {
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();

                Stream str = res.GetResponseStream();
                XmlReader xr = XmlReader.Create(str);
                while (xr.Read())
                {
                    if (xr.Value != "") comboBoxRESTFUL.Items.Add(xr.Value);
                }
                res.Close();
            
            }
            catch(Exception ex)
            {
                Console.Write("Error");
            }*/

        }

        private void buttonGetPrice_Click(object sender, EventArgs e)
        {
            inClass4.BeerService myBeer = new inClass4.BeerService();
            string beerName = comboBoxRESTFUL.Items[comboBoxRESTFUL.SelectedIndex].ToString();
            string beerPrice = myBeer.GetPrice(beerName);
            // put it into the text box
            textBoxGetPrice.Text = beerPrice;
        }
    }
}
