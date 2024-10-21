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

namespace ejercicio_dataBinnding2
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

        private void Button_Small_Click(object sender, RoutedEventArgs e)
        {
            this.MiSlide.Value = this.MiSlide.Minimum;
        }

        private void Button_Medium_Click(object sender, RoutedEventArgs e)
        {
            this.MiSlide.Value = (this.MiSlide.Maximum + this.MiSlide.Minimum) / 2;
        }

        private void Button_Big_Click(object sender, RoutedEventArgs e)
        {
            this.MiSlide.Value = this.MiSlide.Maximum;
        }
    }
}
