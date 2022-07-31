namespace WindowsFormsApp1
{
    partial class employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mrs = new System.Windows.Forms.RadioButton();
            this.ms = new System.Windows.Forms.RadioButton();
            this.mr = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mssex = new System.Windows.Forms.RadioButton();
            this.mrsex = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tad1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cad1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tad3 = new System.Windows.Forms.TextBox();
            this.tad2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mphone = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.importpic = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.midcard = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tdate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tpost1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tadd1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cadd1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tadd3 = new System.Windows.Forms.TextBox();
            this.tadd2 = new System.Windows.Forms.TextBox();
            this.tpost2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label22 = new System.Windows.Forms.Label();
            this.MIDE = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.mrs);
            this.groupBox1.Controls.Add(this.ms);
            this.groupBox1.Controls.Add(this.mr);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " คำนำหน้า";
            // 
            // mrs
            // 
            this.mrs.AutoSize = true;
            this.mrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mrs.Location = new System.Drawing.Point(81, 40);
            this.mrs.Name = "mrs";
            this.mrs.Size = new System.Drawing.Size(52, 24);
            this.mrs.TabIndex = 1;
            this.mrs.TabStop = true;
            this.mrs.Text = "นาง";
            this.mrs.UseVisualStyleBackColor = true;
            this.mrs.CheckedChanged += new System.EventHandler(this.mrs_CheckedChanged);
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ms.Location = new System.Drawing.Point(148, 40);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(78, 24);
            this.ms.TabIndex = 2;
            this.ms.TabStop = true;
            this.ms.Text = "นางสาว";
            this.ms.UseVisualStyleBackColor = true;
            this.ms.CheckedChanged += new System.EventHandler(this.ms_CheckedChanged);
            // 
            // mr
            // 
            this.mr.AutoSize = true;
            this.mr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mr.Location = new System.Drawing.Point(11, 40);
            this.mr.Name = "mr";
            this.mr.Size = new System.Drawing.Size(54, 24);
            this.mr.TabIndex = 0;
            this.mr.TabStop = true;
            this.mr.Text = "นาย";
            this.mr.UseVisualStyleBackColor = true;
            this.mr.CheckedChanged += new System.EventHandler(this.mr_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(39, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "เพศ";
            // 
            // mssex
            // 
            this.mssex.AutoSize = true;
            this.mssex.BackColor = System.Drawing.Color.Transparent;
            this.mssex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mssex.Location = new System.Drawing.Point(182, 131);
            this.mssex.Name = "mssex";
            this.mssex.Size = new System.Drawing.Size(57, 24);
            this.mssex.TabIndex = 1;
            this.mssex.TabStop = true;
            this.mssex.Text = "หญิง";
            this.mssex.UseVisualStyleBackColor = false;
            this.mssex.CheckedChanged += new System.EventHandler(this.mssex_CheckedChanged);
            // 
            // mrsex
            // 
            this.mrsex.AutoSize = true;
            this.mrsex.BackColor = System.Drawing.Color.Transparent;
            this.mrsex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mrsex.Location = new System.Drawing.Point(103, 131);
            this.mrsex.Name = "mrsex";
            this.mrsex.Size = new System.Drawing.Size(53, 24);
            this.mrsex.TabIndex = 0;
            this.mrsex.TabStop = true;
            this.mrsex.Text = "ชาย";
            this.mrsex.UseVisualStyleBackColor = false;
            this.mrsex.CheckedChanged += new System.EventHandler(this.mrsex_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(333, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "ชื่อ-นามสกุล";
            // 
            // tname
            // 
            this.tname.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tname.Location = new System.Drawing.Point(445, 49);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(256, 31);
            this.tname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(46, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ที่อยู่ตามบัตรประชาชน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(78, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "บ้านเลขที่";
            // 
            // tad1
            // 
            this.tad1.Location = new System.Drawing.Point(153, 226);
            this.tad1.MaxLength = 100;
            this.tad1.Name = "tad1";
            this.tad1.Size = new System.Drawing.Size(194, 28);
            this.tad1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(94, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "จังหวัด";
            // 
            // cad1
            // 
            this.cad1.FormattingEnabled = true;
            this.cad1.Items.AddRange(new object[] {
            "กระบี่   ",
            "กรุงเทพมหานคร   ",
            "กาญจนบุรี   ",
            "กาฬสินธุ์   ",
            "กำแพงเพชร   ",
            "ขอนแก่น   ",
            "จันทบุรี   ",
            "ฉะเชิงเทรา   ",
            "ชลบุรี   ",
            "ชัยนาท   ",
            "ชัยภูมิ   ",
            "ชุมพร   ",
            "เชียงราย   ",
            "เชียงใหม่   ",
            "ตรัง   ",
            "ตราด   ",
            "ตาก   ",
            "นครนายก   ",
            "นครปฐม   ",
            "นครพนม   ",
            "นครราชสีมา   ",
            "นครศรีธรรมราช   ",
            "นครสวรรค์   ",
            "นนทบุรี   ",
            "นราธิวาส   ",
            "น่าน   ",
            "บึงกาฬ",
            "บุรีรัมย์   ",
            "ปทุมธานี   ",
            "ประจวบคีรีขันธ์   ",
            "ปราจีนบุรี   ",
            "ปัตตานี   ",
            "พระนครศรีอยุธยา   ",
            "พะเยา   ",
            "พังงา   ",
            "พัทลุง   ",
            "พิจิตร   ",
            "พิษณุโลก   ",
            "เพชรบุรี   ",
            "เพชรบูรณ์   ",
            "แพร่   ",
            "ภูเก็ต   ",
            "มหาสารคาม   ",
            "มุกดาหาร   ",
            "แม่ฮ่องสอน   ",
            "ยโสธร   ",
            "ยะลา   ",
            "ร้อยเอ็ด   ",
            "ระนอง   ",
            "ระยอง   ",
            "ราชบุรี   ",
            "ลพบุรี   ",
            "ลำปาง   ",
            "ลำพูน   ",
            "เลย   ",
            "ศรีสะเกษ   ",
            "สกลนคร   ",
            "สงขลา   ",
            "สตูล   ",
            "สมุทรปราการ   ",
            "สมุทรสงคราม   ",
            "สมุทรสาคร   ",
            "สระแก้ว   ",
            "สระบุรี",
            "สิงห์บุรี   ",
            "สุโขทัย   ",
            "สุพรรณบุรี   ",
            "สุราษฎร์ธานี   ",
            "สุรินทร์   ",
            "หนองคาย   ",
            "หนองบัวลำภู   ",
            "อ่างทอง   ",
            "อำนาจเจริญ   ",
            "อุดรธานี   ",
            "อุตรดิตถ์   ",
            "อุทัยธานี   ",
            "อุบลราชธานี   "});
            this.cad1.Location = new System.Drawing.Point(155, 289);
            this.cad1.Name = "cad1";
            this.cad1.Size = new System.Drawing.Size(191, 28);
            this.cad1.Sorted = true;
            this.cad1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(391, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "แขวง/ตำบล";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(666, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "เขต/อำเภอ";
            // 
            // tad3
            // 
            this.tad3.Location = new System.Drawing.Point(745, 225);
            this.tad3.MaxLength = 100;
            this.tad3.Name = "tad3";
            this.tad3.Size = new System.Drawing.Size(143, 28);
            this.tad3.TabIndex = 9;
            // 
            // tad2
            // 
            this.tad2.Location = new System.Drawing.Point(485, 226);
            this.tad2.MaxLength = 100;
            this.tad2.Name = "tad2";
            this.tad2.Size = new System.Drawing.Size(141, 28);
            this.tad2.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(384, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "รหัสไปรษณีย์";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(359, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "เบอร์โทร";
            // 
            // mphone
            // 
            this.mphone.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.mphone.Location = new System.Drawing.Point(445, 146);
            this.mphone.Mask = "00 0000 0000";
            this.mphone.Name = "mphone";
            this.mphone.Size = new System.Drawing.Size(147, 31);
            this.mphone.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(1055, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // importpic
            // 
            this.importpic.BackColor = System.Drawing.Color.LightCyan;
            this.importpic.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.up;
            this.importpic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importpic.Location = new System.Drawing.Point(1055, 242);
            this.importpic.Name = "importpic";
            this.importpic.Size = new System.Drawing.Size(152, 33);
            this.importpic.TabIndex = 20;
            this.importpic.Text = "เพิ่มรูป";
            this.importpic.UseVisualStyleBackColor = false;
            this.importpic.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(298, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "เลขบัตรประชาชน";
            // 
            // midcard
            // 
            this.midcard.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.midcard.Location = new System.Drawing.Point(445, 96);
            this.midcard.Mask = "0 0000 00000 00 0";
            this.midcard.Name = "midcard";
            this.midcard.Size = new System.Drawing.Size(198, 31);
            this.midcard.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(62, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "ว/ด/ป เกิด";
            // 
            // tdate
            // 
            this.tdate.Location = new System.Drawing.Point(153, 346);
            this.tdate.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(216, 28);
            this.tdate.TabIndex = 12;
            this.tdate.ValueChanged += new System.EventHandler(this.datetime_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(401, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "อายุ";
            // 
            // tage
            // 
            this.tage.BackColor = System.Drawing.Color.White;
            this.tage.Enabled = false;
            this.tage.Location = new System.Drawing.Point(447, 349);
            this.tage.MaxLength = 3;
            this.tage.Name = "tage";
            this.tage.Size = new System.Drawing.Size(56, 28);
            this.tage.TabIndex = 13;
            this.tage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tage.TextChanged += new System.EventHandler(this.tace_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(509, 352);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "ปี";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(46, 420);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 29;
            this.label14.Text = "ที่อยุูปัจุบัน";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PeachPuff;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Save2;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(824, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "บันทึก";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PapayaWhip;
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.document;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button3.Location = new System.Drawing.Point(959, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 45);
            this.button3.TabIndex = 22;
            this.button3.Text = "ลบทั้งหมด";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.PapayaWhip;
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.home;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button4.Location = new System.Drawing.Point(1092, 609);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 45);
            this.button4.TabIndex = 23;
            this.button4.Text = "กลับ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.Location = new System.Drawing.Point(136, 420);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(174, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "ที่อยู่ตามบัตรประชาชน";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tpost1
            // 
            this.tpost1.Location = new System.Drawing.Point(483, 293);
            this.tpost1.MaxLength = 5;
            this.tpost1.Name = "tpost1";
            this.tpost1.Size = new System.Drawing.Size(141, 28);
            this.tpost1.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(76, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "บ้านเลขที่";
            // 
            // tadd1
            // 
            this.tadd1.Location = new System.Drawing.Point(151, 471);
            this.tadd1.MaxLength = 100;
            this.tadd1.Name = "tadd1";
            this.tadd1.Size = new System.Drawing.Size(194, 28);
            this.tadd1.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(92, 537);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "จังหวัด";
            // 
            // cadd1
            // 
            this.cadd1.FormattingEnabled = true;
            this.cadd1.Items.AddRange(new object[] {
            "กรุงเทพมหานคร   ",
            "สมุทรปราการ   ",
            "นนทบุรี   ",
            "ปทุมธานี   ",
            "พระนครศรีอยุธยา   ",
            "อ่างทอง   ",
            "ลพบุรี   ",
            "สิงห์บุรี   ",
            "ชัยนาท   ",
            "สระบุรี",
            "ชลบุรี   ",
            "ระยอง   ",
            "จันทบุรี   ",
            "ตราด   ",
            "ฉะเชิงเทรา   ",
            "ปราจีนบุรี   ",
            "นครนายก   ",
            "สระแก้ว   ",
            "นครราชสีมา   ",
            "บุรีรัมย์   ",
            "สุรินทร์   ",
            "ศรีสะเกษ   ",
            "อุบลราชธานี   ",
            "ยโสธร   ",
            "ชัยภูมิ   ",
            "อำนาจเจริญ   ",
            "หนองบัวลำภู   ",
            "ขอนแก่น   ",
            "อุดรธานี   ",
            "เลย   ",
            "หนองคาย   ",
            "มหาสารคาม   ",
            "ร้อยเอ็ด   ",
            "กาฬสินธุ์   ",
            "สกลนคร   ",
            "นครพนม   ",
            "มุกดาหาร   ",
            "เชียงใหม่   ",
            "ลำพูน   ",
            "ลำปาง   ",
            "อุตรดิตถ์   ",
            "แพร่   ",
            "น่าน   ",
            "พะเยา   ",
            "เชียงราย   ",
            "แม่ฮ่องสอน   ",
            "นครสวรรค์   ",
            "อุทัยธานี   ",
            "กำแพงเพชร   ",
            "ตาก   ",
            "สุโขทัย   ",
            "พิษณุโลก   ",
            "พิจิตร   ",
            "เพชรบูรณ์   ",
            "ราชบุรี   ",
            "กาญจนบุรี   ",
            "สุพรรณบุรี   ",
            "นครปฐม   ",
            "สมุทรสาคร   ",
            "สมุทรสงคราม   ",
            "เพชรบุรี   ",
            "ประจวบคีรีขันธ์   ",
            "นครศรีธรรมราช   ",
            "กระบี่   ",
            "พังงา   ",
            "ภูเก็ต   ",
            "สุราษฎร์ธานี   ",
            "ระนอง   ",
            "ชุมพร   ",
            "สงขลา   ",
            "สตูล   ",
            "ตรัง   ",
            "พัทลุง   ",
            "ปัตตานี   ",
            "ยะลา   ",
            "นราธิวาส   ",
            "บึงกาฬ"});
            this.cadd1.Location = new System.Drawing.Point(153, 534);
            this.cadd1.Name = "cadd1";
            this.cadd1.Size = new System.Drawing.Size(191, 28);
            this.cadd1.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(389, 474);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "แขวง/ตำบล";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(664, 474);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 20);
            this.label18.TabIndex = 13;
            this.label18.Text = "เขต/อำเภอ";
            // 
            // tadd3
            // 
            this.tadd3.Location = new System.Drawing.Point(743, 470);
            this.tadd3.MaxLength = 100;
            this.tadd3.Name = "tadd3";
            this.tadd3.Size = new System.Drawing.Size(143, 28);
            this.tadd3.TabIndex = 17;
            // 
            // tadd2
            // 
            this.tadd2.Location = new System.Drawing.Point(483, 471);
            this.tadd2.MaxLength = 100;
            this.tadd2.Name = "tadd2";
            this.tadd2.Size = new System.Drawing.Size(141, 28);
            this.tadd2.TabIndex = 16;
            // 
            // tpost2
            // 
            this.tpost2.Location = new System.Drawing.Point(481, 538);
            this.tpost2.MaxLength = 5;
            this.tpost2.Name = "tpost2";
            this.tpost2.Size = new System.Drawing.Size(141, 28);
            this.tpost2.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(382, 542);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 20);
            this.label19.TabIndex = 16;
            this.label19.Text = "รหัสไปรษณีย์";
            this.label19.Click += new System.EventHandler(this.label8_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label20.Location = new System.Drawing.Point(693, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 23);
            this.label20.TabIndex = 22;
            this.label20.Text = "ตำแหน่ง";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.Location = new System.Drawing.Point(693, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(73, 23);
            this.label21.TabIndex = 22;
            this.label21.Text = "เงินเดือน";
            // 
            // position
            // 
            this.position.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "คนสวน",
            "แม่บ้าน",
            "รปภ",
            "นักการตลาด",
            "นักบัญชี",
            "ไอที",
            "ผู้บริหาร",
            "เลขา"});
            this.position.Location = new System.Drawing.Point(777, 96);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(142, 31);
            this.position.TabIndex = 5;
            // 
            // salary
            // 
            this.salary.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.salary.Location = new System.Drawing.Point(777, 146);
            this.salary.MaxLength = 7;
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(142, 31);
            this.salary.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label22.Location = new System.Drawing.Point(711, 52);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(103, 23);
            this.label22.TabIndex = 22;
            this.label22.Text = "รหัสพนักงาน";
            // 
            // MIDE
            // 
            this.MIDE.Font = new System.Drawing.Font("FC Lamoon", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MIDE.Location = new System.Drawing.Point(820, 49);
            this.MIDE.Mask = "ID-00000";
            this.MIDE.Name = "MIDE";
            this.MIDE.Size = new System.Drawing.Size(99, 31);
            this.MIDE.TabIndex = 4;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.พนักงาน;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.position);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.midcard);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.importpic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MIDE);
            this.Controls.Add(this.mphone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tpost2);
            this.Controls.Add(this.tpost1);
            this.Controls.Add(this.tadd2);
            this.Controls.Add(this.tadd3);
            this.Controls.Add(this.tad2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tad3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cadd1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cad1);
            this.Controls.Add(this.tadd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tad1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mrsex);
            this.Controls.Add(this.mssex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "employee";
            this.Text = "employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton mrs;
        private System.Windows.Forms.RadioButton ms;
        private System.Windows.Forms.RadioButton mr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton mssex;
        private System.Windows.Forms.RadioButton mrsex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tad1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cad1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tad3;
        private System.Windows.Forms.TextBox tad2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mphone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button importpic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox midcard;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker tdate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tpost1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tadd1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cadd1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tadd3;
        private System.Windows.Forms.TextBox tadd2;
        private System.Windows.Forms.TextBox tpost2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.MaskedTextBox MIDE;
    }
}