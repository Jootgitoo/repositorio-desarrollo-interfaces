using ApiRestPrueba.domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ApiRestPrueba.persistence.manages
{
    internal class ApiManager
    {
        public string _apiUrl;


        /// <summary>
        ///     Obtenemos una lista de objetos de la api
        /// </summary>
        /// <returns>
        ///     Lista de objetos ApiRestObject que contiene objetos extraidos de la API
        /// </returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<ApiRestObject>> getListaObjetos()
        { 
            //Guardamos la url de la API
            _apiUrl= "https://api.restful-api.dev/objects";

            //Nos creamos un "cliente" para hacer una solicitud a la api
            HttpClient cliente = new HttpClient();

            //Enviamos una solicitud HTTP GET a la API
            HttpResponseMessage respuesta = await cliente.GetAsync(_apiUrl);

            if (respuesta.IsSuccessStatusCode) //Si el codigo devuelto es exitoso
            {

                //Me devuelve en formato json la respuesta de la API
                string jsonRespuesta = await respuesta.Content.ReadAsStringAsync();

                //Devuelvo la respuesta deserializada para poder leerlo bien
                return JsonConvert.DeserializeObject<List<ApiRestObject>>(jsonRespuesta);
            }
            else {
                throw new Exception($"Error: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }


        /// <summary>
        ///     Añadimos un objeto nuevo a la api
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<string> addNuevo()
        {
            //Guardamos la url de la api
            _apiUrl = "https://api.restful-api.dev/objects";

            //Nuevo objeto de prueba creado
            string body = "{\"name\": \"Prueba\", \"data\": { \"Generation\": \"4th\", \"Price\": \"519.99\" }}";

            //Cremos la conexion
            HttpClient cliente = new HttpClient();

            //Creamos el contenido de la solicitud
            //body --> Cadena Json que se enviará
            //Encoding.UTF8 --> Caracteres
            //application/json --> Especifica el tipo de medio del contenido
            HttpContent contenido = new StringContent(body, Encoding.UTF8, "application/json");
            
            //Guardamos la respuesta de la api. Obtenemos contenido(variable) de la _apiUrl(varibale) 
            HttpResponseMessage respuesta = await cliente.PostAsync(_apiUrl, contenido);

            if (respuesta.IsSuccessStatusCode) //Si es un codigo correcto
            {

                //Leemos el contenido de la respuesta y lo guardamso en un string en formato json
                string jsonRespuest = await respuesta.Content.ReadAsStringAsync();

                //Devolvemos el json obtenido 
                return jsonRespuest;

            }
            else
            {
                throw new Exception($"Error al añadir objeto: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }


        /// <summary>
        ///     Buscamos si dentro de la API hay un objeto con un id específico
        /// </summary>
        /// <param name="id">
        ///     Id del objeto a buscar
        /// </param>
        /// <returns>
        ///     Devuelve un objeto de tipo ApiRestObject
        /// </returns>
        /// <exception cref="Exception"></exception>
        public async Task<ApiRestObject> GetbyID(string id) { 

            //URL de la api
            _apiUrl = "https://api.restful-api.dev/objects";

            //Le añadimos el id por que quiero obtener de esa api un objeto con un id en concreto
            string peticion = _apiUrl +"/"+id;

            //Cremos la conexion
            HttpClient cliente = new HttpClient();

            //Enviamos una solicitud de tipo get a la API
            HttpResponseMessage respuesta = await cliente.GetAsync(peticion);

            if (respuesta.IsSuccessStatusCode) //Si el codigo devuelto es correcto
            {
                //Transformo la respuesta HTTP en tipo string 
                string contenido = await respuesta.Content.ReadAsStringAsync();

                //Deserializo el json en un objeto ApiRestObject
                return JsonConvert.DeserializeObject<ApiRestObject>(contenido);
            }
            else {
                throw new Exception($"Error: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            
            }
        }


        /// <summary>
        ///     Borramos un objeto de la API cuyo id se lo pasamos
        /// </summary>
        /// <param name="id">
        ///     Id del objeto a borrar
        /// </param>
        /// <returns>
        ///     
        /// </returns>
        /// <exception cref="Exception"></exception>
        public async Task DeleteObjetoAsync(string id)
            {

            //Url de la API
            _apiUrl = "https://api.restful-api.dev/objects";

            //Creamos la conexion
            HttpClient cliente = new HttpClient();

            //Lanzamos un delete a la api añadiendole el id del objeto a borrar
            HttpResponseMessage respuesta = await cliente.DeleteAsync(_apiUrl+"/"+id);

            if (!respuesta.IsSuccessStatusCode) //Si el codigo no es el esperado
            {
                //Lanzamos el mensaje de error
                throw new Exception($"Error al borrar el objeto: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }


    }
}
