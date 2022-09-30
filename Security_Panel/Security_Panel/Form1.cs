using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string status = "";
        string group = "";
        string path = @"C:\Users\Naomi On\Downloads\Năm 3 HK1\AI\Security_Panel\Login_Log.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button2.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button3.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button4.Text;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button5.Text;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button6.Text;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button7.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button8.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button9.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += button0.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showLog();
        }

        private void lbxAccessLog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showLog();
            }
            else if (e.KeyCode == Keys.D0)
            {
                txtSecurityCode.Text += "0";
            }
            else if (e.KeyCode == Keys.D1)
            {
                txtSecurityCode.Text += "1";
            }
            else if (e.KeyCode == Keys.D2)
            {
                txtSecurityCode.Text += "2";
            }
            else if (e.KeyCode == Keys.D3)
            {
                txtSecurityCode.Text += "3";
            }
            else if (e.KeyCode == Keys.D4)
            {
                txtSecurityCode.Text += "4";
            }
            else if (e.KeyCode == Keys.D5)
            {
                txtSecurityCode.Text += "5";
            }
            else if (e.KeyCode == Keys.D6)
            {
                txtSecurityCode.Text += "6";
            }
            else if (e.KeyCode == Keys.D7)
            {
                txtSecurityCode.Text += "7";
            }
            else if (e.KeyCode == Keys.D8)
            {
                txtSecurityCode.Text += "8";
            }
            else if (e.KeyCode == Keys.D9)
            {
                txtSecurityCode.Text += "9";
            }
            else if (e.KeyCode == Keys.Back)
            {
                txtSecurityCode.Clear();
            }
        }
        private void showLog()
        {
            int code = Convert.ToInt32(txtSecurityCode.Text);
            switch (code)
            {
                case 1645:
                    status = "granted";
                    group = "Technicians";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);
                    break;
                case 1689:
                    status = "granted";
                    group = "Technicians";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);

                    break;
                case 8345:
                    status = "granted";
                    group = "Custodians";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);

                    break;
                case 9998:
                    status = "granted";
                    group = "Scientist";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);

                    break;
                case 1006:
                    status = "granted";
                    group = "Scientist";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);

                    break;
                case 1008:
                    status = "granted";
                    group = "Scientist";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " " + group);
                    break;
                default:
                    status = "denied";
                    lbxAccessLog.Items.Add(" " + DateTime.Now.ToString() + " Restricted Access!");
                    break;
            }
            WriteToFile();
        }
        private void WriteToFile()
        {
            if (status == "granted")
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(" " + DateTime.Now.ToString() + " " + group);
                }
            }
            else if (status == "denied")
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(" " + DateTime.Now.ToString() + " Restricted Access! ");
                }
            }
        }
    }
}
