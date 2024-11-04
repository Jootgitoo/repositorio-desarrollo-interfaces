using GridsPersonas.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

internal class PersonasPersistance
{
    private DataTable table { get; set; }
    public PersonasPersistance()
    {
        table = new DataTable();
    }

        
    public static List<Persona> leerPersonas()
    {
        List<Persona> ListaPersonas = new List<Persona>();

        ListaPersonas.Add(new Persona("Jorge", "Herrera", 19));
        ListaPersonas.Add(new Persona("Maria", "Gomez", 32));
        ListaPersonas.Add(new Persona("Carlos", "López", 28));
        ListaPersonas.Add(new Persona("Javier", "Moreno", 20));
        ListaPersonas.Add(new Persona("Luis", "Hernandez", 21));
            

        return ListaPersonas;
    }
}
    

