using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosListasDinamicas.Ejercicio1
{   
    internal class Producto
    {
        //ATRIBUTOS
        private int codigo;
        private string nombre;
        private double precio;
        private int cantidadStock;

        LinkedList<Producto> listaProductos;
//-------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR
        
        public Producto()
        {
            listaProductos = new LinkedList<Producto>();
        }

        public Producto(int codigo, string nombre, double precio, int cantidadStock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidadStock = cantidadStock;

            listaProductos = new LinkedList<Producto>();
        }   

//----------------------------------------------------------------------------------------------------------
        //MÉTODOS

        /// <summary>
        ///     Añades un producto al final de la lista
        /// </summary>
        /// <param name="producto">
        ///     Producto que vas a añadir
        /// </param>
        public void addProductoFinal(Producto producto)
        {
            listaProductos.AddLast(producto);
            Console.WriteLine("Producto añadido al final con exito");
        }


        /// <summary>
        ///     Añades un producto al principio de la lista
        /// </summary>
        /// <param name="producto">
        ///     Producto que vas a añadir
        /// </param>
        public void addProductoInicio(Producto producto)
        {
            listaProductos.AddFirst(producto);
            Console.WriteLine("Producto añadido al principio con exito");

        }


        /// <summary>
        ///     Buscas un producto por su codigo
        /// </summary>
        /// <param name="codigo">
        ///     Codigo con el que vas a buscar el producto
        /// </param>
        public void buscarPorCodigo(int codigo)
        {

            foreach (Producto p in listaProductos)
            {
                if (p.Codigo == codigo)
                {
                    Console.WriteLine("Producto encontrado: ");
                    Console.WriteLine("--> Codigo: " + p.Codigo);
                    Console.WriteLine("--> Nombre: " + p.Nombre);
                    Console.WriteLine("--> Precio: " + p.Precio);
                    Console.WriteLine("--> Cantidad en Stock " +p.CantidadStock);
                    break;
                }
                else
                {
                    Console.WriteLine("El producto no se ha encontrado");
                }
            }
        }


        /// <summary>
        ///     Cambias el id del producto por otro nuevo pasado por parametro
        /// </summary>
        /// <param name="producto">
        ///     Producto al que vamos a cambiar el id
        /// </param>
        /// <param name="nuedoId">
        ///     Id que va ha tener el nuevo producto
        /// </param>
        public void cambiarIdProducto(Producto producto, int nuedoId)
        {
            producto.Codigo = nuedoId;
            Console.WriteLine("Id del producto cambiado con exito");

        }


        /// <summary>
        ///     Cambias la cantidad de stock de un producto pasado por parametro
        /// </summary>
        /// <param name="producto">
        ///     Producto al que vas a realizar el cambio
        /// </param>
        /// <param name="nuevaCantidadStock">
        ///     Nueva cantidad que le vas a poner al producto
        /// </param>
        public void cambiarCantidadStock(Producto producto, int nuevaCantidadStock)
        {
            producto.CantidadStock = nuevaCantidadStock;
            Console.WriteLine("Cantidad en Stock del producto cambiado con exito");

        }


        /// <summary>
        ///     Te imprime los productos con una cantidad de stock menor a la pasada por parametro
        /// </summary>
        /// <param name="cantidadStock">
        ///     Cantidad de stock con la que se va a comprar la cantidad de stock del producto
        ///     Si es menor se imprime, si no no se imprime
        /// </param>
        public void selectProducto(int cantidadStock)
        {
            foreach (Producto p in listaProductos)
            {
                if (p.CantidadStock < cantidadStock)
                {
                    Console.WriteLine("Mostrando producto con menos stock que " +cantidadStock);
                    Console.WriteLine("--> Codigo: " + p.Codigo);
                    Console.WriteLine("--> Nombre: " + p.Nombre);
                    Console.WriteLine("--> Precio: " + p.Precio);
                    Console.WriteLine("--> Cantidad en Stock " + p.CantidadStock);
                }
            } 
        }


        public int Codigo { get=> codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set=> precio = value; }
        public int CantidadStock { get => cantidadStock; set => cantidadStock = value; }
    }
}
