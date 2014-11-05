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
    public partial class Form2 : Form
    {
        public Form2(string StrData)
        {
            InitializeComponent();
            textBoxTxtNewForm2.Text = StrData;
            textBoxAddressForm2.Text = StrData;
        }

        private void buttonForm2Close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This window is about to close.");
            //remember the this is pointing to the form itself and not the button object
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Close();
        }
    }
}
