using System;
using System.CodeDom;
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
using System.Xml;
using WpfApp1.hooks;

namespace WpfApp1
{
    /// <summary>
    /// slidebarTest.xaml の相互作用ロジック
    /// </summary>
    public partial class slidebarTest : Page
    {
        private Boolean filterState = false;
        public slidebarTest()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
        private void Filter(object sender,MouseButtonEventArgs e)
        {
            if (!filterState)
            {
                
            }
        }
    }


    public static class StaticData
    {
        public static string TestWord { get; set; } = "Hello from C#";
        public static string TestWord2 { get; set; } = "こんちくび";

    }

}
