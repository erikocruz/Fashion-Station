using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblTiposPersonasBL
    {
        Contexto _contexto;

        public BindingList<TblTipoPersona> ListaTblTiposPersonas { get; set; }

        public TblTiposPersonasBL()
        {
            _contexto = new Contexto();
            ListaTblTiposPersonas = new BindingList<TblTipoPersona>();
        }

        public BindingList<TblTipoPersona> ObtenerTblTiposPersonas()
        {
            _contexto.TblTiposPersonas.Load();
            ListaTblTiposPersonas = _contexto.TblTiposPersonas.Local.ToBindingList();

            return ListaTblTiposPersonas;
        }

    }

    public class TblTipoPersona
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
