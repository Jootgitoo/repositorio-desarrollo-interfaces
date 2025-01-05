using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDeLaVida
{
    /// <summary>
    ///     
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatriz = Operaciones.pedirSizeMatriz();

            int[,] matriz = new int[sizeMatriz[0], sizeMatriz[1]];

            Operaciones.rellenarMatriz(matriz);
            


        }
    }
}
