using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    class Examine
    {/// <summary>
     /// 编号
     /// </summary>
        public String number;
        /// <summary>
        /// 来源学生，ID的集合
        /// </summary>
        public String student;
        /// <summary>
        /// 老师的集合
        /// </summary>
        public String teacher;
        /// <summary>
        /// 总得分
        /// </summary>
        public String score;
        /// <summary>
        /// 状态--0：还没开始 TODO，1：正在进行 DOING，2：已完成 DONE
        /// </summary>
        public int statu;
        /// <summary>
        /// 文件列表，包括文件名--路径，得分，反馈，状态
        /// </summary>
        public String files;

    }
}
