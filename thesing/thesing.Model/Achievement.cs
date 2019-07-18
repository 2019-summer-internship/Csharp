using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    class Achievement
    {/// <summary>
     /// 编号
     /// </summary>
        public String number;
        /// <summary>
        /// 学生的集合
        /// </summary>
        public String student;
        /// <summary>
        /// 总成绩
        /// </summary>
        public String score;
        /// <summary>
        /// 所属阶段-- 0：开题 BEGIN，1：中期 MIDDLE，2 ：结题FINISH
        /// </summary>
        public int stage;
        /// <summary>
        /// 组成列表：名称，占比，得分，评阅人，评阅时间
        /// </summary>
        public String constitution;

    }
}
