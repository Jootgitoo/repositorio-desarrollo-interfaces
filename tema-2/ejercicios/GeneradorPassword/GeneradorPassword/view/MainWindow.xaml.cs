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

        private List<string> _arrayPasswords;

        public MainWindow()
        {
            InitializeComponent();

            _arrayPasswords = new List<string>();

        }

        private void btnGenerarPassword_Click(object sender, RoutedEventArgs e)
        {
            
            int longitudPassword = int.Parse(tbLongitudPassword.Text);
            int numeroPasswords = int.Parse(tboxNumeroPassword.Text);

            string[] aux = new string[numeroPasswords];

            aux = Operaciones.generarPassword(longitudPassword, numeroPasswords);

            foreach(string s in aux)
            {
                _arrayPasswords.Add(s);
            }

            dgPassword.ItemsSource = null;
            dgPassword.ItemsSource = _arrayPasswords;
            
        }

    }
}