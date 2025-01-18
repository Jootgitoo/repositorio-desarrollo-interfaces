using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvMercadonaBBDD.domain;

namespace tpvMercadonaBBDD.persistence.manages
{
    class ManejoProducto
    {
        DBBroker dbbroker;
        List<Producto> listaProductos;

        public ManejoProducto()
        {
            dbbroker = DBBroker.obtenerAgente();
        }


        public List<Producto> leerProductos()
        {
            List<Object> listaAux = dbbroker.leer("SELECT * FROM bbddTPV.Producto;");


            foreach (List<Object> obj in listaAux)
            {
                Producto p = new Producto( obj[0].ToString(), Convert.ToDouble(obj[1]) );

                listaProductos.Add( p );
            }

            return listaProductos;
        }

        public void insertar(Producto producto)
        {
            string precio = Convert.ToString(producto.Precio, CultureInfo.InvariantCulture);

            dbbroker.modificar("INSERT INTO bbddtpvmercadona.producto (nombre, precio) values ( '"+producto.Nombre+"', "+precio+" ) ");
        }
    }
}
