using System.Windows;

namespace EssentialWpf
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


        /// <summary>
        /// コントロールウィンドウの表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fastControl_start(object sender, RoutedEventArgs e)
        {
            fast.fastControl window = new fast.fastControl();
            window.ShowDialog();
        }

        /// <summary>
        /// 3Dコントロールウィンドウの表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void control3d_Start(object sender, RoutedEventArgs e)
        {
            fast.Control3d window = new fast.Control3d();
            window.ShowDialog();
            
        }
    }
}
