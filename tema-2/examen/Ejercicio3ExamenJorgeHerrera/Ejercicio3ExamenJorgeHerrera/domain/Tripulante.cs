using Ejercicio3ExamenJorgeHerrera.persistence.Manajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3ExamenJorgeHerrera.domain
{
    internal class Tripulante
    {

        private static int nextDni = 1;


        private string dni;
        private string name;
        private string surname;
        private int age;
        private string birthday;
        private string crewCharge;

        public ManejoTripulantes mt;
        private List<Tripulante> listaTripulantes;


        public string Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }
        public string Birthday { get => surname; set => surname = value; }
        public string CrewCharge { get => surname; set => surname = value; }


        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        // constructores =>

        public Tripulante() => mt = new ManejoTripulantes();

        public Tripulante(string dni, string name, string surname, int edad, string birthday, string crewCharge)
        {
            mt = new ManejoTripulantes();
            this.dni = dni;
            this.name = name;
            this.surname = surname;
            this.age = edad;
            this.birthday = birthday;
            this.crewCharge = crewCharge;

        }
        //————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        // metodos =>


        /*public List<Tripulante> genListaTripulantes()
        {
            listaTripulantes = mt.leerTripulantes();
            if (listaTripulantes.Any())
            {
                //nextDni = listaTripulantes.Max(t => t.Dni) + 1;
                
            }
            return listaTripulantes;
        }
        */

        public void insertar()
        {
            mt.insertarTripulante(this);
        }

        // metodo | modificar | modifica una persona en la base de datos ==>
        public void modificar()
        {
            mt.modificarPersona(this);
        }

        // metodo | eliminar | elimina una persona en la base de datos ==>
        public void eliminar()
        {
            mt.deletePersona(this);
            ResetIdCounter();
        }

        public static void ResetIdCounter()
        {
            nextDni = 1;
        }



    }
}
