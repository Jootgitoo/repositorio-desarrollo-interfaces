using GeneradorPassword.domain;
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

namespace GeneradorPassword
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

        private void btnGenerarPassword_Click(object sender, RoutedEventArgs e)
        {
            
            int longitudPassword = int.Parse(tbLongitudPassword.Text);
            int numeroPasswords = int.Parse(tboxNumeroPassword.Text);

            Password[] passwords = new Password[numeroPasswords];

            passwords = Password.generarPassword(longitudPassword, numeroPasswords);

            dgPassword.ItemsSource = null;
            dgPassword.ItemsSource = passwords;
            
            
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generar contraseñas seguras ayuda a que no te hacken las cuentas :)", "Advertencia", MessageBoxButton.OK);
        }
    }
}