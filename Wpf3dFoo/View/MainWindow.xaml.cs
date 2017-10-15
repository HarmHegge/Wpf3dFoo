using HHE.Wpf3dFoo.ViewModel;
using System.Windows;

namespace HHE.Wpf3dFoo.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new MainViewModel();

            InitializeComponent();
        }
    }
}
