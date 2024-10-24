using System.Diagnostics.Eventing.Reader;
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
            if (listaPersonas.Where(p => p.Nombre == txtNombre.Text && p.Apellidos == txtApellidos.Text).ToList().Any() )
            {
                listaPersonas.Where(p => p.Nombre.Equals(txtNombre.Text) && p.Apellidos.Equals(txtApellidos.Text)).ToList().ForEach(p =>
                {
                    p.Nombre = txtNombre.Text;
                    p.Apellidos = txtApellidos.Text;
                    p.Edad = int.Parse(txtEdad.Text);
                });

                dgvPersonas.Items.Refresh();
                txtEdad.Clear();
                txtApellidos.Clear();

                btnModificar.IsEnabled = true;
                btnEliminar.IsEnabled = true;

            } else
            {
                if (listaPersonas.Where(p => p.Nombre.Equals(txtNombre.Text) && p.Apellidos.Equals(txtApellidos.Text)).ToList().Any() == false) {

                    listaPersonas.Add(new Persona(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text)));

                } else
                {
                    MessageBox.Show("La persona ya existe en la lista de personas. No se añade de nuevo");
                    dgvPersonas.Items.Refresh();
                    txtEdad.Clear();
                    txtNombre.Clear();
                    txtApellidos.Clear();

                }

            } 
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.Remove((Persona) dgvPersonas.SelectedItem);
            dgvPersonas.Items.Refresh();
        }
    }
}