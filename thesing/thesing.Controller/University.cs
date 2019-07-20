using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Controller
{
    /// <summary>
    /// 校方类，继承自用户类
    /// </summary>
    public class University : User
    {
        /// <summary>
        /// 校方信息
        /// </summary>
        public new thesing.Model.University info;

        public University()
        {
            info = new Model.University();
        }

        /// <summary>
        /// 搜索学院
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<thesing.Model.School> SearchSchool(string key, string type)
        {
            List<thesing.Model.School> result = new List<thesing.Model.School>();
            return result;
        }

    }
}

