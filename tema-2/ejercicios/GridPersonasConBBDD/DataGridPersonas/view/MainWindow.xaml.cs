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


namespace DataGridPersonas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Persona> lstPersonas;
        public MainWindow()
        {
            InitializeComponent();
            lstPersonas = new List<Persona>();
            //Load default values
            lstPersonas = PersonasPersistance.leerPersonas();

            dgvPersonas.ItemsSource = lstPersonas;

        }

        private void bntAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (Modificar.IsEnabled == false)
            {
                lstPersonas.Remove((Persona)dgvPersonas.SelectedItem);
                dgvPersonas.Items.Refresh();
                lstPersonas.Add(new Persona(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text)));

                //Same code using LINQ expresion over the list
                lstPersonas.Where(p => p.Nombre == txtNombre.Text && p.Apellidos == txtApellidos.Text)
                    .ToList().ForEach(p =>
                {
                    p.Nombre = txtNombre.Text;
                    p.Apellidos = txtApellidos.Text;
                    p.Edad = int.Parse(txtEdad.Text);
                });

                dgvPersonas.Items.Refresh();
                txtEdad.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                Modificar.IsEnabled = true;
                bntEliminar.IsEnabled = true;
                bntAgregar.Content = "Agregar Personas";
            } else {
                if (lstPersonas.Where(p =>  p.Nombre.Equals(txtNombre.Text) && 
                                         p.Apellidos.Equals(txtApellidos.Text)).ToList().Any() == false) //If not exist
                    lstPersonas.Add(new Persona(txtNombre.Text, txtApellidos.Text, int.Parse(txtEdad.Text)));
                else
                    MessageBox.Show("La persona ya existe en la lista de persona. No se añade de nuevo.");
                
                dgvPersonas.Items.Refresh();
                txtEdad.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
            }
        }

        private void Modificar_Click(object sender, RoutedEventArgs e)
        {
            Persona persElegida = (Persona)dgvPersonas.SelectedItem;
            txtNombre.Text = persElegida.Nombre;
            txtApellidos.Text = persElegida.Apellidos;
            txtEdad.Text=persElegida.Edad.ToString();
            Modificar.IsEnabled = false;
            bntEliminar.IsEnabled = false;
            bntAgregar.Content = "Actualizar Datos";

        }

        private void bntEliminar_Click(object sender, RoutedEventArgs e)
        {
            lstPersonas.Remove((Persona)dgvPersonas.SelectedItem);
            dgvPersonas.Items.Refresh();
        }
    }
}
