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


        //执行全部显示语句
        private void btn_select_all_Click(object sender, EventArgs e)
        {
            DB_access access = new DB_access();
            DataSet ds = access.db_search();
            try
            {
                if (ds.Tables[0] != null && ds.Tables[0].Columns.Count > 1)
                {
                    Dgv_db1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //执行自定义语句
        private void btn_cmd_Click(object sender, EventArgs e)
        {
            String text = this.txt_cmd.Text.Trim();
            DB_access access = new DB_access();
            try
            {
                access.db_go(text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
            Anime anime = new Anime(index, string_name, string_cnname, string_staff, string_LocalLink, string_Dlink, string_author);
            DB_access access = new DB_access();
            int result = access.db_update(anime);
            if (result > 0)
            {
                MessageBox.Show("修改成功");
            }
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

            DB_access acceess = new DB_access();
            int result = acceess.db_insert(anime);
            if (result > 0)
            {
                MessageBox.Show("插入成功");
            }

        }

        //打开自动录入窗口
        private void btn_auto_input_Click(object sender, EventArgs e)
        {
            DataAutoInput db录入窗口 = new DataAutoInput();
            db录入窗口.Show();
        }
    }
}
