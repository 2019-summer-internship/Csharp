﻿using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
<<<<<<< HEAD
    class Student
    {/// <summary>
     /// 学号
     /// </summary>
        public String studentID;
=======
    /// <summary>
    /// 学生模型
    /// </summary>
    class Student
    {
>>>>>>> 29b30b308d27e05266cc250f76ae5fa26fc364df
        /// <summary>
        /// 学生id
        /// </summary>
        public string studentID;

        /// <summary>
        /// 成绩列表
        /// </summary>
        public List<Achievement> achievement;

        /// <summary>
        /// 班级
        /// </summary>
        public string clas;

        /// <summary>
        /// 专业
        /// </summary>
        public string major;

        /// <summary>
        /// 学院
        /// </summary>
        public string school;

        /// <summary>
        /// 我的题目
        /// </summary>
        public Project project;

        /// <summary>
        /// 我的老师
        /// </summary>
        public string teacher;

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
