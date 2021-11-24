using BL.Fashion;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormReporteFacturas : Form
    {
        public FormReporteFacturas()
        {
            InitializeComponent();

            var _facturasBL = new FacturasBL();
            var bindingSource = new BindingSource();

            bindingSource.DataSource = _facturasBL.ObtenerFacturas();
            var reporte = new ReporteFacturaCTL();
            reporte.SetDataSource(bindingSource);
            //reporte.OpenSubreport(2).SetDataSource(DataSet.FacturaDataTable);
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
