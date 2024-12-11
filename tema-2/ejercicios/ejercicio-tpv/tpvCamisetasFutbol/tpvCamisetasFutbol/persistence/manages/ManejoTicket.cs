using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvCamisetasFutbol.domain;

namespace tpvCamisetasFutbol.persistence.manages
{
    internal class ManejoTicket
    {
        //ATRIBUTOS
        DBBroker dbbroker;
        int lastId;

//-------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR
        public ManejoTicket()
        {
            dbbroker = DBBroker.obtenerAgente();
        }

//-------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        public void insertarTicket(Ticket ticket)
        {
            string total = Convert.ToString(ticket.Total, CultureInfo.InvariantCulture);

            dbbroker.modificar("INSERT INTO bbddTPV.Ticket (idTicket, Fecha, Cliente, Total) VALUES (" + ticket.Id + ", '" + ticket.Fecha.ToString("yyyy-MM-dd") + "', '" + ticket.Cliente + "', " + total + ")");
        }


        public int getLastId(Ticket ticket)
        {
            List<Object> listaAux;
            listaAux = DBBroker.obtenerAgente().leer("select COALESCE(MAX(id), 0) FROM bbddtpv.Ticket");

            foreach (List<Object> aux in listaAux)
            {
                lastId = Convert.ToInt32(aux[0]) + 1;
            }

            return lastId;
        }

    }

}
