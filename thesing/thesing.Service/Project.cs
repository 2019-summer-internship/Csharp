using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thesing.Service
{
    /// <summary>
    /// 操作题目表的操作服务类
    /// </summary>
    class Project
    {
        /// <summary>
        /// 数据库
        /// </summary>
        Service.SqlDbHelper database = new SqlDbHelper();

        /// <summary>
        /// 新建题目
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int CreateProject(Model.Project project)
        {
            return 0;
        }

        /// <summary>
        /// 更新题目信息
        /// </summary>
        /// <param name="newInfo"></param>
        /// <returns></returns>
        public int UpdataProject(Model.Project newInfo)
        {
            return 0;
        }

        public Model.Project GetProjectById(string id)
        {
            Model.Project result = new Model.Project();

            return result;
        }

        /// <summary>
        /// 通过出题教师查询题目
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByTeacher(string teacher)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }

        /// <summary>
        /// 通过题目标题查询题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByTitle(string title)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }

        /// <summary>
        /// 通过题目类型查询题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByType(string type)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }

        /// <summary>
        /// 通过题目来源查询题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByFrom(string from)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }

        /// <summary>
        /// 通过题目工作量查询题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByAmount(string amount)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }

        /// <summary>
        /// 通过题目难度查询题目
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Project> GetProjectByDifficult(string difficult)
        {
            List<Model.Project> result = new List<Model.Project>();

            return result;
        }
    }
}
