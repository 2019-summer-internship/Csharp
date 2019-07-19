using thesing.Model;
using System.Collections.Generic;
using System;

namespace thesing.Controller
{
    public class user
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
        /// <param name="tempUser"></param>
        /// <returns></returns>
        /// 
        public user() { }
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
        public bool Creat()
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
        public Boolean DestoryMail(List<string> mails)
        {
            return true;
        }

    }
}
