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

        //async HACE QUE SE PUEDAN REALIZAR OPERACIONES ASÍNCRONAS CON await DENTRO DEL MÉTODO

        /// <summary>
        ///     Hacemos una llamada a una API y obtenemos datos de ella
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            //Limpiamos el ResultsListBox
            ResultsListBox.Items.Clear();

            //Mostramos al usuario un mensaje de q estamos cargando (es temporal)
            ResultsListBox.Items.Add("Cargando datos...");

            try {
                //Llamamos al método getListaObjetos para realizar una solicitud a una API REST obteniendo una lista de objetos
                List<ApiRestObject> objetos = await apiManager.getListaObjetos();

                //Limpiamos el ResultsListBox para esscribir en el los datos obtenidos de la consulta
                ResultsListBox.Items.Clear();

                //Por cada objeto que haya en objetos(lista de valores extraidos de la api)
                foreach (var obj in objetos)
                {
                    //Escribimos el id y el nombre
                    ResultsListBox.Items.Add($"ID: {obj.Id}, Name: {obj.Name}");
                }

            }catch (Exception ex){ 
                ResultsListBox.Items.Clear();
                ResultsListBox.Items.Add($"Error al obtener datos: {ex.Message}");
            }

        }


        /// <summary>
        ///     Creamos un objeto a la api con la llamada a .addNuevo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click_CrearObjeto(object sender, RoutedEventArgs e)
        {
            try
            {
                //Hacemos una llamada a la API para crear un objeto nuevo
                string creado =  await apiManager.addNuevo();

                //Mostramos un mensaje al usuario
                MessageBox.Show("Objeto añadido con éxito.");

                //Llamamos al método de carga de datos para que te muestre el nuevo objeto creado
                LoadDataButton_Click(null, null);

                //Añadimoa a RecogerID el texto del objecto creado
                RecogerID.Text = creado;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al añadir el objeto: {ex.Message}");
            }
        }


        /// <summary>
        ///     Eliminas un objeto de la API con su id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click_Borrar(object sender, RoutedEventArgs e)
        {
            //Cogemos el elemento seleccionado
            if (ResultsListBox.SelectedItem == null){
                MessageBox.Show("Seleccione un objeto para borra"); //Si no ha seleccionado ninguno mostramos un mensaje
                return;
            }

            //Obtener el ID del objeto seleccionado
            string selectedItem = ResultsListBox.SelectedItem.ToString();
            string id;
            try
            {
                //Cogemos el id dividiendo la cadena por ,
                id = selectedItem.Split(',')[0].Split(':')[1].Trim();
            }
            catch
            {
                MessageBox.Show("No se pudo obtener el ID del objeto seleccionado"); //Error de que el id es incorrecto
                return;
            }

            try
            {
                //Llamamos al método delete para que borre el objeto con id = valor id (el valor lo hemos conseguido antes)
                await apiManager.DeleteObjetoAsync(id);
                MessageBox.Show("Objeto borrado con éxito.");
                
                //Recargamso los datos 
                LoadDataButton_Click(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al borrar el objeto: {ex.Message}");
            }
        }


        /// <summary>
        ///     Busca un objeto de la API a través de su id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click_Buscar(object sender, RoutedEventArgs e)
        {
            //Limpas y pones un mensjae de traza en ResultsListBox
            ResultsListBox.Items.Clear();
            ResultsListBox.Items.Add("Cargando datos...");

            //Recoges el id escrito por el usuario
            string id = EscribirId.Text;

            try
            {
                if (id != null) //Si el id no es null..
                {

                    //Hacemos una solicitud a la api pidiendo el objeto con ese id 
                    ApiRestObject objeto = await apiManager.GetbyID(id);

                    //Limpiamos el ResultsListBox
                    ResultsListBox.Items.Clear();

                    //Y solo escribimos el objeto extraido
                    ResultsListBox.Items.Add($"ID: {objeto.Id}, Name: {objeto.Name}");

                }
                else {
                    //Si el id es null...
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
