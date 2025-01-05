using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Operaciones
    {

        /// <summary>
        ///     Relleno la matriz de numeros aleatorios
        /// </summary>
        /// <param name="matriz">
        ///     Matriz que se va a rellenar 
        /// </param>
        public static void rellenarMatriz(int[,] matriz)
        {
            Random random = new Random();

            for (int i=0; i< matriz.GetLength(0); i++)
            {
                for (int j=0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(10) + 1;
                }
            }
            pintarMatriz(matriz);
        }

        public static void pintarMatriz(int[,] matriz)
        {
            for(int i=0; i< matriz.GetLength(0); i++)
            {
                for( int j=0;j< matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public static void comprobarNumerosMatriz(int[,] matriz)
        {
            bool correcto = false;

            for (int i=0;i< matriz.GetLength(0); i++)
            {
                for(int j=0; j< matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > 0 || matriz[i,j] <= 10)
                    {
                        correcto = true;
                    }
                    else
                    {
                        correcto = false;
                        break;
                    }
                }
            }
            Console.WriteLine("Matriz valida: " +correcto);
            Console.ReadKey();
        }
    }
}
