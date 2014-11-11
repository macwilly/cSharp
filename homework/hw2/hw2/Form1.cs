using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonForm1Next_Click(object sender, EventArgs e)
        {
            string TxtName = textBoxNameFirst.Text+ " " + textBoxNameLast.Text;
            Form2 secondForm = new Form2(TxtName);
            //Show and ShowDialog also impact if you can do a hide or not 
            secondForm.Show();
            ////////////////////////////////////
            // This did not work the way that I wanted it to 
            //Form1 firstForm = new Form1();
            //firstForm.Hide();
            ///////////////////////////////////
            this.Hide();
            //this.Close(); when I did this and it worked closed the whole program
        }
    }
}
