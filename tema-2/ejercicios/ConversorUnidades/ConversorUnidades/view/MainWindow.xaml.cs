using ConversorUnidades.domain;
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

namespace ConversorUnidades
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

        private void btConvertir_Click(object sender, RoutedEventArgs e)
        {

            double resultadoInicial = double.Parse(tboxNumero.Text);
            string unidadPrincipal = cb1.SelectedItem.ToString();
            string unidadFinal = cb2.SelectedItem.ToString();

            double resultadoFinal = 0;

            if(unidadPrincipal.Equals("Metros") && unidadFinal.Equals("Kilometros"))
            {
                resultadoFinal = conversioncambioMetrosKilometros(resultadoInicial);

                tbResultado.Text = resultadoFinal.ToString("0.0000");

            } else if (unidadPrincipal == "Kilometros" && unidadFinal == "Metros")
            {
                resultadoFinal = cambioKilometrosMetros(resultadoInicial);

                tbResultado.Text = resultadoFinal.ToString("0.0000");

            } else
            {
                MessageBox.Show("Seleccione unidades de medida diferentes", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Conversiones conversion = new Conversiones(resultadoInicial, unidadPrincipal, resultadoFinal, unidadFinal);
            conversion.insertar();
        }

        private double conversioncambioMetrosKilometros(double resultadoInicial)
        {
            double resultado = 0;

            resultado = resultadoInicial / 1000;

            return resultado;
        }

        private double cambioKilometrosMetros(double resultadoInicial)
        {
            double resultado = 0;

            resultado = resultadoInicial * 1000;

            return resultado;
        }
    }
}