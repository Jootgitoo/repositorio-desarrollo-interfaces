using proyectoExamen.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.persistence.manages
{
    class ManejoCliente
    {

        DBBroker dbbroker;
        List<Cliente> listaClientes;
        int lastId;



        public ManejoCliente()
        {
            dbbroker = DBBroker.obtenerAgente();
            listaClientes = new List<Cliente>();
        }

        public int getLastId(Cliente cliente)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(idCliente), 0) FROM tienda.Clientes");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

        public void insertarCliente(Cliente cliente)
        {
            dbbroker.modificar("Insert into tienda.Clientes values (" + cliente.IdCliente + ", '" + cliente.NombreCliente + "', '" + cliente.EmailCliente + "')");
        }


        public void eliminarCliente(Cliente cliente)
        {
            dbbroker.modificar("DELETE FROM tienda.Clientes WHERE idCliente = " + cliente.IdCliente);
        }

        public void modificarCliente(Cliente cliente)
        {
            dbbroker.modificar("UPDATE tienda.Clientes SET nombreCliente = '" + cliente.NombreCliente + "', emailCliente = '" + cliente.EmailCliente + "' WHERE idCliente = " + cliente.IdCliente);
        }

        public List<Cliente> leerClientes()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM tienda.Clientes");

            foreach (List<Object> aux in listaAux)
            {
                Cliente cliente = new Cliente(Convert.ToInt32(aux[0]), aux[1].ToString(), aux[2].ToString());
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }

    }
}
