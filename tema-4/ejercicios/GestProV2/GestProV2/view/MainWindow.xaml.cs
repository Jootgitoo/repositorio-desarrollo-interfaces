using GestProV2.domain;
using GestProV2.view;
using Mysqlx.Crud;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestProV2


{
    //ROLES INSERTADOS A MANO
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(1, 'Junior', 'Programador junior');
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(2, 'Medio', 'Programador nivel medio');
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(3, 'Senior', 'Programador senior');

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Proyecto> lstProyectos;
        private List<String> empresas;
        private List<Empleado> listaEmpleados;
        private Usuario usuario;
        private List<Usuario> listaUsuario;
        Random r = new Random();
        int contador = 0;
        DataTable tabla1;


        public MainWindow()
        {
            InitializeComponent();

            Proyecto proyecto = new Proyecto();
            proyecto.readProyectos();
            dgDatos.ItemsSource = proyecto.getListaProyectos();
            //lstProyectos = proyecto.getListaProyectos();


            Empleado empleado = new Empleado();
            //empleado.readEmpleados();

            //creo la lista de empresas y la relleno
            empresas = new List<String>();

            empresas.Add("Allegro");
            empresas.Add("Velneo");
            empresas.Add("SAP");
            empresas.Add("Naturgy");
            empresas.Add("Santander");
            empresas.Add("MutuaMadrileña");

            lstProyectos = new List<Proyecto>();
            listaUsuario = new List<Usuario>();
            listaEmpleados = new List<Empleado>();
            usuario = new Usuario();

            lstProyectos = proyecto.getListaProyectos();
            dgProyecto.ItemsSource = lstProyectos;

            listaUsuario = usuario.genListaUsuarios();
            dgUsuarios.ItemsSource = listaUsuario;

            listaEmpleados = empleado.genListaEmpleados();
            dgEmpleados.ItemsSource = listaEmpleados;

            cbProyectos.ItemsSource = lstProyectos;
            cbProyectos.DisplayMemberPath = "NombreProyecto";

            cbEmpleados.ItemsSource = listaEmpleados;
            cbEmpleados.DisplayMemberPath = "NombreEmpleado";

            //--------------------------------------------------------------------------------------------------------------
            //CrystalReport

            tabla1 = new DataTable("DataTable1");

            tabla1.Columns.Add("NombreProyecto");
            tabla1.Columns.Add("FechaProyecto");
            tabla1.Columns.Add("CsrProyecto");


            //AÑADIMOS LAS FILAS
            for (int i = 1; i <= 100; i++)
            {
                //creamos una fila de datos de la tabla creada
                DataRow row = tabla1.NewRow();
                row["NombreProyecto"] = "Jorge";
                row["FechaProyecto"] = "01/01/2000";
                row["CsrProyecto"] = "400";

                tabla1.Rows.Add(row);
            }

            informe_coste_proyectos report = new informe_coste_proyectos();
            report.Database.Tables["DataTable1"].SetDataSource(tabla1);

            reportViewer1.ViewerCore.ReportSource = report;
        }

        private void btnProyectos_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void start()
        {
            txtCodigoProyecto.Text = "";
            txtNombre.Text = "";
            dateFin.Text = "";
            dateInicio.Text = "";

            dgDatos.SelectedItems.Clear();
        }


        private void dgDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (dgDatos.SelectedItems.Count > 0)
            {

                Proyecto proyecto = (Proyecto)dgDatos.SelectedItems[0];
                txtCodigoProyecto.Text = proyecto.Codigo;
                txtNombre.Text = proyecto.NombreProyecto;
                dateInicio.SelectedDate = proyecto.fecIncio;
                dateFin.SelectedDate = proyecto.fecFin;

            }

        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (!btnModificar.Content.Equals("Actualizar"))
            {

                if (System.Windows.MessageBox.Show("Do you want to add this proyect?", "Confirmtion", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Proyecto p = new Proyecto(txtCodigoProyecto.Text, txtNombre.Text, dateInicio.SelectedDate.Value, dateFin.SelectedDate.Value);
                    p.insert();
                    p.last();

                    ((List<Proyecto>)dgDatos.ItemsSource).Add(p);
                    dgDatos.Items.Refresh();
                }

            }
            else
            {

                Proyecto pro = (Proyecto)dgDatos.SelectedItem;

                List<Proyecto> listProyecto = (List<Proyecto>)dgDatos.ItemsSource;

                listProyecto[dgDatos.SelectedIndex].codigo = txtCodigoProyecto.Text;
                listProyecto[dgDatos.SelectedIndex].nombreProyecto = txtNombre.Text;
                listProyecto[dgDatos.SelectedIndex].fecIncio = dateInicio.SelectedDate.Value;
                listProyecto[dgDatos.SelectedIndex].fecFin = dateFin.SelectedDate.Value;

                int idP = pro.id;
                String codPro = pro.codigo;
                String nombre = pro.nombreProyecto;
                DateTime fecIni = pro.fecIncio;
                DateTime fecFin = pro.fecFin;

                Proyecto p = new Proyecto(idP, nombre, codPro, fecIni, fecFin);

                p.update();

                dgDatos.Items.Refresh();

            }


        }
        
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

            if (System.Windows.MessageBox.Show("Do you wat to remove this project?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Proyecto proyecto = (Proyecto)dgDatos.SelectedItem;

                proyecto.delete();
                List<Proyecto> lstProyecto = (List<Proyecto>)dgDatos.ItemsSource;
                lstProyecto.Remove(proyecto);
                dgDatos.Items.Refresh();
                dgDatos.ItemsSource = lstProyecto;
                start();
            }

        }

        private void tboxBusqueda_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                RealizarBusqueda();
            }
        }

        private void txtBusqueda_TextChanged(object sender, TextChangedEventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string searchText = txtBusqueda.Text.Trim().ToLower();

            if (lstProyectos == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(searchText))
            {
                dgDatos.ItemsSource = lstProyectos;
            }
            else
            {
                //NO METO PARA BUSCAR LAS FECHAS
                var filteredList = lstProyectos.Where(proyecto =>
                    proyecto != null && (
                    proyecto.Codigo.ToString().ToLower().Contains(searchText) ||
                    (proyecto.NombreProyecto != null && proyecto.NombreProyecto.ToLower().Contains(searchText))
                    )
                ).ToList();

                dgDatos.ItemsSource = filteredList;
            }

            dgDatos.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int empresa = 0;
            List<Proyecto> proyectos = new List<Proyecto>();


            for (int i = 0; i < 20; i++)
            {
                Proyecto p = new Proyecto();

                empresa = r.Next(0, 5);
                contador = contador + 1;

                //p.codigo = "MTR" + contador + empresas[empresa] + DateTime.Now.Year.ToString();
                p.codigo = "MTR" + contador;
                p.nombreProyecto = empresas[empresa];
                p.fecIncio = DateTime.Now;
                p.fecFin = DateTime.Now;

                p.insert();
                p.last();


                proyectos.Add(p);


            }

            foreach (Proyecto pro in proyectos)
            {
                ((List<Proyecto>)dgDatos.ItemsSource).Add(pro);
                dgDatos.Items.Refresh();

            }

        }

        private void AddUsuario_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = new Usuario(tbNombreUsuario.Text, tbPasswordUsuario.Text);

            usuario.insertarUsuario();

            listaUsuario.Add(usuario);
            dgUsuarios.Items.Refresh();

        }


        private void AddEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.NombreEmpleado = tbNombreEmpleado.Text;
            empleado.ApellidoEmpleado = tbApellidoEmpleado.Text;
            empleado.CsrEmpleado = float.Parse(tbCsrEmpleado.Text);

            if (((ComboBoxItem)cbRol.SelectedItem).Content.ToString() == "Junior")
            {
                empleado.IdRol = 1;
            }
            else if (((ComboBoxItem)cbRol.SelectedItem).Content.ToString() == "Medio")
            {
                empleado.IdRol = 2;
            }
            else if (((ComboBoxItem)cbRol.SelectedItem).Content.ToString() == "Senior")
            {
                empleado.IdRol = 3;
            }

            empleado.IdUsuario = Int32.Parse(tbIdUsuario.Text);

            empleado.insertarEmpleado();

            listaEmpleados.Add(empleado);
            dgEmpleados.Items.Refresh();


            System.Windows.MessageBox.Show("Empleado añadido con éxito", "Aviso", MessageBoxButton.OK);

        }

        private void eliminarUsuario_Click(object sender, RoutedEventArgs e)
        {
            Usuario usuario = (Usuario) dgUsuarios.SelectedItem;
            usuario.eliminar();
            List<Usuario> newList = (List<Usuario>)dgUsuarios.ItemsSource;
            newList.Remove(usuario);
            dgDatos.Items.Refresh();
            dgDatos.ItemsSource = newList;

            System.Windows.MessageBox.Show("Usuario eliminado con exito", "Aviso", MessageBoxButton.OK);
        }

        private void eliminarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleado empleado = (Empleado)dgEmpleados.SelectedItem;
            empleado.eliminarEmpleado();

            List<Empleado> newList = (List<Empleado>)dgEmpleados.ItemsSource;
            newList.Remove(empleado);
            dgEmpleados.Items.Refresh();
            dgEmpleados.ItemsSource = newList;

            System.Windows.MessageBox.Show("Empleado eliminado con éxito", "Aviso", MessageBoxButton.OK);
        }


        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {

            Proyecto proyectoModificar = (Proyecto)dgDatos.SelectedItem;

            txtCodigoProyecto.Text = proyectoModificar.Codigo.ToString();
            txtNombre.Text = proyectoModificar.NombreProyecto.ToString();
            dateInicio.SelectedDate = proyectoModificar.FecInicio;
            dateFin.SelectedDate = proyectoModificar.FecFin;

            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;

            btnAgregar.Content = "Actualizar";

        }


        private void modificarUsuario_Click(object sender, RoutedEventArgs e)
        {

            Usuario u = (Usuario)dgUsuarios.SelectedItem;


            List<Usuario> newList = (List<Usuario>)dgUsuarios.ItemsSource;
            newList.Remove(u);


            Usuario usuario = new Usuario(tbNombreUsuario.Text, tbPasswordUsuario.Text);
            usuario.Id = u.Id;

            newList.Add(usuario);
            usuario.modificarUsuario();

            dgDatos.Items.Refresh();
            dgDatos.ItemsSource = newList;

            System.Windows.MessageBox.Show("Usuario modificado con éxito", "Aviso", MessageBoxButton.OK);

        }


        private void modificarEmpleado_Click(object sender, RoutedEventArgs e)
        {
            Empleado em = (Empleado)dgEmpleados.SelectedItem;

            List<Empleado> newList = (List<Empleado>) dgEmpleados.ItemsSource;
            newList.Remove(em);

            Empleado empleado = new Empleado(tbNombreEmpleado.Text, tbApellidoEmpleado.Text, float.Parse(tbCsrEmpleado.Text) );
            empleado.IdEmpleado = em.IdEmpleado;

            newList.Add(empleado);
            empleado.modificarEmpleado();

            dgEmpleados.Items.Refresh();
            dgEmpleados.ItemsSource = newList;

            System.Windows.MessageBox.Show("Empleado modificado con exito", "Aviso", MessageBoxButton.OK);

        }

        private void cbProyectos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}