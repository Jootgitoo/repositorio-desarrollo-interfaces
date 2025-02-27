using proyectoExamen.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.persistence.manages
{
    internal class ManageUsuario
    {
        DBBroker dbbroker;
        int lastId;
        List<Usuario> listaUsuarios;

        public ManageUsuario()
        {
            dbbroker = DBBroker.obtenerAgente();
            listaUsuarios = new List<Usuario>();
        }

        public int getLastId(Usuario usuario)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(IdUsuario), 0) FROM gestpro.usuario");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

        public void insertarUsuario(Usuario usuario)
        {
            dbbroker.modifier("INSERT INTO gestpro.usuario (IdUsuario, NombreUsu, PassUsu) VALUES (" + usuario.Id + ", '" + usuario.Name + "', '" + usuario.Password + "')");
        }

        public void eliminarUsuario(Usuario usuario)
        {
            dbbroker.modifier("DELETE FROM gestpro.usuario WHERE IdUsuario = " + usuario.Id + ";");
        }

        public void modificarUsuario(Usuario usuario)
        {
            dbbroker.modifier("UPDATE gestpro.usuario SET PassUsu = '" + usuario.Password + "' WHERE IdUsuario = " + usuario.Id + ";");
        }

        public List<Usuario> leerUsuarios()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM gestpro.usuario");

            foreach (List<Object> aux in listaAux)
            {
                Usuario u = new Usuario();
                u = new Usuario(Convert.ToInt32(aux[0]), aux[1].ToString(), aux[2].ToString());
                listaUsuarios.Add(u);
            }
            return listaUsuarios;
        }
    }
}
