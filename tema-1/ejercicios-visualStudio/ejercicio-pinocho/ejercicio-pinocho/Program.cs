using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_pinocho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo a los dos jugadores
            Jugador pinocho = new Jugador("Pinocho");
            Jugador gepeto = new Jugador("Gepeto");

            //Creo la matriz
            string[,] matriz = new string[8, 8];

            //Primero juega pinocho
            Operaciones.rellenarMatriz(matriz, "P");
            Operaciones.pintarMatriz(matriz);
            Operaciones.movimiento(pinocho, matriz);
            Console.ReadKey();


            //Segundo juega gepeto


        }
    }

}
