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

namespace MayorMenor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /**
         * SI LAS IMAGENES NO CARGAN
         *  - CLICK DERECHO EN LA IMAGEN
         *  - PROPIEDADES
         *  - ACCIÓN DE COMPILACION --> RECURSO
         */

        int numeroAleatorio;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, RoutedEventArgs e)
        {
            int numeroMinimo = Int32.Parse( tbNumeroMenor.Text.ToString() );
            int numeroMaximo = Int32.Parse( tbNumeroMayor.Text.ToString() );

            Random rnd = new Random();
            numeroAleatorio = rnd.Next(numeroMinimo, numeroMaximo);

        }

        private void Button_ComprobarNumero_Click(object sender, RoutedEventArgs e)
        {
            int numeroDichoUsuario = Int32.Parse(tbNumeroDichoUsuario.Text.ToString());

            if(numeroDichoUsuario > numeroAleatorio)
            {
                MessageBox.Show("El numero dicho es mayor que el aleatorio", "OK", MessageBoxButton.OK);

            } else if(numeroDichoUsuario < numeroAleatorio)
            {
                MessageBox.Show("El numero dicho es menor que el aleatorio", "OK", MessageBoxButton.OK);

            } else{
                MessageBox.Show("Has acertado el numero!", "OK", MessageBoxButton.OK);
            }
        }
    }
}