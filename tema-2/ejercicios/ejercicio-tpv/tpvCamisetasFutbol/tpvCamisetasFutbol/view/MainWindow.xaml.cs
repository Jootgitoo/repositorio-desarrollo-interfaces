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
using tpvCamisetasFutbol.domain;

namespace tpvCamisetasFutbol
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Producto producto = new Producto(1, 30.00, "Primera quipacion FCB 24-25", 1);
            Producto producto1 = new Producto(2, 25.50, "Primera equipacion RM 24-25", 1);
            Producto producto2 = new Producto(3, 70.99, "Edicion limitada RM", 1);
            Producto producto3 = new Producto(4, 150.99, "Edicion limitada FCB", 1);
            Producto producto4 = new Producto(5, 25.99, "Primera equipacion ATM 24-25", 1);
            Producto producto5 = new Producto(6, 15.00, "Primera equipacion Albacete 24-25", 1);
            Producto producto6 = new Producto(7, 22.00, "Segunda equipacion Alavés 24-25", 1);
            Producto producto7 = new Producto(8, 30.00, "Primera equpacion Betis 24-25", 1);


           //producto.insertar();
            producto1.insertar();
            producto2.insertar();   
            producto3.insertar();
            producto4.insertar();
            producto5.insertar();
            producto6.insertar();
            producto7.insertar();
        }
    }
}
