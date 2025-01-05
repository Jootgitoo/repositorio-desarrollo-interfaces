using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            int[,] matriz = new int[9, 9];

            Operaciones.rellenarMatriz(matriz);
            Operaciones.comprobarNumerosMatriz(matriz);

        }
    }
}
