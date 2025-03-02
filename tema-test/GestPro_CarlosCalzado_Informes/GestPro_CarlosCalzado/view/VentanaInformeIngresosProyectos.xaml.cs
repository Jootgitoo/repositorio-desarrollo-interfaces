using GestPro_CarlosCalzado.domain;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace GestPro_CarlosCalzado.view
{
    /// <summary>
    /// Lógica de interacción para VentanaInformeIngresosProyectos.xaml
    /// </summary>
    public partial class VentanaInformeIngresosProyectos : Window
    {
        DataTable tabla1;
        private List<ProyectoEmpleado> lstProyectoEmpleado;
        private ProyectoEmpleado proyectoEmpleado;
        public VentanaInformeIngresosProyectos()
        {
            InitializeComponent();

            lstProyectoEmpleado = new List<ProyectoEmpleado>();
            proyectoEmpleado = new ProyectoEmpleado();
            lstProyectoEmpleado = proyectoEmpleado.getProyectoEmpleado();

            tabla1 = new DataTable("DataTableProyectoEmpleado");
            tabla1.Columns.Add("Nombre Proyecto");
            tabla1.Columns.Add("Fecha");
            tabla1.Columns.Add("Costes");

            foreach (ProyectoEmpleado proyectoEmpleado in lstProyectoEmpleado)
            {
                DataRow row = tabla1.NewRow();
                row["Nombre Proyecto"] = proyectoEmpleado.NombreProyecto;
                row["Fecha"] = proyectoEmpleado.Fecha;
                row["Costes"] = proyectoEmpleado.Costes;
                tabla1.Rows.Add(row);
            }
            InformeCostesIngresos report = new InformeCostesIngresos();

            report.Database.Tables["DataTableProyectoEmpleado"].SetDataSource((DataTable)tabla1);

            visorCostesIngresos.ViewerCore.ReportSource = report;
        }
    }
}
