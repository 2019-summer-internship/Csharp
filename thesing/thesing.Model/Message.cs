using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    class Message
    {/// <summary>
     /// 消息编号
     /// </summary>
        public String number;
        /// <summary>
        /// 发送者
        /// </summary>
        public String sender;
        /// <summary>
        /// 接收者
        /// </summary>
        public String receiver;
        /// <summary>
        /// 消息状态--0：未读 UNREAD，1：已读 READ
        /// </summary>
        public int statu;
        /// <summary>
        /// 发布时间
        /// </summary>
        public String time;
        /// <summary>
        /// 消息类型--0：文字 TEXT，1：图片 IMAGE，2文件 FILE
        /// </summary>
        public int type;
        /// <summary>
        /// 内容
        /// </summary>
        public String content;
        /// <summary>
        /// 图片路径
        /// </summary>
        public String image;
        /// <summary>
        /// 文件路径
        /// </summary>
        public String file;
        /// <summary>
        /// 阶段标签
        /// </summary>
        public String label;

    }
}
