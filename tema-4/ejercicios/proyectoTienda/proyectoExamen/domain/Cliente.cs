using proyectoExamen.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.domain
{
    class Cliente
    {

        private int idCliente;
        private String nombreCliente;
        private String emailCliente;
        public ManejoCliente mc;

        public List<Cliente> listaClientes;
        private static int nextId = 1;


        public Cliente(int idCliente, string nombreCliente, string emailCliente)
        {
            mc = new ManejoCliente();

            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.emailCliente = emailCliente;
        }

        public Cliente(string nombreCliente, string emailCliente)
        {
            mc = new ManejoCliente();

            this.idCliente = mc.getLastId(this);
            this.nombreCliente = nombreCliente;
            this.emailCliente = emailCliente;
        }

        public Cliente()
        {
            mc = new ManejoCliente();
        }


        public void insertarCliente()
        {
            mc.insertarCliente(this);
        }

        public List<Cliente> genListaClientes()
        {

            listaClientes = mc.leerClientes();

            if (listaClientes.Any())
            {
                nextId = listaClientes.Max(c => c.IdCliente) + 1;
            }

            return listaClientes;
        }


        public void eliminarCliente()
        {
            mc.eliminarCliente(this);

            ResetIdCounter();
        }

        public void modificarCliente()
        {
            mc.modificarCliente(this);
        }

        public static void ResetIdCounter()
        {
            nextId = 1;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }



    }
}
