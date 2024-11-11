using DataGridPersonas;
using DataGridPersonas.persistence;
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
    public void readPeople()
    {
        Persona p = null;
        List<Object> lpeople;
        lpeople = DBBroker.obtenerAgente().leer("select * from people order by idpeople");
        
        foreach(List<Object> aux in lpeople)
        {
            p = new Persona(Int32.Parse(aux[0].ToString()));
            p.Nombre = aux[1].ToString();
            p.Edad = Int32.Parse(aux[2].ToString());
            this.listPeople.Add(p);
        }

    }
    
}
