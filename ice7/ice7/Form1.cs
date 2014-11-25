using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ice7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxOrganizationName.Text = "";
            textBoxZip.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            //this is the base uri
            string uri = @"http://simon.ist.rit.edu:8080/Serices?resources/ESD/Organizations?";

            //add parameters per the search form
            //Paramerters: ...ESD/Organizations?type= &name= &town= &state= &zip= &county=

            if (comboBoxOrganizationType.Text != "")
            {
                uri = uri + "&type=" + comboBoxOrganizationType.Text;
            }
            if (textBoxOrganizationName.Text !="")
            {
                uri = uri + "&name=" + textBoxOrganizationName.Text;
            }
            if (comboBoxCity.Text !="")
            {
                uri = uri + "&town=" + comboBoxCity.Text;
            }
            if (comboBoxState.Text !="")
            {
                uri = uri + "&state=" + comboBoxState.Text;
            }
            if (textBoxZip.Text !="")
            {
                uri = uri + "&zip" + textBoxZip.Text;
            }
            if (comboBoxCounty.Text !="")
            {
                uri = uri + "&county" + comboBoxCounty.Text;
            }
        }
    }
}
