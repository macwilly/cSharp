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

        private void buttonCheckBoxList_Click(object sender, EventArgs e)
        {
            //Display in a message box details of the checkboxes in the
            //checkbox list

            foreach(object itemList in checkedBoxList.CheckedItems)
            {
                MessageBox.Show("Item Name: "+itemList.ToString());
                //for this you do not really need this Becasue if it is check it will show 
                MessageBox.Show("Checked State: "+checkedBoxList.GetItemCheckState(checkedBoxList.Items.IndexOf(itemList)).ToString());
            }
            
        }

        private void buttonCheckBoxList_MouseHover(object sender, EventArgs e)
        {
            //tool tip
            myToolTip = new ToolTip();
            myToolTip.SetToolTip(buttonCheckBoxList, "Bam Mother F*cker Tool Tip");
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            myToolTip = new ToolTip();
            myToolTip.IsBalloon = true;
            myToolTip.SetToolTip(label1, "I'm a tool......Tip");
        }
    }
}
