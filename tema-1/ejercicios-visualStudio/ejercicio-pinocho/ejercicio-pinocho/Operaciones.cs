using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_pinocho
{
    internal class Operaciones
    {

        /*
         * Rellenamos la matriz con números aleatorios random entre el 0 y el 2
         */
        public static void rellenarMatriz(string[,] matriz)
        {
            //Creamos la variable random
            Random random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Generamos el nº random y lo añadimos a la matriz
                    matriz[i, j] = random.Next(4).ToString();
                }
            }
            matriz[0, 0] = "P";
            matriz[1, 0] = "G";

            Console.ReadKey();

        }

        /*
         * Mostramos la matriz por pantalla
         */
        public static void pintarMatriz(string[,] matriz)
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


        public static void menu()
        {
            Console.WriteLine("1. Arriba");
            Console.WriteLine("2. Abajo");
            Console.WriteLine("3. Izquierda");
            Console.WriteLine("4. Derecha");
            Console.WriteLine("5. Salir");

            Console.ReadKey();


        }
    }

}
