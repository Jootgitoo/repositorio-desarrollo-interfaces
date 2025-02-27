using proyectoExamen.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.persistence.manages
{
    internal class ProyectoEmpleadoManage
    {
        private List<ProyectoEmpleado> listaProyectoEmpleados { get; set; }

        public ProyectoEmpleadoManage()
        {
            listaProyectoEmpleados = new List<ProyectoEmpleado>();
        }

        public List<ProyectoEmpleado> leerEmpleados()
        {
            ProyectoEmpleado proyectoEmpleado = null;
            List<Object> aux = DBBroker.obtenerAgente().leer("Select p.IdProyecto,p.NombreProyecto,e.NombreEmp,pe.horas,e.CSR,pe.fecha,p.IdProyecto, e.IdEmpleado FROM proyecto p" +
                " JOIN proyectoempleado pe on p.IdProyecto=pe.PROYECTO_IdProyecto" +
                " JOIN empleado e ON pe.EMPLEADO_IdEmpleado=e.IdEmpleado;");

            List<ProyectoEmpleado> listaProyectos = new List<ProyectoEmpleado>();
            foreach (List<Object> c in aux)
            {
                proyectoEmpleado = new ProyectoEmpleado(Convert.ToInt32(c[0]), c[1].ToString(), c[2].ToString(), Convert.ToInt32(c[3]), Convert.ToDouble(c[4]), Convert.ToDateTime(c[5]));
                proyectoEmpleado.idProyecto = Convert.ToInt32(c[6]);
                proyectoEmpleado.idEmpleado = Convert.ToInt32(c[7]);
                listaProyectos.Add(proyectoEmpleado);
            }//(string codigoProyecto, string nombrePro, string nombreEmp, int horas, double csr,DateTime fecha
            return listaProyectos;
        }

        public void insertarProyectoEmpleado(ProyectoEmpleado em)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            string fechaFormateada = em.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"Insert into proyectoempleado (PROYECTO_IdProyecto, EMPLEADO_IdEmpleado, horas, fecha, coste) values ({em.idProyecto}, {em.idEmpleado}, {em.Horas}, '{fechaFormateada}', {em.Coste});";
            dBBroker.modifier(query);
        }


    }
}
