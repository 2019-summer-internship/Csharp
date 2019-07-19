using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    /// <summary>
    /// 
    /// </summary>
    class Teacher:User
    {
        /// <summary>
        /// 
        /// </summary>
        public thesing.Model.Teacher teacher;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projiect"></param>
        /// <returns></returns>
        public Teacher() { }
        public Boolean AddProjiect(Project projiect)
        {
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean UpdateProjiect(Project project)
        {
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean DestoryProjiect(string project)
        {
            return false;
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="yepe"></param>
        /// <returns></returns>
        public List<Project> SearchProjict(string key, string yepe)
        {
            List<Project> result = new List<Project>();
            return result;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <param name="score"></param>
        /// <param name="feedbake"></param>
        /// <returns></returns>
        public Boolean GaveGrade(string file, int score, string feedbake)
        {
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Boolean RejictChoose(string student)
        {
            return false;
        }
    }
}
