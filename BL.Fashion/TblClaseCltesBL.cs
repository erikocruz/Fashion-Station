using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblClaseCltesBL
    {
        Contexto _contexto;

        public BindingList<TblClaseClte> ListaTblClaseCltes { get; set; }

        public TblClaseCltesBL()
        {
            _contexto = new Contexto();
            ListaTblClaseCltes = new BindingList<TblClaseClte>();
        }

        public BindingList<TblClaseClte> ObtenerTblClaseCltes()
        {
            _contexto.TblClaseCltes.Load();
            ListaTblClaseCltes = _contexto.TblClaseCltes.Local.ToBindingList();

            return ListaTblClaseCltes;
        }

    }

    public class TblClaseClte
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}