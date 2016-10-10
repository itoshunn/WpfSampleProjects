//--------------------------------------------
//  StartUp Window
//--------------------------------------------
using System.Windows;

namespace StartWindow
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region MinimumProjectの起動

        /// <summary>
        /// MinimumProjectの起動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void minimunProject_Start(object sender, RoutedEventArgs e)
        {
            MinimumProjects.MainWindow window = new MinimumProjects.MainWindow();
            window.ShowDialog();
        }

        #endregion

    }
}
