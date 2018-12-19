using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dns_check_program_bank_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NH_Click(object sender, EventArgs e)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry("banking.nonghyup.com");

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                string nh_dns = ip.ToString(); // 농협 현재 dns
                string nh_check = "61.37.254.31"; // 농협 원래 dns
                if (nh_dns == nh_check)
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되지 않았습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : "+ nh_dns.ToString() + "\r\n기본 DNS : " + nh_check, "DNS 변조 체크");
                    if (MessageBox.Show("NH농협 사이트로 이동하시겠습니까?", "DNS 변조 체크", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start("https://banking.nonghyup.com/");
                    }
                }
                else
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되었습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + nh_dns.ToString() + "\r\n기본 DNS : " + nh_check, "DNS 변조 체크");
                }
            }
        }

        private void shinhan_Click(object sender, EventArgs e)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry("bank.shinhan.com");

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                string shinhan_dns = ip.ToString(); // 신한 현재 dns
                string shinhan_check = "59.7.252.240"; // 신한 원래 dns
                if (shinhan_dns == shinhan_check)
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되지 않았습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + shinhan_dns.ToString() + "\r\n기본 DNS : " + shinhan_check, "DNS 변조 체크");
                    if (MessageBox.Show("신한은행 사이트로 이동하시겠습니까?", "DNS 변조 체크", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start("https://bank.shinhan.com/");
                    }
                }
                else
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되었습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + shinhan_dns.ToString() + "\r\n기본 DNS : " + shinhan_check, "DNS 변조 체크");
                }
            }
        }

        private void kb_Click(object sender, EventArgs e)
        {
            IPHostEntry hostEntry = Dns.GetHostEntry("www.kbstar.com");

            foreach (IPAddress ip in hostEntry.AddressList)
            {
                //MessageBox.Show(ip.ToString());
                string kb_dns = ip.ToString(); // 국민 현재 dns
                string kb_check = "203.248.188.31"; // 국민 원래 dns
                string kb_check1 = "121.129.49.31"; 
                if (kb_dns == kb_check)
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되지 않았습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + kb_dns.ToString() + "\r\n기본 DNS : " + kb_check, "DNS 변조 체크");
                    if (MessageBox.Show("국민은행 사이트로 이동하시겠습니까?", "DNS 변조 체크", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start("https://www.kbstar.com/");
                    }
                }
                else if (kb_dns == kb_check1)
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되지 않았습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + kb_dns.ToString() + "\r\n기본 DNS : " + kb_check1, "DNS 변조 체크");
                    if (MessageBox.Show("국민은행 사이트로 이동하시겠습니까?", "DNS 변조 체크", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Process.Start("https://www.kbstar.com/");
                    }
                }
                else
                {
                    MessageBox.Show("해당 사이트 DNS가 변조 되었습니다.", "DNS 변조 체크");
                    MessageBox.Show("현재 DNS : " + kb_dns.ToString() + "\r\n기본 DNS : " + kb_check, "DNS 변조 체크");
                }
            }
        }
    }
}
