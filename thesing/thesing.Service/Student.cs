using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thesing.Service
{
    class Student
    {
        /// <summary>
        /// 数据库
        /// </summary>
        private Service.SqlDbHelper database;

        /// <summary>
        /// SQL语句
        /// </summary>
        string sql;

        /// <summary>
        /// 返回查询表
        /// </summary>
        DataTable table;

        public Student()
        {
            database = new SqlDbHelper();
            sql = "";
            table = new DataTable();
        }

        /// <summary>
        /// 通过id获取学生信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Model.Student> GetStudentById(string[] idList)
        {
            Service.Achievement achievement = new Achievement();
            Service.Class clas = new Class();
            Service.Major major = new Major();
            Service.School school = new School();
            Service.Project project = new Project();
            Service.Teacher teacher = new Teacher();
            Service.Mail mail = new Mail();

            List<Model.Student> result = new List<Model.Student>();

            sql = "SELECT * FROM student WHERE id=@id";
            MySqlParameter[] parameter =
            {
                new MySqlParameter("@id", MySqlDbType.Int32)
            };
            foreach (string id in idList)
            {
                parameter[0].Value = id;
                table = database.ExecuteDataTable(sql, parameter);

                foreach (DataRow dataRow in table.Rows)
                {
                    Model.Student student = new Model.Student();
                    student.studentID = dataRow["_id"].ToString();
                    student.achievement = achievement.GetAchievementById(dataRow["achievement"].ToString().Split(',').ToList<string>());
                    student.clas = clas.GetClassNameById(dataRow["class"].ToString());
                    student.major = major.GetMajorNameById(dataRow["major"].ToString());
                    student.school = school.GetSchoolNameById(dataRow["school"].ToString());
                    student.project = project.GetProjectById(dataRow["project"].ToString());
                    student.teacher = teacher.GetTeacherNameById(dataRow["teacher"].ToString());
                    student.process = student.project.process;
                    student.mail = mail.GetMailByReciver(dataRow["_id"].ToString());

                    result.Add(student);
                }
            }

            return result;
        }
    }
}
