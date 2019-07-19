using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Student
    {/// <summary>
     /// 学号
     /// </summary>
        public String studentID;
        /// <summary>
        /// 成绩的对象
        /// </summary>
        public Achievement  achievement;
        /// <summary>
        /// 班级的集合
        /// </summary>
        public String Class;
        /// <summary>
        /// 专业的集合
        /// </summary>
        public String major;
        /// <summary>
        /// 学院
        /// </summary>
        public String  school;
        /// <summary>
        /// 我的题目
        /// </summary>
        public Project project;
        /// <summary>
        /// 我的老师
        /// </summary>
        public Teacher teacher;
        /// <summary>
        /// 我的进度
        /// </summary>
        public List<Task> process;
        /// <summary>
        /// 通知的集合
        /// </summary>
        public List<Mail> mail;
    }
}
