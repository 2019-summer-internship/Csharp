using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 学院模型
    /// </summary>
    public class School
    {
        /// <summary>
        /// 学院编号
        /// </summary>
        private string number { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 日程安排的集合
        /// </summary>
        public List<Schedule> schedule { get; set; }

        /// <summary>
        /// 教师的集合
        /// </summary>
        public List<Teacher> theachers { get; set; }

        /// <summary>
        /// 复议的集合
        /// </summary>
        public List<Reconsider> reconsider { get; set; }

        /// <summary>
        /// 题目审核
        /// </summary>
        public List<Project> uncheckProject { get; set; }

        /// <summary>
        /// 通知的集合
        /// </summary>
        public List<Mail> mail { get; set; }

        public School() { }
    }
}
