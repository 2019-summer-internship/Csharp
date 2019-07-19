using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    public class Project
    {/// <summary>
     /// 题目编号
     /// </summary>
        public String number;
        /// <summary>
        /// 发布时间
        /// </summary>
        public String time;
        /// <summary>
        /// 发布教师
        /// </summary>
        public String teacher;
        /// <summary>
        /// 选题学生
        /// </summary>
        public String studentr;
        /// <summary>
        /// 审核人
        /// </summary>
        public String manger;

        /// <summary>
        /// 题目状态 --0：待审核，1：已通过，2：已被选，-1：已撤销
        /// </summary>
        public int statu;
        /// <summary>
        /// 题目方向
        /// </summary>
        public String type;
        /// <summary>
        /// 题目来源--0：教师命题，1：学生自主命题
        /// </summary>
        public int from;
        /// <summary>
        /// 工作量
        /// </summary>
        public String amount;
        /// <summary>
        /// 难度
        /// </summary>
        public String difficult;
        /// <summary>
        /// 摘要
        /// </summary>
        public String abstracts;
        /// <summary>
        /// 题目背景
        /// </summary>
        public String background;
        /// <summary>
        /// 要求
        /// </summary>
        public String requirement;

        /// <summary>
        /// 附件
        /// </summary>
        public String enclosure;
        /// <summary>
        /// 进度
        /// </summary>
        public List<Task> process;

    }
}
