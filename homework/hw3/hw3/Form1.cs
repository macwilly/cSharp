using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace hw3
{
    public partial class formFileRead : Form
    {
        public formFileRead()
        {
            InitializeComponent();
        }

        private void buttonPopTxt_Click(object sender, EventArgs e)
        {
            string val = "";
            //did a direct path in class for the file would like to try and make it
            //so that it is a relative path. Think that it would be better this 
            //way with how I am working with everything off of gitHub and 
            //I don't know which machine I will be working from
            StreamReader sr = new StreamReader("MyPets.txt");
           // clear the box before it is loaded that way you don't have repeat of the data
            comboBoxTxt.Items.Clear();
            while ((val = sr.ReadLine()) !=null)
            {
                comboBoxTxt.Items.Add(val);
            }
            comboBoxTxt.Sorted = true;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearTxt_Click(object sender, EventArgs e)
        {
            comboBoxTxt.Items.Clear();
        }

        private void buttonPopXML_Click(object sender, EventArgs e)
        {
            XmlReader xr = XmlReader.Create("MyPets.xml");
            comboBoxXML.Items.Clear();
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Text)
                {
                    comboBoxXML.Items.Add(xr.Value);
                }
            }
            comboBoxXML.Sorted = true;
        }

        private void buttonXmlClear_Click(object sender, EventArgs e)
        {
            comboBoxXML.Items.Clear();
        }

        private void buttonPopJSON_Click(object sender, EventArgs e)
        {
            StreamReader srJson = new StreamReader("MyPets.json");
            string json = srJson.ReadToEnd();
            List<string> vals = JsonConvert.DeserializeObject<List<string>>(json);
            foreach (string val in vals)
                comboBoxJSON.Items.Add(val);

            comboBoxJSON.Sorted = true;
        }

        private void buttonJsonClear_Click(object sender, EventArgs e)
        {
            comboBoxJSON.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxTxt.Hide();
            
            if(comboBoxTxt.Visible!=true)
            {
                button2.Text = "Show";
                groupBoxTxt.Show();
            }
        }
       
    }
}
