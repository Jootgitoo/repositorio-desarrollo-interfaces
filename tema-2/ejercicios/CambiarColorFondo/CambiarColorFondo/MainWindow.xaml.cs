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

namespace CambiarColorFondo
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

        private void btnAmarillo_Click(object sender, RoutedEventArgs e)
        {
            gridPrincipal.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {
            gridPrincipal.Background = new SolidColorBrush(Colors.Green);

        }

        private void btnVeige_Click(object sender, RoutedEventArgs e)
        {
            gridPrincipal.Background = new SolidColorBrush(Colors.Beige);
        }
    }
}