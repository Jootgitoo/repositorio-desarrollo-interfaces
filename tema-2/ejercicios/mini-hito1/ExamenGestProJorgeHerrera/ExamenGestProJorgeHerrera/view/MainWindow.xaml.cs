﻿using ExamenGestProJorgeHerrera.manages;
using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

        Proyecto p = new Proyecto(); 


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void addProyect(object sender, RoutedEventArgs e)
        {
            Proyecto proyecto = new Proyecto(txtProyectName.Text, txtfechaInicio.Text, txtFechaFin.Text, txtCreationTime.Text);
            proyecto.insert(proyecto);
        }

        private void modifyProyect(object sender, RoutedEventArgs e)
        {

        }

        private void deleteProyect(object sender, RoutedEventArgs e)
        {

        }


        /*private void addPredefinedProyect(object sender, RoutedEventArgs e)
        {
            p.insertarProyecto();
        }
        */






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
