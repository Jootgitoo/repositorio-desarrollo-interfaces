using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Operaciones
    {
        public static void positivos()
        {

            int positivo = 0;
            int conta = 0;
            int numero = 0;

            Console.WriteLine("Introduce número");

            numero = Int32.Parse(Console.ReadLine());

            while (numero != 5)
            {

                conta = conta + 1;

                if (numero > 0)
                {
                    positivo = positivo + 1;

                }

                Console.WriteLine("Introduce número");
                numero = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("Has introducido un total de {0}", conta);
            Console.WriteLine("Y son positivos: {0}", positivo);
            Console.ReadKey();

        }

        public static void generaRandom()
        {
            Random random = new Random();

            int numRandom = random.Next(10);

            Console.WriteLine("El numero aleatorio es {0}");
        }


        public static void presentacionListas()
        {
            //TRABAJAR CON LISTAS
            List<string> ListaColores = new List<string>();


            //Añadir elementos a un ArrayList
            ListaColores.Add("Azul");
            ListaColores.Add("Rojo");
            ListaColores.Add("Azul");
            ListaColores.Add("Verde");
            ListaColores.Add("Amarillo");
            ListaColores.Add("Morado");


            //Escribir en consola
            Console.WriteLine(ListaColores[1]);
            Console.ReadKey(); //Lee el teclado


            //Con esto estamos diciendo que lo que haya en la posicion 2 lo destruya y añade hola, es decir, rojo desaparece y añade hola
            ListaColores[2] = "hola";


            //Escribimos en consola
            Console.WriteLine(ListaColores[2]);
            Console.ReadKey();


            //Bucle for each: Por cada cosa que haya en un cajón de lista de colores se añade a color y se imprime
            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);

            }
            Console.ReadKey();


            //Con esto decimos que inserte lo que le decimos (segundo parametro) en la posicion 2 (la posición se pone en el primer parámetro)
            //pero no destruye lo q hay sino que lo coloca una posicion por debajo
            ListaColores.Insert(2, "otra vez");

            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);

            }
            Console.ReadKey();


            //Ordena alfabeticamente de la A a la Z
            ListaColores.Sort();

            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);

            }
            Console.ReadKey();


            //Te dice la posición en la que se encuentra el elemento
            Console.WriteLine(ListaColores.IndexOf("Rojo"));
            Console.ReadKey();


            //Esto te busca si en el array se encuentra esa palabra (en este caso palabra por que es un array de Strings)
            Console.WriteLine(ListaColores.Contains("Rojo"));


            //Remplaza la posicion de "otra vez" por "verde
            ListaColores[ListaColores.IndexOf("otra vez")] = "verde";

            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);

            }
            Console.ReadKey();


            Console.WriteLine(ListaColores.Count);
            Console.ReadKey();

            Console.WriteLine(ListaColores.Capacity);
            Console.ReadKey();


            //Limpia la lista de colores
            ListaColores.Clear();
            foreach (string color in ListaColores)
            {
                Console.WriteLine(color);

            }
            Console.ReadKey();
        }



        //Lista de 100 elementos que tengan numeros aleatorios del 1 al 50
        public static void genera100random()
        {
            //Creamos la lista
            List<int> numerosAleatorios = new List<int>();

            //Creo una variable del tipo random
            Random rnd = new Random();

            //Se hace 100 veces
            for (int i = 0; i < 100; i++)
            {

                //Añadirlo a una lista
                numerosAleatorios.Add(rnd.Next(50) + 1); //Se pone el +1 para que nunca se guarde un 0
                

            }

            //Escribimos la lista
            foreach (int numero in numerosAleatorios)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();



        }
    }
}
