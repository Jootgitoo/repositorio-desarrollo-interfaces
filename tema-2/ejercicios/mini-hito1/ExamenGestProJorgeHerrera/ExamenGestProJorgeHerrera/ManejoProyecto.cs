using ExamenGestProJorgeHerrera.manages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestProJorgeHerrera
{
    internal class ManejoProyecto
    {
        // constantes & variables =>
        private DataTable dataTable;
        private List<Proyecto> listaPersonas;
        int lastId;

        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        // constructores =>
        public ManejoProyecto()
        {
            dataTable = new DataTable();
            listaPersonas = new List<Proyecto>();
        }

        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        

        // metodo | genListaPersonas | genera y devuelve una lista de personas ==>
        public void insertarPersona(Proyecto inputProyecto)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            dbBroker.modificar("Insert into bbddProyectoFinal.proyecto (codigoProy, nombreProy, descProy, presupuesto) values '" + inputProyecto.CodigoProyecto + "', '" + inputProyecto.NombreProy+ "', '" + inputProyecto.DescProy + "', " + inputProyecto.Presupuesto);
        }

    }
}
