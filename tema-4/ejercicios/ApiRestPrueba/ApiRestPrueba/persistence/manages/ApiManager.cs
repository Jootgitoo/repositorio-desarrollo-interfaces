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

        public async Task<List<ApiRestObject>> getListaObjetos()
        { 
            _apiUrl= "https://api.restful-api.dev/objects";
            HttpClient cliente = new HttpClient();
            HttpResponseMessage respuesta = await cliente.GetAsync(_apiUrl);

            if (respuesta.IsSuccessStatusCode)
            {
                string jsonRespuesta = await respuesta.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ApiRestObject>>(jsonRespuesta);
            }
            else {
                throw new Exception($"Error: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }

        public async Task<string> addNuevo()
        {
            _apiUrl = "https://api.restful-api.dev/objects";
            string body = "{\"name\": \"Prueba\", \"data\": { \"Generation\": \"4th\", \"Price\": \"519.99\" }}";
            HttpClient cliente = new HttpClient();
            HttpContent contenido = new StringContent(body, Encoding.UTF8, "application/json");
            HttpResponseMessage respuesta = await cliente.PostAsync(_apiUrl, contenido);

            if (respuesta.IsSuccessStatusCode)
            {
                string jsonRespuest = await respuesta.Content.ReadAsStringAsync();
                return jsonRespuest;

            }
            else
            {
                throw new Exception($"Error al añadir objeto: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }

        public async Task<ApiRestObject> GetbyID(string id) { 
            _apiUrl = "https://api.restful-api.dev/objects";
            string peticion = _apiUrl +"/"+id;
            HttpClient cliente = new HttpClient();
            HttpResponseMessage respuesta = await cliente.GetAsync(peticion);
            if (respuesta.IsSuccessStatusCode)
            {
                string contenido = await respuesta.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ApiRestObject>(contenido);
            }
            else {
                throw new Exception($"Error: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            
            }
        }

        public async Task DeleteObjetoAsync(string id)
            {
            _apiUrl = "https://api.restful-api.dev/objects";
            HttpClient cliente = new HttpClient();
            HttpResponseMessage respuesta = await cliente.DeleteAsync(_apiUrl+"/"+id);

            if (!respuesta.IsSuccessStatusCode)
            {
                throw new Exception($"Error al borrar el objeto: {respuesta.StatusCode} - {respuesta.ReasonPhrase}");
            }
        }


    }
}
