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
        public string number;

        /// <summary>
        /// 发送者
        /// </summary>
        public string sender;

        /// <summary>
        /// 接收者
        /// </summary>
        public string receiver;

        /// <summary>
        /// 消息状态--0：未读 UNREAD，1：已读 READ
        /// </summary>
        public string statu;

        /// <summary>
        /// 发布时间
        /// </summary>
        public string time;

        /// <summary>
        /// 消息类型--0：文字 TEXT，1：图片 IMAGE，2文件 FILE
        /// </summary>
        public string type;

        /// <summary>
        /// 内容
        /// </summary>
        public string content;

        /// <summary>
        /// 图片路径
        /// </summary>
        public string image;

        /// <summary>
        /// 文件路径
        /// </summary>
        public string file;

        /// <summary>
        /// 阶段标签
        /// </summary>
        public string label;

        public Message() { }

    }
}
