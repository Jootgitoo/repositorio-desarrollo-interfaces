using AprsPrueba.Domain;
using AprsPrueba.Modelo;
using System.Net.Http;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AprsPrueba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ManejoAPI manejoApi;

        public MainWindow()
        {
            InitializeComponent();
            manejoApi = new ManejoAPI(); 
        }

        private async void botonCargar_Click(object sender, RoutedEventArgs e)
        {
         
            ResultListBox.Items.Clear();
            ResultListBox.Items.Add("Cargando datos...");

            try
            {
                var objects = await manejoApi.obtenerObjetos();

                ResultListBox.Items.Clear();
                foreach (var obj in objects)
                {
                    ResultListBox.Items.Add($"ID: {obj.Id}, Name: {obj.Name}");
                }
            }
            catch (Exception ex)
            {
                ResultListBox.Items.Clear();
                ResultListBox.Items.Add($"Error: {ex.Message}");
            }
        }

        private async void addObjetos_Click(object sender, RoutedEventArgs e)
        {
            // Crear un nuevo objeto
            var nuevoObjeto = new ApiObject
            {
                Id = Guid.NewGuid().ToString(), // Generar un ID único (opcional si la API lo genera automáticamente)
                Name = "Nuevo Objeto",
                Data = new Dictionary<string, string>
                {
                    { "Propiedad1", "Valor1" },
                    { "Propiedad2", "Valor2" }
                }
            };

            try
            {
                var objetoCreado = await manejoApi.agregarObjeto(nuevoObjeto);

                // Mostrar confirmación en la interfaz
                ResultListBox.Items.Add($"Objeto añadido: ID={objetoCreado.Id}, Name={objetoCreado.Name}");
            }
            catch (Exception ex)
            {
                // Mostrar error en la interfaz
                ResultListBox.Items.Add($"Error al añadir objeto: {ex.Message}");
            }
        }


        private async void borrarObjetos_Click(object sender, RoutedEventArgs e)
        {
            if (ResultListBox.SelectedItem == null)
            {
                ResultListBox.Items.Add("Seleccione un objeto para eliminar.");
                return;
            }

            try
            {
                // Extraer el ID del objeto seleccionado (esto depende de cómo se muestra en la lista)
                string seleccionado = ResultListBox.SelectedItem.ToString();
                string id = seleccionado.Split(',')[0].Replace("ID: ", "").Trim();

                // Llamar al método para eliminar el objeto
                await manejoApi.eliminarObjeto(id);

                // Confirmar eliminación
                ResultListBox.Items.Add($"Objeto con ID {id} eliminado.");
            }
            catch (Exception ex)
            {
                ResultListBox.Items.Add($"Error al eliminar objeto: {ex.Message}");
            }
        }


    }
}