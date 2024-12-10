using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvCamisetasFutbol.domain;

namespace tpvCamisetasFutbol.persistence
{
    internal class ManejoProducto
    {
        //ATRIBUTOS 
        private DataTable dataTable;
        private List<Producto> listaProductos;
        DBBroker dbbroker;

//-------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR

        public ManejoProducto()
        {
            dataTable = new DataTable();
            listaProductos = new List<Producto>();
            dbbroker = DBBroker.obtenerAgente();
        }

//-------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        public List<Producto> leerProducto()
        {
            List<Object> listaAux = dbbroker.leer("SELECT * FROM bbddTPV.Producto;");

            foreach(List<Object> aux in listaAux)
            {
                
                Producto producto = new Producto(Convert.ToInt32(aux[0]), Convert.ToDouble(aux[1]), aux[2].ToString(), Convert.ToInt32(aux[3]) );
                listaProductos.Add(producto);

            }

            return listaProductos;
        }


        /// <summary>
        ///     Inserta un producto en la bbdd
        /// </summary>
        /// <param name="producto">
        ///     Producto que se va ha insertar
        /// </param>
        public void insertarProducto(Producto producto)
        {
            string precio = Convert.ToString(producto.Precio, CultureInfo.InvariantCulture);

            dbbroker.modificar("INSERT INTO bbddTPV.Producto (idProducto, Precio, Descripcion, idTipoProducto) VALUES (" + producto.IdProducto + ", " + precio + ", '" + producto.Descripcion + "', " + producto.IdTipoProducto + ")");
        }


        /// <summary>
        ///     Borra un producto en la bbdd
        /// </summary>
        /// <param name="producto">
        ///     Producto que vas a borrar de la bbdd
        /// </param>
        public void borrarProducto(Producto producto)
        {
            dbbroker.modificar("DELETE FROM bbddTPV.Producto WHERE idProducto = " + producto.IdProducto + ";");
        }


        /// <summary>
        ///     Modifica un producto de la bbdd
        /// </summary>
        /// <param name="producto">
        ///     Producto que se va a modificar en la bbdd
        /// </param>
        public void modificarProducto(Producto producto)
        {
            dbbroker.modificar("UPDATE bbddTPV.Producto set idProducto = "+producto.IdProducto+ ", Precio = " +producto.Precio+ ", Descripcion = '" +producto.Descripcion+"';");
        }

       public void encontrarProducto(Producto producto)
        {
            dbbroker.leer("SELECT * FROM bbddTPV.Producto where idProdcuto = " +producto.IdProducto);
        }
    }
}
