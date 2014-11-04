using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//also c# does a precompile not on the full thing though 
namespace inClass2 //this is the name of the project. can help prohibit access. You are enclosing it. Makes it different 
{
    public partial class Form1 : Form //partial means that it is not the full class they hide other parts
    {
        //this is a constructor
        public Form1() 
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
