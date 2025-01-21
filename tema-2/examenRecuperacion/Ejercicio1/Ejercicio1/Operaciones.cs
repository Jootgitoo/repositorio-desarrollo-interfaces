using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Operaciones
    {
        /// <summary>
        ///     Relleno la matriz con las S-->Serpiente, R --> Ratón, p--> Pared
        /// </summary>
        /// <param name="matriz">
        ///     Matriz a rellenar
        /// </param>
        public static void rellenarMatriz(string[,] matriz)
        {
            //Creamos la variable random
            Random random = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    //Generamos el nº random y lo añadimos a la matriz. 
                    //Le pongo q me genere numeros 1,2,3 para cuando genere el 3 dejar ese hueco vacio
                    int nRandom = random.Next(3) + 1;

                    if (nRandom == 1) //Pongo una pared
                    {

                        matriz[i, j] = "P";

                    } else if(nRandom == 2) //Pongo un ratón
                    {

                        matriz[i, j] = "R";

                    } else //Pinto V de vacio
                    {
                        matriz[i, j] = "V";
                    }
                }
            }

            //En los 4 primeros huecos escribimos la serpiente
            matriz[0, 0] = "S";
            matriz[0, 1] = "S";
            matriz[0, 2] = "S";
            matriz[0, 3] = "S";


            pintarMatriz(matriz);
        }


        /*
         * Mostramos la matriz por pantalla
         */
        private static void pintarMatriz(string[,] matriz)
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


        /// <summary>
        ///     Muestras el menú por panatalla
        /// </summary>
        public static void menu()
        {
            Console.WriteLine("W. Arriba");
            Console.WriteLine("S. Abajo");
            Console.WriteLine("A. Izquierda");
            Console.WriteLine("D. Derecha");
        }


        private static bool comprobarGanador(string[,] matriz)
        {
            bool gana = false;

            for(int i = 0;i < matriz.GetLength(0); i++)
            {
                for(int j = 0;j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] == "R")
                    {
                        gana = false;
                        return gana;
                    }
                }
            }
            gana = true;
            return gana;
        }

        /// <summary>
        ///     Aqui se realiza todo el juego
        /// </summary>
        /// <param name="matriz"></param>
        public static void eleccion(string[,] matriz, int posICabeza, int posJCabeza, int posICola, int posJCola)
        {
            //Creamos la variable opcion
            string opcion;

            //Preguntamos hacia donde quiere moverse el usuario
            Console.WriteLine("¿Hacia donde quieres moverte?");

            //Y lo guardamos
            opcion = Console.ReadLine();

            //Según la opcion hacemos un movimiento
            switch (opcion)
            {
                case "W": //Hacia arriba

                    posICabeza = posICabeza - 1;

                    if (posICabeza < 0) //Movimiento invalido
                    {
                        Console.WriteLine("Con este movimiento te sales de la matriz");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        //Deshacemos el cambio
                        posICabeza = posICabeza + 1;

                        //Volvemos a enseñar el menú con los movimientos
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                    }
                    else //Movimiento válido
                    {
                        //Comprobamos que valor tiene la matriz
                        if (matriz[posICabeza, posJCabeza] == "P") //Pared
                        {
                            Console.WriteLine("Te has chocado con una pared");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            //Deshacemos el cambio
                            posICabeza = posICabeza + 1;

                            //Volvemos a enseñar el menú con los movimientos
                            pintarMatriz(matriz);
                            menu();
                            eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                        }
                        else if (matriz[posICabeza, posJCabeza] == "R") //Raton 
                        {
                            Console.WriteLine("Te has comido un ratón");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";


                        }
                        else if (matriz[posICabeza, posJCabeza] == "V") //Vacio
                        {
                            Console.WriteLine("No has encontrado nada");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";
                        }
                    }
                    bool gana = comprobarGanador(matriz);

                    if (gana)
                    {
                        Console.WriteLine("Has ganado el juego!");
                        
                        break;

                    }
                    {
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);
                    }
                    break;

                case "S": //Hacia abajo

                    //Como vamos hacia abajo la nueva posicion de i es la posicion de i + 1
                    posICabeza = posICabeza + 1;

                    if (posICabeza < 0) //Movimiento invalido
                    {
                        Console.WriteLine("Con este movimiento te sales de la matriz");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        //Deshacemos el cambio
                        posICabeza = posICabeza - 1;

                        //Volvemos a enseñar el menú con los movimientos
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                    }
                    else //Movimiento valido
                    {
                        //Comprobamos que valor tiene la matriz
                        if (matriz[posICabeza, posJCabeza] == "P") //Pared
                        {
                            Console.WriteLine("Te has chocado con una pared");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            //Deshacemos el cambio
                            posICabeza = posICabeza - 1;

                            //Volvemos a enseñar el menú con los movimientos
                            pintarMatriz(matriz);
                            menu();
                            eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                        }
                        else if (matriz[posICabeza, posJCabeza] == "R") //Raton 
                        {
                            Console.WriteLine("Te has comido un ratón");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";


                        }
                        else if (matriz[posICabeza, posJCabeza] == "V") //Vacio
                        {
                            Console.WriteLine("No has encontrado nada");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";
                        }
                    }
                    gana = comprobarGanador(matriz);

                    if (gana)
                    {
                        Console.WriteLine("Has ganado el juego!");

                        break;

                    }
                    {
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);
                    }

                    break;

                case "A":

                    //Como vamos hacia la izquierda la nueva posicion de j es la posicion de j - 1
                    posJCabeza = posJCabeza - 1;


                    if (posJCabeza < 0) //Movimiento invalido
                    {
                        Console.WriteLine("Con este movimiento te sales de la matriz");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        //Deshacemos el cambio
                        posJCabeza = posJCabeza + 1;

                        //Volvemos a enseñar el menú con los movimientos
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                    }
                    else //Movimiento valido
                    {
                        //Comprobamos que valor tiene la matriz
                        if (matriz[posICabeza, posJCabeza] == "P") //Pared
                        {
                            Console.WriteLine("Te has chocado con una pared");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            //Deshacemos el cambio
                            posJCabeza = posJCabeza + 1;

                            //Volvemos a enseñar el menú con los movimientos
                            pintarMatriz(matriz);
                            menu();
                            eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                        }
                        else if (matriz[posICabeza, posJCabeza] == "R") //Raton 
                        {
                            Console.WriteLine("Te has comido un ratón");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";


                        }
                        else if (matriz[posICabeza, posJCabeza] == "V") //Vacio
                        {
                            Console.WriteLine("No has encontrado nada");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";
                        }
                    }
                    gana = comprobarGanador(matriz);

                    if (gana)
                    {
                        Console.WriteLine("Has ganado el juego!");

                        break;

                    }
                    {
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);
                    }

                break;

                case "D":

                    //Como vamos hacia la derecha la nueva posicion de j es la posicion de j + 1
                    posJCabeza = posJCabeza + 1;


                    if (posJCabeza < 0) //Movimiento invalido
                    {
                        Console.WriteLine("Con este movimiento te sales de la matriz");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        //Deshacemos el cambio
                        posJCabeza = posJCabeza - 1;

                        //Volvemos a enseñar el menú con los movimientos
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                    }
                    else //Movimiento valido
                    {
                        //Comprobamos que valor tiene la matriz
                        if (matriz[posICabeza, posJCabeza] == "P") //Pared
                        {
                            Console.WriteLine("Te has chocado con una pared");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            //Deshacemos el cambio
                            posJCabeza = posJCabeza - 1;

                            //Volvemos a enseñar el menú con los movimientos
                            pintarMatriz(matriz);
                            menu();
                            eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);

                        }
                        else if (matriz[posICabeza, posJCabeza] == "R") //Raton 
                        {
                            Console.WriteLine("Te has comido un ratón");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";


                        }
                        else if (matriz[posICabeza, posJCabeza] == "V") //Vacio
                        {
                            Console.WriteLine("No has encontrado nada");

                            //Rellena la casilla con la cabeza de la serpmiente
                            matriz[posICabeza, posJCabeza] = "S";

                            //Rellenas la ultima casilla con v 
                            matriz[posICola, posJCola] = "V";
                        }
                    }
                    gana = comprobarGanador(matriz);

                    if (gana)
                    {
                        Console.WriteLine("Has ganado el juego!");

                        break;

                    }
                    {
                        pintarMatriz(matriz);
                        menu();
                        eleccion(matriz, posICabeza, posJCabeza, posICola, posJCola);
                    }
                break;
            }

        }
    }
}
