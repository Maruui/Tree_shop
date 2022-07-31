namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ขอมลพนกงานToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ขอมลสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.เพมรายการสนคาToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ระบบขายสนคาToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ออกจากระบบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("FC Lamoon", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ขอมลพนกงานToolStripMenuItem,
            this.ขอมลสนคาToolStripMenuItem,
            this.เพมรายการสนคาToolStripMenuItem1,
            this.ระบบขายสนคาToolStripMenuItem,
            this.ออกจากระบบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ขอมลพนกงานToolStripMenuItem
            // 
            this.ขอมลพนกงานToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.ขอมลพนกงานToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ขอมลพนกงานToolStripMenuItem.Name = "ขอมลพนกงานToolStripMenuItem";
            this.ขอมลพนกงานToolStripMenuItem.Size = new System.Drawing.Size(188, 40);
            this.ขอมลพนกงานToolStripMenuItem.Text = "ข้อมูลพนักงาน";
            this.ขอมลพนกงานToolStripMenuItem.Click += new System.EventHandler(this.ขอมลพนกงานToolStripMenuItem_Click);
            // 
            // ขอมลสนคาToolStripMenuItem
            // 
            this.ขอมลสนคาToolStripMenuItem.BackColor = System.Drawing.Color.PaleGreen;
            this.ขอมลสนคาToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ขอมลสนคาToolStripMenuItem.Name = "ขอมลสนคาToolStripMenuItem";
            this.ขอมลสนคาToolStripMenuItem.Size = new System.Drawing.Size(155, 40);
            this.ขอมลสนคาToolStripMenuItem.Text = "ข้อมูลสินค้า";
            this.ขอมลสนคาToolStripMenuItem.Click += new System.EventHandler(this.ขอมลสนคาToolStripMenuItem_Click);
            // 
            // เพมรายการสนคาToolStripMenuItem1
            // 
            this.เพมรายการสนคาToolStripMenuItem1.BackColor = System.Drawing.Color.LimeGreen;
            this.เพมรายการสนคาToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.เพมรายการสนคาToolStripMenuItem1.Name = "เพมรายการสนคาToolStripMenuItem1";
            this.เพมรายการสนคาToolStripMenuItem1.Size = new System.Drawing.Size(225, 40);
            this.เพมรายการสนคาToolStripMenuItem1.Text = "เพิ่มรายการสินค้า";
            this.เพมรายการสนคาToolStripMenuItem1.Click += new System.EventHandler(this.เพมรายการสนคาToolStripMenuItem1_Click);
            // 
            // ระบบขายสนคาToolStripMenuItem
            // 
            this.ระบบขายสนคาToolStripMenuItem.BackColor = System.Drawing.Color.Aquamarine;
            this.ระบบขายสนคาToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ระบบขายสนคาToolStripMenuItem.Name = "ระบบขายสนคาToolStripMenuItem";
            this.ระบบขายสนคาToolStripMenuItem.Size = new System.Drawing.Size(196, 40);
            this.ระบบขายสนคาToolStripMenuItem.Text = "ระบบขายสินค้า";
            this.ระบบขายสนคาToolStripMenuItem.Click += new System.EventHandler(this.ระบบขายสนคาToolStripMenuItem_Click);
            // 
            // ออกจากระบบToolStripMenuItem
            // 
            this.ออกจากระบบToolStripMenuItem.BackColor = System.Drawing.Color.PeachPuff;
            this.ออกจากระบบToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ออกจากระบบToolStripMenuItem.Name = "ออกจากระบบToolStripMenuItem";
            this.ออกจากระบบToolStripMenuItem.Size = new System.Drawing.Size(183, 40);
            this.ออกจากระบบToolStripMenuItem.Text = "ออกจากระบบ";
            this.ออกจากระบบToolStripMenuItem.Click += new System.EventHandler(this.ออกจากระบบToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.เมนูv2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(954, 349);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("FC Lamoon", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ขอมลพนกงานToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ขอมลสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ระบบขายสนคาToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ออกจากระบบToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem เพมรายการสนคาToolStripMenuItem1;
    }
}