using thesing.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace tesing.Controller
{
    class School:User
    {
        public thesing.Model.School school;
        public Boolean AddShedule(Shedule shedule)
        {
            return true;
        }
        public Boolean UpdateShedule(Shedule shedule)
        {
            return true;
        }
        public Boolean DestoryShedule(string shedule)
        {
            return true;

        }
        public Array<Shedule> ShowSheduleHistory(string key, string type)
        {
        }
        public Boolean Allocation(string teacher, int count)
        {
            return true;
        }
        public Array<Project> SearchUncheckProject(String key, string type)
        {
        }
        public Boolean PassProjiect(string project, string feedbake)
        {
            return true;
        }
        public Boolean RejiectProjiect(string project, string feedbake)
        {
            return true;
        }
        public Array<Recondiser> SearchReconsider(string key,string type)
        {

        }
        public Boolean RejiectReconsider(string reconder, string feedbake)
        {

        }
        public Boolean AcceptReconsider(string reconsider, string feedback)
        {
            return true;
        }

    }
}
