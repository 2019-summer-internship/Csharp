using System;
using System.Collections.Generic;
using System.Text;

namespace thesing.Controller
{
    /// <summary>
    /// 学院类，继承自用户类
    /// </summary>
    public class School : User
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
        public Boolean AddShedule(Model.Schedule schedule)
        {
            return true;
        }

        /// <summary>
        /// 更新日程信息
        /// </summary>
        /// <param name="shedule"></param>
        /// <returns></returns>
        public Boolean UpdateShedule(string schedule, Model.Schedule newInfo)
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
        public List<Model.Schedule> ShowScheduleHistory(string key, string type)
        {
            List<Model.Schedule> result = new List<Model.Schedule>();
            return result;
        }

        /// <summary>
        /// 搜索导师
        /// </summary>
        /// <param name="key"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Model.Teacher> SearchTeacher(string key, string type)
        {
            List<Model.Teacher> result = new List<Model.Teacher>();
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
        public List<Model.Project> SearchUncheckProject(String key, string type)
        {
            List<Model.Project> result = new List<Model.Project>();
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
        public List<Model.Reconsider> SearchReconsider(string key, string type)
        {
            List<Model.Reconsider> result = new List<Model.Reconsider>();
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

