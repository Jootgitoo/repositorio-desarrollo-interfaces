using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpvCamisetasFutbol.domain
{
    internal class Producto
    {
        //ATRIBUTOS
        private int idProducto;
        private double precio;
        private string descripcion;
        private int idTipoProducto;

//------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTORES

        public Producto(int p_idProducto, double p_precio, string p_descripcion, int p_idTipoProdcuto)
        {
            this.idProducto = p_idProducto;
            this.precio = p_precio;
            this.descripcion = p_descripcion;
            this.idTipoProducto = p_idTipoProdcuto;
        }

        public Producto() 
        { 

        }



//-----------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA

        public int IdProducto { get => idProducto; set => idProducto = value; }

        public double Precio { get => precio; set => precio = value; }

        public string Descripcion { get => descripcion; set => descripcion = value; }

        public int IdTipoProducto { get => idTipoProducto; set => idTipoProducto = value; }


    }
}
