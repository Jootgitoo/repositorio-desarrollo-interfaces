using RegistroPedidosBBDD.Persistence.Manajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPedidosBBDD.Domain
{
    internal class Pedido
    {
        //ATRIBUTOS
        private int id;
        private string nombreCliente;
        private DateTime fecha;

        public ManejoPedido mp;

        //---------------------------------------------------------------------------------------------------------------
        //CONSTRUCTORES
        public Pedido(string nombreCliente)
        {
            mp = new ManejoPedido();
            this.id = mp.getLastId(this);
            this.nombreCliente = nombreCliente;
            fecha = DateTime.Now;

        }

        public Pedido()
        {
            mp = new ManejoPedido();
        }

//--------------------------------------------------------------------------------------------------------------- 
        //MÉTODOS
        public void insertarPedido()
        {
            mp.insertarPedido(this);
        }


//---------------------------------------------------------------------------------------------------------------
        //GETTERS Y SETTERS
        public int Id { get => id; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public DateTime Fecha { get => fecha; }



    }
}
