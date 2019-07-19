using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    /// <summary>
    /// 导师类，继承自用户类
    /// </summary>
    class Teacher:User
    {
        /// <summary>
        /// 导师信息
        /// </summary>
        public thesing.Model.Teacher info;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Teacher() { }

        /// <summary>
        /// 新建题目
        /// </summary>
        /// <param name="projiect"></param>
        /// <returns></returns>
        public Boolean AddProject(Project project)
        {
            return true;
        }

        /// <summary>
        /// 更新题目信息
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean UpdateProject(Project project)
        {
            return false;
        }

        /// <summary>
        /// 删除题目
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean DestoryProject(string project)
        {
            return false;
        }

        /// <summary>
        /// 搜索题目
        /// </summary>
        /// <param name="key"></param>
        /// <param name="yepe"></param>
        /// <returns></returns>
        public List<Project> SearchProjct(string key, string type)
        {
            List<Project> result = new List<Project>();
            return result;

        }

        /// <summary>
        /// 给分
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
        /// 驳回学生选题
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public Boolean RejectChoose(string student)
        {
            return false;
        }
    }
}
