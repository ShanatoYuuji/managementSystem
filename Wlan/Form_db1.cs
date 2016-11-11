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
        
        
       /// <summary>
       /// 提供MySQL数据库的连接
       /// </summary>
       /// <returns></returns>
        private MySqlConnection offerMySqlConnection()
        {  //定义数据库连接字符串
            String str_db = "Server=localhost;User ID=root;Password=123zzz;Database=cbb;CharSet=utf8;";
            return new MySqlConnection(str_db);
        }

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

        
        //SQL文查询语句执行没有返回结果
        private void cmd_select(String text)
        {
            MySqlConnection con = offerMySqlConnection();
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

        /// <summary>
        /// 根据 提供的动漫返回SQL用的参数
        /// </summary>
        /// <param name="anime">动漫</param>
        /// <returns></returns>
        private MySqlParameter [] offerParameters(Anime anime)
        {
            MySqlParameter[] parameters =
             {
                new MySqlParameter("@Name",MySqlDbType.VarChar),
                new MySqlParameter("@Name_CN",MySqlDbType.VarChar),
                new MySqlParameter("@Staff",MySqlDbType.VarChar),
                new MySqlParameter("@LocalLink",MySqlDbType.VarChar),
                new MySqlParameter("@DLink",MySqlDbType.VarChar),
                new MySqlParameter("@Author",MySqlDbType.VarChar),
                new MySqlParameter("@Num",MySqlDbType.Int32)
            };

            parameters[0].Value = anime.Name1;
            parameters[1].Value = anime.Name_cn1;
            parameters[2].Value = anime.Staff1;
            parameters[3].Value = anime.LocalLink1;
            parameters[4].Value = anime.DLink1;
            parameters[5].Value = anime.Author1;
            parameters[6].Value = anime.Num1;
            return parameters;
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

            Anime anime = new Anime(index, string_name, string_cnname, string_staff, string_LocalLink, string_Dlink, string_author);
            
            MySqlCommand command = new MySqlCommand();
            command.Connection = offerMySqlConnection();
            command.CommandText = "update anime set Name = @Name, Name_CN = @Name_CN, Staff = @Staff, LocalLink = @LocalLink, DLink = @DLink, Author = @Author where Num = @Num";

            MySqlParameter[] parameters = offerParameters(anime);
            command.Parameters.AddRange(parameters);
            //command.Parameters.Add(parameters[0]);

            command.Connection.Open();
            Console.WriteLine(command.CommandText);
            command.ExecuteNonQuery();
          
            Console.WriteLine(command.CommandText);
            command.Connection.Close();
            //cmd_select("select * from anime");
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
            Anime anime = new Anime(name, cnname, staff, locallink, dlink, author);
            MySqlCommand command = new MySqlCommand();
            command.Connection = offerMySqlConnection();
            command.CommandText = String.Format("CALL `proc_anime`(@name, @cnname, @staff, @locallink,@dlink,@author) ");
            MySqlParameter[] mysqlParameters = offerParameters(anime);
            command.Parameters.AddRange(mysqlParameters);

            command.ExecuteNonQuery();
            Console.WriteLine(command.CommandText);
        }

        //打开自动录入窗口
        private void btn_auto_input_Click(object sender, EventArgs e)
        {
            DataAutoInput db录入窗口 = new DataAutoInput();
            db录入窗口.Show();
        }
    }
}
