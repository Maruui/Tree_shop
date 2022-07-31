using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการออกจากโปรแกรมหรือไม่", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("จบการทำงาน", "จบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
            }
            else
                MessageBox.Show("กลับเข้าสู่ระบบ", "กลับไปที่ระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "NUTTAPAT", password = "636051200302";
            if (tusername.Text == "")
            {
                MessageBox.Show("คุณยังไม่ได้ใส่รหัส กรุณาใส่ข้อมูล", "รหัสผู้ใช้งาน", MessageBoxButtons.OK);
                tusername.Focus();
            }
            if (tpassword.Text == "")
            {
                MessageBox.Show("คุณยังไม่ได้ใส่รหัสผ่าน กรุณราใส่ข้อมูล", "รหัสผ่าน", MessageBoxButtons.OK);
                tpassword.Focus();
            }
            if (name == tusername.Text && password == tpassword.Text)
            {
                
                Menu F = new Menu();
                F.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username หรือ Password ไม่ถูกต้องกรุณาใส่ใหม่อีกครั้ง", "User name", MessageBoxButtons.OK);
                tusername.Text = "";
                tpassword.Text = "";
                tusername.Focus();
            }
        }

        private void tusername_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
