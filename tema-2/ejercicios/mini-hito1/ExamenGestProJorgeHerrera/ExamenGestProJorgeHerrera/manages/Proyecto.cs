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
        
        private string codigoProy;
        private string nombreProy;
        private string descProy;
        private double presupuesto;

        private string[] listaEmpresas;
        private int numeroAleatorio;

        public ManejoProyecto mp;

       

        public Proyecto()
        {

            mp = new ManejoProyecto();
            string[] listaEmpresas = new string[6];
            listaEmpresas[0] = "Allegro";
            listaEmpresas[1] = "Velneo";
            listaEmpresas[2] = "SAP";
            listaEmpresas[3] = "Naturgy";
            listaEmpresas[4] = "Santander";
            listaEmpresas[5] = "MutuaMadrid";
            this.numeroAleatorio = generaNumeroAleatorio();
        }


        public void generarProyecto()
        {
            
            this.codigoProy = generaCodigoProyecto();

            this.nombreProy = listaEmpresas[this.numeroAleatorio];

            this.descProy = "Proyecto numero " +this.codigoProy;

            this.presupuesto = generaFloatAleatorio();
        }

        public void insertarProyecto()
        {
            for (int i = 0; i <= 20; i++)
            {
                generaCodigoProyecto();

                DBBroker dbBroker = DBBroker.obtenerAgente();
                dbBroker.modificar("Insert into bbddProyectoFinal.proyecto (codigoProy, nombreProy, descProy, presupuesto) values '"+this.codigoProy+ "', '"+this.nombreProy+"', '"+this.descProy+"', "+this.presupuesto);

            }
        }

        public void insertar()
        {
            insertarProyecto();
        }

        public string generaCodigoProyecto()
        {
            Random numero = new Random();

            int numeroProyecto = 1;

            string codigoProyecto = "MTR";
            codigoProyecto += "" + numeroProyecto;
            numeroProyecto++;

            int numeroAleatorio = numero.Next(6);

            switch (numeroAleatorio) 
            {
                case 0:
                    codigoProy += "Allegro";
                    break;
                case 1:
                    codigoProy += "Velneo";
                    break;
                case 2:
                    codigoProy += "SAP";
                    break;
                case 3:
                    codigoProy += "Naturgy";
                    break;
                case 4:
                    codigoProy += "Santander";
                    break;
                case 5:
                    codigoProy += "MutuaMadrid";
                    break;
                
            }


            codigoProy += DateTime.Now.Year;
            

            return codigoProy;
        }

        private int generaNumeroAleatorio()
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(5);
            return numeroAleatorio;
        }

        private int generaFloatAleatorio()
        {
            Random numero = new Random();
            double doubleAleatorio = numero.NextDouble() + 0.1;
            doubleAleatorio *= 1000;
            return numeroAleatorio;
        }
        

        public string CodigoProyecto { get => codigoProy; set => codigoProy = value; }
        
        public string NombreProy { get => nombreProy; set => nombreProy = value; }

        public string DescProy { get => descProy; set => descProy = value; }

        public double Presupuesto { get => presupuesto; set => presupuesto = value; }
    }
}
