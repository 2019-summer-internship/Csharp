using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Controller
{
    /// <summary>
    /// 导师类，继承自用户类
    /// </summary>
    public class Teacher : User
    {
        /// <summary>
        /// 导师信息
        /// </summary>
        public new thesing.Model.Teacher info;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Teacher() { }

        /// <summary>
        /// 新建题目
        /// </summary>
        /// <param name="projiect"></param>
        /// <returns></returns>
        public Boolean AddProject(Model.Project project)
        {
            return true;
        }

        /// <summary>
        /// 更新题目信息
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public Boolean UpdateProject(Model.Project project)
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
        public List<Model.Project> SearchProjct(string key, string type)
        {
            List<Model.Project> result = new List<Model.Project>();
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

