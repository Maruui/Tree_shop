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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Menu G = new Menu();
            G.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu G = new Menu();
            G.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("กำลังสั่งพิมพ์กรุณารอสักครู่", "Printer", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addproductline G = new Addproductline();
            G.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void button4_Click_1(object sender, EventArgs e)
        {
            int i, c = 1;
            double sum = 0, sum1 = 0;
            if (MessageBox.Show("คุุณต้องการยกเลิกรายการสินค้านี้ใช่หรือไม่ ?", "ยกเลิกรายการขาย", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                for (i = 0; i <= listView1.SelectedItems.Count - 1; i++)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    c--;
                    sum1 = sum1 - sum;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("อัพเดทยอดล่าสุดเรียบร้อย","อัพเดท",MessageBoxButtons.OK);
        }
    }
}
