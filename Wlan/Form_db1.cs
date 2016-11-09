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
    public partial class Form_db1 : Form
    {
        public Form_db1()
        {
            InitializeComponent();
        }
        //定义数据库连接字符串
        private String str_db = "Server=localhost;User ID=root;Password=123zzz;Database=cbb;CharSet=utf8;";

        //执行全部显示语句
        private void btn_select_all_Click(object sender, EventArgs e)
        {
            string strcmd = "select * from anime";
            cmd_select(strcmd);
        }

        //执行自定义语句
        private void btn_cmd_Click(object sender, EventArgs e)
        {
            string strcmd = this.txt_cmd.Text.Trim().ToString();
            if (strcmd != null && strcmd != "")
            {
                cmd_select(strcmd);
            }
        }

        //SQL文查询语句执行 
        private void cmd_select(String text)
        {
            MySqlConnection con = new MySqlConnection(str_db);
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(text, con);
                MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                if (ada != null)
                {
                    ada.Fill(ds);
                }
                if (ds.Tables[0] != null && ds.Tables[0].Columns.Count >= 1)
                {
                    Dgv_db1.DataSource = ds.Tables[0];
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                con.Close();
            }

        }
        //打开文件路径
        private void btn_open_Click(object sender, EventArgs e)
        {
            //行的索引
            int row = Dgv_db1.CurrentCell.RowIndex;
            String addressString = Dgv_db1.CurrentRow.Cells[4].Value.ToString();
            Console.WriteLine(addressString);
            System.Diagnostics.Process.Start("explorer.exe", addressString);
        }
        //单元格选中时内容显示
        private void Dgv_db1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Dgv_db1.CurrentCell.RowIndex;
            //没有用因为textbox要对应
            /**
                int columncount = Dgv_db1.ColumnCount;
            **/
            txt_name.Text = Dgv_db1.CurrentRow.Cells[1].Value.ToString();
            txt_cnname.Text = Dgv_db1.CurrentRow.Cells[2].Value.ToString();
            txt_staff.Text = Dgv_db1.CurrentRow.Cells[3].Value.ToString();
            txt_LocalLink.Text = Dgv_db1.CurrentRow.Cells[4].Value.ToString();
            txt_D_link.Text = Dgv_db1.CurrentRow.Cells[5].Value.ToString();
            txt_author.Text = Dgv_db1.CurrentRow.Cells[6].Value.ToString();
        }

        //修改信息
        private void btn_edit_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(Dgv_db1.CurrentRow.Cells[0].Value.ToString());
            String string_name = txt_name.Text.Trim();
            String string_cnname = txt_cnname.Text.Trim();
            String string_staff = txt_staff.Text.Trim();
            String string_LocalLink = txt_LocalLink.Text.Trim();
            String string_Dlink = txt_D_link.Text.Trim();
            String string_author = txt_author.Text.Trim();
            String sql = String.Format("update anime set Name='{0}' , Name_CN='{1}',Staff='{2}',LocalLink='{3}',Dlink='{4}',Author='{5}' where num=",
                string_name, string_cnname, string_staff, string_LocalLink.Replace("\\", "\\\\"), string_Dlink, string_author);
            sql = sql + index;
            Console.WriteLine(sql);
            cmd_select(sql);
        }

        //呼叫存储过程
        private void btn_add_Click(object sender, EventArgs e)
        {
            string name = txt_in_name.Text.Trim();
            string cnname = txt_in_cnname.Text.Trim();
            string staff = txt_in_staff.Text.Trim();
            string locallink = txt_in_locallink.Text.Trim();
            string dlink = txt_in_Dlink.Text.Trim();
            string author = txt_in_author.Text.Trim();
            String str_sql = String.Format("CALL `proc_anime`('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');", name, cnname,
                staff, locallink.Replace("\\", "\\\\"), dlink, author);
            Console.WriteLine(str_sql);
            cmd_select(str_sql);
        }

        //打开自动录入窗口
        private void btn_auto_input_Click(object sender, EventArgs e)
        {
            DataAutoInput db录入窗口 = new DataAutoInput();
            db录入窗口.Show();
        }
    }
}
