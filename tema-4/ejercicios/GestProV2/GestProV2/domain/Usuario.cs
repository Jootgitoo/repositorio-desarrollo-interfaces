using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GestProV2.persistence.manages;

namespace GestProV2.domain
{
    class Usuario
    {
        ManageUsuario mu;
        public int id;
        public string name;
        public string password;
        private static int nextId = 1;


        private List<Usuario> listaUsuarios = new List<Usuario>();


        public Usuario()
        {
            mu = new ManageUsuario();
        }

        public Usuario(string name, string password)
        {
            mu = new ManageUsuario();
            this.id = mu.getLastId(this);
            this.name = name;
            this.password = password;
        }

        public Usuario(int id, string name, string password)
        {
            mu = new ManageUsuario();
            this.id = id;
            this.name = name;
            this.password = password;
        }


        public void insertarUsuario()
        {
            this.password = EncryptMD5(this.password);

            mu.insertarUsuario(this);
        }

        public void eliminar()
        {
            mu.eliminarUsuario(this);
        }

        public void modificarUsuario()
        {
            mu.modificarUsuario(this);
        }

        public List<Usuario> genListaUsuarios()
        {

            listaUsuarios = mu.leerUsuarios();

            if (listaUsuarios.Any())
            {
                nextId = listaUsuarios.Max(u => u.Id) + 1;
            }

            return listaUsuarios;

        }

        static string EncryptMD5(string text)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }


        public int Id { get=> id; set => id = value; }
        public string Name { get=> name; set=> name = value; }
        public string Password { get => password; set => password = value; }
    }
}
    
