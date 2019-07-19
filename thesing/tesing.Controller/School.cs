using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    /// <summary>
    /// 学院类，继承自用户类
    /// </summary>
    class School:User
    {
        /// <summary>
        /// 学院信息
        /// </summary>
        public thesing.Model.School info;

        /// <summary>
        /// 构造函数
        /// </summary>
        public School() { }

        /// <summary>
        /// 新建日程
        /// </summary>
        /// <param name="shedule"></param>
        /// <returns></returns>
        public Boolean AddShedule(Shedule shedule)
        {
            return true;
        }

        /// <summary>
        /// 更新日程信息
        /// </summary>
        /// <param name="shedule"></param>
        /// <returns></returns>
        public Boolean UpdateShedule(string schedule, Schedule newInfo)
        {
            return true;
        }

        /// <summary>
        /// 删除日程
        /// </summary>
        /// <param name="schedule"></param>
        /// <returns></returns>
        public Boolean DestorySchedule(string schedule)
        {
            return true;

        }

        /// <summary>
        /// 显示历史发布日程
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Schedule> ShowScheduleHistory(string key, string type)
        {
            List<Schedule> result = new List<Schedule>();
            return result;
        }

        /// <summary>
        /// 分配名额
        /// </summary>
        /// <param name="teacher"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public Boolean Allocation(string teacher, int count)
        {
            return true;
        }

        /// <summary>
        /// 搜索未通过审核题目
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Array<Project> SearchUncheckProject(String key, string type)
        {
            List<Project> result = new List<Project>();
            return result;
        }

        /// <summary>
        /// 通过题目审核
        /// </summary>
        /// <param name="project"></param>
        /// <param name="feedbake"></param>
        /// <returns></returns>
        public Boolean PassProjiect(string project, string feedbake)
        {
            return true;
        }

        /// <summary>
        /// 驳回题目审核申请
        /// </summary>
        /// <param name="project"></param>
        /// <param name="feedbake"></param>
        /// <returns></returns>
        public Boolean RejectProjiect(string project, string feedbake)
        {
            return true;
        }

        /// <summary>
        /// 搜索复议
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public Array<Recondiser> SearchReconsider(string key,string type)
        {
            List<Reconsider> result = new List<Reconsider>();
            return result;
        }

        /// <summary>
        /// 驳回复议
        /// </summary>
        /// <param name="reconder"></param>
        /// <param name="feedbake"></param>
        /// <returns></returns>
        public Boolean RejectReconsider(string reconsider, string feedbake)
        {
            return true;
        }

        /// <summary>
        /// 接受复议
        /// </summary>
        /// <param name="reconsider"></param>
        /// <param name="feedback"></param>
        /// <returns></returns>
        public Boolean AcceptReconsider(string reconsider, string feedback)
        {
            return true;
        }

    }
}
