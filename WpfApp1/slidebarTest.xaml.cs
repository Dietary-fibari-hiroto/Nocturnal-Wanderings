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

namespace WpfApp1
{
    /// <summary>
    /// slidebarTest.xaml の相互作用ロジック
    /// </summary>
    public partial class slidebarTest : Page
    {
        public slidebarTest()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = (double)e.NewValue;
            TestValue.Text = value.ToString();
        }
    }


    public static class StaticData
    {
        public static string TestWord { get; set; } = "Hello from C#";
        public static string TestWord2 { get; set; } = "こんちくび";

    }

}
