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

        public class ApiObject
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public Dictionary<string, String> Data { get; set; }
        }
    }
}