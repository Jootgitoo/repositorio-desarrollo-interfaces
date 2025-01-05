using ConversorUnidades.domain;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.persistence.manages
{
    class ManejoConversiones
    {
        //ATRIBUTOS
        DBBroker dbbroker;
        int lastId;

//--------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR
        public ManejoConversiones()
        {
            dbbroker = DBBroker.obtenerAgente();
        }

//--------------------------------------------------------------------------------------------------------
        //MÉTODOS
        public void insertarConversion(Conversiones conversion)
        {
            //Para meter doubles en la bbdd los tienes que mandar como string
            string resultadoInicial = Convert.ToString(conversion.ResultadoInicial, CultureInfo.InvariantCulture);
            string resultadoFinal = Convert.ToString(conversion.ResultadoFinal, CultureInfo.InvariantCulture);

            dbbroker.modificar("INSERT INTO bbddconversorunidades.Conversion (idConverison, resultadoInicial, unidadPrincipal, resultadoFinal, unidadFinal) VALUES (" +conversion.IdConversion+", "+resultadoInicial+", '"+conversion.UnidadPrincipal+"', "+resultadoFinal+", '"+conversion.UnidadFinal+"'  )");
        }

        public int getLastId(Conversiones conversiones)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("select COALESCE(MAX(ID),0) FROM  bbddconversorunidades.conversion");

            foreach(List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }
            return lastId;
        }

    }
}
