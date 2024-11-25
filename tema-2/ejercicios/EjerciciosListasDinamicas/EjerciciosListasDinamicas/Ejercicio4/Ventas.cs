using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosListasDinamicas.Ejercicio4
{
    internal class Ventas
    {
        private int[,] ventasMensuales;

        public Ventas(int filas, int columnas)
        {
            ventasMensuales = new int[filas, columnas];
        }


        public void establecerValor(int fila, int columna, int valor)
        {
            ventasMensuales[fila, columna] = valor;
        }


    }
}
