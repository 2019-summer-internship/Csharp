using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 日程模型
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 所属学院
        /// </summary>
        public string school { get; set; }

        /// <summary>
        /// 阶段：--0：出题 MAKE，1：选题 CHOOSE，2：开题 BEGIN，3：中期 MIDDLE，4：结题 FINISH
        /// </summary>
        public string stage { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string start { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string end { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string content { get; set; }

        public Schedule() { }
    }
}
