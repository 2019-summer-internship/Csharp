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
        private string number { get; set; }

        /// <summary>
        /// 发送者
        /// </summary>
        public string sender { get; set; }

        /// <summary>
        /// 接收者
        /// </summary>
        public string receiver { get; set; }

        /// <summary>
        /// 发送时间
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string statu { get; set; }

        public Mail() { }
    }
}
