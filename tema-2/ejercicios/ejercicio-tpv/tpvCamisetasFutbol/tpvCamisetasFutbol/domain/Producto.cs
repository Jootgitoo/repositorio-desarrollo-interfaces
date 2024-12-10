using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvCamisetasFutbol.persistence;

namespace tpvCamisetasFutbol.domain
{
    internal class Producto
    {
        //ATRIBUTOS
        private int idProducto;
        private double precio;
        private string descripcion;
        private int idTipoProducto;
        public ManejoProducto mp;
        private List<Producto> listaProducto;

//------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTORES

        public Producto(int p_idProducto, double p_precio, string p_descripcion, int p_idTipoProdcuto)
        {
            mp = new ManejoProducto();
            this.idProducto = p_idProducto;
            this.precio = p_precio;
            this.descripcion = p_descripcion;
            this.idTipoProducto = p_idTipoProdcuto;
        }

        public Producto(int p_idProducto)
        {
            mp = new ManejoProducto();
            this.idProducto = p_idProducto;
        }

        public Producto() 
        {
            mp = new ManejoProducto();
        }

//-------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        /// <summary>
        ///     Insertas un producto en la bbdd
        /// </summary>
        public void insertar()
        {
            mp.insertarProducto(this);
        }


        /// <summary>
        ///     Modifica un producto en la bbdd
        /// </summary>
        public void modificar()
        {
            mp.modificarProducto(this);
        }


        /// <summary>
        ///     Elimina un producto en la bbdd
        /// </summary>
        public void eliminar()
        {
            mp.borrarProducto(this);
        }

        public List<Producto> encontrar(int idProducto)
        {
            List<Producto> listaProductoAux = mp.leerProducto();

            listaProducto = new List<Producto> ();

            foreach (Producto p in listaProductoAux)
            {
                if (p.idProducto == idProducto)
                {
                    listaProducto.Add(p);
                }
            }

            return listaProducto;
        }

//-----------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA

        public int IdProducto { get => idProducto; set => idProducto = value; }

        public double Precio { get => precio; set => precio = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }


    }
}
