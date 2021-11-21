using BL.Fashion;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormUsuarios : Form
    {
        SeguridadBL _usuarios;
        
        public FormUsuarios()
        {
            InitializeComponent();

            _usuarios = new SeguridadBL();
            listaUsuariosBindingSource.DataSource = _usuarios.ObtenerUsuarios();
            _usuarios.ObtenerUsuarios();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _usuarios.AgregarUsuario();
            listaUsuariosBindingSource.MoveLast();

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

        private void listaUsuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuariosBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                usuario.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                usuario.Foto = null;
            }
            var resultado = _usuarios.GuardarUsuario(usuario);

            if (resultado.Exitoso == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Usuario Guardado");
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
            var resultado = _usuarios.EliminarUsuario(id);
            if (resultado == true)
            {
                listaUsuariosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el usuario.");
            }
        }

        private void CancelarToolStripButton_Click(object sender, EventArgs e)
        {
            _usuarios.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)listaUsuariosBindingSource.Current;

            if (usuario != null)
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
                MessageBox.Show("Debe crear un usuario antes de asignarle una imagen");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
