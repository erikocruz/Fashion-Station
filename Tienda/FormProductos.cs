using BL.Fashion;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormProductos : Form
    {

        ProductosBL _productos;
        TblTiposPersonasBL _tipospersonas;
        TblCategoriasBL _categorias;

        public FormProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProductos();

            _tipospersonas = new TblTiposPersonasBL();
            listaTblTiposPersonasBindingSource.DataSource = _tipospersonas.ObtenerTblTiposPersonas();

            _categorias = new TblCategoriasBL();
            listaTblCategoriasBindingSource.DataSource = _categorias.ObtenerTblCategorias();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();

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

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var producto = (Producto)listaProductosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }
            var resultado = _productos.GuardarProducto(producto);

            if (resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Producto Guardado");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea liminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
            else
            {
                MessageBox.Show("No hay registros, 'No Aplica' el proceso.");
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _productos.EliminarProducto(id);
            if (resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el producto.");
            }
        }

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            _productos.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductosBindingSource.Current;

            if (producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Debe crear un producto antes de asignarle una imagen");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
