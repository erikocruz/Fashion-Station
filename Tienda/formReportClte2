using BL.Fashion;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();

            var _clientesBL = new ClientesBL();
            var bindingSource = new BindingSource();

            bindingSource.DataSource = _clientesBL.ObtenerClientes();
            var reporte = new ReporteClientes();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
