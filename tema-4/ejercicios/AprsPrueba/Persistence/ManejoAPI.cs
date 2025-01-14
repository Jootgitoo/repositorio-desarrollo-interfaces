using AprsPrueba.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static AprsPrueba.MainWindow;

namespace AprsPrueba.Modelo
{
    internal class ManejoAPI
    {

        private string apiUrl = "https://api.restful-api.dev/objects";

        /// <summary>
        ///     Método para obtener objetos de la API
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<List<ApiObject>> obtenerObjetos()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var objects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiObject>>(jsonResponse);
                    return objects;
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching data: {ex.Message}");
            }
        }

        public async Task<ApiObject> agregarObjeto(ApiObject nuevoObjeto)
        {
            try
            {
                HttpClient client = new HttpClient();

                // Serializar el objeto a JSON
                string jsonObjeto = Newtonsoft.Json.JsonConvert.SerializeObject(nuevoObjeto);

                // Crear el contenido de la solicitud
                StringContent contenido = new StringContent(jsonObjeto, Encoding.UTF8, "application/json");

                // Enviar la solicitud POST
                HttpResponseMessage response = await client.PostAsync(apiUrl, contenido);

                if (response.IsSuccessStatusCode)
                {
                    // Leer la respuesta de la API
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserializar el objeto resultante
                    var objetoCreado = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiObject>(jsonResponse);
                    return objetoCreado;
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar el objeto: {ex.Message}");
            }
        }

        public async Task eliminarObjeto(string id)
        {
            try
            {
                HttpClient client = new HttpClient();

                // Crear la URL completa para eliminar el objeto
                string urlEliminar = $"{apiUrl}/{id}";

                // Enviar la solicitud DELETE
                HttpResponseMessage response = await client.DeleteAsync(urlEliminar);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error al eliminar: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al eliminar el objeto: {ex.Message}");
            }
        }

    }
}
