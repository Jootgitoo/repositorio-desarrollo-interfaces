using GestPro_CarlosCalzado.domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GestPro_CarlosCalzado.persistence
{
    internal class ProyectosManage
    {
        private DataTable table { get; set; }
        private static List<Proyecto> listaProyectos { get; set; }
        int Id;

        public ProyectosManage()
        {
            table = new DataTable();
            listaProyectos = new List<Proyecto>();
        }
        public List<Proyecto> leerProyectos()
        {
            Proyecto proyecto = null;
            List<Object> aux = DBBroker.obtenerAgente().leer("Select * from mydb.proyecto;");
            foreach (List<Object> c in aux)
            {
                proyecto = new Proyecto(Convert.ToInt32(c[0]), c[1].ToString(), c[2].ToString(), c[3].ToString(), c[4].ToString());
                listaProyectos.Add(proyecto);
            }

            /*
            List<Proyecto> listaProyectos = new List<Proyecto>();
            listaProyectos.Add(new Proyecto(1, "Proyecto1", "01/01/2024", "01/01/2025"));
            listaProyectos.Add(new Proyecto(2, "Proyecto2", "02/02/2024", "02/02/2025"));
            listaProyectos.Add(new Proyecto(3, "Proyecto3", "03/03/2024", "03/03/2025"));
            */

            return listaProyectos;
        }

        public void insertarProyecto(Proyecto p, int lastId)
        {
            DBBroker dbBroker = DBBroker.obtenerAgente();
            MessageBox.Show("insert into mydb.proyecto (codigo,nombre) values('" + p.Codigo + "," + p.Nombre + ")");
            dbBroker.modificar("Insert into mydb.Proyecto (CodigoProyecto,NombreProyecto,DescProyecto,Presupuesto) values ('" + p.Codigo + "','" + p.Nombre + "','" + p.Desc + "','" + p.Coste + "');");
        }

        public void eliminarProyecto(Proyecto p)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("delete from mydb.proyecto where idproyecto = " + p.Id);
        }

        public void actualizarProyecto(Proyecto p)
        {
            DBBroker dBBroker = DBBroker.obtenerAgente();
            dBBroker.modificar("update mydb.proyecto set codigoproyecto = '" + p.Codigo + "', nombreproyecto ='" + p.Nombre + " where idproyecto = " + p.Id);
        }

        public int lastId(Proyecto p)
        {

            List<Object> listaProyectos;
            listaProyectos = DBBroker.obtenerAgente().leer("select MAX(idproyecto) FROM mydb.proyecto");
            foreach (List<Object> aux in listaProyectos)
            {
                Id = Convert.ToInt32(aux[0]) + 1;
            }
            return Id;
        }
    }
}
