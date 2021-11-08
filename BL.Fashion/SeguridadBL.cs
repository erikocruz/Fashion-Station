using System.Linq;

namespace BL.Fashion
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }

        public bool Autorizar(string usuario, string contrasena)
        {
            var usuarios = _contexto.Usuarios.ToList();

            foreach(var UsuarioDB in usuarios)
            {
                if (usuario == UsuarioDB.Nombre && contrasena == UsuarioDB.Contrasena)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}
