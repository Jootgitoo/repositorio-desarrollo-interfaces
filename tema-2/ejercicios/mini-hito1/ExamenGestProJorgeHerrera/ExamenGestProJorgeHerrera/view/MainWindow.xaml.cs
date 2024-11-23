using ExamenGestProJorgeHerrera.manages;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace ExamenGestProJorgeHerrera
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Proyecto p = new Proyecto(); 


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void addProyect(object sender, RoutedEventArgs e)
        {
            string format = "dd/MM/YYYY";

            string nombreProyecto = txtProyectName.Text;

            string fechaComienzo = txtfechaInicio.Text;
            DateTime dtFechaComienzo = DateTime.ParseExact(fechaComienzo, format, CultureInfo.InvariantCulture);

            string fechaFinal = txtFechaFin.Text;
            DateTime dtFechaFin = DateTime.ParseExact(fechaFinal, format, CultureInfo.InvariantCulture);

            string fechaCreacion = txtCreationTime.Text;
            DateTime dtFechaCreacion = DateTime.ParseExact(fechaCreacion, format, CultureInfo.InvariantCulture);

            Proyecto proyecto = new Proyecto(nombreProyecto, dtFechaComienzo, dtFechaFin, dtFechaCreacion);
            proyecto.insert(proyecto);
        }

        private void modifyProyect(object sender, RoutedEventArgs e)
        {

        }

        private void deleteProyect(object sender, RoutedEventArgs e)
        {

        }


        /*private void addPredefinedProyect(object sender, RoutedEventArgs e)
        {
            p.insertarProyecto();
        }
        */






        /*        private void Button_Add_Click(object sender, RoutedEventArgs e)
                {

                    lstProyecto.Where(p => p.codigoProyecto == txtCodigoProyecto.Text && p.Nombre == txtNombre.Text)
                        .ToList().ForEach(p =>
                        {
                            p.Nombre = txtNombre.Text;
                            p.Apellidos = txtApellidos.Text;
                            p.Edad = int.Parse(txtEdad.Text);
                        });
                }

        */
    }
}
