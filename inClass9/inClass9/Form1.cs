using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;//allow us to have a stop watch
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace inClass9
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            // play with stopwatch
            sw.Reset();
            sw.Start();
            //load xml documents and GetElementsByTagName()
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/1/Facilities";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(resp.GetResponseStream());

            XmlNodeList elementList = xmlDoc.GetElementsByTagName("facility");
            for (int i = 0; i < elementList.Count;i++ )
            {
                string[] arr = new string[4];
                arr[0] = elementList[i].SelectSingleNode("typeId").InnerText;
                arr[1] = elementList[i].SelectSingleNode("type").InnerText;
                arr[2] = elementList[i].SelectSingleNode("quantity").InnerText;
                arr[3] = elementList[i].SelectSingleNode("description").InnerText;

                ListViewItem itm;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

            sw.Stop();
            MessageBox.Show(sw.ElapsedMilliseconds.ToString() + "ms");
        }
    }
}
