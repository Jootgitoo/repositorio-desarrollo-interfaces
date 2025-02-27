using proyectoExamen.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.domain
{
    internal class Empleado
    {
        ManageEmpleado me;

        private int idEmpleado;
        private string nombreEmpleado;
        private string apellidoEmpleado;
        private float csrEmpleado;
        private int idRol;
        private int idUsuario;

        private List<Empleado> listaEmpleados = new List<Empleado>();
        private static int nextId = 1;

        public Empleado()
        {
            me = new ManageEmpleado();

            this.idEmpleado = me.getLastId(this);

        }

        public Empleado(int id, string nombre, string apellido, float csr, int idRol, int idUsuario)
        {
            me = new ManageEmpleado();

            this.idEmpleado = id;
            this.nombreEmpleado = nombre;
            this.apellidoEmpleado = apellido;
            this.csrEmpleado = csr;
            this.idRol = idRol;
            this.idUsuario = idUsuario;
        }

        public Empleado(string nombre, string apellido, float csr, int idRol, int idUsuario)
        {
            me = new ManageEmpleado();

            this.idEmpleado = me.getLastId(this);
            this.nombreEmpleado = nombre;
            this.apellidoEmpleado = apellido;
            this.csrEmpleado = csr;
            this.idRol = idRol;
            this.idUsuario = idUsuario;
        }



        public Empleado(string nombre, string primerApellido, float csr)
        {
            me = new ManageEmpleado();

            this.nombreEmpleado = nombre;
            this.apellidoEmpleado = primerApellido;
            this.csrEmpleado = csr;
        }

        public List<Empleado> genListaEmpleados()
        {

            listaEmpleados = me.leerEmpleados();

            if (listaEmpleados.Any())
            {
                nextId = listaEmpleados.Max(e => e.IdEmpleado) + 1;
            }

            return listaEmpleados;

        }


        public void insertarEmpleado()
        {
            me.insertarEmpleado(this);
        }

        public void eliminarEmpleado()
        {
            me.eliminarEmpleado(this);
        }

        public void modificarEmpleado()
        {
            me.modificarEmpleado(this);
        }

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public String NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public String ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
        public float CsrEmpleado { get => csrEmpleado; set => csrEmpleado = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

    }
}
