using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Model
{
    /// <summary>
    /// 进度项模型
    /// </summary>
    public class Task
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string number { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public string label { get; set; }

        /// <summary>
        /// 完成时间
        /// </summary>
        public string time { get; set; }

        /// <summary>
        /// 状态--0：还没开始 TODO，1：正在进行 DOING，2：已完成 DONE
        /// </summary>
        public string statu { get; set; }

        public Task() { }

    }
}
