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

namespace ejercicio_grids_final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // Definimos las filas y columnas con grids
            for (int i = 0; i < 15; i++) 
            {
                RowDefinition fila = new RowDefinition(); //Creamos la instancia de la fila
                ColumnDefinition columna = new ColumnDefinition(); //Creamos la instancia de la columna

                grid.RowDefinitions.Add(fila); //Añadimos la fila
                grid.ColumnDefinitions.Add(columna); //Añadimos la columna

            }

            //Escribimos los botones
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    // Creamos un label 
                    Label etiqueta = new Label();

                    // Este es el contenido que va a tener el label
                    etiqueta.Content = "Botón " + i + ", " + j;

                    // Esta es la alineación que va a tener el label
                    etiqueta.HorizontalAlignment = HorizontalAlignment.Center;
                    etiqueta.VerticalAlignment = VerticalAlignment.Center; 

                    // Colocamos los label en el Grid
                    Grid.SetRow(etiqueta, i);
                    Grid.SetColumn(etiqueta, j);

                    // Agregamos el label al Grid
                    grid.Children.Add(etiqueta);
                    grid.ShowGridLines = true;
                }
            }
        }
    }
}