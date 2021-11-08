using BL.Fashion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormFacturas : Form
    {
        FacturasBL _facturasBL;
        ClientesBL _clientesBL;
        ProductosBL _productosBL;

        public FormFacturas()
        {
            InitializeComponent();

            _facturasBL = new FacturasBL();
            listaFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new ProductosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProductos();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturasBL.AgregarFactura();
            listaFacturasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            CancelarToolStripButton.Visible = !valor;
        }

        private void CancelartoolStripButton_Click(object sender, EventArgs e)
        {
            _facturasBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void listaFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturasBindingSource.EndEdit();
            var factura = (Factura)listaFacturasBindingSource.Current;

            var resultado = _facturasBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;

            _facturasBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;
            _facturasBL.CalcularFactura(factura);
            listaFacturasBindingSource.ResetBindings(false);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturasBL.AnularFactura(id);
            if(resultado == true)
            {
                listaFacturasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar anular la factura.");
            }
        }

        private void listaFacturasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura = (Factura)listaFacturasBindingSource.Current;

            if (factura != null && factura.Id != 0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}
