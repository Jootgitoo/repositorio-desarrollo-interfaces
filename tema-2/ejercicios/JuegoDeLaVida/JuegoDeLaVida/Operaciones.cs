using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLaVida
{
    internal class Operaciones
    {
        public static int[] pedirSizeMatriz()
        {
            int[] sizeMatriz = new int[2];

            Console.Write("Dime cuantas filas quieres que tenga la matriz: ");
            sizeMatriz[0] = int.Parse(Console.ReadLine());

            Console.Write("Dime cuantas columnas quieres que tenga la matriz: ");
            sizeMatriz[1] = int.Parse(Console.ReadLine());

            Console.WriteLine();

            return sizeMatriz;
        }

        public static void rellenarMatriz(int[,] matriz)
        {
            Random rnd = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rnd.Next(3);
                }

            }
            pintarMatriz(matriz);
        }

        private static void pintarMatriz(int[,]matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
