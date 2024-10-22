using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_combobox1.domain
{
    internal class Usuario
    {
        public string Login { get; set; }
        public string Passw { get; set; }

        public Usuario(string login, string passw)
        {
            Login = login;
            Passw = passw;
        }

        public override string ToString()
        {
            return Login + " " + Passw;
        }
    }
}
