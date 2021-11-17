using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void ropaParaCaballeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_hombre = new FormTblCategorias();
            formproductos_hombre.MdiParent = this;
            formproductos_hombre.Show();
        }

        private void ropaParaNiñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos_nino = new FormTblTiposPersonas();
            formproductos_nino.MdiParent = this;
            formproductos_nino.Show();
        }

        private void reporteDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporinventario = new FormReportInv();
            formreporinventario.MdiParent = this;
            formreporinventario.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporcliente = new FormReporteClientes();
            formreporcliente.MdiParent = this;
            formreporcliente.Show();
        }

        private void reporteDeErroresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formreporterror = new FormTBLTipoProd();
            formreporterror.MdiParent = this;
            formreporterror.Show();
        }

        private void administrarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formadmbase = new FormAdminBD();
            formadmbase.MdiParent = this;
            formadmbase.Show();

        }

        private void formmenu_Load(object sender, EventArgs e)
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeErroresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formreporterror = new FormTBLTipoProd();
            formreporterror.MdiParent = this;
            formreporterror.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mantProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formproductos = new FormProductos();
            formproductos.MdiParent = this;
            formproductos.Show();
        }

        private void mantCltesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formclientes = new FormClientes();
            formclientes.MdiParent = this;
            formclientes.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formfacturas = new FormFacturas();
            formfacturas.MdiParent = this;
            formfacturas.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProductos = new FormReporteProductos();
            formReporteProductos.MdiParent = this;
            formReporteProductos.Show();
        }

        private void reporteDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }
    }
}

