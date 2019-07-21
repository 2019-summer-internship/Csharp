using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace thesing.Service
{
    public class Sign
    {
        //定义数据库驱动
        private SqlDbHelper database;

        public Sign()
        {
            database = new SqlDbHelper();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int SignIn(int id, string password, Model.User user)
        {
            string[] userType = { "user", "student", "teacher", "school", "university" };

            //查询SQL语句
            string sql = "SELECT * FROM users WHERE id=@id";

            //查询参数
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@id", MySqlDbType.Int32),
                new MySqlParameter("@pwd", MySqlDbType.VarChar)
            };

            parameter[0].Value = id;
            parameter[1].Value = password;

            //检查用户是否存在
            DataTable table = database.ExecuteDataTable(sql, parameter);
            if (table.Rows.Count != 1)
            {
                return -1; //用户不存在
            }

            sql = "SELECT * FROM users WHERE id=@id AND pwd=@pwd";
            //检查用户密码是否正确
            table = database.ExecuteDataTable(sql, parameter);

            if (table.Rows.Count == 1)
            {
                user.id = table.Rows[0]["id"].ToString();
                user.name = table.Rows[0]["name"].ToString();
                //user.gender = table.Rows[0]["gender"].ToString();
                user._password = table.Rows[0]["pwd"].ToString();
                user.avatar = table.Rows[0]["avatar"].ToString();
                user.type = userType[Int32.Parse(table.Rows[0]["type"].ToString())];
                user.phone = table.Rows[0]["phone"].ToString();
                user.email = table.Rows[0]["email"].ToString();

                return 0; //查询成功
            }
            else
            {
                return -2; //密码错误
            }
        }
    }
}
