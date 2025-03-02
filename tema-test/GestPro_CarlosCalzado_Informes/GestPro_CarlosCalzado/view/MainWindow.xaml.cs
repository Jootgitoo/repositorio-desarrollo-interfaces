using GestPro_CarlosCalzado.domain;
using GestPro_CarlosCalzado.view;
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

namespace GestPro_CarlosCalzado
{
    public partial class MainWindow : Window
    {
        private List<Proyecto> lstProyectos;
        private List<Usuario> lstUsuarios;
        private Proyecto proyecto;
        private Usuario usuario;
        List<String> empresas = new List<String>();
        private int cont = 0;
        public MainWindow()
        {
            InitializeComponent();
            lstProyectos = new List<Proyecto>();
            lstUsuarios = new List<Usuario>();

            proyecto = new Proyecto();
            usuario = new Usuario();

            lstProyectos = proyecto.getProyectos();
            lstUsuarios = usuario.getUsuarios();

            dgProyectos.ItemsSource = lstProyectos;
            dgUsuarios.ItemsSource = lstUsuarios;

            start();

            empresas.Add("allegro");
            empresas.Add("velneo");
            empresas.Add("SAP");
            empresas.Add("naturgy");
            empresas.Add("Santander");
            empresas.Add("mutuaMadrileña");

        }
        private void start()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtFechaI.Text = "";
            txtFechaF.Text = "";

            txtUsuario.Text = "";
            txtPassword.Text = "";

            dgProyectos.SelectedItems.Clear();
            dgUsuarios.SelectedItems.Clear();

            btnAnadir.IsEnabled = true;
            btnEliminar.IsEnabled = false;
            btnModificar.IsEnabled = false;

            BtnAltaUsu.IsEnabled = true;
            BtnModificarUsu.IsEnabled = false;
            BtnEliminarUsu.IsEnabled = false;
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            int codigo;
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtFechaI.Text) && !string.IsNullOrWhiteSpace(txtFechaF.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && int.TryParse(txtCodigo.Text, out codigo))
            {
                Proyecto proyecto = new Proyecto(codigo, txtNombre.Text, txtFechaI.Text, txtFechaF.Text);
                List<Proyecto> list = (List<Proyecto>)dgProyectos.ItemsSource;
                list.Add(proyecto);
                dgProyectos.Items.Refresh();
                dgProyectos.ItemsSource = list;
                start();
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Error");
            }
        }

        private void dgProyectos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgProyectos.SelectedItems.Count > 0)
            {
                Proyecto proyecto = (Proyecto)dgProyectos.SelectedItems[0];
                txtCodigo.Text = proyecto.Id.ToString();
                txtNombre.Text = proyecto.Nombre;
                txtFechaI.Text = proyecto.FechaI;
                txtFechaF.Text = proyecto.FechaF;

                btnAnadir.IsEnabled = false;
                btnEliminar.IsEnabled = true;
                btnModificar.IsEnabled = true;
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Quiere eliminar este proyecto?", "Confirmación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Proyecto proyecto = (Proyecto)dgProyectos.SelectedItem;
                List<Proyecto> lst = (List<Proyecto>)dgProyectos.ItemsSource;
                lst.Remove(proyecto);
                dgProyectos.Items.Refresh();
                dgProyectos.ItemsSource = lst;
                start();
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            int codigo;
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtFechaI.Text) && !string.IsNullOrWhiteSpace(txtFechaF.Text) && !string.IsNullOrWhiteSpace(txtNombre.Text) && int.TryParse(txtCodigo.Text, out codigo))
            {
                Proyecto proyectoV = (Proyecto)dgProyectos.SelectedItem;
                Proyecto proyectoN = new Proyecto(codigo, txtNombre.Text, txtFechaI.Text, txtFechaF.Text);
                List<Proyecto> list = (List<Proyecto>)dgProyectos.ItemsSource;
                int posicion = list.IndexOf(proyectoV);
                list.Remove(proyectoV);
                list.Insert(posicion, proyectoN);
                dgProyectos.Items.Refresh();
                dgProyectos.ItemsSource = list;
                start();
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Error");
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i<20; i++) {
            String codigo;
            Random random = new Random();
            int num = random.Next(0, empresas.Count);
            codigo = "MTR" + cont + empresas[num] + DateTime.Now.Year;
            Proyecto proyecto = new Proyecto(codigo, empresas[num], "desc", 0.0);
            cont++;
            proyecto.insertar();

            }
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgUsuarios.SelectedItems.Count > 0)
            {
                Usuario usuario = (Usuario)dgUsuarios.SelectedItems[0];
                txtUsuario.Text = usuario.NombreUsuario;
                txtPassword.Text = usuario.PassUsuario;

                BtnAltaUsu.IsEnabled = false;
                BtnModificarUsu.IsEnabled = true;
                BtnEliminarUsu.IsEnabled = true;
                txtUsuario.IsEnabled = false;
            }
        }

        private void BtnAltaUsu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Usuario usuario = new Usuario(txtUsuario.Text,txtPassword.Text);
                List<Usuario> list = (List<Usuario>)dgUsuarios.ItemsSource;
                list.Add(usuario);
                usuario.insertar();
                dgUsuarios.Items.Refresh();
                dgUsuarios.ItemsSource = list;
                start();
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Error");
            }
        }

        private void BtnEliminarUsu_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Quiere eliminar este usuario?", "Confirmación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Usuario usuario = (Usuario)dgUsuarios.SelectedItem;
                List<Usuario> lst = (List<Usuario>)dgUsuarios.ItemsSource;
                lst.Remove(usuario);
                usuario.eliminar();
                dgUsuarios.Items.Refresh();
                dgUsuarios.ItemsSource = lst;
                start();
            }
        }

        private void BtnModificarUsu_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Usuario usuarioV = (Usuario)dgUsuarios.SelectedItem;
                Usuario usuarioN = new Usuario(txtUsuario.Text, txtPassword.Text);
                List<Usuario> list = (List<Usuario>)dgUsuarios.ItemsSource;
                int posicion = list.IndexOf(usuarioV);
                list.Remove(usuarioV);
                list.Insert(posicion, usuarioN);
                usuarioN.actualizar();
                dgUsuarios.Items.Refresh();
                dgUsuarios.ItemsSource = list;
                start();
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Error");
            }
        }

        private void dgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgEmpleados.SelectedItems.Count > 0)
            {
                Empleado empleado = (Empleado)dgEmpleados.SelectedItems[0];
                txtNombreEmpleado.Text = empleado.NombreEmpleado;
                txtApellidosEmpleado.Text = empleado.ApellidosEmpleado;
                txtCSR.Text = empleado.CSR.ToString();
            }
        }

        private void btnAnadirEmp_Click(object sender, RoutedEventArgs e)
        {
            double csr;
            if (!string.IsNullOrWhiteSpace(txtNombreEmpleado.Text) && !string.IsNullOrWhiteSpace(txtApellidosEmpleado.Text) && double.TryParse(txtCSR.Text, out csr))
            {
                Empleado empleado = new Empleado(txtNombreEmpleado.Text, txtApellidosEmpleado.Text, cmbRol.SelectedIndex+1, Convert.ToDouble(txtCSR.Text), 1);
                List<Empleado> list = (List<Empleado>)dgEmpleados.ItemsSource;
                empleado.insertar();
                list.Add(empleado);
                
                dgEmpleados.Items.Refresh();
                dgEmpleados.ItemsSource = list;
                start();
            }
            else
            {
                MessageBox.Show("Datos no válidos", "Error");
            }
        }

        private void btnMostrarInforme_Click(object sender, RoutedEventArgs e)
        {
            if (cmbInformes.SelectedIndex == 0) {
                VentanaInformeIngresosProyectos informe1 = new VentanaInformeIngresosProyectos();
                informe1.Show();
                this.Close();
            }
            else { 
                
            }
        }
    }
}
