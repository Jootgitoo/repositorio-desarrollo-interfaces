using Newtonsoft.Json;
using ProyectoPersonasJson.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoPersonasJson.persistence.manages
{
    internal class ManejoPersonas
    {
        // constantes & variables =>
        private DataTable dataTable;
        private List<Persona> listaPersonas;
        int lastId;

        //Para el Json
        private string path;


        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        // constructores =>
        public ManejoPersonas()
        {
            dataTable = new DataTable();
            listaPersonas = new List<Persona>();
            path = "example.json";
        }

        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        // metodos publicos =>
        
          
        
        // metodo | leerPersonas | lee todas las personas de la base de datos y las almacena en una lista que devuelve ==>
        public void leerPersonas()
        {
            //Read the file content
            string jsonContent = File.ReadAllText(path);

            //Deserialize the JSON content
            var rootObject = JsonConvert.DeserializeObject<RootObject>(jsonContent);

        //    List<Object> listaAux = DBBroker.obtenerAgente().leer("SELECT * FROM people1.people;");
        //    foreach (List<Object> aux in listaAux)
        //    {
        //        Persona persona = new Persona();
        //        Console.WriteLine(aux.ToString());
        //        persona = new Persona(Convert.ToInt32(aux[0]), aux[1].ToString(), Convert.ToInt32(aux[2]));
        //        listaPersonas.Add(persona);
        //    }

        //    return listaPersonas;
        }



        // metodo | genListaPersonas | genera y devuelve una lista de personas ==>
        public void insertarPersona(Persona inputPersona)
        {
            //DBBroker dbBroker = DBBroker.obtenerAgente();
            //dbBroker.modificar("Insert into people1.people (id,name,age) values (" + inputPersona.Id + ",'" + inputPersona.Nombre + "', " + inputPersona.Edad + ");");
        }

        // metodo | getLastId | obtiene el ultimo id y le agrega 1 ==>
        public void getLastId(Persona inputPersona)
        {
        //    List<Object> listaAux;
        //    listaAux = DBBroker.obtenerAgente().leer("select COALESCE(MAX(id), 0) FROM people1.people");

        //    foreach (List<Object> aux in listaAux)
        //    {
        //        lastId = Convert.ToInt32(aux[0]) + 1;
        //    }

        //    return lastId;
        }

        // metodo | deletePersona | elimina una persona ==>
        public void deletePersona(Persona inputPersona)
        {
            //DBBroker dBBroker = DBBroker.obtenerAgente();
            //dBBroker.modificar("DELETE FROM people1.people WHERE id = " + inputPersona.Id + ";");
        }

        // metodo | modificarPersona | modifica una persona ==>
        public void modificarPersona(Persona inputPersona)
        {
            //DBBroker dbBroker = DBBroker.obtenerAgente();
            //dbBroker.modificar("UPDATE people1.people SET name = '" + inputPersona.Nombre + "', age = " + inputPersona.Edad.ToString() + " WHERE id = " + inputPersona.Id + ";");
        }
    }

    class RootObject
    {
        [JsonProperty("people")]

        public List<Persona> listPeople { get; set; }
    }
}
