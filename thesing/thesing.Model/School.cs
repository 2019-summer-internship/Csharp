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
        private string number;

        /// <summary>
        /// 学院名称
        /// </summary>
        public string name;

        /// <summary>
        /// 日程安排的集合
        /// </summary>
        public List<Schedule> schedule;

        /// <summary>
        /// 教师的集合
        /// </summary>
        public List<Teacher> theachers;

        /// <summary>
        /// 复议的集合
        /// </summary>
        public List<Reconsider> reconsider;

        /// <summary>
        /// 题目审核
        /// </summary>
        public List<Project> uncheckProject;

        /// <summary>
        /// 通知的集合
        /// </summary>
        public List<Mail> mail;
    }
}
