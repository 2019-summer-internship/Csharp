using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace thesing
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class Home : Window
    {
        public Home(Model.User user)
        {
            InitializeComponent();

            string userType = user.type;
            switch(userType)
            {
                case "student": RenderStudentUI(user); break;
                case "teacher": RenderTeacherUI(user); break;
                case "school": RenderSchoolUI(user); break;
                case "university": RenderUniversityUI(user); break;
                case "user": break;
                default: MessageBox.Show("登录错误"); break;
            }
        }

        /// <summary>
        /// 渲染学生界面
        /// </summary>
        /// <param name="user"></param>
        public void RenderStudentUI(Model.User user)
        {
            nickname.Text = user.name;
            student_process_menu.Visibility = Visibility.Visible;
            student_project_menu.Visibility = Visibility.Visible;
            student_score_menu.Visibility = Visibility.Visible;
            student_teacher_menu.Visibility = Visibility.Visible;

            student_project_menu.IsChecked = true;
        }

        /// <summary>
        /// 渲染导师界面
        /// </summary>
        /// <param name="user"></param>
        public void RenderTeacherUI(Model.User user)
        {
            nickname.Text = user.name;
            teacher_examine_menu.Visibility = Visibility.Visible;
            teacher_project_menu.Visibility = Visibility.Visible;
            teacher_student_menu.Visibility = Visibility.Visible;

            teacher_project_menu.IsChecked = true;
        }
        
        /// <summary>
        /// 渲染学院界面
        /// </summary>
        /// <param name="user"></param>
        public void RenderSchoolUI(Model.User user)
        {
            nickname.Text = user.name;
            school_check_menu.Visibility = Visibility.Visible;
            school_reconsider_menu.Visibility = Visibility.Visible;
            school_schedule_menu.Visibility = Visibility.Visible;
            school_teacher_menu.Visibility = Visibility.Visible;

            school_schedule_menu.IsChecked = true;
        }

        /// <summary>
        /// 渲染校方界面
        /// </summary>
        /// <param name="user"></param>
        public void RenderUniversityUI(Model.User user)
        {
            nickname.Text = user.name;
            university_plan_menu.Visibility = Visibility.Visible;
            university_school_menu.Visibility = Visibility.Visible;

            university_school_menu.IsChecked = true;
        }
    }
}
