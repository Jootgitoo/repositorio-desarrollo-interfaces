using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace ejercicio_dataGrid1
{
    class Persona
    {

        private String nombre;
        private String apellidos;
        private int edad;

        public Persona(string Nombre, string Apellidos, int Edad)
        {
            nombre = Nombre;
            apellidos = Apellidos;
            edad = Edad;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }


    }

    
}
