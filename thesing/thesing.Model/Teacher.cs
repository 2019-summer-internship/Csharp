using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 教师模型
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// 教师工号
        /// </summary>
        public string teacherID { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string school { get; set; }

        /// <summary>
        /// 教师职称
        /// </summary>
        public List<String> title { get; set; }

        /// <summary>
        /// 教师简介
        /// </summary>
        public string introduction { get; set; }

        /// <summary>
        /// 我的学生--id的集合
        /// </summary>
        public List<Student> students { get; set; }

        /// <summary>
        ///  我的题目--id的集合
        /// </summary>
        public List<Project> projects { get; set; }

        /// <summary>
        /// 我的通知--id的集合
        /// </summary>
        public List<Mail> mail { get; set; }

        public Teacher() { }
    }
}
