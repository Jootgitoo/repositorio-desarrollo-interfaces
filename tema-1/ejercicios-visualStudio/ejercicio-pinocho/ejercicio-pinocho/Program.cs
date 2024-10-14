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

            //Relleno la matriz
            Operaciones.rellenarMatriz(matriz, "P");
            Console.ReadKey();


            //Primero juega pinocho
            Operaciones.movimiento(pinocho, matriz);
            Console.ReadKey();

            


            //Segundo juega gepeto
            Operaciones.movimiento(gepeto, matriz);
            Console.ReadKey();

            //Escribo los movimientos de los jugadores
            Operaciones.escribirMovimientos(pinocho);
            Console.ReadKey();
            Operaciones.escribirMovimientos(gepeto);
            Console.ReadKey();

            //Digo quien es el ganador
            Operaciones.comprobarGanador(pinocho, gepeto);
            Console.ReadKey();




        }
    }

}
