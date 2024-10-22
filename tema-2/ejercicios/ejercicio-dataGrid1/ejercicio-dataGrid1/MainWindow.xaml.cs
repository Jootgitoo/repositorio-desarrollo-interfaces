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

namespace ejercicio_dataGrid1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Persona> listaPersonas;
        
        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();

            dgvPersonas.Items.Clear();
            
            dgvPersonas.ItemsSource = listaPersonas;

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.Add(new Persona(txtNombre.Text, txtApellidos.Text,int.Parse(txtEdad.Text)));
            dgvPersonas.Items.Refresh();
        }

        /*
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Quieres añadir esta persona?", "Confirmacion", MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
            { 
                (( List<Persona> ) dgvPersonas.ItemsSource).Add(new Persona(txtNombre.Text, txtApellidos.Text, Int32.Parse(txtEdad.Text)));
                dgvPersonas.Items.Refresh();
            }
        */

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            Persona persElegida = (Persona)dgvPersonas.SelectedItem;
            txtNombre.Text = persElegida.Nombre;
            txtApellidos.Text = persElegida.Apellidos;
            txtEdad.Text = persElegida.Edad.ToString();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.Remove((Persona) dgvPersonas.SelectedItem);
            dgvPersonas.Items.Refresh();
        }
    }
}