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
    public partial class Frm作業_2 : Form
    {
        public Frm作業_2()
        {
            InitializeComponent();
            LoadYearToCombobox();
            this.productPhotoTableAdapter1.Fill(this.awDataSet1.ProductPhoto);

        }

        private void LoadYearToCombobox()
        {
            awDataClassesDataContext dr = new awDataClassesDataContext();

            var q = (from x in dr.ProductPhoto
                     select x.ModifiedDate.Year).Distinct().ToList();

            this.comboBox3.SelectedValue = "ModifiedDate";
            this.comboBox3.DataSource = q;


        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = this.awDataSet1.ProductPhoto;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var q = from x in awDataSet1.ProductPhoto
                    where x.ModifiedDate.Year == Convert.ToInt32(comboBox3.Text)
                    select x;
            this.dataGridView1.DataSource = q.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //string 第一季 = "<=3";
            //string 第二季 = ">3&&<=6";
            //string 第三季 = ">6&&<=9";
            //string 第四季 = ">9&&<=12";
            //int 筆數;
            //this.dataGridView1.DataSource = q.ToList();

            int n = this.comboBox2.SelectedIndex;

            if (n == 0)
            {
                var q = from x in awDataSet1.ProductPhoto
                        where x.ModifiedDate.Month <= 3
                        select x;
                this.dataGridView1.DataSource = q.ToList();
                lblMaster.Text = "Master 共" + q.ToList().Count + "筆";
            }

            if (n == 1)
            {
                var p = from x in awDataSet1.ProductPhoto
                        where x.ModifiedDate.Month > 3 && x.ModifiedDate.Month <= 6
                        select x;
                this.dataGridView1.DataSource = p.ToList();
                lblMaster.Text = "Master 共" + p.ToList().Count + "筆";
            }

            if (n == 2)
            {
                var r = from x in awDataSet1.ProductPhoto
                        where x.ModifiedDate.Month > 6 && x.ModifiedDate.Month <= 9
                        select x;
                this.dataGridView1.DataSource = r.ToList();
                lblMaster.Text = "Master 共" + r.ToList().Count + "筆";
            }

            if (n == 3)
            {
                var w = from x in awDataSet1.ProductPhoto
                        where x.ModifiedDate.Month > 9 && x.ModifiedDate.Month <= 12
                        select x;
                this.dataGridView1.DataSource = w.ToList();
                lblMaster.Text = "Master 共" + w.ToList().Count + "筆";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = from x in awDataSet1.ProductPhoto
                    where dateTimePicker2.Value >= x.ModifiedDate && x.ModifiedDate >= dateTimePicker1.Value
                    select x;
            this.dataGridView1.DataSource = q.ToList();
        }
    }
}
