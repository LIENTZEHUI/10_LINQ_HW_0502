
namespace _10_LINQ_HW_0502
{
    partial class Frm考試
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button36.Location = new System.Drawing.Point(213, -112);
            this.button36.Margin = new System.Windows.Forms.Padding(4);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(375, 75);
            this.button36.TabIndex = 147;
            this.button36.Text = "搜尋 班級學生成績";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button37.Location = new System.Drawing.Point(38, 90);
            this.button37.Margin = new System.Windows.Forms.Padding(4);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(375, 75);
            this.button37.TabIndex = 146;
            this.button37.Text = "每個學生個人成績";
            this.button37.UseVisualStyleBackColor = false;
            this.button37.Click += new System.EventHandler(this.button37_Click_1);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(38, 507);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(375, 75);
            this.button6.TabIndex = 142;
            this.button6.Text = "年 銷售成長率";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.Location = new System.Drawing.Point(38, 284);
            this.button35.Margin = new System.Windows.Forms.Padding(4);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(375, 75);
            this.button35.TabIndex = 145;
            this.button35.Text = "所有隨機分數出現的次數/比率";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.ForeColor = System.Drawing.Color.Black;
            this.button34.Location = new System.Drawing.Point(38, 398);
            this.button34.Margin = new System.Windows.Forms.Padding(4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(375, 75);
            this.button34.TabIndex = 144;
            this.button34.Text = "銷售分析 &&　plot";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(38, 187);
            this.button33.Margin = new System.Windows.Forms.Padding(4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(375, 75);
            this.button33.TabIndex = 143;
            this.button33.Text = "隨機 統計 100 個學生 分數";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(557, 235);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(495, 298);
            this.chart1.TabIndex = 148;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(594, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(391, 150);
            this.dataGridView1.TabIndex = 149;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(38, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 75);
            this.button1.TabIndex = 150;
            this.button1.Text = "搜尋 班級學生成績";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm考試
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 577);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button36);
            this.Controls.Add(this.button37);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button33);
            this.Name = "Frm考試";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}