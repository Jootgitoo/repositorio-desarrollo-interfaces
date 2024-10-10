using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioCoches
{
    internal static class Program
    {
       
        static void Main()
        {
            //Creamos 5 objetos Coche
            Coche c1 = new Coche(0000, "Ferrari", "SF90", 0, 1000000);
            Coche c2 = new Coche(0001, "Audi", "A4", 0, 135000);
            Coche c3 = new Coche(0002, "Porche", "Deportivo", 5, 1350000);
            Coche c4 = new Coche(0003, "Lamgorgini", "Urus", 100, 150000);
            Coche c5 = new Coche(0004, "Ferrari", "Superdeportivo", 1000, 12000000);

            //Hacemos una llamada al ToStirng
            Console.WriteLine(c1.ToString());
            Console.ReadLine();

            //Los añadimos al array
            Coche[] arrayCoches = new Coche[] { c1, c2, c3, c4, c5 };

            //Los escirbimos recorriendo el array
            for (int i = 0; i < arrayCoches.Length; i++) 
            {
                Console.WriteLine("Coche " +i+ arrayCoches[i].ToString());

            }
            Console.ReadLine();

            
        }
    }
}
