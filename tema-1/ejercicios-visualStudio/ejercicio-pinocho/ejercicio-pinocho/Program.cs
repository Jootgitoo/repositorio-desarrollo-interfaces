using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_pinocho
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador pinocho = new Jugador("Pinocho");
            Jugador gepeto = new Jugador("Gepeto");

            string[,] matriz = new string[8, 8];

            Operaciones.rellenarMatriz(matriz, "P");
            Operaciones.menu();
            Operaciones.eleccion();


        }
    }

}
