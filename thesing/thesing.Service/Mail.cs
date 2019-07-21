using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thesing.Service
{
    /// <summary>
    /// 用于操作通知表的通知服务类
    /// </summary>
    class Mail
    {
        /// <summary>
        /// 数据库
        /// </summary>
        Service.SqlDbHelper database = new SqlDbHelper();

        /// <summary>
        /// 更新通知信息
        /// </summary>
        /// <param name="newInfo"></param>
        /// <returns></returns>
        public int UpdateMail(Model.Mail newInfo)
        {
            return 0;
        }

        /// <summary>
        /// 创建通知
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public int CreateMail(Model.Mail mail)
        {
            return 0;
        }

        /// <summary>
        /// 通过发送查询通知
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public List<Model.Mail> GetMailBySender(string sender, string receiver)
        {
            List<Model.Mail> result = new List<Model.Mail>();

            return result;
        }

        /// <summary>
        /// 通过标题查询通知
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public List<Model.Mail> GetMailByTitle(string title, string receiver)
        {
            List<Model.Mail> result = new List<Model.Mail>();

            return result;
        }

        /// <summary>
        /// 通过内容查询
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public List<Model.Mail> GetMailByContent(string content, string receiver)
        {
            List<Model.Mail> result = new List<Model.Mail>();

            return result;
        }
    }
}
