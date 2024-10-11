using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        
        /*
         * Este método te genera un número aleatorio del 1 al 4.
         * Cada uno de estos numeros será un número distinto
         */
        private static int movimientoARealizar()
        {
            //Creamos la variable para guardar la opcion del movimiento
            int opcion;

            //Generamos el numero random para movernos
            Random random = new Random();
            opcion = random.Next(4);

            //Devolvemos la opcion
            return opcion;
        }

        /*
         * Este método devuelve true si puedo jugar o false si no puedo jugar
         */
        private static bool podemosJugar(Jugador jugador)
        {
            bool jugamos = false;

            if (jugador.getSaltos() <= 0 || jugador.getVidas() < 0)
            {
                jugamos = false;
            } else
            {
                jugamos = true;
            }
            return jugamos;
        }

        /*
         * Con este método sabremos si el movimiento realizado es válido o no
         */
        private static bool movimientoValido(int posicion)
        {
            bool esValido = false;

            if (posicion < 0 || posicion > 7)
            {
                esValido = false;
                
            } else
            {
                esValido = true;
            }
            return esValido;
            
        }

       
        /*
         * Este es un método que te comprueba que valor tiene la matriz y realiza la opción oportuna
         */
        private  static void valorPosicionMatriz(int posI, int posJ, string[,] matriz, Jugador jugador) 
        {
            if (matriz[posI, posJ] == "0") //Si el valor de la posicion es 0 pierde una vida
            {
                Console.WriteLine( jugador.getNombre() + " se ha encontrado una piraña. Pierde 1 vida" );
                jugador.setVidas(jugador.getVidas() - 1 );

            } else if (matriz[posI, posJ] == "1") //Si el valor es 1 toca agua y no pasa nada
            {
                Console.WriteLine( jugador.getNombre() + " ha tocado agua. No pasa nada" );
                
            } else if (matriz[posI, posJ] == "2") //Si el valor es 2 se choca con una piedra pierde un pez
            {
                Console.WriteLine( jugador.getNombre() + " se ha chocado con una piedra. Pierde 1 pez");
                jugador.setPeces(jugador.getPeces() - 1 );

            } else if (matriz[posI, posJ] == "3") //Si el valor es 3 se encuentra un pez y suma un pez
            {
                Console.WriteLine(jugador.getNombre() + " ha encontrado un pez. Gana 1 pez");
                jugador.setPeces(jugador.getPeces() + 1 );
            }
            
        }


        public static void movimiento(Jugador jugador, string[,] matriz)
        {
            //Llamamos al metodo movimientoARealizar para que nos diga que movimiento tenemos que hacer
            int opcion = movimientoARealizar();

            //Comprobamos que podamos jugar
            bool jugamos = podemosJugar(jugador);

            //Variables
            bool resultado = false;
            
            if (jugamos == false)
            {
                Console.WriteLine("Game Over");
                Environment.Exit(0);
            }
            else //Si sale por aquí es que podemos jugar
            {
                //Según la opcion hacemos un movimiento u otro
                switch (opcion)
                {
                    //Sale la opcion 1 --> arriba
                    case 1:

                        //Como vamos hacia arriba I se reduce en 1
                        jugador.setPosI(jugador.getPosI() - 1);

                        //Comprobamos que no se salga de la matriz
                        resultado = movimientoValido(jugador.getPosI());

                        if (resultado == false) //Si el resultado es false es q no es válido
                        {
                            Console.WriteLine("Movimiento invalido");

                            //Vuelvo a poner la posición inicial puesto que el cambio es invalido
                            jugador.setPosI(jugador.getPosI() + 1);

                            //Volvemos a llamar al método para que haga otro movimiento
                            movimiento(jugador, matriz);

                        } else //Si llega aquí es que puede seguir jugando
                        {

                            //Una vez que hemos hecho el movimiento compruebo que valor tiene la matriz
                            valorPosicionMatriz( jugador.getPosI(), jugador.getPosJ(), matriz, jugador );

                            //Llamamos al método para que vuelva a realizar una tirada 
                            movimiento(jugador, matriz);
                        }
                    break;

                    //Sale la opcion 2 --> abajo
                    case 2:

                        //Como vamos hacia abajo I aumenta en 1
                        jugador.setPosI(jugador.getPosI() + 1);

                        //Comprobamos que no se salga de la matriz
                        resultado = movimientoValido(jugador.getPosI());

                        if (resultado == false) //Si el resultado es false es q no es válido
                        {
                            Console.WriteLine("Movimiento invalido");

                            //Vuelvo a poner la posición inicial puesto que el cambio es invalido
                            jugador.setPosI(jugador.getPosI() - 1);

                            //Volvemos a llamar al método para que haga otro movimiento
                            movimiento(jugador, matriz);

                        }
                        else //Si llega aquí es que puede seguir jugando
                        {

                            //Una vez que hemos hecho el movimiento compruebo que valor tiene la matriz
                            valorPosicionMatriz(jugador.getPosI(), jugador.getPosJ(), matriz, jugador);

                            //Llamamos al método para que vuelva a realizar una tirada 
                            movimiento(jugador, matriz);
                        }
                    break;

                    //Sale la opcion 3 --> Izquierda
                    case 3:

                        //Como vamos hacia la izquierda J disminuye en 1
                        jugador.setPosJ(jugador.getPosJ() - 1);

                        //Comprobamos que no se salga de la matriz
                        resultado = movimientoValido(jugador.getPosJ());

                        if (resultado == false) //Si el resultado es false es q no es válido
                        {
                            Console.WriteLine("Movimiento invalido");

                            //Vuelvo a poner la posición inicial puesto que el cambio es invalido
                            jugador.setPosJ(jugador.getPosJ() + 1);

                            //Volvemos a llamar al método para que haga otro movimiento
                            movimiento(jugador, matriz);

                        }
                        else //Si llega aquí es que puede seguir jugando
                        {

                            //Una vez que hemos hecho el movimiento compruebo que valor tiene la matriz
                            valorPosicionMatriz(jugador.getPosI(), jugador.getPosJ(), matriz, jugador);

                            //Llamamos al método para que vuelva a realizar una tirada 
                            movimiento(jugador, matriz);
                        }
                    break;

                    //Si sale la opcion 4 --> Derecha
                    case 4:

                        //Como vamos hacia la derecha J aumenta en 1
                        jugador.setPosJ(jugador.getPosJ() + 1);

                        //Comprobamos que no se salga de la matriz
                        resultado = movimientoValido(jugador.getPosJ());

                        if (resultado == false) //Si el resultado es false es q no es válido
                        {
                            Console.WriteLine("Movimiento invalido");

                            //Vuelvo a poner la posición inicial puesto que el cambio es invalido
                            jugador.setPosJ(jugador.getPosJ() - 1);

                            //Volvemos a llamar al método para que haga otro movimiento
                            movimiento(jugador, matriz);

                        }
                        else //Si llega aquí es que puede seguir jugando
                        {

                            //Una vez que hemos hecho el movimiento compruebo que valor tiene la matriz
                            valorPosicionMatriz(jugador.getPosI(), jugador.getPosJ(), matriz, jugador);

                            //Llamamos al método para que vuelva a realizar una tirada 
                            movimiento(jugador, matriz);
                        }
                    break;
                }

            }
            
        }
    }

}
