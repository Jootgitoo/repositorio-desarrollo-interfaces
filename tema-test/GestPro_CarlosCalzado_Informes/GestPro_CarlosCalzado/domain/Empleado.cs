using GestPro_CarlosCalzado.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro_CarlosCalzado.domain
{
    internal class Empleado
    {
        private int idEmpleado;
        private string nombreEmpleado;
        private string apellidosEmpleado;
        private int idRol;
        private double csr;
        private int idUsuario;

        private List<Empleado> lista;
        public EmpleadosManage em;

        public Empleado() { 
            em = new EmpleadosManage();
        }

        public Empleado(int id)
        {
            em = new EmpleadosManage();
            this.idEmpleado = id;
        }

        public Empleado(int id, string nombre, string apellidos, int idRol, double csr, int idUsuario) { 
            this.idEmpleado = id;
            this.nombreEmpleado = nombre;
            this.apellidosEmpleado = apellidos;
            this.idRol = idRol;
            this.csr = csr;
            this.idUsuario = idUsuario;
            em = new EmpleadosManage();
        }

        public Empleado(string nombre, string apellidos, int idRol, double csr, int idUsuario)
        {
            this.nombreEmpleado = nombre;
            this.apellidosEmpleado = apellidos;
            this.idRol = idRol;
            this.csr = csr;
            this.idUsuario = idUsuario;
            em = new EmpleadosManage();
        }

        public Empleado(string nombre, string apellidos, int idRol, double csr)
        {
            this.nombreEmpleado = nombre;
            this.apellidosEmpleado = apellidos;
            this.idRol = idRol;
            this.csr = csr;
            this.idUsuario = 1;
            em = new EmpleadosManage();
        }

        public int IdEmpleado { get { return idEmpleado; } set { idEmpleado = value; } }
        public string NombreEmpleado { get { return nombreEmpleado; } set { nombreEmpleado = value; } }
        public string ApellidosEmpleado { get { return apellidosEmpleado; } set { apellidosEmpleado = value; } }
        public int IdRol { get { return idRol; } set { idRol = value; } }
        public double CSR { get { return csr; } set { csr = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }

        public List<Empleado> getEmpleados()
        {
            lista = em.leerEmpleados();

            return lista;
        }

        public void insertar() {
            //Id = pm.lastId(this);
            //Id = 1;
            em.insertarEmpleado(this, 0);
        }

        public void eliminar()
        {
            em.eliminarEmpleado(this);
        }

        public void actualizar()
        {
            em.actualizarEmpleado(this);
        }

        public void last() { 
            em.lastId(this);
        }

    }
}
