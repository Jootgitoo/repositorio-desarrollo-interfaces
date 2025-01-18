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
        private List<Producto> listaProductos;
        public ManejoProducto mp;

//-------------------------------------------------------------------------------------------
        //CONSTRUCTORES
        public Producto(string nombre, double precio)
        {
            mp = new ManejoProducto();
            listaProductos = new List<Producto>();
            this.nombre = nombre;
            this.precio = precio;
        }

        public Producto()
        {
            mp = new ManejoProducto();
            listaProductos = new List<Producto>();

        }

        //-------------------------------------------------------------------------------------------
        //MÉTODOS
        public void insertarProducto()
        {
            mp.insertar(this);
        }

        public List<Producto>encontrar(String nombreProducto)
        {
            //Obtenemos todos los productos
            List<Producto> lp = mp.leerProductos();

            foreach(Producto p in lp)
            {
                if( p.nombre == nombreProducto)
                {
                    listaProductos.Add(p);
                }
            }

            return listaProductos;
        }

//-------------------------------------------------------------------------------------------
        //GETTERS Y SETTERS
        public string Nombre { get=> nombre; set=>nombre = value; }
        public double Precio { get=> precio; set=>precio = value; }

    }
}
