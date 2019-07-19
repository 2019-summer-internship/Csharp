using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 题目模型
    /// </summary>
    public class Project
    {
        /// <summary>
        /// 题目编号
        /// </summary>
        public string number;

        /// <summary>
        /// 发布时间
        /// </summary>
        public string time;

        /// <summary>
        /// 发布教师
        /// </summary>
        public string teacher;

        /// <summary>
        /// 选题学生
        /// </summary>
        public string studentr;

        /// <summary>
        /// 审核人
        /// </summary>
        public string manger;

        /// <summary>
        /// 题目状态 --0：待审核，1：已通过，2：已被选，-1：已撤销
        /// </summary>
        public string statu;

        /// <summary>
        /// 题目方向
        /// </summary>
        public string type;

        /// <summary>
        /// 题目来源--0：教师命题，1：学生自主命题
        /// </summary>
        public string from;

        /// <summary>
        /// 工作量
        /// </summary>
        public string amount;

        /// <summary>
        /// 难度
        /// </summary>
        public string difficult;

        /// <summary>
        /// 摘要
        /// </summary>
        public string abstracts;

        /// <summary>
        /// 题目背景
        /// </summary>
        public string background;

        /// <summary>
        /// 要求
        /// </summary>
        public string requirement;

        /// <summary>
        /// 附件
        /// </summary>
        public List<string> enclosure;

        /// <summary>
        /// 进度
        /// </summary>
        public List<Task> process;

    }
}
