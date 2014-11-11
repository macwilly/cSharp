using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
