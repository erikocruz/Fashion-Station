using BL.Fashion;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormClientes : Form
    {

        ClientesBL _clientes;
        TblClaseCltesBL _clasecltes;
        TblPaisesBL _paises;
        TblDeptosBL _deptos;
        TblMunicipiosBL _municipios;
        TblSectorBoColsBL _sectorbocols;


        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientes.ObtenerClientes();

            _clasecltes = new TblClaseCltesBL();
            listaTblClaseCltesBindingSource.DataSource = _clasecltes.ObtenerTblClaseCltes();

            _paises = new TblPaisesBL();
            listaTblPaisesBindingSource.DataSource = _paises.ObtenerTblPaises();

            _deptos = new TblDeptosBL();
            listaTblDeptosBindingSource.DataSource = _deptos.ObtenerTblDeptos();

            _municipios = new TblMunicipiosBL();
            listaTblMunicipiosBindingSource.DataSource = _municipios.ObtenerTblMunicipios();

            _sectorbocols = new TblSectorBoColsBL();
            listaTblSectorBoColsBindingSource.DataSource = _sectorbocols.ObtenerTblSectorBoCols();
        }

   

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClientesBindingSource.MoveLast();

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

        private void listaClientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClientesBindingSource.EndEdit();
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                cliente.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                cliente.Foto = null;
            }
            var resultado = _clientes.GuardarCliente(cliente);

            if (resultado.Exitoso == true)
            {
                listaClientesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Cliente Guardado");
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
            var resultado = _clientes.EliminarCliente(id);
            if (resultado == true)
            {
                listaClientesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el cliente.");
            }
        }

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            _clientes.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientesBindingSource.Current;

            if (cliente != null)
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
                MessageBox.Show("Debe crear un cliente antes de asignarle una imagen");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void generoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listaClientesBindingSource.EndEdit();
            //var cliente = (Cliente)listaClientesBindingSource.Current;

            //int indice = generoComboBox.SelectedIndex;
            //cliente.Genero = generoComboBox.SelectedText;

            //cliente.Genero = generoComboBox.Items[indice].ToString();

        }
    }
}
