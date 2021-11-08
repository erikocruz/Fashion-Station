using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblPaisesBL
    {
        Contexto _contexto;

        public BindingList<TblPais> ListaTblPaises { get; set; }

        public TblPaisesBL()
        {
            _contexto = new Contexto();
            ListaTblPaises = new BindingList<TblPais>();
        }

        public BindingList<TblPais> ObtenerTblPaises()
        {
            _contexto.TblPaises.Load();
            ListaTblPaises = _contexto.TblPaises.Local.ToBindingList();

            return ListaTblPaises;
        }

    }

    public class TblPais
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}