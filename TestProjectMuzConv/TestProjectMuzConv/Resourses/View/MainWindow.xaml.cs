using System.Windows;
using TestProjectMuzConv.Resourses.ViewModels;

namespace TestProjectMuzConv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new LoginViewModel();
        }
    }
}
