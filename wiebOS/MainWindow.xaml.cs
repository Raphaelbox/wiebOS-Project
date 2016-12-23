using System.Windows;
using System.Windows.Media.Animation;

namespace wiebOS
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int StartCounter;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, RoutedEventArgs e)
        {
            StartCounter++;
            Start_BeginStoryboard.Storyboard.Stop();
        }

        private void TextPadBTN_Click(object sender, RoutedEventArgs e)
        {
            TextPadBTN.IsEnabled = false;
        }
    }
}