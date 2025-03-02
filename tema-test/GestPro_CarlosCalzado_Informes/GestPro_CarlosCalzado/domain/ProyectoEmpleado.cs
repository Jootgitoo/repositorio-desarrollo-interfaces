using GestPro_CarlosCalzado.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro_CarlosCalzado.domain
{
    internal class ProyectoEmpleado
    {
        private int proyecto_idProyecto;
        private int empleado_idEmpleado;
        private int horas;
        private double costes;
        private String fecha;
        private String nombreProyecto;

        private List<ProyectoEmpleado> lista;
        public ProyectoEmpleadoManage pm;

        public ProyectoEmpleado()
        {
            pm = new ProyectoEmpleadoManage();
        }

        public ProyectoEmpleado(int id)
        {
            pm = new ProyectoEmpleadoManage();
            this.proyecto_idProyecto = proyecto_idProyecto;
            this.empleado_idEmpleado = empleado_idEmpleado;
        }

        public ProyectoEmpleado(int proyecto_idProyecto, int empleado_idEmpleado, int horas, double costes, String fecha, string nombreProyecto)
        {
            pm = new ProyectoEmpleadoManage();
            this.proyecto_idProyecto = proyecto_idProyecto;
            this.empleado_idEmpleado = empleado_idEmpleado;
            this.horas = horas;
            this.costes = costes;
            this.fecha = fecha;
            this.nombreProyecto = nombreProyecto;
        }

        public int Proyecto_idProyecto { get { return proyecto_idProyecto; } set { proyecto_idProyecto = value; } }
        public int Empleado_idEmpleado { get { return empleado_idEmpleado; } set { empleado_idEmpleado = value; } }
        public int Horas { get { return horas; } set { horas = value; } }
        public double Costes { get { return costes; } set { costes = value; } }
        public string Fecha { get { return fecha; } set { fecha = value; } }
        public string NombreProyecto { get { return nombreProyecto; } set { nombreProyecto = value; } }

        public List<ProyectoEmpleado> getProyectoEmpleado()
        {
            lista = pm.leerProyectoEmpleado();

            return lista;
        }

        /*
        public void insertar()
        {
            //Id = pm.lastId(this);
            //Id = 1;
            pm.insertarProyecto(this, 0);
        }

        public void eliminar()
        {
            pm.eliminarProyecto(this);
        }

        public void actualizar()
        {
            pm.actualizarProyecto(this);
        }

        public void last()
        {
            pm.lastId(this);
        }
        */
    }
}
