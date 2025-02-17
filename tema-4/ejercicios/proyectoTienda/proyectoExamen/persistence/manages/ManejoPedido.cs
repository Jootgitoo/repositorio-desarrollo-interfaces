using proyectoExamen.domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.persistence.manages
{
    class ManejoPedido
    {

        DBBroker dbbroker;
        List<Pedido> listaPedidos;
        int lastId;

        public ManejoPedido()
        {
            dbbroker = DBBroker.obtenerAgente();
            listaPedidos = new List<Pedido>();
        }

        public int getLastId(Pedido pedido)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(idPedido), 0) FROM tienda.Pedidos");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }


        public List<Pedido> leerPedidos()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM tienda.Pedidos");
            foreach (List<Object> aux in listaAux)
            {
                Pedido pedido = new Pedido(Convert.ToInt32(aux[0]), Convert.ToDateTime(aux[1]), Convert.ToDouble(aux[2]), Convert.ToInt32(aux[3]));
                listaPedidos.Add(pedido);
            }
            return listaPedidos;
        }


        public void insertarPedido(Pedido pedido)
        {
            dbbroker.modificar("Insert into tienda.Pedidos values (" + pedido.IdPedido + ", '" + pedido.FechaPedido.ToString("yyyy-MM-dd") + "', " + pedido.Total.ToString(CultureInfo.InvariantCulture) + ", "+pedido.IdCliente+")");
        }

        public void eliminarPedido(Pedido pedido)
        {
            dbbroker.modificar("DELETE FROM tienda.Pedidos WHERE idPedido = " + pedido.IdPedido);
        }

        public void modificarPedido(Pedido pedido)
        {
            dbbroker.modificar("UPDATE tienda.Pedidos SET fechaPedido = '" + pedido.FechaPedido.ToString("yyyy-MM-dd") + "', total = " + pedido.Total.ToString(CultureInfo.InvariantCulture) + " WHERE idPedido = " + pedido.IdPedido);
        }

        public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
    }
}
