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
        public string teacherID;

        /// <summary>
        /// 学院名称
        /// </summary>
        public string school;

        /// <summary>
        /// 教师职称
        /// </summary>
        public List<String> title;

        /// <summary>
        /// 教师简介
        /// </summary>
        public string introduction;

        /// <summary>
        /// 我的学生--id的集合
        /// </summary>
        public List<Student> students;

        /// <summary>
        ///  我的题目--id的集合
        /// </summary>
        public List<Project> projects;

        /// <summary>
        /// 我的通知--id的集合
        /// </summary>
        public List<Mail> mail;
    }
}
