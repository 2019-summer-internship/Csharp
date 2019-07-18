using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    class Reconsider
    {/// <summary>
     /// 编号
     /// </summary>
        public String number;
        /// <summary>
        /// 提出者
        /// </summary>
        public String applicant;
        /// <summary>
        /// 处理人
        /// </summary>
        public String manager;
        /// <summary>
        /// 质疑成绩所属集合
        /// </summary>
        public String student;
        /// <summary>
        /// 质疑成绩项
        /// </summary>
        public String item;
        /// <summary>
        /// 质疑理由
        /// </summary>
        public String reason;
        /// <summary>
        /// 状态--0：未解决 UNRESOLVE，1：驳回 REJECT，2：接受 ACCEPT 
        /// </summary>
        public int statu;

    }
}
