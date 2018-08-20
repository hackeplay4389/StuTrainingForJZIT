using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StuTraining
{
    public partial class Login : Form
    {
        public static  string Login_Name { get; set; }
        public static  string Login_ID { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txt_name.Text) || string.IsNullOrEmpty(this.txt_id.Text))
            {
                MessageBox.Show("请输入测试者信息！");
                return;
            }
            Login_Name = this.txt_name.Text;
            Login_ID = this.txt_id.Text;
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
