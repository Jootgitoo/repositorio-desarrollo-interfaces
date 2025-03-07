﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoPersonas.persistence.manages;

namespace proyectoPersonas.domain
{
  internal class Persona
  {
      // constantes & variables =>
    private static int nextId = 1;


    private int id;
    private String nombre;
    private int edad;
    public ManejoPersonas mp;
    private List<Persona> listaPersonas;

    //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
    // constructores =>
    public Persona() => mp = new ManejoPersonas();

        public Persona(string nombre, int edad) 
        {
            mp = new ManejoPersonas();
            this.id = mp.getLastId(this);
            this.nombre = nombre; 
            this.edad = edad;
            
        }

        public Persona(int inputId, string inputNombre, int inputEdad)
        {
            this.id = inputId;
            this.nombre = inputNombre;
            this.edad= inputEdad;
            mp = new ManejoPersonas ();
        }

    //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
    // metodos publicos =>
    // metodo | genListaPersonas | genera y devuelve una lista de personas ==>
        public List<Persona> genListaPersonas()
        {
              listaPersonas = mp.leerPersonas();
              if (listaPersonas.Any())
              {
                    nextId = listaPersonas.Max(p => p.Id) + 1;
              }
              return listaPersonas;
        }

    // metodo | insertar | inserta una persona en la base de datos ==>
        public void insertar ()
        {
            mp.insertarPersona(this);
        }

      // metodo | modificar | modifica una persona en la base de datos ==>
        public void modificar ()
        {
            mp.modificarPersona(this);
        }

      // metodo | eliminar | elimina una persona en la base de datos ==>
        public void eliminar()
        {
            mp.deletePersona(this);
            ResetIdCounter();
        }

      // metodo | ResetIdCounter | resetea el contadort de id ==>
        public static void ResetIdCounter()
        {
            nextId = 1;
        }
        

    //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
    // atributos | getters & setters =>
    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
  }
}
