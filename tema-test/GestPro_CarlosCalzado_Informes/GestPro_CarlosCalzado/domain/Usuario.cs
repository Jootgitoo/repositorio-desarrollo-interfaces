using GestPro_CarlosCalzado.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro_CarlosCalzado.domain
{
    internal class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string passUsuario;

        private List<Usuario> lista;
        public UsuariosManage um;

        public Usuario() { 
            um = new UsuariosManage();
        }

        public Usuario(int id)
        {
            um = new UsuariosManage();
            this.idUsuario = id;
        }

        public Usuario(int id, string nombre, string password) { 
            this.idUsuario = id;
            this.nombreUsuario = nombre;
            this.passUsuario = password;
            um = new UsuariosManage();
        }

        public Usuario(string nombre, string password)
        {
            this.nombreUsuario = nombre;
            this.passUsuario = password;
            um = new UsuariosManage();
        }

        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public string NombreUsuario { get { return nombreUsuario; } set { nombreUsuario = value; } }
        public string PassUsuario { get { return passUsuario; } set { passUsuario = value; } }

        public List<Usuario> getUsuarios()
        {
            lista = um.leerUsuarios();

            return lista;
        }

        public void insertar() {
            //Id = pm.lastId(this);
            //Id = 1;
            um.insertarUsuario(this, 0);
        }

        public void eliminar()
        {
            um.eliminarUsuario(this);
        }

        public void actualizar()
        {
            um.actualizarUsuario(this);
        }

        public void last() { 
            um.lastId(this);
        }

    }
}
