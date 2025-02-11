using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace InformeCrystalReportsBueno
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataTable tabla1;
        private static readonly Random r = new Random();
        private static readonly object Synlock = new object();


        public MainWindow()
        {
            InitializeComponent();
            tabla1 = new DataTable("DataTable1");//el nombre de la tabla del dataset entre comillas 

            //creaoms lsa columnas con los mismos nombres
            tabla1.Columns.Add("Name");
            tabla1.Columns.Add("Age");
            tabla1.Columns.Add("Address");
            tabla1.Columns.Add("Phone");

            //Añadir 100 fila
            for(int i=1; i<=100; i++)
            {
                //creamos una fila de datos de la tabla creada
                DataRow row = tabla1.NewRow();
                row["Name"] = "Jorge";
                row["Age"] = RandomNumber(10, 100);
                row["Address"] = "direccion";
                row["Phone"] = "123456789";

                tabla1.Rows.Add(row);
            }

            //creamos una instancia del report
            CrystalReport1 report = new CrystalReport1();
            report.Database.Tables["DataTable1"].SetDataSource(tabla1);

            visor.ViewerCore.ReportSource= report;
        }

        public static int RandomNumber(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
