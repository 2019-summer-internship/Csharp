using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 学生模型
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学生id
        /// </summary>
        public string studentID { get; set; }

        /// <summary>
        /// 成绩列表
        /// </summary>
        public List<Achievement> achievement { get; set; }

        /// <summary>
        /// 班级
        /// </summary>
        public string clas { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public string major { get; set; }

        /// <summary>
        /// 学院
        /// </summary>
        public string school { get; set; }

        /// <summary>
        /// <summary>
        /// 我的题目
        /// </summary>
        public Project project { get; set; }

        /// <summary>
        /// 我的老师
        /// </summary>
        public string teacher { get; set; }

        /// <summary>
        /// 我的进度
        /// </summary>
        public List<Task> process { get; set; }

        /// <summary>
        /// 通知的集合
        /// </summary>
        public List<Mail> mail { get; set; }

        public Student() { }

    }
}
