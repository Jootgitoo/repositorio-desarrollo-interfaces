using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posI = 0;
            int posJ = 0;

            int pocima = 0;
            int vida = 3;

            string[,] matriz = new string[8, 8];

            Operaciones.rellenarMatriz(matriz);

            Operaciones.pintarMatriz(matriz);

            Operaciones.menu();

            Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
        }
    }
}
