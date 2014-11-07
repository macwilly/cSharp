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
            StreamReader sr = new StreamReader(@"MyPets.txt");
            comboBoxTxt.Items.Clear();
            while ((val = sr.ReadLine()) !=null)
            {
                comboBoxTxt.Items.Add(val);
            }

        }
    }
}
