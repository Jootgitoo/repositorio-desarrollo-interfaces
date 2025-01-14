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
    }
}
