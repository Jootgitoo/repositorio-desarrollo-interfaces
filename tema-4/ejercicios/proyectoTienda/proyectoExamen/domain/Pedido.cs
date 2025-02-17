using proyectoExamen.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.domain
{
    class Pedido
    {
        private int idPedido;
        private DateTime fechaPedido;
        private double total;
        private int idCliente;
        public ManejoPedido mp;

        public List<Pedido> listaPedidos;
        private static int nextId = 1;



        public Pedido(int idPedido, DateTime fechaPedido, double total, int idCliente)
        {
            mp = new ManejoPedido();

            this.idPedido = idPedido;
            this.fechaPedido = fechaPedido;
            this.total = total;
            this.idCliente = idCliente;
        }

        public Pedido(DateTime fechaPedido, double total, int idCliente)
        {
            mp = new ManejoPedido();
            this.idPedido = mp.getLastId(this);
            this.fechaPedido = fechaPedido;
            this.total = total;
            this.idCliente = idCliente;
        }

        public Pedido()
        {
            mp = new ManejoPedido();

        }

        public List<Pedido> genListaPedidos()
        {

            listaPedidos = mp.leerPedidos();

            if (listaPedidos.Any())
            {
                nextId = listaPedidos.Max(p => p.IdPedido) + 1;
            }

            return listaPedidos;
        }

        public void insertarPedido()
        {
            mp.insertarPedido(this);
        }   

        public void eliminarPedido()
        {
            mp.eliminarPedido(this);
        }

        public void modificarPedido()
        {
            mp.modificarPedido(this);
        }   

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public double Total { get => total; set => total = value; }

        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
