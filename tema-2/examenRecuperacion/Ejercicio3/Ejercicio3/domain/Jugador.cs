using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.persistence.manages;

namespace Ejercicio3.domain
{
    class Jugador
    {

        private string nombreJugador;
        private DateTime fecha;
        private int nivelJugador;
        private int puntuacionObtenida;

        public ManejoJugador mj;

        public Jugador( string nombreJugador, DateTime fecha, int nivel, int puntuacion )
        {
            mj = new ManejoJugador();
            this.nombreJugador = nombreJugador;
            this.fecha = fecha;
            this.nivelJugador = nivel;
            this.puntuacionObtenida = puntuacion;
        }


        public void insertar()
        {
            mj.insertar(this);
        }





        public String NombreJugador { get => nombreJugador;}
        public DateTime Fecha { get => fecha;}
        public int NivelJugador { get => nivelJugador; }
        public int PuntuacionObtenida { get => puntuacionObtenida;  }
    }
}
