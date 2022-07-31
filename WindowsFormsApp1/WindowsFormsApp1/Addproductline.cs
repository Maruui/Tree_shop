using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Addproductline : Form
    {
        public Addproductline()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image picture1;
            openFileDialog1.Filter = "image(*.jpg,*.*.gif) | *.jpg;*.png;*.bmp";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            picture1 = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = picture1;
            pictureBox1.Refresh();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu F = new Menu();
            F.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            mid.Text = "";
            tname.Text = "";
            tamount.Text = "";
            unit.Text="";
            tprice.Text = "";
            discliption.Text = "";
        }

        private void mid_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อย","เพิ่มข้อมูล",MessageBoxButtons.OK);

            mid.Text = "";
            tname.Text = "";
            tamount.Text = "";
            unit.Text = "";
            tprice.Text = "";
            discliption.Text = "";
            pictureBox1.Image.Dispose();
        }
    }
}
