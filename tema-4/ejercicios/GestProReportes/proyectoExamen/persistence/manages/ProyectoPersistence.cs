using proyectoExamen.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoExamen.persistence.manages
{
    internal class ProyectoPersistence
    {

        //ATRIBUTOS
        int idDev;

        //------------------------------------------------------------------------------------------------
        //CONSTRUCTORES
        public ProyectoPersistence()
        {
            proyectoList = new List<Proyecto>();
        }

        //------------------------------------------------------------------------------------------------

        /// <summary>
        ///     Lees los proyectos de la bbdd
        /// </summary>
        public void readProyectos()
        {

            Proyecto p = null;

            List<Object> listProyectos;

            listProyectos = DBBroker.obtenerAgente().leer("SELECT * FROM gestpro.proyecto");

            foreach (List<Object> lproyectosAux in listProyectos)
            {

                p = new Proyecto();

                p.Id = Convert.ToInt32(lproyectosAux[0]);
                p.Codigo = lproyectosAux[1].ToString();
                p.NombreProyecto = lproyectosAux[2].ToString();
                p.FecInicio = Convert.ToDateTime(lproyectosAux[3]);
                p.FecFin = Convert.ToDateTime(lproyectosAux[4]);

                proyectoList.Add(p);

            }

        }


        /// <summary>
        ///     Inserta un proyecto en la bbdd
        /// </summary>
        /// <param name="p">
        ///     Proyecto a realizar
        /// </param>
        public void insertProyectos(Proyecto p)
        {
            DBBroker broker = DBBroker.obtenerAgente();

            broker.modifier("INSERT INTO gestpro.proyecto (CodigoProyecto, NombreProyecto, FechaInicio, FechaFin) values" +
                "('" + p.Codigo + "', '" + p.NombreProyecto + "','" + p.FecInicio.ToString("yyyy-MM-dd") + "','" + p.FecFin.ToString("yyyy-MM-dd") + "')");
        }


        /// <summary>
        ///     Borra un proyecto en la bbdd
        /// </summary>
        /// <param name="p">
        ///     Proyecto a borrar
        /// </param>
        public void deleteProyectos(Proyecto p)
        {

            DBBroker broker = DBBroker.obtenerAgente();

            broker.modifier("DELETE FROM gestpro.proyecto WHERE IdProyecto = " + p.Id);

        }


        /// <summary>
        ///     Modificamos un proyecto
        /// </summary>
        /// <param name="p">
        ///     Objeto a modificar
        /// </param>
        public void modifyProyecto(Proyecto p)
        {

            DBBroker broker = DBBroker.obtenerAgente();

            broker.modifier("UPDATE gestpro.proyecto SET IdProyecto = " + p.Id + ", CodigoProyecto = '" + p.Codigo + "', NombreProyecto = '" 
                + p.NombreProyecto + "', FechaInicio = '" + p.FecInicio.ToString("yyyy-MM-dd")
                + "', FechaFin = '" + p.FecFin.ToString("yyyy-MM-dd") + "' WHERE IdProyecto = " + p.Id);

        }


        /// <summary>
        ///     Obtenemos el último last id
        /// </summary>
        /// <param name="p"></param>
        /// <returns>
        ///     Proyecto al q le vamos a añadir el ultimo id cogido + 1
        /// </returns>
        public int lastId(Proyecto p)
        {
            List<Object> lproyectos;
            lproyectos = DBBroker.obtenerAgente().leer("SELECT COALESCE(MAX(IdProyecto), 0) from gestpro.proyecto");

            foreach (List<Object> lproyectosAux in lproyectos)
            {

                idDev = Convert.ToInt32(lproyectosAux[0]) + 1;

            }
            return idDev;
        }

        //----------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS EXTRA
        public List<Proyecto> proyectoList { get; set; }

    }
}
