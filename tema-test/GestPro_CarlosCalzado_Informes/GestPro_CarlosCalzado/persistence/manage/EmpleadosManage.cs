using GestPro_CarlosCalzado.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestPro_CarlosCalzado.persistence
{
    internal class EmpleadosManage
    {
        private DataTable table { get; set; }
        private static List<Empleado> listaEmpleados { get; set; }
        int Id;

        public EmpleadosManage()
        {
            table = new DataTable();
            listaEmpleados = new List<Empleado>();
        }
        public List<Empleado> leerEmpleados()
        {
            Empleado empleado = null;
            List<Object> aux = DBBroker.obtenerAgente().leer("Select * from mydb.Empleado;");
            foreach (List<Object> c in aux)
            {
                empleado = new Empleado(Convert.ToInt32(c[0]), c[1].ToString(), c[2].ToString(), Convert.ToInt32(c[3]), Convert.ToDouble(c[4]), Convert.ToInt32(c[5]));
                listaEmpleados.Add(empleado);
            }
            return listaEmpleados;
        }

        public void insertarEmpleado(Empleado e, int lastId)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            MessageBox.Show("insert into mydb.Empleado (NombreEmpleado,ApellidosEmpleado,IdRol,CSR,IdUsuario) values('" + e.NombreEmpleado + "," + e.ApellidosEmpleado + "," + e.IdRol + "," + e.CSR + "," + e.IdUsuario + "');");
            dbBroker.modificar("insert into mydb.Empleado (NombreEmpleado,ApellidosEmpleado,IdRol,CSR,IdUsuario) values('" + e.NombreEmpleado + "','" + e.ApellidosEmpleado + "'," + e.IdRol + "," + e.CSR + "," + e.IdUsuario + ");");
        }

        public void eliminarEmpleado(Empleado e)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("delete from mydb.Empleado where IdEmpleado = " + e.IdEmpleado);
        }

        public void actualizarEmpleado(Empleado e)
        {
            /*
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("update mydb.Usuario set NombreUsuario = '" + u.NombreUsuario + "', PassUsuario ='" + u.PassUsuario + " where IdUsuario = " + u.IdUsuario);
            */
        }

        public int lastId(Empleado e)
        {

            List<Object> listaEmpleados;
            listaEmpleados = DBBroker.obtenerAgente().leer("select MAX(IdEmpleado) FROM mydb.Empleado");
            foreach (List<Object> aux in listaEmpleados)
            {
                Id = Convert.ToInt32(aux[0]) + 1;
            }
            return Id;
        }
    }
}
