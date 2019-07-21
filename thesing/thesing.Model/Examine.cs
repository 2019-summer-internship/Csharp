using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 评阅模型
    /// </summary>
    public class Examine
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 来源学生
        /// </summary>
        public string student { get; set; }

        /// <summary>
        /// 评阅老师
        /// </summary>
        public string teacher { get; set; }

        /// <summary>
        /// 总得分
        /// </summary>
        public float score { get; set; }

        /// <summary>
        /// 状态--0：还没开始 TODO，1：正在进行 DOING，2：已完成 DONE
        /// </summary>
        public string statu { get; set; }

        /// <summary>
        /// 文件列表，包括文件名--路径，得分，反馈，状态
        /// </summary>
        public List<string> files { get; set; }

        public Examine() { }
    }
}
