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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void คำนำหน้า_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void mr_CheckedChanged(object sender, EventArgs e)
        {
            if (mr.Checked == true)
                mrsex.Checked = Enabled;
            mssex.Checked = false;
        }

        private void mrs_CheckedChanged(object sender, EventArgs e)
        {
            if (mrs.Checked == true)
                mssex.Checked = Enabled;
            mrsex.Checked = false;
        }

        private void ms_CheckedChanged(object sender, EventArgs e)
        {
            if (ms.Checked == true)
                mssex.Checked = Enabled;
            mrsex.Checked = false;
        }

        private void mrsex_CheckedChanged(object sender, EventArgs e)
        {
            if (mrsex.Checked == true)
                mr.Checked = Enabled;
            ms.Checked = false;
        }

        private void mssex_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tadd1.Text = tad1.Text;
                tadd2.Text = tad2.Text;
                tadd3.Text = tad3.Text;
                cadd1.Text = cad1.Text;
                tpost2.Text = tpost1.Text;
                tadd1.Enabled = false;
                tadd2.Enabled = false;
                tadd3.Enabled = false;
                cadd1.Enabled = false;
                tpost2.Enabled = false;
            }
            else
            {
                tadd1.Text = "";
                tadd2.Text = "";
                tadd3.Text = "";
                cadd1.Text = "";
                tpost2.Text = "";
                tadd1.Enabled = true;
                tadd2.Enabled = true;
                tadd3.Enabled = true;
                cadd1.Enabled = true;
                tpost2.Enabled = true;
            }

        }

        private void tace_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void datetime_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(tdate.Value.Year,tdate.Value.Month,tdate.Value.Day);
            DateTime date2 = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
            TimeSpan ts = new TimeSpan();
            int age = 0;
            
            ts = date2.Subtract(date1);
          
            age = (ts.Days / 365);

            if (age < 18 || age > 60)
            {
                MessageBox.Show("อายุพนักงานต้องมากกว่า 18 และไม่เกิน 60 ปี", "Warning", MessageBoxButtons.OK);
                tdate.Focus();
            }
            else
            {
                tage.Text = age.ToString("##");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu F = new Menu();
            F.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mr.Checked = false;
            ms.Checked = false;
            mrs.Checked = false;
            mrsex.Checked = false;
            mssex.Checked = false;
            tname.Text = "";
            midcard.Text = "";
            mphone.Text = "";
            position.Text = "";
            salary.Text = "";
            tad1.Text = "";
            tad2.Text = "";
            tad3.Text = "";
            cad1.Text = "";
            tpost1.Text = "";
            tage.Text = "";
            checkBox1.Checked = false;
            tadd1.Text = "";
            tadd2.Text = "";
            tadd3.Text = "";
            cadd1.Text = "";
            tpost2.Text = "";
            MIDE.Text = "";



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image picture1;
            openFileDialog1.Filter = "image(*.jpg,*.*.gif) | *.jpg;*.png;*.bmp";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            picture1 = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = picture1;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("บันทึกเรียบร้อย","บึนทึกข้อมูล",MessageBoxButtons.OK);
            mr.Checked = false;
            ms.Checked = false;
            mrs.Checked = false;
            mrsex.Checked = false;
            mssex.Checked = false;
            tname.Text = "";
            midcard.Text = "";
            mphone.Text = "";
            position.Text = "";
            salary.Text = "";
            tad1.Text = "";
            tad2.Text = "";
            tad3.Text = "";
            cad1.Text = "";
            tpost1.Text = "";
            tage.Text = "";
            checkBox1.Checked = false;
            tadd1.Text = "";
            tadd1.Text = "";
            tadd3.Text = "";
            cadd1.Text = "";
            tpost2.Text = "";
        }
    }
}
