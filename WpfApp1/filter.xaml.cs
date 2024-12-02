using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;  // これを追加
using System.Drawing;  // これを追加




namespace WpfApp1
{

    /// <summary>
    /// filter.xaml の相互作用ロジック
    /// </summary>
    public partial class filter : Window
    {
        public filter()
        {
            InitializeComponent();
            Loaded += FilterWindow_Loaded;
        }
        private void FilterWindow_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var screen in Screen.AllScreens)
            {
                var hwnd = new WindowInteropHelper(this).Handle;
                int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT | WS_EX_LAYERED);

                // 新しいウィンドウの位置をディスプレイに合わせる
                this.Left = screen.WorkingArea.Left;
                this.Top = screen.WorkingArea.Top;
                this.Width = screen.WorkingArea.Width;
                this.Height = screen.WorkingArea.Height;

                this.Show();
            }
        }

        // Windows API のインポート
        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int WS_EX_LAYERED = 0x80000;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

    }
}
