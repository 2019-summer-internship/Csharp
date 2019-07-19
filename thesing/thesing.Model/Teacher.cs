using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    public class Teacher
    {/// <summary>
     /// 教师工号
     /// </summary>
        public String teacherID;
        /// <summary>
        /// 学院名称
        /// </summary>
        public String school;
        /// <summary>
        /// 教师职称
        /// </summary>
        public String title;
        /// <summary>
        /// 教师简介
        /// </summary>
        public String introduction;
        /// <summary>
        /// 我的学生--id的集合
        /// </summary>
        public String students;
        /// <summary>
        ///  我的题目--id的集合
        /// </summary>
        public String projects;
        /// <summary>
        /// 我的通知--id的集合
        /// </summary>
        public String mail;
    }
}
