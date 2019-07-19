using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 成绩组成项模型
    /// </summary>
    class Consititution
    {
        /// <summary>
        /// 成绩组成项名称
        /// </summary>
        public string name;

        /// <summary>
        /// 组成项占比
        /// </summary>
        public float rate;

        /// <summary>
        /// 得分
        /// </summary>
        public float score;

        /// <summary>
        /// 评阅人
        /// </summary>
        public string teacher;

        /// <summary>
        /// 评阅时间
        /// </summary>
        public string time;
    }
}
