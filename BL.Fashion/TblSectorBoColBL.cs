using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblSectorBoColsBL
    {
        Contexto _contexto;

        public BindingList<TblSectorBoCol> ListaTblSectorBoCols { get; set; }

        public TblSectorBoColsBL()
        {
            _contexto = new Contexto();
            ListaTblSectorBoCols = new BindingList<TblSectorBoCol>();
        }

        public BindingList<TblSectorBoCol> ObtenerTblSectorBoCols()
        {
            _contexto.TblSectorBoCols.Load();
            ListaTblSectorBoCols = _contexto.TblSectorBoCols.Local.ToBindingList();

            return ListaTblSectorBoCols;
        }

    }

    public class TblSectorBoCol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}