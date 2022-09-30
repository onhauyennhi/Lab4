using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txbUsername.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống tên tài khoản!");
            }else if (txbPassword.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống mật khẩu!");
            }
            else if (txbPassword.Text.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 kí tự!");
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (cbRemember.Checked)
                {
                    Properties.Settings.Default.Username = txbUsername.Text;
                    Properties.Settings.Default.Password = txbPassword.Text;
                    Properties.Settings.Default.Remember = true;
                    Properties.Settings.Default.Save();
                }
                else if (!cbRemember.Checked)
                {
                    Properties.Settings.Default.Username = "";
                    Properties.Settings.Default.Password = "";
                    Properties.Settings.Default.Remember = false;

                    Properties.Settings.Default.Save();
                }
            }
        }
        private void loadData()
        {
            if (Properties.Settings.Default.Username !=null)
            {
                txbUsername.Text = Properties.Settings.Default.Username;
            }
            if (Properties.Settings.Default.Password != null)
            {
                txbPassword.Text = Properties.Settings.Default.Password;
            }
            if (Properties.Settings.Default.Remember==true)
            {
                cbRemember.Checked = true;
            }
        }
        private void txbUsername_TextChanged(object sender, EventArgs e) 
        {

        }

        private void rdbRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
            txbPassword.Clear();
            cbRemember.Checked = false;
        }
    }
}
