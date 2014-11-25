using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inClass8
{
    public partial class Form1 : Form
    {
        public TabPage myTabPage;
        public Form1()
        {
            InitializeComponent();
            //there are two ways in which you can build the tabs
            //dynamically create it all
            //make the people tab
            string title = "People";
            myTabPage = new TabPage(title);
            myTabPage.Name = "People";
            //put the tabPage into the controler
            tabControl1.TabPages.Add(myTabPage);
            //now put some new controllers inside of the people tab
            TextBox myTexBox = new System.Windows.Forms.TextBox();
            myTexBox.BackColor = System.Drawing.SystemColors.Info;
            myTexBox.Location = new System.Drawing.Point(162, 30);
            myTexBox.Name = "myTextBox";
            myTexBox.Size = new System.Drawing.Size(162, 20);
            //adding it to the page
            this.myTabPage.Controls.Add(myTexBox);

            //OR
            //Have them created in the design view then remove the ones that are not being used
            //imagin I'm getting back from getTabs
            string[] names = { "General", "Locations", "Treatment", "People" };
            //need to remove the tabs that are not being used 
            foreach(TabPage tab in tabControl1.TabPages)
            {
                // tab is a referance to each tabpage in tabConrol1
                if(!names.Contains(tab.Name))
                {
                    //this tab is not in the set that I need 
                    //dodo? Kill it
                    //get then index of this tab
                    int t = tabControl1.TabPages.IndexOf(tab);
                    tabControl1.TabPages.RemoveAt(t);
                }
            }

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                progressBar1.Value = 0;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (buttonPause.Text == "Pause")
            {
                timer1.Stop();
                buttonPause.Text = "Resume";
            }
            else
            {
                timer1.Start();
                buttonPause.Text = "Pause";

            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            progressBar1.Value = 0;
            pictureBox1.Visible = false;
        }


    }
}
