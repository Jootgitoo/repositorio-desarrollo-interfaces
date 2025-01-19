using AgendaContactosBBDD.persistence.manages;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosBBDD.domain
{
    class Contacto
    {
        //ATRIBUTOS
        private static int nextId = 1;
        private int id;
        private string nombre;
        private int telefono;
        private List<Contacto> listaContactos;
        public ManejoContacto mc;

//------------------------------------------------------------------------------------------
        //CONSTRUCTORES

        public Contacto(string nombre, int telefono)
        {
            mc = new ManejoContacto();

            this.id = mc.getLastId(this);
            this.nombre = nombre;
            this.telefono = telefono;
        }

        public Contacto(int id, string nombre, int telefono)
        {
            mc = new ManejoContacto();

            this.id = id;
            this.nombre = nombre;
            this.telefono= telefono;
        }

        public Contacto()
        {   
            mc = new ManejoContacto();

            this.id = mc.getLastId(this);
        }

//------------------------------------------------------------------------------------------
        //MÉTODOS

        public void insertarNuevoContacto()
        {
            mc.insetarNuevoContacto(this);
        }

        public List<Contacto> genListaContactos()
        {
            
            listaContactos = mc.leerContactos();

            if (listaContactos.Any())
            {
                nextId = listaContactos.Max(c => c.Id) + 1;
            }

            return listaContactos;

        }

        public void eliminar()
        {
            mc.eliminarContacto(this);

            ResetIdCounter();
        }

        // metodo | ResetIdCounter | resetea el contadort de id ==>
        public static void ResetIdCounter()
        {
            nextId = 1;
        }


        public void modificarContacto()
        {
            mc.modificarContacto(this);
        }
//------------------------------------------------------------------------------------------
        //GETTERS Y SETTERS
        public int Id { get => id; set => id = value;  }
        public string Nombre { get=> nombre; set=> nombre = value; }
        public int Telefono { get=> telefono; set=> telefono = value; }
    }
}
