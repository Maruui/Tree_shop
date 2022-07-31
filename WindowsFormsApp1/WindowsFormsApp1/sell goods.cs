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
    public partial class sell_goods : Form

    {
        int i, b = 1, c = 1;
        double vat = 0, netprice = 0, sum = 0, sum1 = 0, receive, change, discount = 0;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุุณต้องการลบรายการสินค้านี้ใช่หรือไม่ ?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                for (i = 0; i <= listView1.SelectedItems.Count - 1; i++)
                {
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                    c--;
                    sum1 = sum1 - sum;
                }
            }
        }

        public sell_goods()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            vat = sum1 * 7 / 100;
            if (sum1 > 10000)
                discount = sum1 * 5 / 100;
            else if (sum1 >= 5000)
                discount = sum1 * 3 / 100;
            else if (sum1 >= 3000)
                discount = sum1 * 1.5 / 100;
            else discount = 0;

            netprice = sum1 + vat - discount;
            tdiscount.Text = discount.ToString("#,###.00");
            tsum.Text = sum1.ToString("#,###,###.00");
            tvat.Text = vat.ToString("#,###.00");
            tsum2.Text = netprice.ToString("#,###,###.00");
            deleteitem.Enabled = false;
            additem.Enabled = false;
            tRecive.Focus();

            try
            {
                receive = Convert.ToDouble(tRecive.Text);
                tRecive.Text = receive.ToString("##,###.00");
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณาใส่จำนวนเงินที่ได้รับ", "receive", MessageBoxButtons.OK);
                tRecive.Text = "";
                return;
            }
            if (receive >= netprice)
            {
                change = receive - netprice;
                tchange.Text = change.ToString("#,###.00");
            }
            else
            {
                MessageBox.Show("จำนวนเงินไม่พอ กรุณาใส่อีกครั้ง.");
                tRecive.Text = "";
                tRecive.Focus();
                return;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu F = new Menu();
            F.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("สั่งพิมพ์เรียบร้อย", "print", MessageBoxButtons.OK);

            name.Text = "";
            tprice.Text = "";
            amount.Text = "";
            unit.Text = "";
            tsum.Text = "";
            tvat.Text = "";
            tdiscount.Text = "";
            tsum2.Text = "";
            tRecive.Text = "";
            tchange.Text = "";
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                MessageBox.Show("กรุณาใส่ชื่อสินค้า", "Goods Name", MessageBoxButtons.OK);
                name.Focus();  //ให้เคอร์เซอ์กลับไปจุดๆนั้น
                return;
            }
            else if (amount.Text == "")
            {
                MessageBox.Show("กรุณาใส่จำนวนสินค้าที่ท่านซื้อ", "QTY", MessageBoxButtons.OK);
                amount.Focus();
                return;
            }
            else if (unit.Text == "")
            {
                MessageBox.Show("กรุณาใส่หน่วยนับสินค้า", "Unit", MessageBoxButtons.OK);
                unit.Focus();
                return;
            }
            else if (tprice.Text == "")
            {
                MessageBox.Show("กรุณาใส่ราคาสินค้า", "Price", MessageBoxButtons.OK);
                tprice.Focus();
                return;
            }
            b++;
            Double[] price = new Double[b];
            Double[] qty = new Double[b];
            for (i = 0; i < b; i++)
            {
                try
                {
                    price[i] = Convert.ToDouble(tprice.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("กรุณาใส่ราคาสินค้าเป็นตัวเลขเท่านั้น", "Price", MessageBoxButtons.OK);
                    tprice.Text = "";
                    return;
                }
                try
                {
                    qty[i] = Convert.ToDouble(amount.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("กรุณาใส่จำนวนสินค้าเป็นตัวเลขเท่านั้น", "QTY", MessageBoxButtons.OK);
                    amount.Text = "";
                    return;
                }
                sum = price[i] * qty[i];
            }
            ListViewItem GB = new ListViewItem(c.ToString());
            c++;

            GB.SubItems.Add(name.Text);
            GB.SubItems.Add(tprice.Text);
            GB.SubItems.Add(amount.Text);
            GB.SubItems.Add(unit.Text);
            GB.SubItems.Add(sum.ToString("#,##.00"));
            listView1.Items.Add(GB);
            unit.Text = "";
            name.Text = "";
            tprice.Text = "";
            amount.Text = "";
            name.Focus();
            sum1 = sum1 + sum;
            name.Focus();
        }
    }
}
