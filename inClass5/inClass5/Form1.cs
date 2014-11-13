using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //how do we know what has been checked or not
            //sender is just a generic object we need to cast the sender
            //turn the generic sender to what I want (cast it)
            CheckBox genCheckBox = sender as CheckBox;
            //or
            //CheckBox genCheckBox = (CheckBox) sender CheckBox;
            //get the text box information
            string str = genCheckBox.Text;
            textBoxTextValue.Text = str;

            //find out if it is on or off
            //String onOff = Convert.ToString(genCheckBox.Checked);
            //textBoxOnOff.Text = onOff;
            ///////
            //textBoxOnOff.Text = Convert.ToString(genCheckBox.Checked);
            textBoxOnOff.Text = (genCheckBox.Checked).ToString();
        }
    }
}
