using Container_in_class.domain;
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

namespace Container_in_class
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

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            Character c1 = new Character("Jorge");
            Character c2 = new Character("Mateo");
            Character c3 = new Character("Ivan");

            cboPlayer.Items.Add(c1);
            cboPlayer.Items.Add(c2);
            cboPlayer.Items.Add(c3);
        }
    }
}