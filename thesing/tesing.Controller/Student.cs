using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    /// <summary>
    /// 
    /// </summary>
    class Student:User
    {
        /// <summary>
        /// 
        /// </summary>
        public thesing.Model.Student Contrallstudent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Student() { }
        public Boolean ChooseProjiect(string project)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Project> SearchProject(string key, string type)
        {
            List<Project> result = new List<Project>();
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Boolean SendMessage(string text)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public Boolean SendMessage(string file,string stage)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="satge"></param>
        /// <returns></returns>
        public Boolean AddFile(string file, string satge)
        {
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stage"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public Boolean AchievementReconsider(string stage, string reason)
        {
            return true;
        }
        
    }
}
