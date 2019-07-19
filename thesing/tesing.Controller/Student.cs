using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    /// <summary>
    /// 学生类，继承自用户类
    /// </summary>
    public class Student:User
    {
        /// <summary>
        /// 学生信息
        /// </summary>
        public thesing.Model.Student info;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Student() { }

        /// <summary>
        /// 选择题目
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean ChooseProject(string project)
        {
            return true;
        }

        /// <summary>
        /// 搜索题目
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Model.Project> SearchProject(string key, string type)
        {
            List<Model.Project> result = new List<Model.Project>();
            return result;
        }

        /// <summary>
        /// 发送纯文本消息
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Boolean SendMessage(string text)
        {
            return true;
        }

        /// <summary>
        /// 发送文件消息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public Boolean SendMessage(string file,string stage)
        {
            return true;
        }

        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public Boolean SendMessage(string image)
        {
            return true;
        }

        /// <summary>
        /// 上传进度任务文件
        /// </summary>
        /// <param name="file"></param>
        /// <param name="satge"></param>
        /// <returns></returns>
        public Boolean AddTaskFile(string task, string file, string satge)
        {
            return false;
        }

        /// <summary>
        /// 成绩复议
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public Boolean AchievementReconsider(string constitution, string reason)
        {
            return true;
        }
        
    }
}
