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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
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
        /// <param projectname="user"></param>
        public void RenderStudentUI(Model.User user)
        {
            nickname.Text = user.name;
            Student_Process_menu.Visibility = Visibility.Visible;
            Student_Project_menu.Visibility = Visibility.Visible;
            Student_Grade_menu.Visibility = Visibility.Visible;
            Student_Teacher_menu.Visibility = Visibility.Visible;
            Student_Project_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            Student_Project_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
            Student_Project_menu.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent, Student_Project_menu));
        }

        /// <summary>
        /// 渲染导师界面
        /// </summary>
        /// <param projectname="user"></param>
        public void RenderTeacherUI(Model.User user)
        {
            nickname.Text = user.name;
            Teacher_Project_menu.Visibility = Visibility.Visible;
            Teacher_Student_menu.Visibility = Visibility.Visible;
            Teacher_Examine_menu.Visibility = Visibility.Visible;
            Teacher_Project_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            Teacher_Project_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
            Teacher_Project_menu.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent, Teacher_Project_menu));
        }
        
        /// <summary>
        /// 渲染学院界面
        /// </summary>
        /// <param projectname="user"></param>
        public void RenderSchoolUI(Model.User user)
        {
            nickname.Text = user.name;
            School_Schedule_menu.Visibility = Visibility.Visible;
            School_Teacher_menu.Visibility = Visibility.Visible;
            School_Project_menu.Visibility = Visibility.Visible;
            School_Reconsider_menu.Visibility = Visibility.Visible;
            School_Schedule_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            School_Schedule_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
            School_Schedule_menu.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent, School_Schedule_menu));
        }

        /// <summary>
        /// 渲染校方界面
        /// </summary>
        /// <param projectname="user"></param>
        public void RenderUniversityUI(Model.User user)
        {
            nickname.Text = user.name;
            //University_plan_menu.Visibility = Visibility.Visible;
            University_School_menu.Visibility = Visibility.Visible;
            University_School_menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EBEBEB"));
            University_School_menu.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
            University_School_menu.RaiseEvent(new RoutedEventArgs(MenuItem.ClickEvent, University_School_menu));
        }

        /// <summary>
        /// 菜单点击函数
        /// </summary>
        /// <param projectname="sender"></param>
        /// <param projectname="e"></param>
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

            string[] names = menuItem.Name.Split('_');
            string page = "/page/" + names[0] + "/" + names[0] + "_" + names[1] + ".xaml";
            //MessageBox.Show(page);

            pageFrame.Navigate(new Uri(page, UriKind.Relative));
            
        }

        /// <summary>
        /// 渲染完成后获取所有可见菜单
        /// </summary>
        /// <param projectname="sender"></param>
        /// <param projectname="e"></param>
        private void getAllMenu(object sender, RoutedEventArgs e)
        {
            allMenu = GetChildObjects<MenuItem>(mainMenu, typeof(MenuItem));
        }

        /// <summary>
        /// 获取所有子元素
        /// </summary>
        /// <typeparam projectname="MenuItem"></typeparam>
        /// <param projectname="obj"></param>
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
