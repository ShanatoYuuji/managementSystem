using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void btn_on_Click(object sender, EventArgs e)
        {

        }


        //执行SQL查询
        private void SQL查询(string SQL语句)
        {
            MySqlConnection 连接 = new MySqlConnection(数据库连接字符串);
            连接.Open();
            MySqlCommand MySQL命令 = new MySqlCommand(SQL语句,连接);
            MySqlDataAdapter MySQL数据接口 = new MySqlDataAdapter(MySQL命令);
            //用来显示结果
            DataSet 结果集 = null;
            MySQL数据接口.Fill(结果集);



        }
    }
}
