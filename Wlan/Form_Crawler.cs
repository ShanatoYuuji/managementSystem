using MySql.Data.MySqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wlan
{

    public partial class Form_Crawler : Form
    {
        int count = 0;
        public Form_Crawler()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            int pageCount = 2;
            string keyword = "lat";
            for (int i = 0; i < pageCount; i++)
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(
                    "http://image.baidu.com/search/index?tn=baiduimage&ipn=r&ct=201326592&cl=2&lm=-1&st=-1&fm=result&fr=&sf=1&fmq=1466307565574_R&pv=&ic=0&nc=1&z=&se=1&showtab=0&fb=0&width=&height=&face=0&istype=2&ie=utf-8&word=" + keyword.ToString());
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String string_hon = textBox1.Text;
            string[] string_ten = string_hon.Split(new String[] { "\r\n" }, StringSplitOptions.None);
            //Console.WriteLine(string_ten.Length); 
            foreach (String line in string_ten)
            {
                string[] stringeache = line.Split(new String[] { " " }, StringSplitOptions.None);
                //Console.WriteLine(stringeache.Length);
                int i = 0;
                foreach (String each in stringeache)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("\"");
                        Console.Write(each.Trim());
                        Console.Write("\":\"");
                    }
                    else
                    {
                        Console.Write(each.Trim());
                        Console.Write("\",");
                        Console.WriteLine();
                    }
                    i++;
                }
            }

        }
        /// <summary>
        /// 数据导入postgresql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_data_Click(object sender, EventArgs e)
        {
            //NpgsqlConnection npc = offerPostgresqlConnection();

            NpgsqlCommand commond = new NpgsqlCommand();
            commond.Connection = offerPostgresqlConnection();

            commond.Connection.Open();

            int i = 1000;
            int max = 0;
            while (i > 999)
            {


                //commond.Transaction = npgTransaction;

                DataSet dtt = db_cmd("SELECT  id, title, date, link, author,  details FROM jiying   WHERE id>" + max + " ORDER BY `id` ASC LIMIT 1000");
                //开启事务

                NpgsqlTransaction npgTransaction = commond.Connection.BeginTransaction();

                foreach (DataRow current in dtt.Tables[0].Rows)
                {
                    try
                    {
                        commond.CommandText = "insert into jiying(id, title, date, link, author,  details) values(@id, @title, @date, @link, @author, @details) ";

                        NpgsqlParameter[] parameters =
                       {
                            new NpgsqlParameter("@id", DbType.Int32),
                            new NpgsqlParameter("@title",  DbType.String),
                            new NpgsqlParameter("@date",  DbType.String),
                            new NpgsqlParameter("@link",  DbType.String),
                            new NpgsqlParameter("@author",  DbType.String),
                            new NpgsqlParameter("@details",  DbType.String),
                        };

                        parameters[0].Value = current["id"].ToString();
                        parameters[1].Value = current["title"].ToString();
                        parameters[2].Value = current["date"].ToString();
                        parameters[3].Value = current["link"].ToString();
                        parameters[4].Value = current["author"].ToString();
                        parameters[5].Value = current["details"].ToString();
                        max = Int32.Parse(current["id"].ToString());
                        commond.Parameters.Clear();
                        commond.Parameters.AddRange(parameters);
                        commond.ExecuteNonQuery();
                        i = dtt.Tables[0].Rows.Count;
                        Console.WriteLine(i);
                    }
                    catch (Exception ee)
                    {
                        //npgTransaction.Rollback();
                        Console.WriteLine(ee.Message);
                    }
                }

                npgTransaction.Commit();
                continue;
            }
            commond.Connection.Close();

        }

        /// <summary>
        /// 获取postgresql连接
        /// </summary>
        /// <returns></returns>
        private NpgsqlConnection offerPostgresqlConnection()
        {
            String str_db = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=123zzz;Database=postgres";
            return new NpgsqlConnection(str_db);
        }

        /// <summary>
        /// 执行自定义查询语句
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private DataSet db_cmd(String text)
        {
            MySqlCommand com = new MySqlCommand();
            com.CommandText = text.Trim();
            com.Connection = offerMySqlConnection();
            MySqlDataAdapter adt = new MySqlDataAdapter(com.CommandText, com.Connection);
            DataSet ds = new DataSet();
            if (adt != null)
            {
                adt.Fill(ds);
            }
            return ds;
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
        /// <summary>
        ///将读取的文件写入数据库 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excel_read_Click(object sender, EventArgs e)
        {

            NpgsqlCommand commond = new NpgsqlCommand();
            commond.Connection = offerPostgresqlConnection();
            commond.Connection.Open();
            DataSet dtt = ExcelToDS("E:\\jy.xls");
            int id = 380000;
            foreach (DataRow current in dtt.Tables[0].Rows)
            {
                try
                {
                    commond.CommandText = "insert into jiying(id, title, date, link, author,  details) values(@id, @title, @date, @link, @author, @details) ";

                    NpgsqlParameter[] parameters =
                   {
                            new NpgsqlParameter("@id", DbType.Int32),
                            new NpgsqlParameter("@title",  DbType.String),
                            new NpgsqlParameter("@date",  DbType.String),
                            new NpgsqlParameter("@link",  DbType.String),
                            new NpgsqlParameter("@author",  DbType.String),
                            new NpgsqlParameter("@details",  DbType.String),
                        };

                    parameters[0].Value = id;
                    parameters[1].Value = current[0].ToString();
                    parameters[2].Value = new DateTime().ToShortTimeString();
                    parameters[3].Value = current[1].ToString();
                    parameters[4].Value = "null";
                    parameters[5].Value = current[2].ToString();

                    commond.Parameters.Clear();
                    commond.Parameters.AddRange(parameters);
                    commond.ExecuteNonQuery();
                    id++;
                    int i = dtt.Tables[0].Rows.Count;
                    Console.WriteLine(i);
                }
                catch (Exception ee)
                {
                    //npgTransaction.Rollback();
                    Console.WriteLine(ee.Message);
                }
            }

        }

        /// <summary>
        /// 读取excel文件
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public DataSet ExcelToDS(string Path)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Path + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            
            string strExcel = "";
            OleDbDataAdapter myCommand = null;
            DataSet ds = null;
            strExcel = "select * from [sheet1$]";
            myCommand = new OleDbDataAdapter(strExcel, strConn);
            ds = new DataSet();
            myCommand.Fill(ds, "table1");
            
            return ds;
        }
    }
}
