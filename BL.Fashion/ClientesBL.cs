using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class ClientesBL
    {
        Contexto _contexto;

        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();

           }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();
            ListaClientes.Add(nuevoCliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }


        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (cliente == null)
            {
                resultado.Mensaje = "Agregue un cliente válido.";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty (cliente.Nombre) == true)
            {
                resultado.Mensaje = "Debe registrar el 'Nombre del Cliente'.";
                resultado.Exitoso = false;
            }

           // if (cliente.Precio <= 0)
           // {
           //     resultado.Mensaje = "El Precio debe ser mayor que cero.";
           //     resultado.Exitoso = false;
           // }

           // if (cliente.Existencia < 0)
           // {
           //     resultado.Mensaje = "La Existencia debe ser mayor o igual a cero.";
           //     resultado.Exitoso = false;
           // }
            
           // if (cliente.TipoPersonaId == 0)
           // {
           //     resultado.Mensaje = "Debe registrar al Tipo de Persona al que refiere este Producto.";
           //     resultado.Exitoso = false;
           // }

           // if (cliente.CategoriaId == 0)
           // {
           //     resultado.Mensaje = "Debe registrar una 'Categoría'.";
           //     resultado.Exitoso = false;
           // }

            return resultado;
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        public int TblClaseClteId { get; set; }
        public TblClaseClte TblClaseClte { get; set; }
        //public int PaisOrigenId { get; set; }
        //public TblPais TblPais { get; set; }
        public int TblPaisId { get; set; }
        public TblPais TblPais { get; set; }
        public int TblDeptoId { get; set; }
        public TblDepto TblDepto { get; set; }
        public int TblMunicipioId { get; set; }
        public TblMunicipio TblMunicipio { get; set; }
        public int TblSectorBoColId { get; set; }
        public TblSectorBoCol TblSectorBoCol { get; set; }
        public string Direccion { get; set; }

        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }

        public string Genero { get; set; }

        //public int TipoPersonaId { get; set; }
        //public TblTipoPersona TblTipoPersona { get; set; }
        //public int CategoriaId { get; set; }
        //public TblCategoria TblCategoria { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }

        public Cliente()
        {
            Activo = true;
        }
    }
}