using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_LINQ_HW_0502
{
    public partial class Frm作業_1 : Form
    {
        public Frm作業_1()
        {
            InitializeComponent();
            LoadYearToCombobox();
            this.ordersTableAdapter1.Fill(this.nwDataSet1.Orders);
            this.bindingSource1.DataSource = this.nwDataSet1.Orders;
            this.order_DetailsTableAdapter1.Fill(this.nwDataSet1.Order_Details);
        }


        private void LoadYearToCombobox()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var r = (from x in dc.Orders
                     select x.OrderDate.Value.Year).Distinct().ToList();

            comboBox1.ValueMember = "OrderDate";
            comboBox1.DataSource = r;
            comboBox1.SelectedIndex = 0;



        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.nwDataSet1.Orders;
            this.dataGridView2.DataSource = this.nwDataSet1.Order_Details;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = from o in nwDataSet1.Orders
                    where o.OrderDate.Year == Convert.ToInt32(comboBox1.Text)
                    select o;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            this.dataGridView1.DataSource = files;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from k in files
                    where k.CreationTime.Year == 2017
                    select k;

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from n in files
                    where n.Length > 10000
                    select n;

            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
