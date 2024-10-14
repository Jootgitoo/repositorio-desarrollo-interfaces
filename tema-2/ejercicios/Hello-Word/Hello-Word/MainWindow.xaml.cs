using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Hello_Word
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

        private void Button_Hello(object sender, RoutedEventArgs e)
        {
            texto.Content = "Hello World";

        }

        private void Button_Bye(object sender, RoutedEventArgs e)
        {
            texto.Content = "Bye world";
        }

        
    }
}