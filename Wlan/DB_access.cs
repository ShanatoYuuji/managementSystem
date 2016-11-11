using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlan
{
    class DB_access
    {
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
        /// 根据 提供的动漫返回SQL用的参数
        /// </summary>
        /// <param name="anime">动漫</param>
        /// <returns></returns>
        private MySqlParameter[] offerParameters(Anime anime)
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
        /// 无返回值的自定义查询语句
        /// </summary>
        /// <param name="text"></param>
        private void db_cmd_(String text)
        {
            MySqlCommand com = new MySqlCommand();
            com.CommandText = text.Trim();
            com.Connection = offerMySqlConnection();
            com.Connection.Open();
            com.ExecuteNonQuery();
            com.Connection.Close();
        }

        /// <summary>
        /// 更新表的一条记录
        /// </summary>
        /// <param name="anime"></param>
        /// <returns></returns>
        public int db_update(Anime anime)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = offerMySqlConnection();
            command.CommandText = "update anime set Name = @Name, Name_CN = @Name_CN, Staff = @Staff, LocalLink = @LocalLink, DLink = @DLink, Author = @Author where Num = @Num";
            MySqlParameter[] parameters = offerParameters(anime);
            command.Parameters.AddRange(parameters);

            command.Connection.Open();
            int i = command.ExecuteNonQuery();
            command.Connection.Close();
            return i;
        }

        /// <summary>
        /// 插入一条记录
        /// </summary>
        /// <param name="anime"></param>
        /// <returns></returns>
        public int db_insert(Anime anime)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = offerMySqlConnection();
            command.CommandText = String.Format("CALL `proc_anime`(@name, @Name_CN, @staff, @locallink,@dlink,@author) ");
            MySqlParameter[] mysqlParameters = offerParameters(anime);
            command.Parameters.AddRange(mysqlParameters);
            command.Connection.Open();
            Console.WriteLine(command.CommandText);
            int result=command.ExecuteNonQuery();

            //关闭数据连接
            command.Connection.Close();
            return result;
        }

        /// <summary>
        /// 查找返回数据
        /// </summary>
        /// <returns></returns>
         public DataSet db_search()
        {
            String text = "select * from anime";
            return db_cmd(text);
        }

        /// <summary>
        /// 自定义语句的执行有返回值
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public DataSet db_go(String text, bool flag)
        {
            DataSet ds = db_cmd(text);
            return ds;
        }

        /// <summary>
        /// 自定义语句执行无返回值
        /// </summary>
        /// <param name="text"></param>
        public void db_go(String text)
        {
            db_cmd_(text);
        }
    }
}
