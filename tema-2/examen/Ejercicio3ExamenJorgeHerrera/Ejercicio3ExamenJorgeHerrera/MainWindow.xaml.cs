using Ejercicio3ExamenJorgeHerrera.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ejercicio3ExamenJorgeHerrera
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Tripulante> listaTripulantes;
        private Tripulante tripulante;

        public MainWindow()
        {
            InitializeComponent();
            listaTripulantes = new List<Tripulante>();
            tripulante = new Tripulante();

            //listaTripulantes = tripulante.genListaTripulantes();

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            tripulante = new Tripulante(boxDNI.Text, boxName.Text, boxSurname.Text, int.Parse(boxAge.Text), boxBirth.Text, boxCrewCharge.Text);
            tripulante.insertar();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            tripulante = new Tripulante(boxDNI.Text, boxName.Text, boxSurname.Text, int.Parse(boxAge.Text), boxBirth.Text, boxCrewCharge.Text);
            tripulante.modificar();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            tripulante = new Tripulante(boxDNI.Text, boxName.Text, boxSurname.Text, int.Parse(boxAge.Text), boxBirth.Text, boxCrewCharge.Text);
            tripulante.eliminar();
        }
    }
}
