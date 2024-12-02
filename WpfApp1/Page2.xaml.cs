using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Page2.xaml の相互作用ロジック
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Cord(object sender, MouseButtonEventArgs e)
        {
            foreach (var screen in Screen.AllScreens)
            {
                filter FilterWindow = new filter
                {
                    Width = screen.Bounds.Width,
                    Height = screen.Bounds.Height,
                    Left = screen.Bounds.Left,
                    Top = screen.Bounds.Top,
                    Background = System.Windows.Media.Brushes.Black,
                    Opacity = 0.5 // フィルターの透明度設定
                };
                FilterWindow.Show();
            }
        

        }
    }
}
