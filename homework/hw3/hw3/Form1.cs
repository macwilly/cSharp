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
            comboBoxTxt.Items.Clear();
            while ((val = sr.ReadLine()) !=null)
            {
                comboBoxTxt.Items.Add(val);
            }

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
    }
}
