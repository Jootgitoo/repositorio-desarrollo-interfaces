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

namespace registro_alumnos
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

        private void botonRegistrar_Click(object sender, RoutedEventArgs e)
        {
            //Crea una nueva ventana que enseña el contenido que tiene tbNombre
            MessageBox.Show(tbNombre.Text + " se ha registrado correctamente");
        }

        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            //Se cierra del programa
            App.Current.Shutdown();
        }
    }
}