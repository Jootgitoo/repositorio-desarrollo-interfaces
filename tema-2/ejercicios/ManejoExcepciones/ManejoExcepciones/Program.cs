using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divisiones();
        }


        public static void Divisiones()
        {
            int[] arrayResultados = new int[10];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Indicanos un numero: ");
                    int num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Indicanos otro numero: ");
                    int num2 = Int32.Parse(Console.ReadLine());

                    int resultado = num1 / num2;

                    arrayResultados[i] = resultado;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("El array es más pequeño del valor seleccionado");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Por favor, introduce un número válido");
            }
            finally
            {
                Console.WriteLine("Programa finalizado");
            }
        }
    }
}
