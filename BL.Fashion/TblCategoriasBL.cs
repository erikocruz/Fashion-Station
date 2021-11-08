using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblCategoriasBL
    {
        Contexto _contexto;

        public BindingList<TblCategoria> ListaTblCategorias { get; set; }

        public TblCategoriasBL()
        {
            _contexto = new Contexto();
            ListaTblCategorias = new BindingList<TblCategoria>();
        }

        public BindingList<TblCategoria> ObtenerTblCategorias()
        {
            _contexto.TblCategorias.Load();
            ListaTblCategorias = _contexto.TblCategorias.Local.ToBindingList();

            return ListaTblCategorias;
        }

    }

    public class TblCategoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}