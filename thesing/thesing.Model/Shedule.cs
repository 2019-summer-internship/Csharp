using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    public class Schedule
    {/// <summary>
     /// 编号
     /// </summary>
        public String number;
        /// <summary>
        /// 所属学院
        /// </summary>
        public String school;
        /// <summary>
        /// 阶段：--0：出题 MAKE，1：选题 CHOOSE，2：开题 BEGIN，3：中期 MIDDLE，4：结题 FINISH
        /// </summary>
        public int stage;
        /// <summary>
        /// 开始时间
        /// </summary>
        public String start;
        /// <summary>
        /// 结束时间
        /// </summary>
        public String end;
        /// <summary>
        /// 说明
        /// </summary>
        public String content;
    }
}
