using Mysqlx.Crud;
using proyectoExamen.domain;
using proyectoExamen.persistence.manages;
using proyectoExamen.reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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

namespace proyectoExamen
{
    //Interts bbdd
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(1, 'Junior', 'Programador junior');
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(2, 'Medio', 'Programador nivel medio');
    //INSERT INTO gestpro.rol(IdRol, NombreRol, DescripcionRol) VALUES(3, 'Senior', 'Programador senior');

    //insert into gestpro.usuario values(1, 'Jorge', 'Patata');

    //INSERT INTO gestpro.empleado VALUES(1, 'Jorge', 'Herrera', 3.5, 1, 1);

    //insert into gestpro.factura values (1, 'Fac1', 15000, 'Factura uno de prueba', 1);



    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        private List<Proyecto> lstProyectos;
        private List<String> empresas;
        private List<Empleado> listaEmpleados;
        private Usuario usuario;
        private List<Usuario> listaUsuario;
        Random r = new Random();
        int contador = 0;

        private Holiday holiday;
        private ProyectoEmpleadoManage pem;
        private List<Holiday> holidays;
        private List<ProyectoEmpleado> listaProyectoEmpleados;


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

            holiday = new Holiday();
            holidays = new List<Holiday>();
            listaProyectoEmpleados = new List<ProyectoEmpleado>();
            pem = new ProyectoEmpleadoManage();


            listaProyectoEmpleados = pem.leerEmpleados();
            dgProyecto.ItemsSource = listaProyectoEmpleados;


            //---------------------------------------------------------------------------------------------------
            //CRYSTALREPORT
            //inicializarCrystalReport();


        }

        private void inicializarCrystalReport()
        {
            DataTable tablaProyectoEmpleados = new DataTable("PROYECTOEMPLEADO");


            //Creamos las columnas
            tablaProyectoEmpleados.Columns.Add("FechaProyecto");
            tablaProyectoEmpleados.Columns.Add("NombreProyecto");
            tablaProyectoEmpleados.Columns.Add("Coste");


            foreach (ProyectoEmpleado pe in listaProyectoEmpleados)
            { //Por cada empleado que haya en la lista de empleados

                //Creo una fila nueva
                DataRow fila = tablaProyectoEmpleados.NewRow();

                fila["FechaProyecto"] = pe.Fecha;
                fila["NombreProyecto"] = pe.NombrePro;
                fila["Coste"] = pe.Coste;

                tablaProyectoEmpleados.Rows.Add(fila);
            }

            ReporteProyectoEmpleado reporteProyectoEmpleado = new ReporteProyectoEmpleado();
            reporteProyectoEmpleado.Database.Tables["PROYECTOEMPLEADO"].SetDataSource(tablaProyectoEmpleados);

            visorReporteProyEmple.ViewerCore.ReportSource = reporteProyectoEmpleado;

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
            if (btnModificar.IsEnabled)
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
            Usuario usuario = (Usuario)dgUsuarios.SelectedItem;
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

            List<Empleado> newList = (List<Empleado>)dgEmpleados.ItemsSource;
            newList.Remove(em);

            Empleado empleado = new Empleado(tbNombreEmpleado.Text, tbApellidoEmpleado.Text, float.Parse(tbCsrEmpleado.Text));
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

        private void cargarReporte_Click(object sender, RoutedEventArgs e)
        {
            inicializarCrystalReport();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string nombreUsuario = tbNombreUsuarioLogin.Text;
            string passwordEncriptada = EncryptMD5(tbPasswordUsuarioLogin.Text);
            string passwordNormal = tbPasswordUsuarioLogin.Text;

            foreach(Usuario u in listaUsuario)
            {
                if( u.Name.Equals(nombreUsuario)) //Si el nombre del usuario existe
                {

                    if ( u.Password.Equals(passwordNormal)) //Si la contraseña existe
                    {
                        //Deshabilito en la pantalla de login
                        tbNombreUsuarioLogin.IsEnabled = false;
                        tbPasswordUsuarioLogin.IsEnabled = false;
                        btnLogin.IsEnabled = false;

                        //Habilito las demás pantallas
                        itemInicio.IsEnabled = true;
                        itemProyecto.IsEnabled = true;
                        itemUsuarios.IsEnabled = true;
                        itemEmpleados.IsEnabled = true;
                        itemGestionEconomica.IsEnabled = true;
                        itemEstadisticas.IsEnabled = true;
                        itemProyectosEmpleados.IsEnabled = true;

                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Usuario encontrado pero contraseña incorrecta", "Aviso", MessageBoxButton.OK);
                    }

                }
            }
        }

        static string EncryptMD5(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void btnImputarHoras_Click(object sender, RoutedEventArgs e)
        {
            DateTime fecha = (DateTime)dpDiaAImputar.SelectedDate;
            if (await ComprobarFecha(fecha) == false)
            {
                Empleado emp = (Empleado)cbEmpleados.SelectedItem;
                Proyecto pro = (Proyecto)cbProyectos.SelectedItem;
                int horas = Convert.ToInt32(tbHoras.Text);
                ProyectoEmpleado proyectoEmpleado = new ProyectoEmpleado(pro.Id, pro.NombreProyecto, emp.NombreEmpleado, horas, emp.CsrEmpleado, fecha);
                proyectoEmpleado.idEmpleado = emp.IdEmpleado;
                proyectoEmpleado.idProyecto = pro.Id;
                proyectoEmpleado.insertar();
                listaProyectoEmpleados.Add(proyectoEmpleado);
                dgProyecto.ItemsSource = listaProyectoEmpleados;
                dgProyecto.Items.Refresh();

            }
            else
            {
                MessageBox.Show("No se puede añadir en dia festivo, seleccione otra fecha");
            }
        }

        private async Task<bool> ComprobarFecha(DateTime fecha)
        {
            bool festivo = false;
            int dia = fecha.Day;
            int mes = fecha.Month;
            int anio = fecha.Year;
            var holidays = await holiday.GetHolidays("ES", anio, mes, dia);
            if (holidays.Count > 0)
            {
                festivo = true;
            }
            return festivo;
        }

        private async void btnModificarGEconomica_Click(object sender, RoutedEventArgs e)
        {
            DateTime fecha = (DateTime)dpDiaAImputar.SelectedDate;
            if (await ComprobarFecha(fecha) == false)
            {
                ProyectoEmpleado proyectoEmpleado = dgProyecto.SelectedItem as ProyectoEmpleado;
                proyectoEmpleado.CodigoProyecto = ((Proyecto)cbProyectos.SelectedItem).id;
                proyectoEmpleado.NombrePro = ((Proyecto)cbProyectos.SelectedItem).NombreProyecto;
                proyectoEmpleado.NombreEmp = ((Empleado)cbEmpleados.SelectedItem).NombreEmpleado;
                proyectoEmpleado.Fecha = (DateTime)dpDiaAImputar.SelectedDate;
                proyectoEmpleado.Csr = ((Empleado)cbEmpleados.SelectedItem).CsrEmpleado;

                proyectoEmpleado.Horas = Convert.ToInt32(tbHoras.Text);
                proyectoEmpleado.Coste = proyectoEmpleado.Csr * proyectoEmpleado.Horas;
                dgProyecto.Items.Refresh();
            }
            else
            {
                MessageBox.Show("No se puede modificar en dia festivo, seleccione otra fecha");
            }
        }

        private void btnEliminarGEconomica_Click(object sender, RoutedEventArgs e)
        {
            ProyectoEmpleado proyectoEmpleado = dgProyecto.SelectedItem as ProyectoEmpleado;
            listaProyectoEmpleados.Remove(proyectoEmpleado);
            dgProyecto.Items.Refresh();
        }

        private void btnReporte2_Click(object sender, RoutedEventArgs e)
        {
            DataTable tblEmpleadosEnProyecto = new DataTable("EmpleadosEnProyecto");

            //Creamos las columnas
            tblEmpleadosEnProyecto.Columns.Add("nombreEmpleado");
            tblEmpleadosEnProyecto.Columns.Add("nombreProyecto");

            foreach (ProyectoEmpleado pe in listaProyectoEmpleados)
            { //Por cada empleado que haya en la lista de empleados

                //Creo una fila nueva
                DataRow fila = tblEmpleadosEnProyecto.NewRow();

                fila["nombreEmpleado"] = pe.NombreEmp;
                fila["nombreProyecto"] = pe.NombrePro;

                tblEmpleadosEnProyecto.Rows.Add(fila);
            }

            EmpleadosEnProyecto reporte = new EmpleadosEnProyecto();
            reporte.Database.Tables["EmpleadosEnProyecto"].SetDataSource(tblEmpleadosEnProyecto);

            visorEmpleadosEnProyecto.ViewerCore.ReportSource = reporte;
        }
    }
}
