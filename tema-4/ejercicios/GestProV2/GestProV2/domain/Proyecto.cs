using GestProV2.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestProV2.domain
{
    internal class Proyecto
    {
        //ATRIBUTOS

        public int id;
        public String codigo;
        public String nombre;
        public DateTime fecIncio;
        public DateTime fecFin;
        public ProyectoPersistence pm;

//--------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTORES

        public Proyecto(string codigo, string nombre, DateTime fecIncio, DateTime fecFin)
        {

            pm = new ProyectoPersistence();

            this.id = pm.lastId(this);
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecIncio = fecIncio;
            this.fecFin = fecFin;

        }

        public Proyecto(int id, string codigo, string nombre, DateTime fecIni, DateTime fecFin)
        {
            pm = new ProyectoPersistence();

            this.id = id;
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecIncio = fecIni;
            this.fecFin = fecFin;

        }

        public Proyecto()
        {

            pm = new ProyectoPersistence();
            this.id = pm.lastId(this);
        }

//-------------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS
        
        public void readProyectos()
        {
            pm.readProyectos();
        }

        public List<Proyecto> getListaProyectos()
        {
            return pm.proyectoList;
        }

        public void insert()
        {
            pm.insertProyectos(this);
        }

        public void delete()
        {
            pm.deleteProyectos(this);
        }

        public void update()
        {
            pm.modifyProyecto(this);
        }

        public void last()
        {
            pm.lastId(this);
        }

//--------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA

        public int Id { get => id; set => id = value; }
        public String Codigo { get => codigo; set => codigo = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public DateTime FecInicio { get => fecIncio; set => fecIncio = value; }
        public DateTime FecFin { get => fecFin; set => fecFin = value; }
        public ProyectoPersistence PM { get => pm; set => pm = value; }

        public override string ToString()
        {
            return nombre;
        }

    }
}
