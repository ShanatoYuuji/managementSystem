using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wlan;

namespace Wlan
{
    public partial class Form_in : Form
    {
        public Form_in()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            string name = this.txt_name.Text.Trim();
            string pwd = this.txt_pwd.Text.Trim();
            string cmd = "netsh wlan set hostednetwork mode=allow ssid=  " + name + " key=" + pwd;
            this.执行cmd(cmd);
            Console.WriteLine(cmd);
            string open = "netsh wlan start hostednetwork";
            this.执行cmd(open);
            Console.WriteLine(open);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            string close = "netsh wlan stop hostednetwork";
            this.执行cmd(close);
        }



        private void change_Click(object sender, EventArgs e)
        {
            string url = "magnet:?xt=urn:btih:" + this.txt_url.Text.Trim();
            //this.txt_url.Text = url;
            this.lab_change.Text = url;
            System.Diagnostics.Process.Start("Thunder.exe",url);
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            
            DateTime now = new DateTime();
            now = DateTime.Now;
            TimeSpan 时间差 = dtp_close.Value.Subtract(now);
            int 时间秒 = (int)时间差.TotalSeconds;
            string command = "shutdown /s /t "+ 时间秒;
            Console.WriteLine(command);
        }

        private void 执行cmd(string cmd)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.RedirectStandardInput = true;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
            //  proc.StandardInput.WriteLine("taskmgr");
            proc.StandardInput.WriteLine(cmd);
            proc.Close();
        }

        private void btn_know_Click(object sender, EventArgs e)
        {
            string year = txt_know.Text.ToString();
            int result = 0;
           bool f = Int32.TryParse(year,out result);
            if (f)
            {
                MessageBox.Show("転換できない");
            }
            else
            {
                int year_int = Int32.Parse(year);
                if((year_int%4==0&& year_int%100!=0)|| year_int % 400 == 0)
                {
                    MessageBox.Show("そうです");
                }
                else
                {
                    MessageBox.Show("違います");
                }
            }
        }

        private void btn_db1_Click(object sender, EventArgs e)
        {
            Form_db1 数据库窗口 = new Form_db1();        
            数据库窗口.Show();

        }

        private void btn_QEcode_Click(object sender, EventArgs e)
        {
            Form_QEcode qecode = new Form_QEcode();
            qecode.Show();
        }
    }
}
