using System;
using System.Collections.Generic;
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
                    Console.Write(matriz[i,j] + " " );
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
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    matriz[i,j] = rand.Next(9);
                }
            }

            //Pinto la matriz
            for( int i=0; i< matriz.GetLength(0); i++)
            {
                for(int j=0; j< matriz.GetLength(1); j++)
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
            for(int i = 0;i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    matriz1[i,j] = random.Next(9);
                    Console.Write(matriz1[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Relleno matriz2 de numeros aleatorios
            Console.WriteLine("..........................................");
            Console.WriteLine("Matriz 2");
            for (int i = 0; i< matriz2.GetLength(0); i++)
            {
                for(int j = 0; j < matriz2.GetLength(1); j++)
                {
                    matriz2[i,j] = random.Next(9);
                    Console.Write(matriz2[i, j] + " ");

                }
                Console.WriteLine();

            }

            //Sumo las matrizes por posicion (la pos [0,0] con la [0,0]) e imprimo el resultado sumado
            Console.WriteLine("..........................................");
            Console.WriteLine("Matriz sumada");
            for (int i = 0; i<matriz1.GetLength(0) ; i++)
            {
                for(int j=0; j<matriz1.GetLength(1); j++)
                {
                    int resultado = matriz1[i,j] + matriz2[i,j];
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
            int sizeMatriz = Int32.Parse( Console.ReadLine() );

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
                    Console.Write(matriz1[i,j] + " ");
                }
                Console.WriteLine();
            }

            //Relleno la segunda matriz
            Console.WriteLine("-----Matriz2-----");
            for (int i=0; i< matriz2.GetLength(0); i++)
            {
                for( int j = 0;j < matriz2.GetLength(1); j++)
                {
                    matriz2[i, j] = random.Next(9);
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----Matriz final-----");

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for ( int j = 0; j< matriz1.GetLength(1); j++)
                {
                    int solucion = matriz1[i,j] - matriz2[i,j];
                    Console.Write(solucion.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
