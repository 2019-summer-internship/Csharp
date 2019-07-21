using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 消息模型
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 发送者
        /// </summary>
        public string sender { get; set; }

        /// <summary>
        /// 接收者
        /// </summary>
        public string receiver { get; set; }

        /// <summary>
        /// 消息状态--0：未读 UNREAD，1：已读 READ
        /// </summary>
        public string statu { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// 消息类型--0：文字 TEXT，1：图片 IMAGE，2文件 FILE
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }

        /// <summary>
        /// 图片路径
        /// </summary>
        public string image { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public string file { get; set; }

        /// <summary>
        /// 阶段标签
        /// </summary>
        public string label { get; set; }

        public Message() { }

    }
}
