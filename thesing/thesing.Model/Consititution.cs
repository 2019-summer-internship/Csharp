using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 成绩组成项模型
    /// </summary>
    public class Consititution
    {
        /// <summary>
        /// 成绩组成项名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 组成项占比
        /// </summary>
        public float rate { get; set; }

        /// <summary>
        /// 得分
        /// </summary>
        public float score { get; set; }

        /// <summary>
        /// 评阅人
        /// </summary>
        public string teacher { get; set; }

        /// <summary>
        /// 评阅时间
        /// </summary>
        public string time { get; set; }

        public Consititution() { }
    }
}
