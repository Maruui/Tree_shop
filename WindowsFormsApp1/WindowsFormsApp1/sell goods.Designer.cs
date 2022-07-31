namespace WindowsFormsApp1
{
    partial class sell_goods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sell_goods));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ldetail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.additem = new System.Windows.Forms.Button();
            this.tsum = new System.Windows.Forms.TextBox();
            this.tvat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tdiscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tsum2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tRecive = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tchange = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.deleteitem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ข้อมูลสินค้า";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(43, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อสินค้า";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(113, 123);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 28);
            this.name.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(316, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ราคา";
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(366, 123);
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(162, 28);
            this.tprice.TabIndex = 1;
            this.tprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(534, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "บาท";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(599, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "จำนวน";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(660, 123);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(63, 28);
            this.amount.TabIndex = 2;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(729, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "หน่วยนับ";
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "ต้น",
            "แฝง"});
            this.unit.Location = new System.Drawing.Point(801, 123);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(107, 28);
            this.unit.Sorted = true;
            this.unit.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.LNO,
            this.Ldetail,
            this.LPrice,
            this.LAmount,
            this.LUnit,
            this.LSum});
            this.listView1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(74, 171);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1007, 200);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LNO
            // 
            this.LNO.Text = "ที่";
            // 
            // Ldetail
            // 
            this.Ldetail.Text = "ชื่อสินค้า";
            this.Ldetail.Width = 403;
            // 
            // LPrice
            // 
            this.LPrice.Text = "ราคา";
            this.LPrice.Width = 157;
            // 
            // LAmount
            // 
            this.LAmount.Text = "จำนวน";
            this.LAmount.Width = 114;
            // 
            // LUnit
            // 
            this.LUnit.Text = "หน่วยนับ";
            this.LUnit.Width = 127;
            // 
            // LSum
            // 
            this.LSum.Text = "ผลรวม";
            this.LSum.Width = 142;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(26, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "รวมเป็นเงิน";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(260, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "บาท";
            // 
            // additem
            // 
            this.additem.BackColor = System.Drawing.Color.Aquamarine;
            this.additem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.add;
            this.additem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.additem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.additem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.additem.Location = new System.Drawing.Point(1110, 123);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(117, 42);
            this.additem.TabIndex = 4;
            this.additem.Text = "เพิ่มรายการ";
            this.additem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.additem.UseVisualStyleBackColor = false;
            this.additem.Click += new System.EventHandler(this.button1_Click);
            // 
            // tsum
            // 
            this.tsum.Enabled = false;
            this.tsum.Location = new System.Drawing.Point(114, 396);
            this.tsum.Name = "tsum";
            this.tsum.Size = new System.Drawing.Size(140, 28);
            this.tsum.TabIndex = 5;
            this.tsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tvat
            // 
            this.tvat.Enabled = false;
            this.tvat.Location = new System.Drawing.Point(361, 399);
            this.tvat.Name = "tvat";
            this.tvat.Size = new System.Drawing.Size(140, 28);
            this.tvat.TabIndex = 6;
            this.tvat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(321, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "ภาษี";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(507, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "บาท";
            // 
            // tdiscount
            // 
            this.tdiscount.Enabled = false;
            this.tdiscount.Location = new System.Drawing.Point(637, 399);
            this.tdiscount.Name = "tdiscount";
            this.tdiscount.Size = new System.Drawing.Size(140, 28);
            this.tdiscount.TabIndex = 2;
            this.tdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label11.Location = new System.Drawing.Point(575, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "ส่วนลด";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(783, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "บาท";
            // 
            // tsum2
            // 
            this.tsum2.Enabled = false;
            this.tsum2.Location = new System.Drawing.Point(941, 402);
            this.tsum2.Name = "tsum2";
            this.tsum2.Size = new System.Drawing.Size(140, 28);
            this.tsum2.TabIndex = 2;
            this.tsum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label13.Location = new System.Drawing.Point(847, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "รวมเงินสุทธิ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label14.Location = new System.Drawing.Point(1087, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "บาท";
            // 
            // tRecive
            // 
            this.tRecive.Location = new System.Drawing.Point(941, 460);
            this.tRecive.Name = "tRecive";
            this.tRecive.Size = new System.Drawing.Size(140, 28);
            this.tRecive.TabIndex = 6;
            this.tRecive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label15.Location = new System.Drawing.Point(859, 463);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "เงินที่ได้รับ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label16.Location = new System.Drawing.Point(1087, 463);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "บาท";
            // 
            // tchange
            // 
            this.tchange.Enabled = false;
            this.tchange.ForeColor = System.Drawing.Color.Brown;
            this.tchange.Location = new System.Drawing.Point(941, 516);
            this.tchange.Name = "tchange";
            this.tchange.Size = new System.Drawing.Size(140, 28);
            this.tchange.TabIndex = 2;
            this.tchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label17.Location = new System.Drawing.Point(874, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "เงินทอน";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label18.Location = new System.Drawing.Point(1087, 519);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "บาท";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCoral;
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(1112, 613);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 9;
            this.button4.Text = "กลับ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.printer;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(966, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "พิมพ์ใบเสร็จ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.calculator;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(823, 613);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 45);
            this.button5.TabIndex = 7;
            this.button5.Text = "คำนวน";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // deleteitem
            // 
            this.deleteitem.BackColor = System.Drawing.Color.Bisque;
            this.deleteitem.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.delete;
            this.deleteitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteitem.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.deleteitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteitem.Location = new System.Drawing.Point(1110, 179);
            this.deleteitem.Name = "deleteitem";
            this.deleteitem.Size = new System.Drawing.Size(117, 42);
            this.deleteitem.TabIndex = 5;
            this.deleteitem.Text = "ลบรายการ";
            this.deleteitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteitem.UseVisualStyleBackColor = false;
            this.deleteitem.Click += new System.EventHandler(this.button6_Click);
            // 
            // sell_goods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.ขายสินค้า;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteitem);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tchange);
            this.Controls.Add(this.tRecive);
            this.Controls.Add(this.tsum2);
            this.Controls.Add(this.tdiscount);
            this.Controls.Add(this.tvat);
            this.Controls.Add(this.tsum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sell_goods";
            this.Text = "sell_goods";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader LNO;
        private System.Windows.Forms.ColumnHeader Ldetail;
        private System.Windows.Forms.ColumnHeader LPrice;
        private System.Windows.Forms.ColumnHeader LAmount;
        private System.Windows.Forms.ColumnHeader LUnit;
        private System.Windows.Forms.ColumnHeader LSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.TextBox tsum;
        private System.Windows.Forms.TextBox tvat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tdiscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tsum2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tRecive;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tchange;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button deleteitem;
    }
}