using DataGridPersonas;
using System;
using System.Collections.Generic;
using System.Data;

internal class PersonasPersistance
{
    private DataTable table { get; set; }
    public PersonasPersistance()
    {
        table = new DataTable();    }

    /// <summary>
    /// Simulate a DB reading
    /// </summary>
    public static List<Persona> leerPersonas()
    {
             List<Persona> ListaPersonas = new List<Persona>();

    ListaPersonas.Add(new DataGridPersonas.Persona("Miguel", "Diaz", 21));
        ListaPersonas.Add(new Persona("Silvia", "Aparicio", 21));
        ListaPersonas.Add(new Persona("Antonio", "Sobrino", 18));
        ListaPersonas.Add(new Persona("Javier", "Moreno", 20));
        ListaPersonas.Add(new Persona("Stacy", "Estrada", 21));
        ListaPersonas.Add(new Persona("Carlos", "Mora", 20));
        ListaPersonas.Add(new Persona("Patricia", "López de la Franca", 21));
        ListaPersonas.Add(new Persona("David", "Ruedas", 25));
        ListaPersonas.Add(new Persona("Miguel", "Pelaez", 20));
        ListaPersonas.Add(new Persona("Pedro", "Menchen", 22));
        ListaPersonas.Add(new Persona("Rosa María", "Zapata", 00));

        return ListaPersonas;
    }
    
}
