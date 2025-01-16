using RegistroPedidosBBDD.Domain;
using RegistroPedidosBBDD.Persistence;
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

namespace RegistroPedidosBBDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        private List<String> listaProductos;
        int lastId;

        public MainWindow()
        {
            InitializeComponent();

            listaProductos = new List<String>();
        }

        private void Button_AddProducto(object sender, RoutedEventArgs e)
        {
            string productoUsuario = tbProductosAComprar.Text.ToString();
            listaProductos.Add(productoUsuario);
        }

        private void Button_pagar(object sender, RoutedEventArgs e)
        {
            Pedido pedido = new Pedido();

            pedido.NombreCliente = tbNombreCliente.Text.ToString();

            pedido.insertarPedido();

        }

        
    }
}