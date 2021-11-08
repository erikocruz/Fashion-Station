using System.Data.Entity;


namespace BL.Fashion
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var claseclte1 = new TblClaseClte();
            claseclte1.Descripcion = "Normal";
            contexto.TblClaseCltes.Add(claseclte1);

            var claseclte2 = new TblClaseClte();
            claseclte2.Descripcion = "Accionista";
            contexto.TblClaseCltes.Add(claseclte2);

            var pais1 = new TblPais();
            pais1.Descripcion = "Honduras";
            contexto.TblPaises.Add(pais1);

            var pais2 = new TblPais();
            pais2.Descripcion = "EEUU";
            contexto.TblPaises.Add(pais2);

            var depto1 = new TblDepto();
            depto1.Descripcion = "Atlantida";
            contexto.TblDeptos.Add(depto1);

            var depto2 = new TblDepto();
            depto2.Descripcion = "Cortés";
            contexto.TblDeptos.Add(depto2);

            var muni1 = new TblMunicipio();
            muni1.Descripcion = "San Pedro Sula";
            contexto.TblMunicipios.Add(muni1);

            var muni2 = new TblMunicipio();
            muni2.Descripcion = "San Antonio de Cortés";
            contexto.TblMunicipios.Add(muni2);

            var muni3 = new TblMunicipio();
            muni3.Descripcion = "Villanueva";
            contexto.TblMunicipios.Add(muni3);

            var col1 = new TblSectorBoCol();
            col1.Descripcion = "Col. Prieto";
            contexto.TblSectorBoCols.Add(col1);

            var col2 = new TblSectorBoCol();
            col2.Descripcion = "Bo. El Centro";
            contexto.TblSectorBoCols.Add(col2);

            var col3 = new TblSectorBoCol();
            col3.Descripcion = "Bo. La Tigra";
            contexto.TblSectorBoCols.Add(col3);

            var col4 = new TblSectorBoCol();
            col4.Descripcion = "Col. Los Castaños";
            contexto.TblSectorBoCols.Add(col4);

            var tipopersona1 = new TblTipoPersona();
            tipopersona1.Descripcion = "Hombre";
            contexto.TblTiposPersonas.Add(tipopersona1);

            var tipopersona2 = new TblTipoPersona();
            tipopersona2.Descripcion = "Mujer";
            contexto.TblTiposPersonas.Add(tipopersona2);

            var tipopersona3 = new TblTipoPersona();
            tipopersona3.Descripcion = "Niños";
            contexto.TblTiposPersonas.Add(tipopersona3);

            var tipopersona4 = new TblTipoPersona();
            tipopersona4.Descripcion = "Varios";
            contexto.TblTiposPersonas.Add(tipopersona4);

            var categoria1 = new TblCategoria();
            categoria1.Descripcion = "Ropa";
            contexto.TblCategorias.Add(categoria1);

            var categoria2 = new TblCategoria();
            categoria2.Descripcion = "Calzado";
            contexto.TblCategorias.Add(categoria2);

            var categoria3 = new TblCategoria();
            categoria3.Descripcion = "Cosméticos";
            contexto.TblCategorias.Add(categoria3);

            var categoria4 = new TblCategoria();
            categoria4.Descripcion = "Lencería";
            contexto.TblCategorias.Add(categoria4);

            var categoria5 = new TblCategoria();
            categoria5.Descripcion = "Juguetes";
            contexto.TblCategorias.Add(categoria5);

            var categoria6 = new TblCategoria();
            categoria6.Descripcion = "Cocina";
            contexto.TblCategorias.Add(categoria6);

            base.Seed(contexto);
        }
    }
}
