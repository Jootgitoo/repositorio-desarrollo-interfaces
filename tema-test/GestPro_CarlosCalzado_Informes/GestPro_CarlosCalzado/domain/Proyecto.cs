using GestPro_CarlosCalzado.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestPro_CarlosCalzado.domain
{
    internal class Proyecto
    {
        private int id;
        private string codigo;
        private string nombre;
        private string fechaI;
        private string fechaF;
        private string desc;
        private double coste;
        private List<Proyecto> lista;
        public ProyectosManage pm;

        public Proyecto() { 
            pm = new ProyectosManage();
        }

        public Proyecto(int id)
        {
            pm = new ProyectosManage();
            this.id = id;
        }

        public Proyecto(int id, string nombre, string fechaI, string fechaF) { 
            this.id = id;
            this.nombre = nombre;
            this.fechaI = fechaI;
            this.fechaF = fechaF;
        }

        public Proyecto(int id, string codigo, string nombre, string fechaI, string fechaF)
        {
            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.fechaI = fechaI;
            this.fechaF = fechaF;
        }

        public Proyecto(string codigo, string nombre, string desc, double coste)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.desc = desc;
            this.coste = coste;
            pm = new ProyectosManage();
        }

        public int Id { get { return id; } set { id = value; } }
        public string Codigo { get { return codigo; } set { codigo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Desc { get { return desc; } set { desc = value; } }
        public double Coste { get { return coste; } set { coste = value; } }
        public string FechaI { get { return fechaI; } set { fechaI = value; } }
        public string FechaF { get { return fechaF; } set { fechaF = value; } }

        public List<Proyecto> getProyectos()
        {
            lista = pm.leerProyectos();

            return lista;
        }

        public void insertar() {
            //Id = pm.lastId(this);
            //Id = 1;
            pm.insertarProyecto(this, 0);
        }

        public void eliminar()
        {
            pm.eliminarProyecto(this);
        }

        public void actualizar()
        {
            pm.actualizarProyecto(this);
        }

        public void last() { 
            pm.lastId(this);
        }

    }
}
