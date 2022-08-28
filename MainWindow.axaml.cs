using Avalonia.Controls;

namespace Aval1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel2(); //Community Toolkit MVVM Version is added.
            //DataContext = new MainWindowViewModel();  //Tutorial's basic MVVM
        }
    }
}