using _10_LINQ_HW_0502;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class Frm作業_3 : Form
    {
        public Frm作業_3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from f in files
                    group f by f.Length > 10000 into g
                    select new { MyKey = g.Key, MyCount = g.Count(), MyGroup = g };

            this.dataGridView1.DataSource = q.ToList();

            foreach (var group in q)
            {
                string s = $"{group.MyKey}({group.MyCount})";
                TreeNode node = treeView1.Nodes.Add(group.MyKey.ToString(), s);
                foreach (var item in group.MyGroup)
                {
                    node.Nodes.Add(item.ToString());
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"c:\windows");

            System.IO.FileInfo[] files = dir.GetFiles();

            var q = from f in files
                    group f by f.CreationTime.Year <= 2019 into g
                    select new { MyKey = g.Key, MyCount = g.Count(), MyGroup = g };
            this.dataGridView1.DataSource = q.ToList();

            foreach (var group in q)
            {
                string s = $"{group.MyKey}({group.MyCount})";
                TreeNode node = treeView1.Nodes.Add(group.MyKey.ToString(), s);
                foreach (var item in group.MyGroup)
                {
                    node.Nodes.Add(item.ToString());
                }
            }

        }

        NorthwindEntities2 dbcontext = new NorthwindEntities2();


        private void button8_Click(object sender, EventArgs e)
        {
            var q = from f in dbcontext.Products.AsEnumerable()
                    group f by MyKey(f.UnitPrice) into g
                    select new { g.Key, MyCount = g.Count() };

            this.dataGridView1.DataSource = q.ToList();



        }

        private object MyKey(decimal? n)
        {
            if (n == null)
            {
                return "空值";
            }

            else if (n < 30)
            {
                return "便宜";

            }
            else if (n < 60)
            {
                return "中等";
            }
            else
            {
                return "貴";
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            var q = from y in dbcontext.Orders
                    group y by y.OrderDate.Value.Year into g
                    select new { g.Key, MyCount = g.Count() };

            this.dataGridView1.DataSource = q.ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var q2 = from o in this.dbcontext.Orders
                     group o by new { o.OrderDate.Value.Year, o.OrderDate.Value.Month } into g
                     select new { Year = g.Key, Count = g.Count() };

            this.dataGridView1.DataSource = q2.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = from t in dbcontext.Order_Details
                    select new { Total = (int)(t.UnitPrice * t.Quantity) * (1 - t.Discount) };

            MessageBox.Show("總銷售額:" + q.Sum(n => n.Total));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = (from n in dbcontext.Order_Details.AsEnumerable()
                     group n by new { Name = n.Order.Employee.FirstName + n.Order.Employee.LastName } into g
                     let a =g.Sum(n => (float)n.UnitPrice * n.Quantity * (1 - n.Discount))
                     orderby a descending
                     select new { g.Key, 營業額=a }
                     ).Take(5);

            this.dataGridView1.DataSource = q.ToList();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var q = (from n in dbcontext.Products
                    group n by new{ n.UnitPrice,n.Category.CategoryName,n.ProductName} into g
                    orderby g.Key descending
                    select new { 單價 = g.Key }).Take(5);


            this.dataGridView1.DataSource = q.ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var q = dbcontext.Products.Any(n => n.UnitPrice > 300);

            MessageBox.Show(" NW 產品有任何一筆單價大於300 ?" + q);
        }
    }
}