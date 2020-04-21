using System.Windows;
using TestProjectMuzConv.Resourses.ViewModels;

namespace TestProjectMuzConv.Resourses.View
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();

            DataContext = new SignUp();
        }
    }
}
