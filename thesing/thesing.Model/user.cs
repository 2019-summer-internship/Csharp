﻿using System;
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
        public string id;

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string name;

        /// <summary>
        /// 用户性别
        /// </summary>
        public string gender;

        /// <summary>
        /// 密码
        /// </summary>
        private string password;

        /// <summary>
        /// 头像
        /// </summary>
        public string avatar;

        /// <summary>
        /// 学生【STUDENT】导师【TEACHER】学院【SCHOOL】校方【UNIVERSITY】
        /// </summary>
        public int type;

        /// <summary>
        /// 用户角色id
        /// </summary>
        private string act;

        /// <summary>
        /// 电话
        /// </summary>
        public string phone;

        /// <summary>
        /// 邮箱号
        /// </summary>
        public string email;

    }
}