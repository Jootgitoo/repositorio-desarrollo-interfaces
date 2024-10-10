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
        public static void rellenarMatriz(string[,] matriz, string letraInicial)
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
            matriz[0, 0] = letraInicial;

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
                    Console.Write("= ");
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


        public void sale(Jugador jugador, string[,] matriz, int peces)
        {
            if (matriz[7,7] == "P" || matriz[7,7] == "G" && peces >= 5)
            {
                Console.Write("Enhorabuena! Has conseguido salir del río");
                break;
            }
        }

        //public void movimiento

        /*public void eleccion(Jugador jugador1, Jugador jugador2, string[,] matriz)
        {
            //Aqui vemos a quien le toca, si a pinocho o a gepeto
            Boolean turno = false;

            //Creamos la variable para guardar la opcion
            int opcion;

            //Generamos el numero random para movernos
            Random random = new Random();
            opcion = random.Next(4);

            //Comprobamos que tenga vidas para poder jugar
            if (saltos > 0)
            {
                //Según la opcion hacemos un movimiento u otro
                switch (opcion)
                {
                    //ELEGIMOS LA OPCION 1 --> ARRIBA
                    case "1":
                        //Como vamos hacia arriba I se reduce en 1
                        posI = posI - 1;

                        //Comprobamos que no se salga de la matriz
                        if (posI < 0)
                        {
                            Console.WriteLine("No puedes subir por que te sales de la matriz");

                            //Quitamos un salto
                            saltos = saltos - 1;

                            //Deshacemos el cambio puesto que es invalido
                            posI = posI + 1;

                            //Volvemos a llamar a los métodos
                            Operaciones.pintarMatriz(matriz);
                            Operaciones.menu();
                            Operaciones.eleccion(jugador, matriz, posI, posJ, peces, saltos);

                        }
                        else //Si entra por aquí es que el movimiento es válido
                        {
                            //Comprobamos que valor tiene la posicion en la que nos movemos

                        }



                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    default:



                }


            }
            else //Si no tiene vidas...
            {
                Console.WriteLine(jugador.getNombre + " se ha ahogado!!");
                break;
            }
        }*/
    }

}
