using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posICabeza = 0;
            int posJCabeza = 3;

            int posICola = 0;
            int posJCola = 0;


            //Creo la matriz 
            string[,] tablero = new string[8,8];

            Operaciones.rellenarMatriz(tablero);

            Operaciones.menu();

            Operaciones.eleccion(tablero, posICabeza, posJCabeza, posICola, posJCola);
        }
    }
}
