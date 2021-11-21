using BL.Fashion;
using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormLogin : Form
    {
        SeguridadBL _usuariosBL; 

        public FormLogin()
        {
            InitializeComponent();

            _usuariosBL = new SeguridadBL();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login(); 
        }

        private void Login()
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verificando...";
            Application.DoEvents();

            var usuarioDB = _usuariosBL.Autorizar(usuario, contrasena);

            if (usuarioDB != null)
            {
                Utilidades.UsuarioActual = usuarioDB;
                //              MessageBox.Show(Program.UsuarioLogueado.Nombre);
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
            button1.Enabled = true;
            button1.Text = "Aceptar";
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  (e.KeyChar == Convert.ToChar(Keys.Enter) 
                && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox2.Text))
            {
                Login();
            }
        }
    }
}