using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Service
{
    class Sign
    {
        private SqlDbHelper database = new SqlDbHelper();

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
            string sql = "SELECT * FROM users WHERE id=@id AND pwd=@password AND flag=0";

            //查询参数
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@id", MySqlDbType.Int32),
                new MySqlParameter("@pwd", MySqlDbType.VarChar)
            };

            parameter[0] = id;
            parameter[1] = password;

            //执行查询
            DataTable table = database.ExecuteDataTable(sql, parameter);

            if(table != null)
            {
                if(table.Rows.Count > 1)
                {
                    return 2; //用户不唯一
                }
                user.id = database.Rows[0]["id"].ToString();
                user.name = database.Rows[0]["name"].ToString();
                user.gender = database.Rows[0]["gender"].ToString();
                user.password.set(database.Rows[0]["pwd"].ToString());
                user.avatar = database.Rows[0]["avatar"].ToString();
                user.type = userType[Int32.Parse(database.Rows[0]["type"])];
                user.act.set(database.Rows[0]["info"].ToString());
                user.phone = database.Rows[0]["phone"].ToString();
                user.email = database.Rows[0]["email"].ToString();

                return 0; //查询成功
            }
            else
            {
                return -1; //用户不存在
            }
        }
    }
}
