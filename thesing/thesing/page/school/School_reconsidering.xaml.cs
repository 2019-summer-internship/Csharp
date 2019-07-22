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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace thesing.page.School
{
    /// <summary>
    /// School_reconsidering.xaml 的交互逻辑
    /// </summary>
    public partial class School_reconsidering : Page
    {
        public List<schoolInfo> allSchoolInfo { get; set; } //这是ListBox绑定的item列表
        public School_reconsidering()
        {
            InitializeComponent();
            allSchoolInfo = new List<schoolInfo>(); //new一个新对象了，终于有对象了
            allSchoolInfo.Add(new schoolInfo //给这个对象添加一个新schoolInfo，好比买了一个包包给对象
            {
                avatar = "/source/image/people.ico",
                name = "第一阶段有误",
                from = "胡晓鹏",
                data = "2019-7-22",

            });
            allSchoolInfo.Add(new schoolInfo //这里又添加一个schoolInfo，又买一个包包
            {
                avatar = "/source/image/people.ico",
                name = "第二阶段有误",
                from = "胡晓鹏",
                data = "2019-7-22",

            });
            allSchoolInfo.Add(new schoolInfo //这里又添加一个schoolInfo，这次恐怕得买。。。。。额不知道了！！
            {
                avatar = "/source/image/people.ico",
                name = "第三阶段有误",
                from = "胡晓鹏",
                data = "2019-7-22",

            });

            this.DataContext = this; //总之，这样我也不懂什么this赋值给this之后，这个鬼扯的ListBox就搞定了，以后只要更新allSchoolInfo，界面就会跟着更新了
        }


        /// <summary>
        /// 绑定数据用的学院信息类
        /// </summary>
        public class schoolInfo
        {
            public string avatar { get; set; }
            public string name { get; set; }
            public string from { get; set; }
            public string data { get; set; }
        }
    }

}