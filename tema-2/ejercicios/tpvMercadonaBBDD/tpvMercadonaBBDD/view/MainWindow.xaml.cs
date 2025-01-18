using System.Security.Cryptography.Pkcs;
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
using tpvMercadonaBBDD.domain;

namespace tpvMercadonaBBDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Producto> listaProductos;
        public MainWindow()
        {
            InitializeComponent();

            listaProductos = new List<Producto>();
/*
            //Productos que he añadido a la bddd
                //Comida
            Producto p1 = new Producto("Carne", 50.00);
            Producto p2 = new Producto("Cereales", 9.78);
            Producto p3 = new Producto("Pan", 15.70);
            Producto p4 = new Producto("Chuches", 7.77);
                //Cosmeticos
            Producto p5 = new Producto("Colonia", 100.00);
            Producto p6 = new Producto("Desodorante", 50.00);
            Producto p7 = new Producto("Jabon", 16.99);
            Producto p8 = new Producto("PastaDientes", 1.78);

            p1.insertarProducto();
            p2.insertarProducto();
            p3.insertarProducto();
            p4.insertarProducto();
            p5.insertarProducto();
            p6.insertarProducto();
            p7.insertarProducto();
            p8.insertarProducto();
*/

        }
        private void btnCarne_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Carne");

            foreach(Producto pAux in lp)
            {

                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);

            }
        }

        private void btnCereales_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Cereales");

            foreach(Producto pAux in lp){

                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }

        }

        private void btnPan_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Pan");

            foreach (Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }
            
        }

        private void btnChuches_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Chuches");

            foreach (Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }
        }

        private void btnColonia_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Colonia");

            foreach (Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }
            
        }

        private void btnDesodorante_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Desodorante");

            foreach(Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }

        }

        private void btnJabon_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("Jabon");

            foreach(Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }

        }

        private void btnPastaDientes_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();

            List<Producto> lp = p.encontrar("PastaDientes");


            foreach (Producto pAux in lp)
            {
                listaProductos.Add(pAux);
                dgListaProductos.Items.Add(pAux);
            }
        }
    }
}