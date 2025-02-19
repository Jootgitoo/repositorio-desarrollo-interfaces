﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private List<Producto> listaProducto; 
        private List<Producto> newList;

        public MainWindow()
        {
            InitializeComponent();
            listaProducto = new List<Producto>();
            newList = new List<Producto>();


            //PRODUCTOS QUE HE AÑADIDO EN LA BBDD
            /*
            Producto producto = new Producto(1, 30.75, "Primera quipacion FCB 24-25", 1);
            Producto producto1 = new Producto(2, 25.50, "Primera equipacion RM 24-25", 1);
            Producto producto2 = new Producto(3, 70.99, "Edicion limitada RM", 1);
            Producto producto3 = new Producto(4, 150.99, "Edicion limitada FCB", 1);
            Producto producto4 = new Producto(5, 25.99, "Primera equipacion ATM 24-25", 1);
            Producto producto5 = new Producto(6, 15.00, "Primera equipacion Albacete 24-25", 1);
            Producto producto6 = new Producto(7, 22.00, "Segunda equipacion Alavés 24-25", 1);
            Producto producto7 = new Producto(8, 30.00, "Primera equpacion Betis 24-25", 1);
            


            producto.insertar();
            producto1.insertar();
            producto2.insertar();   
            producto3.insertar();
            producto4.insertar();
            producto5.insertar();
            producto6.insertar();
            producto7.insertar();
            

            Producto producto8 = new Producto(9, 200.00, "Edicion Limitada España", 1);
            producto8.insertar();   
            */
        }

        /// <summary>
        ///     Boton para añadir la equipacion en el data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void botonProducto1(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(1);

            List<Producto> list = prod.encontrar( prod.IdProducto );

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }

        }

        private void botonProducto2(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(2);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto3(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(3);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto4(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(4);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto5(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(5);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el subtotal
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto6(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(6);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto7(object sender, RoutedEventArgs e)
        {
            Producto prod = new Producto(7);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            {

                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }
        private void botonProducto8(object sender, RoutedEventArgs e)
        {

            Producto prod = new Producto(8);

            List<Producto> list = prod.encontrar(prod.IdProducto);

            foreach (Producto pAux in list)
            { 


                listaProducto.Add(pAux);
                dgCamisetas.Items.Add(pAux);

                //Sumamos los precios de los productos en la lista
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");  // Usa "0.00" para mostrar siempre los centimos 
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }
        }

        private void boton_Cajon(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Abriendo cajón para el cambio en efectivo", "Cajon abierto", MessageBoxButton.OK);
        }

        
        private void botonEliminar(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("¿ Quiere eliminar esta persona?", "Confirmación", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Producto producto = (Producto)dgCamisetas.SelectedItem;

                listaProducto.Remove(producto);

                //Vacio la lista
                dgCamisetas.Items.Clear();

                //Le asigno una lista al data grid
                dgCamisetas.ItemsSource = listaProducto;

                //Refresco para que salgan los items
                dgCamisetas.Items.Refresh();

                //Sumamos los precios de los productos en la lista sin el producto eliminado
                double precioTotal = listaProducto.Sum(p => p.Precio);

                //Mostramos el total en el TextBox
                tbSubtotal.Text = precioTotal.ToString("0.00");
                tbPrecioTotal.Text = precioTotal.ToString("0.00");

            }

        }
        

        private void botonPagar(object sender, RoutedEventArgs e)
        {
            Ticket ticket = new Ticket();

            //Saco la fecha actual
            DateTime fechaActual = DateTime.Now;
            ticket.Fecha = fechaActual.Date;

            ticket.Total = Double.Parse(tbPrecioTotal.Text);

            ticket.insertar();
            MessageBox.Show("Ticket creado correctamente", "Confirmación", MessageBoxButton.OK);

            limpiarCampos();
        }

        private void limpiarCampos()
        {
            tbSubtotal.Text = "";
            tbDescuento.Text = "";
            tbPrecioTotal.Text = "";

            listaProducto.Clear();
            dgCamisetas.Items.Clear();
        }
    }
}
