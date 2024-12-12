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


        /// <summary>
        ///     Inserta un ticket en la bbdd
        /// </summary>
        /// <param name="ticket">
        ///     Objeto ticket que se va ha insertar
        /// </param>
        public void insertarTicket(Ticket ticket)
        {
            string total = Convert.ToString(ticket.Total, CultureInfo.InvariantCulture);

            dbbroker.modificar("INSERT INTO bbddTPV.Ticket (idTicket, Fecha, Cliente, Total) VALUES (" + ticket.Id + ", '" + ticket.Fecha.ToString("yyyy-MM-dd") + "', '" + ticket.Cliente + "', " + total + ")");
        }


        /// <summary>
        ///     Obtiene el ultimo id y le añade uno para ponerselo al ticket nuevo
        ///     El de la bbdd es autoincremental
        /// </summary>
        /// <param name="ticket">
        ///     El ticket que se va ha añadir en la bbdd
        /// </param>
        /// <returns>
        ///     Devuelve el id del ultimo ticket + 1 que será el que se le añada al nuevo ticket
        /// </returns>
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
