using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 通知模型
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// 通知编号
        /// </summary>
        private string number;

        /// <summary>
        /// 发送者
        /// </summary>
        public string sender;

        /// <summary>
        /// 接收者
        /// </summary>
        public string receiver;

        /// <summary>
        /// 发送时间
        /// </summary>
        public string time;

        /// <summary>
        /// 标题
        /// </summary>
        public string title;

        /// <summary>
        /// 内容
        /// </summary>
        public string content;

        /// <summary>
        /// 状态
        /// </summary>
        public string statu;
    }
}
