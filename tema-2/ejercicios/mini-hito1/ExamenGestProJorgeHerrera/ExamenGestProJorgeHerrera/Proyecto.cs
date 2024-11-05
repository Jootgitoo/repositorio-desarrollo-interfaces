using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestProJorgeHerrera
{
    internal class Proyecto
    {
        public int codigoProyecto;
        public string nombre;
        public string fechaInicio;
        public string fechaFin;

        public Proyecto(int codigoProyecto, string nombre, string fechaInicio, string fechafin) 
        {
            this.codigoProyecto = codigoProyecto;
            this.nombre = nombre;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechafin;
        }

    }
}
