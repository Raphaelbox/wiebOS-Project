using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace wiebOS
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartBTN_Click(object sender, RoutedEventArgs e)
        {
            var transformGroup = TextPadBTN.RenderTransform as TransformGroup;
            TranslateTransform transform = transformGroup.Children[3] as TranslateTransform;
            var x = transform.X;
            var y = transform.Y;
            if (y != 1)
            {
                StartBTN.IsEnabled = false;
            }
        }

        private void TextPadBTN_Click(object sender, RoutedEventArgs e)
        {
           TextPadController.Opacity = 1;
        }
    }
}