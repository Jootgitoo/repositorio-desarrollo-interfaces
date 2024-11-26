using Ejercicio3ExamenJorgeHerrera.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ExamenJorgeHerrera.persistence.Manajes
{
    internal class ManejoTripulantes
    {

        private DataTable dataTable;
        private List<Tripulante> listaTripulantes;
        int lastId;

        public ManejoTripulantes()
        {
            dataTable = new DataTable();
            listaTripulantes = new List<Tripulante>();
        }



       /* public List<Tripulante> leerTripulantes()
        {
            List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM people1.people;");
            foreach (List<Object> aux in listaAux)
            {
                Tripulante persona = new Tripulante();
                Console.WriteLine(aux.ToString());
                persona = new Tripulante(Convert.ToInt32(aux[0]), aux[1].ToString(), Convert.ToInt32(aux[2]));
                listaTripulantes.Add(persona);
            }

            return listaTripulantes;
        }
       */

        public void insertarTripulante(Tripulante inputTripulante)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            dbBroker.modificar("Insert into dbExamen2.Tripulante (id,name,surname,age, birthday, creawCharge) values (" + inputTripulante.Dni + ",'" + inputTripulante.Name + "', '" + inputTripulante.Surname + "', "+ inputTripulante.Age+ ", '"+ inputTripulante.Birthday+"', '"+ inputTripulante.CrewCharge+"');");
        }
        public void deletePersona(Tripulante inputTripulante)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("DELETE FROM dbExamen2.Tripulante WHERE dni = " + inputTripulante.Dni + ";");
        }

        public void modificarPersona(Tripulante inputTripulante)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            dbBroker.modificar("UPDATE dbExamen2.Tripulante SET name = '" + inputTripulante.Name + "';");
        }
    }
}
