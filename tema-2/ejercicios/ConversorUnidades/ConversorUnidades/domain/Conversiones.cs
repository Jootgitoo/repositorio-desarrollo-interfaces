using ConversorUnidades.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.domain
{
    class Conversiones
    {

        //ATRIBUTOS
        private int idConversion;
        private double resultadoInicial;
        private string unidadPrincipal;
        private double resultadoFinal;
        private string unidadFinal;
        public ManejoConversiones mc;

//----------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTORES
        public Conversiones(double resultadoInicial, string unidadPrincipal, double resultadoFinal, string unidadFinal)
        {
            //Creo la instancia
            mc = new ManejoConversiones();

            this.idConversion = mc.getLastId(this);
            this.resultadoInicial = resultadoInicial;
            this.unidadPrincipal = unidadPrincipal; 
            this.resultadoFinal = resultadoFinal;
            this.unidadFinal = unidadFinal;
        }

        public Conversiones(){}


//----------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        /// <summary>
        ///     Llama al metodo insertarConversion (clase = ManejoConversiones) para realizar el insert en la bbdd
        /// </summary>
        public void insertar()
        {
            mc.insertarConversion(this);
        }


//----------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA
        public int IdConversion { get => idConversion; set => idConversion = value;}
        public double ResultadoInicial { get => resultadoInicial; set => resultadoInicial = value;}
        public string UnidadPrincipal { get => unidadPrincipal; set => unidadPrincipal = value;}
        public double ResultadoFinal { get => resultadoFinal; set => resultadoFinal = value;}
        public string UnidadFinal { get => unidadFinal; set => unidadFinal = value;}



    }
}
