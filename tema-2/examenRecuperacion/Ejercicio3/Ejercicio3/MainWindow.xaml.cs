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
using Ejercicio3.domain;

namespace Ejercicio3
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string nombreJugador = tbNivelJuagdor.Text;
            DateTime fechaActual = DateTime.Now;
            int nivel = int.Parse( tbNivelJuagdor.Text );
            int puntuacion = int.Parse( tbPuntuacion.Text);

            Jugador j = new Jugador(nombreJugador, fechaActual, nivel, puntuacion);
            j.insertar();

        }


    }
}