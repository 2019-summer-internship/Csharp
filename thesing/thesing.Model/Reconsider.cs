using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 成绩复议模型
    /// </summary>
    class Reconsider
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number;

        /// <summary>
        /// 提出者
        /// </summary>
        public string applicant;

        /// <summary>
        /// 处理人
        /// </summary>
        public string manager;

        /// <summary>
        /// 质疑成绩所属集合
        /// </summary>
        public string student;

        /// <summary>
        /// 质疑成绩项
        /// </summary>
        public Consititution item;

        /// <summary>
        /// 质疑理由
        /// </summary>
        public string reason;

        /// <summary>
        /// 状态--0：未解决 UNRESOLVE，1：驳回 REJECT，2：接受 ACCEPT 
        /// </summary>
        public string statu;

    }
}
