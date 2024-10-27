using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace TableroV2
{
    internal class Operaciones
    {

        //Rellenar la matriz con una cadena dada
        public static void rellenarMatriz(string[,] matriz, string cadena)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = cadena;
                }
            }
        }


        public static void ponerPosicion(String[,] matriz, int posI, int posJ, string cadena)
        {
            matriz[posI, posJ] = cadena;
        }



        public static void mostrarMenu()
        {
            int opcion;
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("1. Derecha");
                Console.WriteLine("2. Izquierda");
                Console.WriteLine("3. Abajo");
                Console.WriteLine("4. Arriba");
                Console.WriteLine("5. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());


                switch (opcion)
                {
                    case 1:

                    case 5:
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Solo opciones entre 1 y 5");
                        break;

                }


            }
        }


        public static void mostrarMatriz(string[,] matriz)
        {
            for(int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        public static void moverPosicion(string[,] matriz, int posI, int posJ, int nuevaPosI, int nuevaPosJ)
        {
            if (posI >= 4 || posJ >= 4 || nuevaPosI >= 4 || nuevaPosJ >= 4)
            {
                Console.WriteLine("Te estas saliendo del tablero");
                Operaciones.mostrarMenu();
            }
            else
            {

                matriz[posI, posJ] = "X";
                matriz[nuevaPosI, nuevaPosJ] = "0";
            }
        }


    }
}
