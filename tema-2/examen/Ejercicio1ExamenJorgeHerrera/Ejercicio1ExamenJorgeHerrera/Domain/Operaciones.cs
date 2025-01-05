using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1ExamenJorgeHerrera
{
    internal class Operaciones
    {

        /// <summary>
        ///     Sirve para rellenar la matriz
        /// </summary>
        /// <param name="matriz">
        ///     Matriz que vamos a recorrer y rellenar
        /// </param>
        public static void rellenarMatriz(string[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Rellenamos la matriz con - en un primer momento
                    matriz[i, j] = "-";
                }
            }
            Console.WriteLine("Matriz rellenada con exito");

        }

        /// <summary>
        ///     Relleno el array de numeros aleatorios que va a ser la longitud de los barcos
        ///     Cada hueco del array va ha ser el tamaño de un barco
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="maxSize"></param>
        public static void rellenarArraySizeBarcos(int[] matriz, int maxSize)
        {
            for(int i = 0;i < matriz.GetLength(0); i++)
            {
               
                matriz[i] = numeroRandom(maxSize);

                Console.Write(matriz[i] + ", ");
            }
            Console.WriteLine("Array de barcos rrellenado con exito");
        }

        private static int numeroRandom(int maxSize)
        {
            Random random = new Random();
            int numeroRandom = random.Next(maxSize) + 1;
            return numeroRandom;
        }

        /// <summary>
        ///     Mostramos la matriz por pantalla
        /// </summary>
        /// <param name="matriz"></param>
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

        //Pintamos los barcos en la matriz
        public static void pintarBarcos(int n, string[,]matriz, int[]sizeBarcos)
        {

            bool colocado = false;
            for( int i = 0; i < sizeBarcos.GetLength(0); i++)
            {

                while (!colocado)
                {
                    int sizeBarco = sizeBarcos[i];

                    Random random = new Random();
                    int posI = random.Next(n) + 1;

                    int direccion = random.Next(5); //Me devuelve un numero entre 0 y 4 que son las 4 direcciones


                    if(direccion == 0) //Colocamos el dibujo hacia la izquierda
                    {
                        for (int j = 0; j < sizeBarco; j++)
                        {

                            
                        }
                    }
                }
                
            }


        }
    }
}
