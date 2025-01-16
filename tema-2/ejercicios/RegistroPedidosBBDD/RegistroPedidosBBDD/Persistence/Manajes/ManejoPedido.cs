using RegistroPedidosBBDD.Domain;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPedidosBBDD.Persistence.Manajes
{
    internal class ManejoPedido
    {

        DBBroker dbbroker;
        int lastId;

        public ManejoPedido()
        {
            dbbroker = DBBroker.obtenerAgente();
        }


        /// <summary>
        ///     Inserta un ticket en la bbdd
        /// </summary>
        /// <param name="ticket">
        ///     Objeto ticket que se va ha insertar
        /// </param>
        public void insertarPedido(Pedido pedido)
        {
            dbbroker.modificar("INSERT INTO bbddRegistroPedidos.pedido (idpedido, Nombre) VALUES (" + pedido.Id + ", '" + pedido.NombreCliente + "')");
        }


        public int getLastId(Pedido pedido)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("select COALESCE(MAX(id), 0) FROM people1.people");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }

            return lastId;
        }
    }
}
