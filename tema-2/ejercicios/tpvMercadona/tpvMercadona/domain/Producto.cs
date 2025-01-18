using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpvMercadona.persistence
{
    class Producto
    {

        private string nombre;
        private double precio;

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;}

        public Producto()
        {
        }
        
        public string Nombre { get; set; }
        public double Precio { get; set; }

    }
}
