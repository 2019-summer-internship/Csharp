using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 评阅模型
    /// </summary>
    class Examine
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number;

        /// <summary>
        /// 来源学生
        /// </summary>
        public string student;

        /// <summary>
        /// 评阅老师
        /// </summary>
        public string teacher;

        /// <summary>
        /// 总得分
        /// </summary>
        public float score;

        /// <summary>
        /// 状态--0：还没开始 TODO，1：正在进行 DOING，2：已完成 DONE
        /// </summary>
        public string statu;

        /// <summary>
        /// 文件列表，包括文件名--路径，得分，反馈，状态
        /// </summary>
        public List<string> files;

    }
}
