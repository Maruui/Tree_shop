namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tusername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("FC Lamoon", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(410, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "มากมี พันธุ์ไม้";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("FC Lamoon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(390, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            // 
            // tusername
            // 
            this.tusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tusername.Font = new System.Drawing.Font("FC Lamoon", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tusername.Location = new System.Drawing.Point(396, 210);
            this.tusername.MaxLength = 13;
            this.tusername.Name = "tusername";
            this.tusername.Size = new System.Drawing.Size(433, 28);
            this.tusername.TabIndex = 0;
            this.tusername.TextChanged += new System.EventHandler(this.tusername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("FC Lamoon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(390, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password :";
            // 
            // tpassword
            // 
            this.tpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpassword.Font = new System.Drawing.Font("FC Lamoon", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tpassword.Location = new System.Drawing.Point(396, 333);
            this.tpassword.MaxLength = 13;
            this.tpassword.Name = "tpassword";
            this.tpassword.PasswordChar = '*';
            this.tpassword.Size = new System.Drawing.Size(433, 28);
            this.tpassword.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("FC Lamoon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(396, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(433, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Log in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("FC Lamoon", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.MediumBlue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1064, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.istockphoto_1075360978_612x612_waifu2x_art_noise1_scale_tta_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1223, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tusername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

