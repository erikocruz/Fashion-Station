using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class ProductosBL
    {
        Contexto _contexto;

        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();

           }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }


        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto == null)
            {
                resultado.Mensaje = "Agregue un producto válido.";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty (producto.Descripcion) == true)
            {
                resultado.Mensaje = "Debe registrar una 'Descripción'.";
                resultado.Exitoso = false;
            }

            if (producto.Precio <= 0)
            {
                resultado.Mensaje = "El Precio debe ser mayor que cero.";
                resultado.Exitoso = false;
            }

            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La Existencia debe ser mayor o igual a cero.";
                resultado.Exitoso = false;
            }
            
            if (producto.TblTipoPersonaId == 0)
            {
                resultado.Mensaje = "Debe registrar al Tipo de Persona al que refiere este Producto.";
                resultado.Exitoso = false;
            }

            if (producto.TblCategoriaId == 0)
            {
                resultado.Mensaje = "Debe registrar una 'Categoría'.";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public int TblTipoPersonaId { get; set; }
        public TblTipoPersona TblTipoPersona { get; set; }
        public int TblCategoriaId { get; set; }
        public TblCategoria TblCategoria { get; set; }
        public byte[] Foto{ get; set; }
        public bool Activo { get; set; }

        public Producto()
        {
            Activo = true;
        }
    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }

}