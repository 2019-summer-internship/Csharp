using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    class Task
    {/// <summary>
     /// 编号
     /// </summary>
        public String number;
        /// <summary>
        /// 任务名称
        /// </summary>
        public String name;
        /// <summary>
        /// 标签
        /// </summary>
        public String label;
        /// <summary>
        /// 完成时间
        /// </summary>
        public String time;
        /// <summary>
        /// 状态--0：还没开始 TODO，1：正在进行 DOING，2：已完成 DONE
        /// </summary>
        public int statu;

    }
}
