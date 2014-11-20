using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace inClass7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetIt_Click(object sender, EventArgs e)
        {
            // needs to be in Bin/Debug
            XmlReader xmlFile = XmlReader.Create(@"data.xml");
            DataSet dataSet = new DataSet();

            //read the xml into dataset
            dataSet.ReadXml(xmlFile);

            //Pass row table to dataGrid the datasource
            dataGridView1.DataSource = dataSet.Tables["row"];

            dataGridView1.Columns[0].Visible = false;
            // OR
            //dataGridView1.Columns["OrganizationID"].Visible = false;

            
            xmlFile.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clicked");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Clicked The Cell");
            //what one am I clicking on?
            int col = e.ColumnIndex;//don't really need..
            int row = e.RowIndex;

            int orgId = Convert.ToInt32(dataGridView1[0, row].Value);

            //getTabs
            string tabs = "getTabs?orgId=" + orgId;
            MessageBox.Show(tabs);


            //assume with the baseURL that I need {orgId}/General
            string criteria = orgId + "/General";
            MessageBox.Show(criteria);
        }
    }
}
