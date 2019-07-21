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
        public string number { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// 发布教师
        /// </summary>
        public string teacher { get; set; }

        /// <summary>
        /// 选题学生
        /// </summary>
        public string studentr { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public string manger { get; set; }

        /// <summary>
        /// 题目状态 --0：待审核，1：已通过，2：已被选，-1：已撤销
        /// </summary>
        public string statu { get; set; }

        /// <summary>
        /// 题目方向
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 题目来源--0：教师命题，1：学生自主命题
        /// </summary>
        public string from { get; set; }

        /// <summary>
        /// 工作量
        /// </summary>
        public string amount { get; set; }

        /// <summary>
        /// 难度
        /// </summary>
        public string difficult { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        public string abstracts { get; set; }

        /// <summary>
        /// 题目背景
        /// </summary>
        public string background { get; set; }

        /// <summary>
        /// 要求
        /// </summary>
        public string requirement { get; set; }

        /// <summary>
        /// 附件
        /// </summary>
        public List<string> enclosure { get; set; }

        /// <summary>
        /// 进度
        /// </summary>
        private Task process { get; set; }

        internal Task Process { get => process; set => process = value; }

        public Project() { }
    }
}
