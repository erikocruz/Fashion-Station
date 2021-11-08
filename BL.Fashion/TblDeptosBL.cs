using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblDeptosBL
    {
        Contexto _contexto;

        public BindingList<TblDepto> ListaTblDeptos { get; set; }

        public TblDeptosBL()
        {
            _contexto = new Contexto();
            ListaTblDeptos = new BindingList<TblDepto>();
        }

        public BindingList<TblDepto> ObtenerTblDeptos()
        {
            _contexto.TblDeptos.Load();
            ListaTblDeptos = _contexto.TblDeptos.Local.ToBindingList();

            return ListaTblDeptos;
        }
    }

    public class TblDepto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}