using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatrices
{
    internal class Operaciones
    {

        public static void imprimirMatriz()
        {
            Console.WriteLine("EJERCICIO 1");

            int[,] matriz = new int[3, 3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;

            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            matriz[2, 0] = 7;
            matriz[2, 1] = 8;
            matriz[2, 2] = 9;

            //matriz.GetLength(0) --> Para obtener el numero de filas
            //matriz.GetLength(1) --> Para obtener el numero de columnas
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


        public static void imprimirCuadrados()
        {
            Console.WriteLine("EJERCICIO 2");


            Console.Write("Cuantos numeros de lado y alto quieres que tenga el cuadrado: ");
            int numero = Int32.Parse(Console.ReadLine());


            int[,] matriz = new int[numero, numero];

            //Relleno la matriz
            Random rand = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(9);
                }
            }

            //Pinto la matriz
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


        public static void sumaDosMatrices()
        {
            Console.WriteLine("EJERCICIO 3");

            Console.Write("Cuantos numeros de lado y alto quieres que tenga el cuadrado: ");
            int numero = Int32.Parse(Console.ReadLine());

            int[,] matriz1 = new int[numero, numero];
            int[,] matriz2 = new int[numero, numero];

            Random random = new Random();

            //Relleno matriz1 de numeros aleatorios
            Console.WriteLine("..........................................");
            Console.WriteLine("Matriz 1");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = random.Next(9);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Relleno matriz2 de numeros aleatorios
            Console.WriteLine("..........................................");
            Console.WriteLine("Matriz 2");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = random.Next(9);
                    Console.Write(matriz2[i, j] + " ");

                }
                Console.WriteLine();

            }

            //Sumo las matrizes por posicion (la pos [0,0] con la [0,0]) e imprimo el resultado sumado
            Console.WriteLine("..........................................");
            Console.WriteLine("Matriz sumada");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    int resultado = matriz1[i, j] + matriz2[i, j];
                    Console.Write(resultado + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }

        public static void restarMatrices()
        {
            Console.WriteLine("EJERCICIO 4");

            Console.Write("Dime el numero de cuanto quieres que sea la matriz: ");
            int sizeMatriz = Int32.Parse(Console.ReadLine());

            int[,] matriz1 = new int[sizeMatriz, sizeMatriz];
            int[,] matriz2 = new int[sizeMatriz, sizeMatriz];

            Random random = new Random();

            Console.WriteLine("-----Matriz 1-----");
            //Relleno la primera matriz
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i, j] = random.Next(9);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Relleno la segunda matriz
            Console.WriteLine("-----Matriz2-----");
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = random.Next(9);
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----Matriz final-----");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    int solucion = matriz1[i, j] - matriz2[i, j];
                    Console.Write(solucion.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        public static void matrizTraspuesta()
        {
            Console.WriteLine("EJERCICIO 5");


            Console.Write("Di el número de filas y columnas de la matriz: ");

            int sizeMatriz = Int32.Parse(Console.ReadLine());

            int[,] matriz1 = new int[sizeMatriz, sizeMatriz];

            Random rand = new Random();

            //Relleno la primera matriz
            Console.WriteLine("********Primera matriz*********");
            for (int i = 0; i < sizeMatriz; i++)
            {
                for (int j = 0; j < sizeMatriz; j++)
                {
                    matriz1[i, j] = rand.Next(9);
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Hago la matriz traspuesta
            int[,] matrizTraspuesta = new int[sizeMatriz, sizeMatriz];

            Console.WriteLine("***********Matriz traspuesta****************");
            for (int i = 0; i < sizeMatriz; i++)
            {
                for (int j = 0; j < sizeMatriz; j++)
                {
                    matrizTraspuesta[j, i] = matriz1[i, j];
                    Console.Write(matrizTraspuesta[i, j] + " ");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        public static void sumarDiagonales()
        {
            Console.WriteLine("EJERCICIO 6");

            Console.Write("Que tamaño quieres que tenga la matriz?: ");
            int sizeMatriz = Int32.Parse(Console.ReadLine());

            int[,] matriz = new int[sizeMatriz, sizeMatriz];

            Random rand = new Random();

            Console.WriteLine("*****Rellenando la matriz******");
            for (int i = 0; i < sizeMatriz; i++)
            {
                for (int j = 0; j < sizeMatriz; j++)
                {
                    matriz[i, j] = rand.Next(9);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("*****Suma de las diagonales*****");

            int sumaDiagonales = 0; 
            for (int i = 0; i < sizeMatriz; i++)
            {
                for (int j = 0; j < sizeMatriz; j++)
                {
                    if (i == j) // Check if it's the right diagonal (i.e., where row index equals column index)
                    {
                        sumaDiagonales += matriz[i, j]; // Accumulate the sum of the right diagonal elements
                    }
                }
                Console.WriteLine();

            }
            Console.WriteLine( "Resultado de sumar las diagonales: " +sumaDiagonales);

            Console.ReadKey();
        }


        public static void sumaFilasColumnas()
        {
            Console.WriteLine("*****EJERCICIO 7*****");

            Console.Write("De que tamaño quieres la matriz cuadrada: ");
            int sizeMatriz = Int32.Parse(Console.ReadLine());

            int[,] matriz = new int[sizeMatriz, sizeMatriz];

            Console.WriteLine("*****RELLENO LA MATRIZ*****");
            Random rand = new Random();
            for(int i=0; i<matriz.GetLength(0); i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++)
                {
                    matriz[i, j] = rand.Next(9);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Creo la matriz con una fila y columna mas para la suma
            int[,] matrizFilasColumnasSumadas = new int[matriz.GetLength(0)+1, matriz.GetLength(0)+1];

            Console.WriteLine("Matriz con las filas y columnas sumadas");

            int sumaFila = 0;
            int sumaColumnas = 0;


            //Sumo las filas
            for (int i=0; i<matriz.GetLength(0); i++)
            {
                for(int j=0; j<matriz.GetLength(1); j++){

                    if (j == (matriz.GetLength(0)))
                    {
                        sumaFila += matriz[i, j];
                    }
                    else
                    {
                        matrizFilasColumnasSumadas[i, j] = sumaFila;
                    }
                }
                sumaFila = 0;
            }

            
            //Sumo las columnas
            for( int j=0; j < matriz.GetLength(1); j++)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    if (i == (matriz.GetLength(0)))
                    {
                        matrizFilasColumnasSumadas[i, j] = sumaFila;

                    }
                    else
                    {
                        sumaFila += matriz[i, j];
                    }
                }
                sumaColumnas = 0;
            }


            //Imprimo la matriz grande
            for(int i=0; i<matrizFilasColumnasSumadas.GetLength(0); i++)
            {
                for ( int j = 0; j < matrizFilasColumnasSumadas.GetLength(1); j++)
                {
                    Console.Write(matrizFilasColumnasSumadas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
