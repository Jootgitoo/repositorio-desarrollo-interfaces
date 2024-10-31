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

namespace grids_MarioBros
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Random random = new Random();

            //RELLENA LA MATRIZ CON NUMEROS 
            //for (int i = 0; i < 8; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        Label label = new Label();
            //        label.Content = random.Next(3).ToString();
            //        label.HorizontalAlignment = HorizontalAlignment.Center;
            //        label.VerticalAlignment = VerticalAlignment.Center;

            //        //Establecemos la posicion en la i y j
            //        Grid.SetRow(label, i);
            //        Grid.SetColumn(label, j);

            //        gridGame.Children.Add(label);
            //    }
            //}


            //VAMOS A RELLENAR LA MATRIZ Y DEPENDE DEL NUMERO SE INGRASARÁ UNA IMAGEN U OTRA
            for (int i = 0; i < 8; i++) 
            {
                for (int j = 0; j < 8; j++) 
                {
                    
                }
            }

        }
    }
}