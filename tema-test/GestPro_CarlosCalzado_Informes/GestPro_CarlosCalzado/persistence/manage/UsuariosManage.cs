using GestPro_CarlosCalzado.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestPro_CarlosCalzado.persistence
{
    internal class UsuariosManage
    {
        private DataTable table { get; set; }
        private static List<Usuario> listaUsuarios { get; set; }
        int Id;

        public UsuariosManage()
        {
            table = new DataTable();
            listaUsuarios = new List<Usuario>();
        }
        public List<Usuario> leerUsuarios()
        {
            Usuario usuario = null;
            List<Object> aux = DBBroker.obtenerAgente().leer("Select * from mydb.Usuario;");
            foreach (List<Object> c in aux)
            {
                usuario = new Usuario(Convert.ToInt32(c[0]), c[1].ToString(), c[2].ToString());
                listaUsuarios.Add(usuario);
            }

            /*
            List<Proyecto> listaProyectos = new List<Proyecto>();
            listaProyectos.Add(new Proyecto(1, "Proyecto1", "01/01/2024", "01/01/2025"));
            listaProyectos.Add(new Proyecto(2, "Proyecto2", "02/02/2024", "02/02/2025"));
            listaProyectos.Add(new Proyecto(3, "Proyecto3", "03/03/2024", "03/03/2025"));
            */

            return listaUsuarios;
        }

        public void insertarUsuario(Usuario u, int lastId)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            MessageBox.Show("insert into mydb.Usuario (NombreUsuario,PassUsuario) values('" + u.NombreUsuario + "," + u.PassUsuario + "');");
            dbBroker.modificar("Insert into mydb.Usuario (NombreUsuario,PassUsuario) values ('" + u.NombreUsuario + "','" + u.PassUsuario + "');");
        }

        public void eliminarUsuario(Usuario u)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("delete from mydb.Usuario where IdUsuario = " + u.IdUsuario);
        }

        public void actualizarUsuario(Usuario u)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("update mydb.Usuario set NombreUsuario = '" + u.NombreUsuario + "', PassUsuario ='" + u.PassUsuario + " where IdUsuario = " + u.IdUsuario);
        }

        public int lastId(Usuario u)
        {

            List<Object> listaUsuarios;
            listaUsuarios = DBBroker.obtenerAgente().leer("select MAX(IdUsuario) FROM mydb.Usuario");
            foreach (List<Object> aux in listaUsuarios)
            {
                Id = Convert.ToInt32(aux[0]) + 1;
            }
            return Id;
        }
    }
}
