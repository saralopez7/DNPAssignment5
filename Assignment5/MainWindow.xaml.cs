using Assignment5.Model;
using System.Windows;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            var dialogBox = new DialogWindow();
            dialogBox.ShowDialog();
        }
        
    }
}
