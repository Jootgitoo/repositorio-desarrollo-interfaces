using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioBros
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
                    matriz[i, j] = random.Next(3).ToString();
                }
            }
            matriz[0, 0] = "M";

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

        public static void eleccion(string[,] matriz, int posI, int posJ, int pocima, int vida)
        {
            //Creamos la variable opcion
            string opcion;

            //Creamos una variable random para generar un numero random
            Random random = new Random();

            //Preguntamos hacia donde quiere moverse el usuario
            Console.WriteLine("¿Hacia donde quieres moverte?");
            //Y lo calculamos
            opcion = Console.ReadLine();

            //Primero comprovamos que tengamos vidas. Si tenemos sigue el programa, si no termina el programa
            if (vida > 0)
            {
                //Según la opcion que hayamos elegido hacemos
                switch (opcion)
                {
                    //ELEGIMOS LA OPCION 1 --> ARRIBA
                    case "1":
                        //Como vamos hacia arriba la nueva posicion de i es la posicion de i - 1
                        posI = posI - 1;

                        //Comprovamos que no se salga de nuestra matriz (Si es menor q 0 es que se ha salido por arriba)
                        if (posI < 0)
                        {
                            //Mensaje de traza para informacion del usuario
                            Console.WriteLine("Movimiento equivocado. -1 vida");

                            //Restamos una vida
                            vida = vida - 1;

                            //Deshacemos el cambio puesto que mario no se ha movido
                            posI = posI + 1;

                            //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                            Operaciones.pintarMatriz(matriz);
                            Operaciones.menu();
                            Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                        }
                        else //Si entra por aqui es que el movimiento es válido
                        {
                            //Comprovamos que valor tiene la posicion en la que nos movemos
                            if (matriz[posI, posJ] == "0")
                            {
                                //Restamos 1 vida
                                Console.WriteLine("Has tocado un 0. -1 vida");
                                vida = vida - 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posI = posI +1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posI = posI - 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);


                            }
                            else if (matriz[posI, posJ] == "1")
                            {
                                //Si es 1 gana 1 vida
                                Console.WriteLine("Has tocado un 1. +1 vida");
                                vida = vida + 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posI = posI + 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posI = posI - 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);

                            }
                            else if (matriz [posI, posJ] == "2" )
                            {
                                //Ganas 2 de pocima 
                                Console.WriteLine("Has tocado un 2. COGES 2ML DE PÓCIMA");
                                pocima = pocima + 2;

                                //Comprovamos si hemos ganado
                                if (pocima >= 5)
                                {
                                    Console.WriteLine("HAS GANADOOOOOOOOO!!!!");
                                    break;
                                } else
                                {
                                    //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                    posI = posI + 1;
                                    matriz[posI, posJ] = random.Next(3).ToString();

                                    //Ahora vamos a la posicion nueva
                                    posI = posI - 1;
                                    matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                    //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                    Operaciones.pintarMatriz(matriz);
                                    Operaciones.menu();
                                    Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                                }
                                
                            }
                        }
                        break;
                    //ELEGIMOS LA OPCION 2 --> ABAJO
                    case "2":
                        //Como vamos hacia abajo la nueva posicion de i es la posicion de i + 1
                        posI = posI + 1;

                        //Comprovamos que no se salga de nuestra matriz (Si es mayor q 7 es que se ha salido por abajo)
                        if (posI > 7)
                        {
                            //Mensaje de traza para informacion del usuario
                            Console.WriteLine("Movimiento equivocado. -1 vida");

                            //Restamos una vida
                            vida = vida - 1;

                            //Deshacemos el cambio puesto que mario no se ha movido
                            posI = posI - 1;

                            //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                            Operaciones.pintarMatriz(matriz);
                            Operaciones.menu();
                            Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                        }
                        else //Si entra por aqui es que el movimiento es válido
                        {
                            //Comprovamos que valor tiene la posicion en la que nos movemos
                            if (matriz[posI, posJ] == "0")
                            {
                                //Restamos 1 vida
                                Console.WriteLine("Has tocado un 0. -1 vida");
                                vida = vida - 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posI = posI - 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posI = posI + 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);


                            }
                            else if (matriz[posI, posJ] == "1")
                            {
                                //Si es 1 gana 1 vida
                                Console.WriteLine("Has tocado un 1. +1 vida");
                                vida = vida + 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posI = posI - 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posI = posI + 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);

                            }
                            else if (matriz[posI, posJ] == "2")
                            {
                                //Ganas 2 de pocima 
                                Console.WriteLine("Has tocado un 2. COGES 2ML DE PÓCIMA");
                                pocima = pocima + 2;

                                //Comprovamos si hemos ganado
                                if (pocima >= 5)
                                {
                                    Console.WriteLine("HAS GANADOOOOOOOOO!!!!");
                                    break;
                                }
                                else
                                {
                                    //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                    posI = posI - 1;
                                    matriz[posI, posJ] = random.Next(3).ToString();

                                    //Ahora vamos a la posicion nueva
                                    posI = posI + 1;
                                    matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                    //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                    Operaciones.pintarMatriz(matriz);
                                    Operaciones.menu();
                                    Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                                }

                            }
                        }
                        break;
                    //ELEGIMOS LA OPCION 3 --> IZQUIERDA
                    case "3":
                        //Como vamos hacia la izquierda la nueva posicion de j es la posicion de j - 1
                        posJ = posJ - 1;

                        //Comprobamos que no se salga de nuestra matriz (Si es menor q 0 es que se ha salido por la izquierda)
                        if (posJ < 0)
                        {
                            //Mensaje de traza para informacion del usuario
                            Console.WriteLine("Movimiento equivocado. -1 vida");

                            //Restamos una vida
                            vida = vida - 1;

                            //Deshacemos el cambio puesto que Mario no se ha movido
                            posJ = posJ + 1;

                            //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                            Operaciones.pintarMatriz(matriz);
                            Operaciones.menu();
                            Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                        }
                        else //Si entra por aqui es que el movimiento es válido
                        {
                            //Comprovamos que valor tiene la posicion en la que nos movemos
                            if (matriz[posI, posJ] == "0")
                            {
                                //Restamos 1 vida
                                Console.WriteLine("Has tocado un 0. -1 vida");
                                vida = vida - 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posJ = posJ + 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posJ = posJ - 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);


                            }
                            else if (matriz[posI, posJ] == "1")
                            {
                                //Si es 1 gana 1 vida
                                Console.WriteLine("Has tocado un 1. +1 vida");
                                vida = vida + 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posJ = posJ + 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posJ = posJ - 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);

                            }
                            else if (matriz[posI, posJ] == "2")
                            {
                                //Ganas 2 de pocima 
                                Console.WriteLine("Has tocado un 2. COGES 2ML DE PÓCIMA");
                                pocima = pocima + 2;

                                //Comprovamos si hemos ganado
                                if (pocima >= 5)
                                {
                                    Console.WriteLine("HAS GANADOOOOOOOOO!!!!");
                                    break;
                                }
                                else
                                {
                                    //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                    posJ = posJ + 1;
                                    matriz[posI, posJ] = random.Next(3).ToString();

                                    //Ahora vamos a la posicion nueva
                                    posJ = posJ - 1;
                                    matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                    //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                    Operaciones.pintarMatriz(matriz);
                                    Operaciones.menu();
                                    Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                                }

                            }
                        }
                        break;
                    //OPCION 4 --> DERECHA 
                    case "4":
                        //Como vamos hacia la derecha la nueva posicion de j es la posicion de j + 1
                        posJ = posJ + 1;

                        //Comprobamos que no se salga de nuestra matriz (Si es mayor q 7 es que se ha salido por la derecha)
                        if (posJ > 7)
                        {
                            //Mensaje de traza para informacion del usuario
                            Console.WriteLine("Movimiento equivocado. -1 vida");

                            //Restamos una vida
                            vida = vida - 1;

                            //Deshacemos el cambio puesto que Mario no se ha movido
                            posJ = posJ - 1;

                            //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                            Operaciones.pintarMatriz(matriz);
                            Operaciones.menu();
                            Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                        }
                        else //Si entra por aqui es que el movimiento es válido
                        {
                            //Comprovamos que valor tiene la posicion en la que nos movemos
                            if (matriz[posI, posJ] == "0")
                            {
                                //Restamos 1 vida
                                Console.WriteLine("Has tocado un 0. -1 vida");
                                vida = vida - 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posJ = posJ - 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posJ = posJ + 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);


                            }
                            else if (matriz[posI, posJ] == "1")
                            {
                                //Si es 1 gana 1 vida
                                Console.WriteLine("Has tocado un 1. +1 vida");
                                vida = vida + 1;

                                //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                posJ = posJ - 1;
                                matriz[posI, posJ] = random.Next(3).ToString();

                                //Ahora vamos a la posicion nueva
                                posJ = posJ + 1;
                                matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                Operaciones.pintarMatriz(matriz);
                                Operaciones.menu();
                                Operaciones.eleccion(matriz, posI, posJ, pocima, vida);

                            }
                            else if (matriz[posI, posJ] == "2")
                            {
                                //Ganas 2 de pocima 
                                Console.WriteLine("Has tocado un 2. COGES 2ML DE PÓCIMA");
                                pocima = pocima + 2;

                                //Comprovamos si hemos ganado
                                if (pocima >= 5)
                                {
                                    Console.WriteLine("HAS GANADOOOOOOOOO!!!!");
                                    break;
                                }
                                else
                                {
                                    //Volvemos a la posicion inicial (donde se encontraba Mario en un primer momento) por que tenemos que añadirle un valor random
                                    posJ = posJ - 1;
                                    matriz[posI, posJ] = random.Next(3).ToString();

                                    //Ahora vamos a la posicion nueva
                                    posJ = posJ + 1;
                                    matriz[posI, posJ] = "M"; //Pintamos a mario en la posicion nueva

                                    //Volvemos a llamar a los metodos para ver la matriz, nos salga el menú y nos capture el siguiente movimiento
                                    Operaciones.pintarMatriz(matriz);
                                    Operaciones.menu();
                                    Operaciones.eleccion(matriz, posI, posJ, pocima, vida);
                                }

                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Saliendo...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.Write("Opcion invalida");
                        Console.ReadKey();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Game over!");
            }
            


        }
    }
}
