﻿using System;
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

namespace ExamenGestProJorgeHerrera
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Proyecto> lstProyecto;

        public MainWindow()
        {
            InitializeComponent();
            lstProyecto = new List<Proyecto>();
            dgvProyectos.ItemsSource = lstProyecto;
        }

        /*        private void Button_Add_Click(object sender, RoutedEventArgs e)
                {

                    lstProyecto.Where(p => p.codigoProyecto == txtCodigoProyecto.Text && p.Nombre == txtNombre.Text)
                        .ToList().ForEach(p =>
                        {
                            p.Nombre = txtNombre.Text;
                            p.Apellidos = txtApellidos.Text;
                            p.Edad = int.Parse(txtEdad.Text);
                        });
                }

        */
    }
}