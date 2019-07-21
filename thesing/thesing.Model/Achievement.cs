using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 成绩模型
    /// </summary>
    public class Achievement
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 所属学生
        /// </summary>
        public string student { get; set; }

        /// <summary>
        /// 总成绩
        /// </summary>
        public float score { get; set; }

        /// <summary>
        /// 所属阶段-- 0：开题 BEGIN，1：中期 MIDDLE，2 ：结题FINISH
        /// </summary>
        public string stage { get; set; }

        /// <summary>
        /// 组成列表：名称，占比，得分，评阅人，评阅时间
        /// </summary>
        public List<Consititution> constitution { get; set; }

        public Achievement() { }

    }
}
