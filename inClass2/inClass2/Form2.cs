using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inClass2
{
    public partial class Form2 : inClass2.Form1
    {
        string fn; //initalize the var
        //write a getter that can be accessed from the other form 
        public string GetName()
        {
            return form2Input;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
