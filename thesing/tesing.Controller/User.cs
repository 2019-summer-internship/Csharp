using thesing.Model;
using System.Collections.Generic;
using System;

namespace thesing.Controller
{
    public class User
    {
        /// <summary>
        /// 
        /// </summary>
        public Model.User _user;

        /// <summary>
        /// 
        /// </summary>
        private string operaterID;

        /// <summary>
        /// 
        /// </summary>
        public User() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tempUser"></param>
        /// <returns></returns>
        public int UpdateInfo(Model.User tempUser)
        {
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Destory()
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Create(Model.User tempUser)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Mail> SearchMail(string key, string type)
        {
            List<Mail> result = new List<Mail>();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mails"></param>
        public bool FlagMailRead(List<string> mails)
        {
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mails"></param>
        /// <returns></returns>
        public Boolean DestoryMail(List<string> mails)
        {
            return true;
        }

    }
}
