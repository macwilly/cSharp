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

namespace inClass3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetTxt_Click(object sender, EventArgs e)
        {
            //get the week 11 txt file and populate the combobox
            // @ is telling visual studio to not use the \ as an esacape 
            // need to see if this can be done with a relative path for working on different machines
            StreamReader sr = new StreamReader(@"C:\Users\Student\Documents\GitHub\cSharp\inClass3\C#fileIOStarter\week11.txt");
            string val = "";
            // clear the comboBox
            comboBoxTxt.Items.Clear();
            while((val = sr.ReadLine())!=null)
            {
                comboBoxTxt.Items.Add(val);
            }
            //sort
            comboBoxTxt.Sorted = true;

        }

        private void buttonGetXML_Click(object sender, EventArgs e)
        {
            string val = "";
            comboBoxXML.Items.Clear();
            XmlReader xr = XmlReader.Create(@"C:\Users\Student\Documents\GitHub\cSharp\inClass3\C#fileIOStarter\week11.xml");
            while (xr.Read())
            {
                //xr reader flatens out the entire file
                if (xr.NodeType == XmlNodeType.Text)
                {
                    comboBoxXML.Items.Add(xr.Value);
                }
            }
        }

        private void buttonJSon_Click(object sender, EventArgs e)
        {
            //go get the james.newtonking.com/json dll there is no native parser
            //instal it 
            //after install rightclick on recources to add
            comboBoxJSon.Items.Clear();
            
            StreamReader srjson = new StreamReader(@"C:\Users\Student\Documents\GitHub\cSharp\inClass3\C#fileIOStarter\week11.json");
            string json = srjson.ReadToEnd();
            //<strin> strongly types the list to a string
            List<string> vals = JsonConvert.DeserializeObject<List<string>>(json);
            foreach(string val in vals)
            {
                comboBoxJSon.Items.Add(val);
            }
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You did it !!!");
        }


    }
}
