﻿
namespace _10_LINQ_HW_0502
{
    partial class Frm作業_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm作業_2));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaster = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productPhotoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.awDataSet1 = new _10_LINQ_HW_0502.awDataSet();
            this.productPhotoTableAdapter1 = new _10_LINQ_HW_0502.awDataSetTableAdapters.ProductPhotoTableAdapter();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblDetails, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 379);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(3, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(588, 32);
            this.lblDetails.TabIndex = 102;
            this.lblDetails.Text = "Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.button10);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.button11);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1034, 606);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(330, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 12);
            this.label10.TabIndex = 136;
            this.label10.Text = "年:";
            // 
            // comboBox3
            // 
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(389, 138);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(133, 20);
            this.comboBox3.TabIndex = 135;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(330, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 12);
            this.label8.TabIndex = 132;
            this.label8.Text = "季:";
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "第一季",
            "第二季",
            "第三季",
            "第四季"});
            this.comboBox2.Location = new System.Drawing.Point(389, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 20);
            this.comboBox2.TabIndex = 131;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(644, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker2.TabIndex = 130;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(50, 90);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 34);
            this.button3.TabIndex = 81;
            this.button3.Text = "     區間腳踏車 ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(599, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 129;
            this.label7.Text = "~";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(51, 131);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(269, 34);
            this.button5.TabIndex = 82;
            this.button5.Text = "     某年腳踏車 ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 22);
            this.dateTimePicker1.TabIndex = 128;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(51, 172);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(269, 34);
            this.button10.TabIndex = 83;
            this.button10.Text = "     某季腳踏車  ? 有幾筆 ?";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(326, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 12);
            this.label3.TabIndex = 127;
            this.label3.Text = "區間:";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button11.Location = new System.Drawing.Point(50, 49);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(269, 34);
            this.button11.TabIndex = 84;
            this.button11.Text = "     All 腳踏車 ";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(48, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 12);
            this.label6.TabIndex = 105;
            this.label6.Text = "LINQ to AdventureWorks DataSet";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Size = new System.Drawing.Size(1034, 383);
            this.splitContainer2.SplitterDistance = 432;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblMaster, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMaster
            // 
            this.lblMaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaster.ForeColor = System.Drawing.Color.White;
            this.lblMaster.Location = new System.Drawing.Point(3, 0);
            this.lblMaster.Name = "lblMaster";
            this.lblMaster.Size = new System.Drawing.Size(422, 32);
            this.lblMaster.TabIndex = 101;
            this.lblMaster.Text = "Master";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 74;
            this.dataGridView1.Size = new System.Drawing.Size(420, 339);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productPhotoBindingSource
            // 
            this.productPhotoBindingSource.DataMember = "ProductPhoto";
            // 
            // awDataSet1
            // 
            this.awDataSet1.DataSetName = "awDataSet";
            this.awDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productPhotoTableAdapter1
            // 
            this.productPhotoTableAdapter1.ClearBeforeFill = true;
            // 
            // Frm作業_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 606);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm作業_2";
            this.Text = "Frm作業_2";
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPhotoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMaster;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productPhotoBindingSource;
        private awDataSet awDataSet1;
        private awDataSetTableAdapters.ProductPhotoTableAdapter productPhotoTableAdapter1;
    }
}