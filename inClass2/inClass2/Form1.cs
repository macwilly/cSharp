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
            InitializeComponent();//this will always be the first thing 
            //hide the inputs
            //nameInput.Hide();
            panel3.Hide();
            groupBox1.Hide();
        }
        //this is the form and not the button
        //sender is who called you 
        private void showNameButton_Click(object sender, EventArgs e)
        {
            //messagebox is an alert
            //MessageBox.Show(nameInput.Text);
            //Console.WriteLine(nameInput.Text);
            //nameInput.Text = "Worked?";
            //panel3.Show();
            //groupBox1.Show();
            //how to hide/sgiw the panel?
            if (panel3.Visible)
            {
                showNameButton.Text = "Hide Stuff";
            }
            else
            {
                showNameButton.Text = "Show Stuff";
            }
            panel3.Visible = !panel3.Visible;
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            Form2 fn = new Form2();
            //show is not modal
            //showDialog is modal
            fn.ShowDialog();
            nameInput.Text = fn.GetName();

        }


    }
}
