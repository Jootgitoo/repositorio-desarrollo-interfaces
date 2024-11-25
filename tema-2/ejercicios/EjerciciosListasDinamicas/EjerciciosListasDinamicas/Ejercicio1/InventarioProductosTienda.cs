using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosListasDinamicas.Ejercicio1
{
    internal class InventarioProductosTienda
    {
        static void Main(string[] args)
        {

            Producto producto = new Producto();

            Producto producto1 = new Producto(1, "Caramelos", 45.78, 34);
            Producto producto2 = new Producto(2, "Cacahuete", 78.89, 77);

            producto.addProductoFinal(producto1);
            Console.WriteLine("");
            Console.ReadKey();

            producto.addProductoInicio(producto2);
            Console.WriteLine("");
            Console.ReadKey();

            producto.buscarPorCodigo(1);
            Console.WriteLine("");
            Console.ReadKey();

            producto.cambiarIdProducto(producto1, 3);
            Console.WriteLine("");
            Console.ReadKey();

            producto.buscarPorCodigo(1);
            Console.WriteLine("");
            Console.ReadKey();

            producto.buscarPorCodigo(3);
            Console.WriteLine("");
            Console.ReadKey();


            producto.selectProducto(77);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
