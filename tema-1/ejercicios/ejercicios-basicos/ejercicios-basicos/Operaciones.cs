using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_basicos
{
    internal class Operaciones
    {

        /*
         * Ejercicio 1 de ejercicios básicos
         *  - Este método crea una variable llamada mark, que tiene in valor aleatorio entre 1 y 100. Si ese valor aleatorio es >= 50 imprime Pass si no imprime Fail
         */
        public static void ejercicio1()
        {
            Random random = new Random();

            int mark = random.Next((100) + 1);


            if (mark >= 50)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

        }


        /*
         * Ejercicio 2 de ejercicios básicos
         *  - Este ejercicio imprime “Número Impar” si la variable entera “numero” es impar o "Numero par" si la variable es par.  
         */
        public static void ejercicio2()
        {

            Random rnd = new Random();
            int numero = rnd.Next((100) + 1);

            if (numero % 2 == 0)
            {
                Console.WriteLine("Numero par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }

        }

        /*
         * Ejercicio 3 de ejercicios basicos
         *  - Calcula una suma sucesiva de numeros hasta un número pasado por parametro
         */
        public static void ejercicio3(int numero)
        {
            //Calculo la suma utilizando el bucle FOR
            int suma = 0;
            for (int i = 0; i < numero; i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma con el bucle FOR es: " + suma);

            //Calculo la media
            double media = suma / numero;
            Console.WriteLine("La media del bucle FOR es: " + media);

            Console.WriteLine("");
        }


        public static void ejercicio3Modificacion1(int numero)
        {

            //Calculo la suma utilizando el bucle WHILE
            int suma = 0;
            int conta = 0;
            int media = 0;
            while (conta < numero)
            {
                suma = suma + conta;
                conta++;
            }
            Console.WriteLine("La suma con el bucle WHILE es: " + suma);

            //Calculo la media
            media = suma / numero;
            Console.WriteLine("La media del bucle while es: " + media);

            Console.WriteLine("");



        }

        public static void ejercicio3Modificacion2(int numero)
        {
            //Calculo la suma utilizando el bucle DO-WHILE
            int suma = 0;
            int conta = 0;
            int media = 0;
            do
            {
                suma = conta + suma;
                conta++;
            } while (conta < numero);
            Console.WriteLine("La suma con el bucle DO-WHILE es: " + suma);

            //Calculo la media
            media = suma / numero;
            Console.WriteLine("La media del bucle do-while es: " + media);

            Console.WriteLine("");
        }


        public static void ejercicio3Modificacion3()
        {
            //Calculo la suma de los numeros pares del 1 al 100 y saco la media
            int suma = 0;
            int conta = 0;


            for (int i = 1; i <= 100; i++)
            {

                //Si el numero es par entonces se suma si no no
                if (i % 2 == 0)
                {
                    suma += i;
                    conta++;
                }
            }
            Console.WriteLine("La suma de los numeros pares del 1 al 100 es: " + suma);

            //Calculo la media
            double media = suma / conta;
            Console.WriteLine("La media de la suma de los numeros pares es: " + media);

        }

        public static void ejercicio3Modificacion4()
        {
            int suma = 0;
            int conta = 0;

            for (int i = 1; i <= 100; i++)
            {

                if ((i % 7) == 0)
                {
                    suma += i;
                    conta++;
                }

            }
            Console.WriteLine("La suma de los números divisibles por 7 es: " + suma);

            //Calculo la media
            double media = suma / conta;
            Console.WriteLine("La media de la suma de los numeros pares es: " + media);
        }


        public static void ejercicio3Modificacion5()
        {

            int suma = 0;
            int conta = 0;


            for (int i = 1; i <= 100; i++)
            {
                suma = suma + (i * i);
                conta++;
            }

            Console.WriteLine("La suma de los cuadrados es: " + suma);

            //Calculo la media
            double media = suma / conta;
            Console.WriteLine("La media de los cuadrados es: " + media);

        }


        // Ejercicio 4 de ejercicios básicos
        // - Serie armónica (sumar los inversos desde 1 hasta n)
        public static void ejercicio4(int num)
        {
            
            double suma = 1;

            for(int i = 1; i < num; i++) 
            {
                suma = suma + (1 / i);
            }
            Console.WriteLine("La suma armonica es: " +suma);

        }


        /* Ejercicio 5 de ejercicios básicos
         * 
         * - Calcula el valor de pi siguiendo una expresion
         * 
        */
        public static void ejercicio5(int num)
        {
            double suma = 1;

            for (int i = 1;i < num; i++) 
            {


                if (i % num == 1 && i != 1)
                {
                    suma = suma + (1 - (1/ i));
                }
                

            }
            suma *= 4;
            Console.WriteLine("La suma armonica es: " + suma);
        }


        /*
         * Ejercicio 6 ejercicios basicos
         *  - Serie de tribonacci (la suma de la sucesion de 3 números)
         */
        public static void ejercicio6(int num)
        {
            int suma = 0;
            int anterior1 = 0;
            int anterior2 = 0;
            int anterior3 = 1;
            

            for (int i = 0; i <= num; i++) 
            {


                suma =  anterior1 + anterior2 + anterior3;

                anterior1 = anterior2;
                anterior2 = anterior3;
                anterior3 = suma;

                Console.WriteLine(suma + " ");
            }
            

        }

        /*
         * Ejercicio 7 de ejercicios básicos
         *  - Sacamos las tablas de multiplicar usando varios bucles
         */
        public static void ejercicio7() 
        {
            int resultado = 0;
            //Bucle principal
            for (int i = 1;i < 11; i++)
            {
                Console.WriteLine("Tabla del " + i);
                //BLoque secundario (este segundo buble se va a multiplicar por i hasta que j llegue a 10

                for (int j = 1;j < 11; j++) 
                {
                    
                    resultado = i * j;

                    Console.WriteLine( i + " x " + j + " = " + resultado);
                }
                Console.WriteLine(" ");

            }
        }


        /*
         * Ejercicio 7 de ejercicios básicos con modificación
         *  - Sacamos las tablas de multiplicar con 1 solo bucle 
         */
        public static void ejercicio7Modificacion1()
        {

            for (int i = 1; i <= 100; i++)
            {
                int multiplicando = (i - 1) / 10 + 1;
                int multiplicador = (i - 1) % 10 + 1;
                Console.Write($"{multiplicando} x {multiplicador} = {multiplicando * multiplicador}\t");
                if (i % 10 == 0) Console.WriteLine();
            }
        }

        /*
         * Ejercicio 8 de ejercicios basicos
         *  - Sacamos el radio y volumen de un radio pasado por teclado
         */
        public static void ejercicio8()
        {
            Console.Write("Escribe el radio: ");

            double radio = Double.Parse( Console.ReadLine() );
            
            double volumen = ((4.0 / 3.0) * Math.PI * Math.Pow(radio, 3));

            double area = 4 * Math.PI * Math.Pow(radio, 2);

            Console.WriteLine("Area: {0:0.00} m2", volumen);
            Console.WriteLine("Volumen: {0:0.00} m3", volumen);
            Console.ReadKey();
            
        }

        /*
         * Ejercicio 9 de ejercicios basicos
         *  - Pasamos un Stirng y devuelve el mismo String pero del revés
         */
        public static void ejercicio9(String cadenaNormal)
        {

            String cadenaGirada = new string(cadenaNormal.Reverse().ToArray());
            Console.WriteLine(cadenaGirada);

        }


        /*
         * Ejercicio 10
         *  - Te dice si una palabra es igual escrita de izquierda a derecha que de derecha a izquierda
         */
        public static void ejercicio10(String palabra)
        {
            String palabraGirada = new string(palabra.Reverse().ToArray());

            if (palabra.Equals(palabraGirada))
            {
                Console.WriteLine(palabra + " es palindroma");
            }
            else
            {
                Console.WriteLine(palabra + " no es palindroma");
            }

        }


        


    }
}
