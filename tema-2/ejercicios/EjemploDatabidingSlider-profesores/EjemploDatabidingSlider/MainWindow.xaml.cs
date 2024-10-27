using System;
using System.Collections.Generic;
using System.Linq;
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

namespace EjemploDatabidingSlider
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void sldTamano_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.sldTamano.Value = 10;

        }

        private void BntPequeño_Click(object sender, RoutedEventArgs e)
        {
            this.sldTamano.Value = 10;

        }

        private void bntNormal_Click(object sender, RoutedEventArgs e)
        {
            this.sldTamano.Value = 24;

        }

        private void bntGrande_Click(object sender, RoutedEventArgs e)
        {
            this.sldTamano.Value = 34;
        }
    }
}
