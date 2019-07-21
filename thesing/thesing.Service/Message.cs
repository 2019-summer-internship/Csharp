using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thesing.Service
{
    /// <summary>
    /// 操作消息表的消息服务类
    /// </summary>
    class Message
    {
        /// <summary>
        /// 数据库
        /// </summary>
        Service.SqlDbHelper database = new SqlDbHelper();

        /// <summary>
        /// 发送新消息
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public int CreateMessage(Model.Message message)
        {
            return 0;
        }

        /// <summary>
        /// 更新消息
        /// </summary>
        /// <param name="newInfo"></param>
        /// <returns></returns>
        public int UpdateMessage(Model.Message newInfo)
        {
            return 0;
        }

        /// <summary>
        /// 获取所有消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="receiver"></param>
        /// <returns></returns>
        public List<Model.Message> GetMessage(string sender, string receiver)
        {
            List<Model.Message> restult = new List<Model.Message>();

            return restult;
        }
    }
}
