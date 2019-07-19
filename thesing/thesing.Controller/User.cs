using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Controller
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        public Model.User info;

        /// <summary>
        /// 操作者id
        /// </summary>
        private string operaterID;

        /// <summary>
        /// 构造函数
        /// </summary>
        public User() { }

        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="tempUser"></param>
        /// <returns></returns>
        public int UpdateInfo(Model.User newInfo)
        {
            return 0;
        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <returns></returns>
        public bool Destory()
        {
            return false;
        }

        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        public bool Create(Model.User tempUser)
        {
            return true;
        }

        /// <summary>
        /// 搜索通知
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Model.Mail> SearchMail(string key, string type)
        {
            List<Model.Mail> result = new List<Model.Mail>();
            return result;
        }

        /// <summary>
        /// 将通知标记已读
        /// </summary>
        /// <param name="mails"></param>
        public bool FlagMailRead(List<string> mails)
        {
            return true;
        }

        /// <summary>
        /// 删除通知
        /// </summary>
        /// <param name="mails"></param>
        /// <returns></returns>
        public Boolean DestoryMail(List<string> mails)
        {
            return true;
        }

    }
}
