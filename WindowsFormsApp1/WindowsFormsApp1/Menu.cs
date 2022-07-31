using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ขอมลพนกงานToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee em = new employee();
            em.Show();
            this.Hide();
        }

        private void ขอมลสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock st = new Stock();
            st.Show();
            this.Hide();
        }

        private void ระบบขายสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sell_goods se = new sell_goods();
            se.Show();
            this.Hide();
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void เพมรายการสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void เพมรายการสนคาToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Addproductline f = new Addproductline();
            f.Show();
            this.Hide();
        }
    }
}
