using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 校方模型
    /// </summary>
    public class University
    {
        /// <summary>
        /// 学校编号
        /// </summary>
        public string number;

        /// <summary>
        /// 学校名字
        /// </summary>
        public string name;

        /// <summary>
        /// 学院的集合
        /// </summary>
        public List<School> schools;

        /// <summary>
        /// 通知的集合
        /// </summary>
        public List<Mail> mail;

    }
}
