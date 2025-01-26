using ApiRestPrueba.domain;
using ApiRestPrueba.persistence.manages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApiRestPrueba
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApiManager apiManager;
        public MainWindow()
        {
            InitializeComponent();
            apiManager = new ApiManager();
        }

        private async void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            
            //    //URL de la API
            //    string apiUrl = "https://api.restful-api.dev/objects";
            //try
            //{

            //    ResultsListBox.Items.Clear();
            //    ResultsListBox.Items.Add("Cargando datos...");

            //    //Realizar la solicitud HTTP
            //    HttpClient client = new HttpClient();
            //    HttpResponseMessage response = await client.GetAsync(apiUrl);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        //Leer y deserializar los datos JSON
            //        string jsonResponse = await response.Content.ReadAsStringAsync();
            //        var objects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ApiObject>>(jsonResponse);

            //        //Limpiar y cargar datos en el Listbox
            //        ResultsListBox.Items.Clear();
            //        foreach (var obj in objects)
            //        {
            //            ResultsListBox.Items.Add($"ID: {obj.Id}, Name: {obj.Name}");
            //        }
            //    }
            //    else
            //    {
            //        ResultsListBox.Items.Clear();
            //        ResultsListBox.Items.Add($"Error: {response.StatusCode} = {response.ReasonPhrase}");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    ResultsListBox.Items.Clear();
            //    ResultsListBox.Items.Add($"Error al obtener datos {ex.Message}");
            //}

            ResultsListBox.Items.Clear();
            ResultsListBox.Items.Add("Cargando datos...");

            try {
                List<ApiRestObject> objetos = await apiManager.getListaObjetos();

                ResultsListBox.Items.Clear();
                foreach (var obj in objetos)
                {
                    ResultsListBox.Items.Add($"ID: {obj.Id}, Name: {obj.Name}");
                }
            }catch (Exception ex){ 
                ResultsListBox.Items.Clear();
                ResultsListBox.Items.Add($"Error al obtener datos: {ex.Message}");
            }


        }

        //public class ApiObject
        //{ 
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public Dictionary<string, string> Data { get; set; }
        //}

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string creado =  await apiManager.addNuevo(); // Llamar al método que agrega un nuevo objeto
                MessageBox.Show("Objeto añadido con éxito.");

                LoadDataButton_Click(null, null);
                RecogerID.Text = creado;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir el objeto: {ex.Message}");
            }
        }

        private async void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            if (ResultsListBox.SelectedItem == null){
                MessageBox.Show("Seleccione un objeto para borra");
                return;
            }

            // Obtener el ID del objeto seleccionado
            string selectedItem = ResultsListBox.SelectedItem.ToString();
            string id;
            try
            {
                id = selectedItem.Split(',')[0].Split(':')[1].Trim();
            }
            catch
            {
                MessageBox.Show("No se pudo obtener el ID del objeto seleccionado");
                return;
            }

            try
            {
                await apiManager.DeleteObjetoAsync(id);
                MessageBox.Show("Objeto borrado con éxito.");
                LoadDataButton_Click(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar el objeto: {ex.Message}");
            }
        }

        private async void Button_Click_Buscar(object sender, RoutedEventArgs e)
        {
            ResultsListBox.Items.Clear();
            ResultsListBox.Items.Add("Cargando datos...");
            string id = EscribirId.Text;

            try
            {
                if (id != null)
                {
                    ApiRestObject objeto = await apiManager.GetbyID(id);
                    ResultsListBox.Items.Clear();
                    ResultsListBox.Items.Add($"ID: {objeto.Id}, Name: {objeto.Name}");

                }
                else {
                    MessageBox.Show("Introduce un ID primero");
                }
            }
            catch (Exception ex)
            {
                ResultsListBox.Items.Clear();
                ResultsListBox.Items.Add($"Error al obtener datos: {ex.Message}");
            }
        }
    }
}
