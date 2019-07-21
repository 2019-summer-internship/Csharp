using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        public string gender { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string _password { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// 学生【STUDENT】导师【TEACHER】学院【SCHOOL】校方【UNIVERSITY】
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 邮箱号
        /// </summary>
        public string email { get; set; }

        public User()
        {
            id = "";
            name = "";
            gender = "";
            _password = "";
            avatar = "";
            type = "";
            phone = "";
            email = "";
        }

    }
}
