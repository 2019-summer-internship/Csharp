using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace thesing.page.school
{
    /// <summary>
    /// School_shdule.xaml 的交互逻辑
    /// </summary>
    public partial class School_shdule : Page
    {
        public ObservableCollection<Person> PList { get; set; }
        public School_shdule()
        {
            InitializeComponent();
            PList = new ObservableCollection<Person>();
            PList.Add(new Person { IsFemale = true, Name = "小红" });
            PList.Add(new Person { IsFemale = false, Name = "小明" });
            PList.Add(new Person { IsFemale = false, Name = "小X" });
            PList.Add(new Person { IsFemale = false, Name = "小xx" });

            this.DataContext = this;
        }
        public class Person
        {
            public bool IsFemale { get; set; }
            public string Name { get; set; }
        }

    }
}
