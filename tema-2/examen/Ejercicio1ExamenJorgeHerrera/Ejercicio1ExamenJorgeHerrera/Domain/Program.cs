using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1ExamenJorgeHerrera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrizMAX = 6;
            int sizeMatrizBarcosMAX = 4;

            string[,] matrizTablero = new string[sizeMatrizMAX, sizeMatrizMAX];
            int[] arrayBarcos = new int[sizeMatrizMAX];

            Operaciones.rellenarMatriz(matrizTablero);
            Console.ReadKey();

            Operaciones.pintarMatriz(matrizTablero);
            Console.ReadKey();

            Operaciones.rellenarArraySizeBarcos(arrayBarcos, sizeMatrizBarcosMAX);
            Console.ReadKey();


            //Operaciones.pintarBarcos(sizeMatrizMAX, matrizTablero, arrayBarcos);
            //Console.ReadKey();

        }
    }
}
