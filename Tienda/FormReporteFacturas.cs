using BL.Fashion;
using System.Collections.Generic;
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

            var facturaDetalle = new List<FacturaDetalle>();
            foreach (var factura in _facturasBL.ListaFacturas)
            {
                foreach (var detalle in factura.FacturaDetalle)
                {
                    facturaDetalle.Add(detalle);
                }
            }

            reporte.Subreports[0].SetDataSource(facturaDetalle);

            //reporte.Subreports[0].SetDataSource(bindingSource); //Espero funcione bien//
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
