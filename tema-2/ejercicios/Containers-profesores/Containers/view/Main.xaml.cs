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
using Containers.domain;

namespace Containers
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Character HT = null;
        Character HG = null;
        Character RW = null;

        public MainWindow()
         
        {
            InitializeComponent();
            btnNew.IsEnabled = false;
            btnDelete.IsEnabled = false;
            btnSave.IsEnabled = false;

            imgWand.IsEnabled = false;
            imgLightning.IsEnabled = false;
            imgBrain.IsEnabled = false;

            dgvStore.IsEnabled = false;

            HT = new Character("Harry Potter");
            HG = new Character("Hermione Granger");
            RW = new Character("Ronald Wesley");

            cboPlayer.Items.Add(HT.name);
            cboPlayer.Items.Add(HG.name);
            cboPlayer.Items.Add(RW.name);
        }

        private void cboPlayer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnNew.IsEnabled = true;
            switch (cboPlayer.SelectedIndex)
            {
                case 0:
                    lblAvaible.Content = "Avaiable Points: " + HT.points;
                    break;
                case 1:
                    lblAvaible.Content = "Avaiable Points: " + HG.points;
                    break; 
                case 2:
                    lblAvaible.Content = "Avaiable Points: " + RW.points;                     
                    break;
            }

        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            btnNew.IsEnabled = false;
            btnDelete.IsEnabled = true;
            btnSave.IsEnabled = true;

            imgWand.IsEnabled = true;
            imgLightning.IsEnabled = true;
            imgBrain.IsEnabled = true;

            dgvStore.IsEnabled = true;
        }

       

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            List<Ability> abilities = new List<Ability>();
            Ability w = new Ability("wand");
            abilities.Add(w);
            HT.addList(w);
            dgvStore.ItemsSource = abilities;
            

        }
    }
}
