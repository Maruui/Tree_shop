namespace WindowsFormsApp1
{
    partial class Addproductline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addproductline));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importpic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mid = new System.Windows.Forms.MaskedTextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tamount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.discliption = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(62, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // importpic
            // 
            this.importpic.BackColor = System.Drawing.Color.Wheat;
            this.importpic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.up;
            this.importpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importpic.FlatAppearance.BorderSize = 0;
            this.importpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importpic.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.importpic.Location = new System.Drawing.Point(189, 348);
            this.importpic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.importpic.Name = "importpic";
            this.importpic.Size = new System.Drawing.Size(112, 35);
            this.importpic.TabIndex = 6;
            this.importpic.Text = "เพิ่มรูป";
            this.importpic.UseVisualStyleBackColor = false;
            this.importpic.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(388, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "รหัสสินค้า";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mid
            // 
            this.mid.ForeColor = System.Drawing.Color.Black;
            this.mid.Location = new System.Drawing.Point(468, 66);
            this.mid.Mask = "ID-######";
            this.mid.Name = "mid";
            this.mid.Size = new System.Drawing.Size(95, 28);
            this.mid.TabIndex = 0;
            this.mid.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mid_MaskInputRejected);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(468, 116);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(417, 28);
            this.tname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(397, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อสินค้า";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(406, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "จำนวน";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // tamount
            // 
            this.tamount.Location = new System.Drawing.Point(468, 174);
            this.tamount.Name = "tamount";
            this.tamount.Size = new System.Drawing.Size(71, 28);
            this.tamount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(554, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "หน่วย";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // unit
            // 
            this.unit.FormattingEnabled = true;
            this.unit.Items.AddRange(new object[] {
            "ต้น",
            "แฝง"});
            this.unit.Location = new System.Drawing.Point(607, 174);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(107, 28);
            this.unit.Sorted = true;
            this.unit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(366, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "ราคา : หน่วย";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // tprice
            // 
            this.tprice.Location = new System.Drawing.Point(468, 228);
            this.tprice.MaxLength = 7;
            this.tprice.Name = "tprice";
            this.tprice.Size = new System.Drawing.Size(151, 28);
            this.tprice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(626, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "บาท";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(603, 295);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "รายละเอียดสินค้า";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // discliption
            // 
            this.discliption.Location = new System.Drawing.Point(468, 330);
            this.discliption.Multiline = true;
            this.discliption.Name = "discliption";
            this.discliption.Size = new System.Drawing.Size(429, 172);
            this.discliption.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(1118, 617);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "กลับ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aquamarine;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.folder_add;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(748, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "เพิ่มข้อมูล";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Honeydew;
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.document;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(924, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 42);
            this.button4.TabIndex = 8;
            this.button4.Text = "ลบข้อความ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Addproductline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.สินค้า;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.discliption);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.tamount);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importpic);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Addproductline";
            this.Text = "Addproductline";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button importpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mid;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tamount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox unit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox discliption;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}