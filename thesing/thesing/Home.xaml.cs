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
        /// <summary>
        /// 所有子菜单
        /// </summary>
        List<MenuItem> allMenu = new List<MenuItem>();

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
            student_project_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            student_project_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
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
            teacher_project_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            teacher_project_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
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
            school_schedule_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            school_schedule_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
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
            university_school_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            university_school_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
        }

        /// <summary>
        /// 菜单点击函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainMenuClick(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            foreach(MenuItem menu in allMenu)
            {
                menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#66CCFF"));
                menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
            }
            menuItem.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            menuItem.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
            MessageBox.Show(menuItem.Name.ToString());
        }


        private void getAllMenu(object sender, RoutedEventArgs e)
        {
            allMenu = GetChildObjects<MenuItem>(mainMenu, typeof(MenuItem));
        }

        /// <summary>
        /// 获取所有子元素
        /// </summary>
        /// <typeparam name="MenuItem"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public List<T> GetChildObjects<T>(DependencyObject obj, Type typename) where T : FrameworkElement
        {
            DependencyObject child = null;
            List<T> childList = new List<T>();

            for (int i = 0; i <= VisualTreeHelper.GetChildrenCount(obj) - 1; i++)
            {
                child = VisualTreeHelper.GetChild(obj, i);

                if (child is T && (((T)child).GetType() == typename))
                {
                    childList.Add((T)child);
                }
                childList.AddRange(GetChildObjects<T>(child, typename));
            }
            return childList;
        }

    }
}
