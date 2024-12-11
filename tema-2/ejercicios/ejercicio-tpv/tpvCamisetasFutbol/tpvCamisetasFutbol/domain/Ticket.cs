using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpvCamisetasFutbol.persistence.manages;

namespace tpvCamisetasFutbol.domain
{
    internal class Ticket
    {
        //ATRIBUTOS
        private int id;
        private DateTime fecha;
        private string cliente;
        private double total;
        public ManejoTicket mt;

//-------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR

        public Ticket( DateTime fecha, double total)
        {
            mt = new ManejoTicket();
            this.id = mt.getLastId(this);
            this.fecha = fecha;
            this.total = total;
        }

        public Ticket()
        {
            mt = new ManejoTicket();
        }

//-------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS

        public void insertar()
        {
            mt.insertarTicket(this);
        }

//-------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA

        public int Id { get => id;  }

        public DateTime Fecha { get => fecha; set => fecha = value; }

        public string Cliente { get => cliente; set => cliente = value; }

        public double Total { get => total; set => total = value; }


    }
}
