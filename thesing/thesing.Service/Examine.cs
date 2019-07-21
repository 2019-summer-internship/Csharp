using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thesing.Service
{
    /// <summary>
    /// 对评阅表进行操作的评阅服务类
    /// </summary>
    class Examine
    {
        /// <summary>
        /// 数据库
        /// </summary>
        Service.SqlDbHelper database = new SqlDbHelper();

        /// <summary>
        /// 通过导师id获取评阅列表
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public List<Model.Examine>GetTeacherExamine(string teacher)
        {
            List<Model.Examine> result = new List<Model.Examine>();

            return result;
        }

        /// <summary>
        /// 创建评阅
        /// </summary>
        /// <param name="examine"></param>
        /// <returns></returns>
        public int CreateExamine(Model.Examine examine)
        {
            return 0;
        }

        /// <summary>
        /// 更新评阅信息
        /// </summary>
        /// <param name="newInfo"></param>
        /// <returns></returns>
        public int UpdateExamine(Model.Examine newInfo)
        {
            return 0;
        }
    }
}
