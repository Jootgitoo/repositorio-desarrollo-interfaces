using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestProV2.domain;

namespace GestProV2.persistence.manages
{
    internal class ManageEmpleado
    {
        DBBroker dbbroker;
        int lastId;
        List<Empleado> listaEmpleados;

        public ManageEmpleado()
        {
            dbbroker = DBBroker.obtenerAgente();
            listaEmpleados = new List<Empleado>();
        }

        public int getLastId(Empleado empleado)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(IdEmpleado), 0) FROM gestpro.empleado");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

        
        public List<Empleado> leerEmpleados()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("select * from gestpro.empleado;");

            foreach (List<Object> aux in listaAux)
            {
                Empleado e = new Empleado();
                e = new Empleado(Convert.ToInt32(aux[0]), aux[1].ToString(), aux[2].ToString(), float.Parse(aux[3].ToString() ), Convert.ToInt32(aux[4]), Convert.ToInt32(aux[5]));
                listaEmpleados.Add(e);
            }
            return listaEmpleados;
        }
        


        public void insertarEmpleado(Empleado empleado)
        {
            dbbroker.modifier("INSERT INTO gestpro.empleado (IdEmpleado, NombreEmp, ApellidoEmp, CSR, IdRol, IdUsuario) VALUES (" + empleado.IdEmpleado + ", '" + empleado.NombreEmpleado + "', '" + empleado.ApellidoEmpleado + "', "+empleado.CsrEmpleado+", "+empleado.IdRol+", "+empleado.IdUsuario+")");

        }

        public void eliminarEmpleado(Empleado empleado)
        {
            dbbroker.modifier("DELETE FROM gestpro.empleado WHERE IdEmpleado = " + empleado.IdEmpleado + ";");
        }

        public void modificarEmpleado(Empleado empleado)
        {
            dbbroker.modifier("UPDATE gestpro.empleado SET NombreEmp = " + empleado.NombreEmpleado + ", ApellidoEmp = "+empleado.ApellidoEmpleado+", CSR = "+empleado.CsrEmpleado+", IdRol = "+empleado.IdRol+", IdUsuario = "+empleado.IdUsuario+" WHERE IdEmpleado = " + empleado.IdEmpleado + ";");
        }

    }
}
