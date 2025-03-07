﻿using proyectoExamen.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace proyectoExamen.domain
{
    internal class ProyectoEmpleado
    {

        public int CodigoProyecto { get; set; }
        public string NombrePro { get; set; }
        public string NombreEmp { get; set; }
        public int Horas { get; set; }
        public double Coste { get; set; }

        public double Csr { get; set; }
        public int idEmpleado { get; set; }
        public int idProyecto { get; set; }
        public DateTime Fecha { get; set; }
        public ProyectoEmpleadoManage pem;
        public ProyectoEmpleado()
        {
            pem = new ProyectoEmpleadoManage();
        }
        public ProyectoEmpleado(int codigoProyecto, string nombrePro, string nombreEmp, int horas, double csr, DateTime fecha)
        {
            pem = new ProyectoEmpleadoManage();
            CodigoProyecto = codigoProyecto;
            NombrePro = nombrePro;
            NombreEmp = nombreEmp;
            Horas = horas;
            Coste = csr * horas;
            Fecha = fecha;
        }
        public void insertar()
        {
            pem.insertarProyectoEmpleado(this);
        }
        public List<ProyectoEmpleado> leer()
        {
            return pem.leerEmpleados();
        }
    }
}
