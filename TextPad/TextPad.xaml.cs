using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using Microsoft.Win32;

namespace TextPad
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TextPadControl : UserControl
    {

        //Commands
        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
        {
            NewFunction();
        }

        private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFunction();
        }

        private void SaveAsCommand(object sender, ExecutedRoutedEventArgs e)
        {
            SaveAsFunction();
        }

        private void PrintCommand(object sender, ExecutedRoutedEventArgs e)
        {
            PrintFunction();
        }

        //Functions
        public TextPadControl()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewFunction();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFunction();
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveAsFunction();
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintFunction();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        //Methods
        private void NewFunction()
        {
            TextEditor.SelectAll();
            TextEditor.Selection.Text = "";
        }

        private void OpenFunction()
        {
            var OpenDialog = new OpenFileDialog();
            OpenDialog.Filter = "Text Files (.txt)|*.txt";
            if (OpenDialog.ShowDialog() == true)
            {
                var fileStream = new FileStream(OpenDialog.FileName, FileMode.Open);
                var range = new TextRange(TextEditor.Document.ContentStart, TextEditor.Document.ContentEnd);
                range.Load(fileStream, DataFormats.Text);
            }
        }

        private void SaveAsFunction()
        {
            var SaveDialog = new SaveFileDialog();
            SaveDialog.Filter = "Text Files (.txt)|*.txt";
            SaveDialog.Title = "Save the note";
            if (SaveDialog.ShowDialog() == true)
            {
                var fileStream = new FileStream(SaveDialog.FileName, FileMode.Create);
                var range = new TextRange(TextEditor.Document.ContentStart, TextEditor.Document.ContentEnd);
                range.Save(fileStream, DataFormats.Text);
            }
        }

        private void PrintFunction()
        {
            var printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
                printDialog.PrintVisual(TextEditor, "Printed by wiebOS");
        }
    }
}