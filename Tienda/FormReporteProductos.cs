using BL.Fashion;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _productosBL = new ProductosBL();
            var bindingSource = new BindingSource();

            bindingSource.DataSource = _productosBL.ObtenerProductos();
            var reporte = new ReporteProductos();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
