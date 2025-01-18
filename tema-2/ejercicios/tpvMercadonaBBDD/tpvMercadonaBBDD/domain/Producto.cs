using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvMercadonaBBDD.persistence.manages;

namespace tpvMercadonaBBDD.domain
{
    class Producto
    {
        //ATRIBUTOS
        private string nombre;
        private double precio;
        public ManejoProducto mp;

//-------------------------------------------------------------------------------------------
        //CONSTRUCTORES
        public Producto(string nombre, double precio)
        {
            mp = new ManejoProducto();
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto()
        {
            mp = new ManejoProducto();
        }

//-------------------------------------------------------------------------------------------
        //MÉTODOS
        public void insertarProducto()
        {
            mp.insertar(this);
        }

        public void encontrar(String nombreProducto)
        {
            //Obtenemos todos los productos
            List<Producto> listaProductos = mp.leerProductos();

            //Por aqui
        }

//-------------------------------------------------------------------------------------------
        //GETTERS Y SETTERS
        public string Nombre { get; set; }
        public double Precio { get; set; }

    }
}
