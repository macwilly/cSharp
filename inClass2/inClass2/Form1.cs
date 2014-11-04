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
        //this is the form and not the button
        //sender is who called you 
        private void showNameButton_Click(object sender, EventArgs e)
        {
            //messagebox is an alert
            MessageBox.Show(nameInput.Text);
            Console.WriteLine(nameInput.Text);
        }

    }
}
