using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3.domain;

namespace Ejercicio3.persistence.manages
{
    class ManejoJugador
    {

        DBBroker dbbroker;

        public ManejoJugador() {
            dbbroker = DBBroker.obtenerAgente();
        }

        public void insertar(Jugador j)
        {
            dbbroker.modificar("INSERT INTO bbddEjercicio3.Jugadores (nombreJugador, fecha, nivel, puntuacion) VALUES ('"+j.NombreJugador+"', '"+j.Fecha.ToString("yyyy-MM-dd")+"', "+j.NivelJugador+", "+j.PuntuacionObtenida+")");
        }

    }
}
