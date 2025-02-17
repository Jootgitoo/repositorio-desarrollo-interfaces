using proyectoExamen.domain;
using proyectoExamen.reports;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace proyectoExamen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Cliente> listaClientes;
        List<Pedido> listaPedidos;

        public MainWindow()
        {
            InitializeComponent();

            listaClientes = new List<Cliente>();
            listaPedidos = new List<Pedido>();

            Cliente cliente = new Cliente();
            listaClientes = cliente.genListaClientes();
            dgClientes.ItemsSource = listaClientes;

            Pedido pedido = new Pedido();
            listaPedidos = pedido.genListaPedidos();
            dgPedidos.ItemsSource = listaPedidos;
        }

        private void insertarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente(tbNombreCliente.Text, tbEmailCliente.Text);

            c.insertarCliente();

            listaClientes.Add(c);

            dgClientes.Items.Refresh();

            limpiarCamposClientes();
        }

        private void btnCrearPedido_Click(object sender, RoutedEventArgs e)
        {
            Pedido p = new Pedido(Convert.ToDateTime(tbFechaPedido.Text), Convert.ToDouble(tbTotalPedido.Text), Convert.ToInt32(tbIdCliente.Text) );

            p.insertarPedido();

            listaPedidos.Add(p);
            dgPedidos.Items.Refresh();
            limpiarCamposPedidos();
        }

        private void limpiarCamposClientes()
        {
            tbNombreCliente.Text = "";
            tbEmailCliente.Text = "";
        }

        private void limpiarCamposPedidos()
        {
            tbTotalPedido.Text = "";
            tbFechaPedido.Text = "";
        }

        private void borrarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = (Cliente)dgClientes.SelectedItem;
            c.eliminarCliente();

            List<Cliente> newList = (List<Cliente>)dgClientes.ItemsSource;
            newList.Remove(c);
            dgClientes.Items.Refresh();
            dgClientes.ItemsSource = newList;

            limpiarCamposClientes();
        }

        private void btnBorrarPedido_Click(object sender, RoutedEventArgs e)
        {
            Pedido p = (Pedido)dgPedidos.SelectedItem;
            p.eliminarPedido();

            List<Pedido> newList = (List<Pedido>)dgPedidos.ItemsSource;
            newList.Remove(p);
            dgPedidos.Items.Refresh();
            dgPedidos.ItemsSource = newList;

            limpiarCamposPedidos();
        }

        private void modificarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = (Cliente)dgClientes.SelectedItem;
            List<Cliente> newList = (List<Cliente>)dgClientes.ItemsSource;
            newList.Remove(c);

            Cliente cliente = new Cliente(tbNombreCliente.Text, tbEmailCliente.Text);
            cliente.IdCliente = c.IdCliente;

            newList.Add(cliente);
            cliente.modificarCliente();

            dgClientes.Items.Refresh();
            dgClientes.ItemsSource = newList;

            limpiarCamposClientes();
        }

        private void modificarPedido_Click(object sender, RoutedEventArgs e)
        {
            Pedido p = (Pedido)dgPedidos.SelectedItem;
            List<Pedido> newList = (List<Pedido>)dgPedidos.ItemsSource;
            newList.Remove(p);

            Pedido pedido = new Pedido(Convert.ToDateTime(tbFechaPedido.Text), Convert.ToDouble(tbTotalPedido.Text), Convert.ToInt32(tbIdCliente.Text));
            pedido.IdPedido = p.IdPedido;

            newList.Add(pedido);
            pedido.modificarPedido();

            dgPedidos.Items.Refresh();
            dgPedidos.ItemsSource = newList;

            limpiarCamposPedidos();
        }

        private void cargarReporteClientes_Click(object sender, RoutedEventArgs e)
        {
            DataTable tablaClientes = new DataTable("Clientes");

            tablaClientes.Columns.Add("NombreCliente");
            tablaClientes.Columns.Add("EmailCliente");

            foreach(Cliente c in listaClientes)
            {
                DataRow row = tablaClientes.NewRow();
                row["NombreCliente"] = c.NombreCliente;
                row["EmailCliente"] = c.EmailCliente;
                tablaClientes.Rows.Add(row);
            }

            ReporteClientes reporteClientes = new ReporteClientes();
            reporteClientes.Database.Tables["Clientes"].SetDataSource(tablaClientes);

            reportClientes.ViewerCore.ReportSource = reporteClientes;

        }

        private void cargarReportePedidos_Click(object sender, RoutedEventArgs e)
        {
            DataTable tablaPedidos = new DataTable("Pedidos");
            tablaPedidos.Columns.Add("FechaPedido");
            tablaPedidos.Columns.Add("Total");

            foreach (Pedido p in listaPedidos)
            {
                DataRow row = tablaPedidos.NewRow();
                row["FechaPedido"] = p.FechaPedido;
                row["Total"] = p.Total;
                tablaPedidos.Rows.Add(row);
            }

            ReportePedidos reportePedidos = new ReportePedidos();
            reportePedidos.Database.Tables["Pedidos"].SetDataSource(tablaPedidos);

            reportPedidos.ViewerCore.ReportSource = reportePedidos;
        }
    }
}
