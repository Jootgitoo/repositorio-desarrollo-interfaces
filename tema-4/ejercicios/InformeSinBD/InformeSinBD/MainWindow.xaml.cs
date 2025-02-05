using System.Data;
using System.Security.Cryptography;
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

namespace InformeSinBD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable tabla1;
        private static readonly Random r = new Random();
        private static readonly object Synclock = new object();

        public MainWindow()
        {
            InitializeComponent();
            tabla1 = new DataTable("DataTable1");

            //crear las columnas con los mismos nombres de campos del datatable
            tabla1.Columns.Add("Name");
            tabla1.Columns.Add("Age");
            tabla1.Columns.Add("Address");
            tabla1.Columns.Add("Phone");

            //Añadir 100 filas
            for(int i=1; i<= 100)
            {
                //Crear una fila 
                DataRow row = tabla1.NewRow();
                row["Name"] = "Jorge";
                row["Age"] = RandomNumberGenerator(10, 100);
                row["Address"] = "direccion";
                row["Phone"] = "6666666";
                taba1.Rows.Add(row);
            }
            CrystalReport1 report = new CrystalReport1();
            report.Database.Tables["DataTable1"].SetDataSource(tabla1);
            visor.ViewerCore.ReportSource = report;
        }
    }
}