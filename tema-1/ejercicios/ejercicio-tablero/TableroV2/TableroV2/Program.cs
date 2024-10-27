using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableroV2
{
    internal static class Program
    {

        static void Main()
        {
            string[,] tablero = new string[4, 4];

            Operaciones.rellenarMatriz(tablero, "X");

            Operaciones.ponerPosicion(tablero, 0, 0, "0");

            // Operaciones.mostrarMenu();

            Operaciones.mostrarMatriz(tablero);

            Operaciones.moverPosicion(tablero, 0, 0, 0, 3);
            Operaciones.mostrarMatriz(tablero);


            Operaciones.moverPosicion(tablero, 0, 3, 2, 2);
            Operaciones.mostrarMatriz(tablero);
        }
    }
}
