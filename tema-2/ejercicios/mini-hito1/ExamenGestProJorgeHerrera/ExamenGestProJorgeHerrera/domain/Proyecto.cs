using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Pqc.Crypto.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestProJorgeHerrera.manages
{
    internal class Proyecto
    {

        //ATRIBUTOS
        private string proyectName;
        private DateTime startDate;
        private DateTime endDate;
        private DateTime creationTime;

        public DBBroker dbbroker;

        private string[] listaEmpresas;
        private int numeroAleatorio;


//----------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR

        public Proyecto(string nombreProyecto, DateTime fechaComienzo, DateTime fechaFinal, DateTime fechaCreacion)
        {
            dbbroker = DBBroker.obtenerAgente();
            this.proyectName = nombreProyecto;
            this.startDate = fechaComienzo;
            this.endDate = fechaFinal;
            this.creationTime = fechaCreacion;
            
        }
        public Proyecto()
        {

        }

//----------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        /// <summary>
        ///     Devuelve una lista de los proyectos que se encuentren en la BBDD
        /// </summary>
        /// <returns>
        ///     Devuelve una lista llena de proyecto (1 por "cajón")
        /// </returns>
        public List<Proyecto> generaListaProyecto()
        {
            List<Object> listaObject = new List<Object>();
            List<Proyecto> listaProyecto = new List<Proyecto>();

            String sentenciaSQL = "Select * FROM gestpro.proyect";

            listaObject = dbbroker.leer(sentenciaSQL);

            foreach (List<Object> aux in listaObject)
            {
                Proyecto p = new Proyecto();
                p = new Proyecto(aux[0].ToString(), Convert.ToDateTime(aux[1]), Convert.ToDateTime(aux[2]), Convert.ToDateTime(aux[3]) );
                listaProyecto.Add(p);
            }

            return listaProyecto;

        }

        /// <summary>
        ///     Inserta una proyecto en la BBDD
        /// </summary>
        /// <param name="proyecto"></param>
        public void insert(Proyecto proyecto)
        {
            string sentenciaSQL = "Insert into gestpro.Proyect (ProyectName, StartDate, EndDate, CreationTime) values ('"+proyecto.proyectName+"', "+proyecto.startDate+", "+proyecto.endDate+", "+proyecto.creationTime+")";
            
            dbbroker.modificar(sentenciaSQL);
        }

        /// <summary>
        ///     Actualiza un proyecto en la BBDD
        /// </summary>
        /// <param name="proyecto"></param>
        public void modify(Proyecto proyecto)
        {
            string sentenciaSQL = "UPDATE gestpro.Proyect SET ProyectName = '" +proyecto.proyectName+ "', StartDate = " +proyecto.StartDate+ ", EndDate = "+proyecto.endDate+ ", CrationTime = " +proyecto.endDate;
            dbbroker.modificar(sentenciaSQL);
        }


        /// <summary>
        ///     Borra un proyecto en la BBDD
        /// </summary>
        /// <param name="proyecto"></param>
        public void delete(int idProyecto)
        {
            string sentenciaSQL = "DELETE FROM gestpro.Proyect WHERE idProyect = " + idProyecto;
        }


        public string ProyectName { get => proyectName; set => proyectName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime CreationTime { get => creationTime; set => creationTime = value; }

        //public Proyecto()
        //{

        //    mp = new ManejoProyecto();
        //    string[] listaEmpresas = new string[6];
        //    listaEmpresas[0] = "Allegro";
        //    listaEmpresas[1] = "Velneo";
        //    listaEmpresas[2] = "SAP";
        //    listaEmpresas[3] = "Naturgy";
        //    listaEmpresas[4] = "Santander";
        //    listaEmpresas[5] = "MutuaMadrid";
        //    this.numeroAleatorio = generaNumeroAleatorio();
        //}


        //public void generarProyecto()
        //{

        //    this.codigoProy = generaCodigoProyecto();

        //    this.nombreProy = listaEmpresas[this.numeroAleatorio];

        //    this.descProy = "Proyecto numero " + this.codigoProy;

        //    this.presupuesto = generaFloatAleatorio();
        //}

        //public void insertarProyecto()
        //{
        //    for (int i = 0; i <= 20; i++)
        //    {
        //        generaCodigoProyecto();

        //        DBBroker dbBroker = DBBroker.obtenerAgente();
        //        dbBroker.modificar("Insert into bbddProyectoFinal.proyecto (codigoProy, nombreProy, descProy, presupuesto) values '" + this.codigoProy + "', '" + this.nombreProy + "', '" + this.descProy + "', " + this.presupuesto);

        //    }
        //}

        //public void insertar()
        //{
        //    insertarProyecto();
        //}

        //public string generaCodigoProyecto()
        //{
        //    Random numero = new Random();

        //    int numeroProyecto = 1;

        //    string codigoProyecto = "MTR";
        //    codigoProyecto += "" + numeroProyecto;
        //    numeroProyecto++;

        //    int numeroAleatorio = numero.Next(6);

        //    switch (numeroAleatorio)
        //    {
        //        case 0:
        //            codigoProy += "Allegro";
        //            break;
        //        case 1:
        //            codigoProy += "Velneo";
        //            break;
        //        case 2:
        //            codigoProy += "SAP";
        //            break;
        //        case 3:
        //            codigoProy += "Naturgy";
        //            break;
        //        case 4:
        //            codigoProy += "Santander";
        //            break;
        //        case 5:
        //            codigoProy += "MutuaMadrid";
        //            break;

        //    }


        //    codigoProy += DateTime.Now.Year;


        //    return codigoProy;
        //}

        //private int generaNumeroAleatorio()
        //{
        //    Random numero = new Random();
        //    int numeroAleatorio = numero.Next(5);
        //    return numeroAleatorio;
        //}

        //private int generaFloatAleatorio()
        //{
        //    Random numero = new Random();
        //    double doubleAleatorio = numero.NextDouble() + 0.1;
        //    doubleAleatorio *= 1000;
        //    return numeroAleatorio;
        //}

    }
}
