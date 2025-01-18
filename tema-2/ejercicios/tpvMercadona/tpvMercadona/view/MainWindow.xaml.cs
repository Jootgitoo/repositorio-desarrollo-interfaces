using System.Collections.ObjectModel;
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
using tpvMercadona.persistence;

namespace tpvMercadona
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Producto> listaProductos;
        public MainWindow()
        {
            InitializeComponent();

            listaProductos = new ObservableCollection<Producto>();

            dgListaProductos.ItemsSource = listaProductos;
        }

        private void btnCarne_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto( "Carne", 50.00);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnCereales_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Cereales", 9.78);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnPan_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Pan", 15.70);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnChuches_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Chuches", 7.77);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnColonia_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Colonia", 100.00);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnDesodorante_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Desodorante", 50.00);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnJabon_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Jabon", 16.99);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }

        private void btnPastaDientes_Click(object sender, RoutedEventArgs e)
        {
            Producto producto = new Producto("Pasta de dientes", 50.00);

            listaProductos.Add(producto);

            dgListaProductos.Items.Refresh();
        }
    }
}