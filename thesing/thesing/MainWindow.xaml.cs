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

namespace thesing
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录按钮响应函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sign(object sender, RoutedEventArgs e)
        {
            Controller.User user = new Controller.User();

            string account = this.account.Text;
            string pwd = this.password.Text;

            if (account.Length <= 0)
            {
                MessageBox.Show("账号不能为空");
                return;
            }
            if (pwd.Length <= 0)
            {
                MessageBox.Show("密码不能为空");
                return;
            }

            int code = user.Sigin(account, pwd);

            switch (code)
            {
                case 0:
                    Home home = new Home(user.info);
                    home.Show();
                    this.Close();
                    break;
                case -1: MessageBox.Show("用户不存在"); break;
                case -2: MessageBox.Show("密码或账号错误"); break;
                case -3: MessageBox.Show("账号格式错误"); break;
                case -4: MessageBox.Show("密码过长"); break;
                default: break;
            }
        }
    }
}
