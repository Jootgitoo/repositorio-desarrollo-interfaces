using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGestProJorgeHerrera
{
    public class DBBroker
    {
        //ATRIBUTOS
        private static DBBroker _instancia;
        private static MySql.Data.MySqlClient.MySqlConnection conexion;
        private const String cadenaConexion = "server=localhost;database=gestpro;uid=root;pwd=mysql";

//------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR

        /// <summary>
        ///     Creamos la conexión con la BBDD
        /// </summary>
        private DBBroker()
        {
            DBBroker.conexion = new MySql.Data.MySqlClient.MySqlConnection(DBBroker.cadenaConexion);
        }

        /// <summary>
        ///     Hace referencia al patron singleton. Sirve para obtener la instancia
        /// </summary>
        /// <returns>
        ///     Devuelve la instancia de la conexion
        /// </returns>
        public static DBBroker obtenerAgente()
        {
            if (DBBroker._instancia == null)
            {
                DBBroker._instancia = new DBBroker();
            }
            return DBBroker._instancia;
        }

//-------------------------------------------------------------------------------------------------------------
        //MÉTODOS
        
        /// <summary>
        ///     Realiza una sentencia sql de tipo select
        /// </summary>
        /// <param name="sql">
        ///     Sentencia sql de tipo select
        /// </param>
        /// <returns>
        ///     Devuelve una lista llena de los objetos que ha leido
        /// </returns>
        public List<Object> leer(String sql)
        {
            List<Object> resultado = new List<object>();
            List<Object> fila;
            int i;
            MySql.Data.MySqlClient.MySqlDataReader reader;
            MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.conexion);

            conectar();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                fila = new List<object>();
                for (i = 0; i <= reader.FieldCount - 1; i++)
                {
                    fila.Add(reader[i].ToString());

                }
                resultado.Add(fila);
            }
            desconectar();
            return resultado;
        }


        /// <summary>
        ///     Realiza una sentencia insert, update, delete en la bbdd
        /// </summary>
        /// <param name="sql">
        ///     Sentencia sql que va ha ejecutar 
        /// </param>
        /// <returns>
        ///     El numero de filas afectadas al ejecutar la sentencia
        /// </returns>
        public int modificar(String sql)
        {
            MySql.Data.MySqlClient.MySqlCommand com = new MySql.Data.MySqlClient.MySqlCommand(sql, DBBroker.conexion);
            int resultado;
            conectar();
            resultado = com.ExecuteNonQuery();
            desconectar();
            return resultado;
        }


        /// <summary>
        ///     Abres la conexion con la BD
        /// </summary>
        private void conectar()
        {

            if (DBBroker.conexion.State == System.Data.ConnectionState.Closed)
            {
                DBBroker.conexion.Open();
            }

        }


        /// <summary>
        ///     Cierras la conexion con la BD
        /// </summary>
        private void desconectar()
        {
            if (DBBroker.conexion.State == System.Data.ConnectionState.Open)
            {
                DBBroker.conexion.Close();
            }
        }

    }
}
