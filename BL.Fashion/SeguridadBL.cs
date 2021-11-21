using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace BL.Fashion
{
    public class SeguridadBL
    {
        Contexto _contexto;
        public BindingList<Usuario> ListaUsuarios { get; set; }

        public SeguridadBL()
        {
            _contexto = new Contexto();
            ListaUsuarios = new BindingList<Usuario>();
        }

        public BindingList<Usuario> ObtenerUsuarios()
        {
            _contexto.Usuarios.Load();
            ListaUsuarios = _contexto.Usuarios.Local.ToBindingList();

            return ListaUsuarios;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarUsuario(Usuario usuario)
        {
            var resultado = Validar(usuario);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();
            ListaUsuarios.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int id)
        {
            foreach (var usuario in ListaUsuarios)
            {
                if (usuario.Id == id)
                {
                    ListaUsuarios.Remove(usuario);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }


        private Resultado Validar(Usuario usuario)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (usuario == null)
            {
                resultado.Mensaje = "Agregue un usuario válido.";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                resultado.Mensaje = "Debe registrar el 'Nombre del Usuario'.";
                resultado.Exitoso = false;
            }


            if (string.IsNullOrEmpty(usuario.Contrasena) == true)
            {
                resultado.Mensaje = "Debe registrar la 'Contraseña' del usuario.";
                resultado.Exitoso = false;
            }
           

            return resultado;
        }


        public Usuario Autorizar(string nombreUsuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach(var usuarioDB in usuarios)
            {
                if (nombreUsuario == usuarioDB.Nombre && contrasena == usuarioDB.Contrasena)
                {
                    return usuarioDB;
                }
            }
            return null;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string TipoUsuario { get; set; }

        public byte[] Foto { get; set; }
        public bool Activo { get; set; }

        public bool UserAdmin { get; set; }
        public bool AccesaClientes { get; set; }
        public bool AccesaProductos { get; set; }
        public bool AccesaFacturas { get; set; }
        public bool AccesaReportes { get; set; }

        public Usuario()
        {
            Activo = true;
            UserAdmin = false;
            AccesaClientes = false;
            AccesaProductos = false;
            AccesaFacturas = false;
            AccesaReportes = false;
        }
    }
}
