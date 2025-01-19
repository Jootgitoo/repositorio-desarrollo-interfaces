using AgendaContactosBBDD.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactosBBDD.persistence.manages
{
    class ManejoContacto
    {
        //ATRIBUTOS
        DBBroker dbbroker;
        List<Contacto> listaContacto;
        int lastId;


//---------------------------------------------------------------------------------------------
        //CONSTRUCTOR
        public ManejoContacto()
        {
            dbbroker = DBBroker.obtenerAgente();
            
            listaContacto = new List<Contacto>();
        }

//---------------------------------------------------------------------------------------------
        //MÉTODOS

        public int getLastId(Contacto contacto)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(id), 0) FROM bbddAgendaContactos.Contactos");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

        public void insetarNuevoContacto(Contacto contacto)
        {
            dbbroker.modificar("INSERT INTO bbddAgendaContactos.Contactos (id, nombre, telefono) VALUES ( "+contacto.Id+", '"+contacto.Nombre+"', "+contacto.Telefono+")");
        }

        public List<Contacto> leerContactos()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM bbddAgendaContactos.Contactos");

            foreach (List<Object> aux in listaAux)
            {
                Contacto contacto = new Contacto();
                contacto = new Contacto(Convert.ToInt32(aux[0]), aux[1].ToString(), Convert.ToInt32(aux[2]));
                listaContacto.Add(contacto);
            }
            return listaContacto;
        }

        public void eliminarContacto(Contacto contacto)
        {
            DBBroker.obtenerAgente().modificar("DELETE FROM bbddAgendaContactos.Contactos WHERE id = " + contacto.Id + ";");
        }

        public void modificarContacto(Contacto contacto)
        {
            DBBroker.obtenerAgente().modificar("UPDATE bbddAgendaContactos.Contactos SET nombre = '" + contacto.Nombre + "', telefono = " + contacto.Telefono + ";");
        }

    }
}
