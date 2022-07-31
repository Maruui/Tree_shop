namespace WindowsFormsApp1
{
    partial class Stock
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LInum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idproduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Lamount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lunit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lpperunit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lsum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(1037, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "กลับ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.report;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(833, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "รายงานสินค้าคงเหลือ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder_add;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(452, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 40);
            this.button3.TabIndex = 1;
            this.button3.Text = "เพิ่มรายการสินค้า";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LInum,
            this.idproduct,
            this.Lname,
            this.Lamount,
            this.Lunit,
            this.Lpperunit,
            this.Lsum});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(108, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1025, 360);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // LInum
            // 
            this.LInum.Text = "ที่";
            // 
            // idproduct
            // 
            this.idproduct.Text = "รหัสสินค้า";
            this.idproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idproduct.Width = 122;
            // 
            // Lname
            // 
            this.Lname.Text = "ชื่อสินค้า";
            this.Lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lname.Width = 420;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(104, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "สินค้าคงเหลือ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(333, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "รายการ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(809, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ราคารวมทั้งหมด";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(217, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 28);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(947, 474);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 28);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(1096, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "บาท";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PeachPuff;
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder_delete;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Location = new System.Drawing.Point(636, 605);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "ยกเลิกรายการขาย";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Azure;
            this.button5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.refresh;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Location = new System.Drawing.Point(267, 604);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "ยอดคงเหลือล่าสุด";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Lamount
            // 
            this.Lamount.Text = "จำนวน";
            this.Lamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lamount.Width = 89;
            // 
            // Lunit
            // 
            this.Lunit.Text = "หน่วย";
            this.Lunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lunit.Width = 73;
            // 
            // Lpperunit
            // 
            this.Lpperunit.Text = "ราคา:หน่วย";
            this.Lpperunit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lpperunit.Width = 118;
            // 
            // Lsum
            // 
            this.Lsum.Text = "ราคารวม";
            this.Lsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lsum.Width = 139;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.สินค้า;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LInum;
        private System.Windows.Forms.ColumnHeader idproduct;
        private System.Windows.Forms.ColumnHeader Lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColumnHeader Lamount;
        private System.Windows.Forms.ColumnHeader Lunit;
        private System.Windows.Forms.ColumnHeader Lpperunit;
        private System.Windows.Forms.ColumnHeader Lsum;
    }
}