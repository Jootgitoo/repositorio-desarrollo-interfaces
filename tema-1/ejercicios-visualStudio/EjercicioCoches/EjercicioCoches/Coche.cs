using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCoches
{
    internal class Coche
    {
        //ATRIBUTOS
        private int _id;
        private String _marca;
        private String _modelo;
        private int _km;
        private double _precio;

        //CONSTRUCTOR
        public Coche(int id, String marca, String modelo, int km, double precio)
        {
            _id = id;
            _marca = marca;
            _modelo = modelo;
            _km = km;
            _precio = precio;
        }

        //GETTERS Y SETTERS
        public int getId() { return _id; }
        public void setId(int id) { _id = id; } 

        public String getMarca() { return _marca; }
        public void setMarca(String marca) { _marca = marca; }

        public String getModelo() { return _modelo; }
        public void setModelo(String modelo) { _modelo = modelo; }

        public int getkm() { return _km; }
        public void setKm(int km) { _km = km; }

        public double getPrecio() { return _precio; }
        public void setPrecio(double precio ) { _precio = precio; }

       
        //MÉTODOS
        /*
         * Método toString para escribir información sobre el coche 
         */
        public override string ToString()
        {
            return ": Coche cuyo id es: " + getId() + ", cuya marca es: " + getMarca() + ", cuyo modelo es " + getModelo() + ", cuyos km son: " + getkm() + ", cuyo precio es: " + getPrecio();
        }
    }
}
