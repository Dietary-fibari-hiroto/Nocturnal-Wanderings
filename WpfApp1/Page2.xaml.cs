using System.Windows.Forms;
using WpfPage = System.Windows.Controls.Page;
using FormsScreen = System.Windows.Forms.Screen;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class Page2 : WpfPage
    {
        public Page2()
        {
            InitializeComponent();
        }
        private void Page(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new slidebarTest());
        }

        private void Cord(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            int screenIndex = 0; // スクリーンごとの処理を分けるためのカウンタ

            foreach (var screen in FormsScreen.AllScreens)
            {
                // フィルターウィンドウを作成
                var filterWindow = new filter
                {
                    Width = screen.Bounds.Width,
                    Height = screen.Bounds.Height,
                    WindowStartupLocation = System.Windows.WindowStartupLocation.Manual
                };

                // スクリーンごとに処理を分ける
                if (screenIndex == 0) // 1回目のスクリーン
                {
                    filterWindow.Left = screen.Bounds.Left;
                    filterWindow.Top = screen.Bounds.Top;
                }
                else if (screenIndex == 1) // 2回目のスクリーン
                {
                    filterWindow.Left = screen.Bounds.Right - filterWindow.Width;  // 右端に合わせる
                    filterWindow.Top = screen.Bounds.Bottom - filterWindow.Height; // 下
                }
                else // それ以降のスクリーン
                {
                    filterWindow.Left = screen.Bounds.Left + 100;
                    filterWindow.Top = screen.Bounds.Top + 100;
                }

                // フィルターウィンドウを表示
                filterWindow.Show();

                screenIndex++; // 次のスクリーンへ
            }
        }

        private void Animate(object sender, MouseButtonEventArgs e){
            var window1 = new Window1();
            window1.Show();

        }
    }
}
