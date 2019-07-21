using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace thesing.Service
{
    /// <summary>
    /// 对成绩表进行操作的成绩服务类
    /// </summary>
    class Achievement
    {
        /// <summary>
        /// 数据库
        /// </summary>
        Service.SqlDbHelper database = new SqlDbHelper();

        /// <summary>
        /// 通过学生id返回成绩
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public List<Model.Achievement> GetStudentAchievement(string student)
        {
            List<Model.Achievement> result = new List<Model.Achievement>();

            return result;
        }

        /// <summary>
        /// 创建成绩
        /// </summary>
        /// <returns></returns>
        public int CreateAchievement(Model.Achievement achievement)
        {
            return 0;
        }

        /// <summary>
        /// 更新成绩信息
        /// </summary>
        /// <param name="newInfo"></param>
        /// <returns></returns>
        public int UpdateAchievement(Model.Achievement newInfo)
        {
            return 0;
        }
    }
}