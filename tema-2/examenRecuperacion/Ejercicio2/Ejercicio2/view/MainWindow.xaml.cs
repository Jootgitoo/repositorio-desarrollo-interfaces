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

namespace Ejercicio2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();


        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //Inserto la serpiente
            int sizeSerpiente = int.Parse(tbSizeSerpiente.Text);

            for (int i = 0; i < sizeSerpiente; i++)
            {
                for (int j = 0; j < sizeSerpiente; j++)
                {
                    Label etiqueta1 = new Label();
                    etiqueta1.Content = "S";


                    // Colocamos los label en el Grid
                    Grid.SetRow(etiqueta1, i);
                    Grid.SetColumn(etiqueta1, j);

                    // Agregamos el label al Grid
                    gridGame.Children.Add(etiqueta1);
                    gridGame.ShowGridLines = true;
                }
                break;
            }


            //Insertar ratones
            int contadorRatones = int.Parse(tbNumeroRatones.Text);

            //Random
            Random random = new Random();
            for (int i=0; i < contadorRatones; i++)
            {
                for(int j=0; j < contadorRatones; j++)
                {
                    int posI = random.Next(8) + 1;
                    int posJ = random.Next(8);

                    Label etiqueta2 = new Label();
                    etiqueta2.Content = "R";

                    // Colocamos los label en el Grid
                    Grid.SetRow(etiqueta2, posI);
                    Grid.SetColumn(etiqueta2, posJ);
                }
                
            }


        }
    }
}