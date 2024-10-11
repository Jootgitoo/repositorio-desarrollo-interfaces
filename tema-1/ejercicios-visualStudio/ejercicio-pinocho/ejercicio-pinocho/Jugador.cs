using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_pinocho
{
    internal class Jugador
    {
        private string nombre;
        private int peces = 0;
        private int saltos = 18;
        private int vidas = 3;

        private int posI = 0;
        private int posJ = 0;

        public Jugador(string nombre)
        {
            this.nombre = nombre;
        }


        public string getNombre()
        {
            return nombre;
        }
        public int getPeces()
        {
            return peces;
        }
        public int getSaltos()
        {
            return saltos;
        }

        public int getVidas()
        {
            return vidas;
        }
        public int getPosI()
        {
            return posI;
        }
        public int getPosJ()
        {
            return posJ;
        }
        

        public void setPeces(int peces)
        {
            this.peces = peces;
        }
        public void setSaltos(int saltos)
        {
            this.saltos = saltos;
        }
        public void setVidas(int vidas)
        {
            this.vidas = vidas;
        }
        public void setPosI(int posI)
        {
            this.posI = posI;
        }
        public void setPosJ(int posJ)
        {
            this.posJ = posJ;
        }
    }
}
