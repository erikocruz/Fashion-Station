using System.ComponentModel;
using System.Data.Entity;

namespace BL.Fashion
{
    public class TblMunicipiosBL
    {
        Contexto _contexto;

        public BindingList<TblMunicipio> ListaTblMunicipios { get; set; }

        public TblMunicipiosBL()
        {
            _contexto = new Contexto();
            ListaTblMunicipios = new BindingList<TblMunicipio>();
        }

        public BindingList<TblMunicipio> ObtenerTblMunicipios()
        {
            _contexto.TblMunicipios.Load();
            ListaTblMunicipios = _contexto.TblMunicipios.Local.ToBindingList();

            return ListaTblMunicipios;
        }

    }

    public class TblMunicipio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}