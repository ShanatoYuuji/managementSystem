using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlan
{
    public partial class DataAutoInput : Form
    {
        public DataAutoInput()
        {
            InitializeComponent();
        }

        private String 数据库连接字符串 = "Server=localhost;User ID=root;password=123zzz;Database=cbb;CharSet=utf8";
        //执行录入
        private void btn_on_Click(object sender, EventArgs e)
        {
            /**
             *
            string sql语句 = "insert into anime values()";
            SQL查询(sql语句);
            **/
            pwdconfirm m = null;
            m += pwdconfirm_1;
            Form_pwd_confirm pwd = new Form_pwd_confirm(m);
            pwd.Show();
         
        }
        //执行将主键重新排列
        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            pwdconfirm m = null;
            m += pwdconfirm_2;
            Form_pwd_confirm pwd = new Form_pwd_confirm(m);
            pwd.Show();
        }

        /// <summary>
        /// 定义委托
        /// </summary>
        /// <param name="m"></param>
        public delegate void pwdconfirm(int m);

        //委托实现方法一
        private void pwdconfirm_1(int m)
        {
            if (m == 123)
            {
                读取目录下面文件夹(txt_address.Text.Trim());
                Console.WriteLine(txt_address.Text.Trim());
            }
        }

        //委托实现方法二 
        private void pwdconfirm_2(int m)
        {
            if (m == 12345)
            {
                String SQL语句 = "ALTER TABLE `anime` DROP COLUMN `Num`;ALTER TABLE `anime`ADD COLUMN `Num` INT(11) NOT NULL AUTO_INCREMENT FIRST,ADD PRIMARY KEY (`Num`); ";
                SQL查询(SQL语句);
            }
        }
  

        private void 读取目录下面文件夹(String 目录)
        {
            DirectoryInfo 系统目录 = new DirectoryInfo(@目录);
            foreach (DirectoryInfo i in 系统目录.GetDirectories())
            {
                Console.WriteLine(系统目录.GetDirectories().Count());
                String SQL语句 = String.Format("call proc_anime('','{0}','','{1}','','');", i.Name.Trim(),i.FullName.Trim().Replace("\\","\\\\"));
                SQL查询(SQL语句);
            }
        }


        //执行SQL查询
        private void SQL查询(string SQL语句)
        {
            MySqlConnection 连接 = new MySqlConnection(数据库连接字符串);
            连接.Open();
            MySqlCommand MySQL命令 = new MySqlCommand(SQL语句,连接);
            try
            {
                if (MySQL命令.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("执行成功！");
                }
                else
                {
                    MessageBox.Show("执行失败！");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }                                                                   
          
            /**
            MySqlDataAdapter MySQL数据接口 = new MySqlDataAdapter(MySQL命令);
            //用来显示结果
            DataSet 结果集 = new DataSet();
            MySQL数据接口.Fill(结果集);
            **/

        }
    
    }
}
