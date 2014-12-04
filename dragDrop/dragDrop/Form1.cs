using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            //Console.WriteLine("on");
            if(e.Data.GetDataPresent("Text"))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            //Console.WriteLine("Dropped");
            string item = (string)e.Data.GetData("Text");
            treeView1.Nodes.Add(item);

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //test to see if I've moused downed on an element in the listBox
            if (this.listBox1.SelectedItem != null)
            {
                DoDragDrop(this.listBox1.SelectedItem, DragDropEffects.Copy);
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Console.WriteLine("Dropped on form");
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("in
        }
    }
}
